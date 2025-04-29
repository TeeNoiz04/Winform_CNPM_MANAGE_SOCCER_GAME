using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Data;
using Microsoft.EntityFrameworkCore;

namespace MANAGE_SOCCER_GAME.Services
{
    public class MatchOfficialService
    {
        private readonly ManageSoccerGame _context;
        public MatchOfficialService(ManageSoccerGame context)
        {
            _context = context;
        }

        public async Task<MatchOfficials?> CreateMatchOfficialAsync(MatchOfficials matchOfficial)
        {
            if (matchOfficial.IdReferee == Guid.Empty || matchOfficial.IdGame == Guid.Empty)
                throw new ArgumentException("IdReferee và IdGame không được để trống.");

            bool refereeExists = await _context.Referees.AnyAsync(r => r.Id == matchOfficial.IdReferee);
            bool gameExists = await _context.Games.AnyAsync(g => g.Id == matchOfficial.IdGame);

            if (!refereeExists || !gameExists)
                throw new ArgumentException("Trọng tài hoặc trận đấu không tồn tại.");

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

    }
}
