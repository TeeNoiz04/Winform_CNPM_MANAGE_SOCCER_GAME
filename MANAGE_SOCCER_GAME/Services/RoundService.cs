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
        public async Task<Round> CreateRoundAsync(Guid Id, Round round)
        {
            var tournament = await _context.Tournaments.FirstOrDefaultAsync(x => x.Id == Id);

            if (tournament == null)
            {
                throw new ArgumentException("Tournament not found.", nameof(Id));
            }

            if (await _context.Rounds.AnyAsync(x => x.Name == round.Name && x.TournamentId == Id))
            {
                throw new ArgumentException("Round name already exists.", nameof(round.Name));
            }

            if (round.StartDate > round.EndDate)
            {
                throw new ArgumentException("Start date must be before end date.", nameof(round));
            }
            if (round.StartDate < DateTime.Now)
            {
                throw new ArgumentException("Start date must be in the future.", nameof(round));
            }
            if (round.EndDate < DateTime.Now)
            {
                throw new ArgumentException("End date must be in the future.", nameof(round));
            }
            if (round.EndDate < round.StartDate)
            {
                throw new ArgumentException("End date must be after start date.", nameof(round));
            }
            if (round.StartDate == round.EndDate)
            {
                throw new ArgumentException("Start date and end date must be different.", nameof(round));
            }

            if (round.StartDate < tournament.StartDate || round.EndDate > tournament.EndDate)
            {
                throw new ArgumentException("Round dates must be within the tournament duration.", nameof(round));
            }

            round.Id = Guid.NewGuid();
            round.TournamentId = Id;
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
                .ThenInclude(x => x.Image)
                .Include(r => r.Games)
                .ThenInclude(g => g.AwayTeam)
                .ThenInclude(x => x.Image)
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

            public async Task<List<Round>> GetAllRoundsForComboBoxAsync()
            {
                return await _context.Rounds
                    .ToListAsync();
            }
    }
}
