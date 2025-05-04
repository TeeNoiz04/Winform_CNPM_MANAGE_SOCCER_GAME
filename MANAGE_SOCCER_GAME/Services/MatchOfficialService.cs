using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Data;
using Microsoft.EntityFrameworkCore;
using MANAGE_SOCCER_GAME.Dtos;

namespace MANAGE_SOCCER_GAME.Services
{
    public class MatchOfficialService
    {
        private readonly ManageSoccerGame _context;
        public MatchOfficialService(ManageSoccerGame context)
        {
            _context = context;
        }

        public async Task<List<MatchOfficialDTO>> GetAllMatchOfficialsAsync()
        {
            var matchs = await _context.MatchOfficials
                         .Include(m => m.Game)
                             .ThenInclude(g => g.HomeTeam)
                         .Include(m => m.Game)
                             .ThenInclude(g => g.AwayTeam)
                         .Include(m => m.Game)
                             .ThenInclude(g => g.Round)
                         .Include(m => m.Referee)
                         .ToListAsync();

            var matchOfficialDTOs = matchs.Select(m => new MatchOfficialDTO
            {
                RefereeId = m.IdReferee,
                GameId = m.IdGame,
                RoundName = m.Game.Round.Name,
                HomeTeam = m.Game.HomeTeam.Name,
                AwayTeam = m.Game.AwayTeam.Name,
                DateStart = m.Game.DateStart,
                RefereeName = m.Referee.Name,
                Position = m.Referee.Position
            }).ToList();

            return matchOfficialDTOs;
        }

        public async Task<MatchOfficials?> CreateMatchOfficialAsync(MatchOfficials matchOfficial)
        {
            if (matchOfficial.IdReferee == Guid.Empty || matchOfficial.IdGame == Guid.Empty)
                throw new ArgumentException("IdReferee và IdGame không được để trống.");

            var refereeExists = await _context.Referees.FirstOrDefaultAsync(r => r.Id == matchOfficial.IdReferee);
            bool gameExists = await _context.Games.AnyAsync(g => g.Id == matchOfficial.IdGame);

            if (refereeExists == null || !gameExists)
                throw new ArgumentException("Trọng tài hoặc trận đấu không tồn tại.");

            bool alreadyAssigned = await _context.MatchOfficials
                                    .AnyAsync(m => m.IdGame == matchOfficial.IdGame && m.IdReferee == matchOfficial.IdReferee);
            if (alreadyAssigned)
                throw new InvalidOperationException("Trọng tài đã được gán cho trận đấu này.");

            bool samePositionExists = await _context.MatchOfficials.Include(x => x.Referee)
                .AnyAsync(m => m.IdGame == matchOfficial.IdGame && m.Referee.Position == refereeExists.Position);

            if (samePositionExists)
                throw new InvalidOperationException($"Vị trí \"{matchOfficial.Referee.Position}\" đã được gán cho trận đấu này.");

            _context.MatchOfficials.Add(matchOfficial);
            await _context.SaveChangesAsync();
            return matchOfficial;
        }

        public async Task<MatchOfficials?> UpdateMatchOfficialAsync(Guid id, MatchOfficials matchOfficial)
        {
            var existingMatchOfficial = await _context.MatchOfficials.FindAsync(id);
            if (existingMatchOfficial == null)
                return null;

            if (matchOfficial.IdReferee == Guid.Empty || matchOfficial.IdGame == Guid.Empty)
                throw new ArgumentException("IdReferee và IdGame không được để trống.");

            bool refereeExists = await _context.Referees.AnyAsync(r => r.Id == matchOfficial.IdReferee);
            bool gameExists = await _context.Games.AnyAsync(g => g.Id == matchOfficial.IdGame);

            if (!refereeExists || !gameExists)
                throw new ArgumentException("Trọng tài hoặc trận đấu không tồn tại.");

            existingMatchOfficial.IdReferee = matchOfficial.IdReferee;
            existingMatchOfficial.IdGame = matchOfficial.IdGame;

            await _context.SaveChangesAsync();
            return existingMatchOfficial;
        }

        public async Task<bool> DeleteMatchOfficialAsync(Guid refereeId, Guid gameId)
        {
            var matchOfficial = await _context.MatchOfficials.FirstOrDefaultAsync(x=> x.IdGame == gameId && x.IdReferee == refereeId);
            if (matchOfficial == null)
                return false;

            _context.MatchOfficials.Remove(matchOfficial);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
