using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using Microsoft.EntityFrameworkCore;

namespace MANAGE_SOCCER_GAME.Services
{
    public class RoundService
    {
        private readonly ManageSoccerGame _context;

        public RoundService(ManageSoccerGame context)
        {
            _context = context;
        }
        public async Task<Round> CreateRoundAsync(Round round)
        {
            round.Id = Guid.NewGuid();
            _context.Rounds.Add(round);
            await _context.SaveChangesAsync();
            return round;
        }
        public async Task<Round?> UpdateRoundAsync(Guid id, Round round)
        {
            var existingRound = await _context.Rounds.FindAsync(id);
            if (existingRound == null)
                return null;

            existingRound.Name = round.Name;
            existingRound.StartDate = round.StartDate;
            existingRound.EndDate = round.EndDate;

            await _context.SaveChangesAsync();
            return existingRound;
        }

        public async Task<List<Round>> GetAllRoundsAsync()
        {
            return await _context.Rounds
                .Include(r => r.Games)
                .ThenInclude(g => g.HomeTeam)
                .Include(r => r.Games)
                .ThenInclude(g => g.AwayTeam)
                .ToListAsync();
        }

        public async Task<Round?> GetRoundByIdAsync(Guid id)
        {
            return await _context.Rounds
                .Include(r => r.Games)
                .ThenInclude(g => g.HomeTeam)
                .Include(r => r.Games)
                .ThenInclude(g => g.AwayTeam)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<bool> DeleteRoundAsync(Guid id)
        {
            var round = await _context.Rounds.FindAsync(id);
            if (round == null)
                return false;

            _context.Rounds.Remove(round);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Round>> GetRoundsByTournamentIdAsync(Guid tournamentId)
        {
            return await _context.Rounds
                .Include(r => r.Games)
                .ThenInclude(g => g.HomeTeam)
                .Include(r => r.Games)
                .ThenInclude(g => g.AwayTeam)
                .Where(r => r.TournamentId == tournamentId)
                .ToListAsync();
        }
    }
}
