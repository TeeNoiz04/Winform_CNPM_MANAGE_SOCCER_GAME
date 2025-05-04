using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;

namespace MANAGE_SOCCER_GAME.Services
{
    public class TournamentService
    {
        private readonly ManageSoccerGame _context;
        public TournamentService(ManageSoccerGame context)
        {
            _context = context;
        }

        public async Task<Tournament> CreateTournamentAsync(Tournament tournament)
        {
            if (string.IsNullOrWhiteSpace(tournament.Name))
                throw new ArgumentException("Tournament name is required.", nameof(tournament.Name));

            if (tournament.StartDate >= tournament.EndDate)
                throw new ArgumentException("Start date must be before end date.");

            if (tournament.StartDate < DateTime.Today)
                throw new ArgumentException("Start date cannot be in the past.");

            bool isDuplicate = await _context.Tournaments
                .AnyAsync(t => !t.IsDeleted && t.Name.ToLower() == tournament.Name.ToLower());

            if (isDuplicate)
                throw new ArgumentException("A tournament with the same name already exists.");

            tournament.Id = Guid.NewGuid();
            _context.Tournaments.Add(tournament);
            await _context.SaveChangesAsync();
            return tournament;
        }

        // Read All
        public async Task<IEnumerable<Tournament>> GetAllTournamentsAsync()
        {
            return await _context.Tournaments.ToListAsync();
        }

        public async Task<IEnumerable<TournamentDTO>> GetAllTournamentsDTOAsync()
        {
            var tournaments = await _context.Tournaments.ToListAsync();

            var dtos = tournaments.Select(t => new TournamentDTO
            {
                Id = t.Id,
                Name = t.Name,
                Description = t.Description,
                StartDate = t.StartDate,
                EndDate = t.EndDate,
            }).ToList();
            return dtos;
        }

        // Read by Id
        public async Task<Tournament?> GetTournamentByIdAsync(Guid id)
        {
            return await _context.Tournaments
                .Include(t => t.Teams)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        // Update
        public async Task<bool> UpdateTournamentAsync(Tournament tournament)
        {
            var existing = await _context.Tournaments.FindAsync(tournament.Id);
            if (existing == null) return false;

            existing.Name = tournament.Name;
            existing.Description = tournament.Description;
            existing.StartDate = tournament.StartDate;
            existing.EndDate = tournament.EndDate;
            // Không xử lý Teams ở đây, vì phụ thuộc logic riêng

            _context.Tournaments.Update(existing);
            await _context.SaveChangesAsync();
            return true;
        }

        // Delete
        public async Task<bool> DeleteTournamentAsync(Guid id)
        {
            var tournament = await _context.Tournaments.FindAsync(id);
            if (tournament == null) return false;

            _context.Tournaments.Remove(tournament);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<Tournament?> GetCurrentTournamentAsync()
        {
            var today = DateTime.Today;

            return await _context.Tournaments
                .FirstOrDefaultAsync(t => t.StartDate <= today && t.EndDate >= today);
        }
        public async Task<List<Tournament>> GetTournamentsInCurrentYearAsync()
        {
            var currentYear = DateTime.Now.Year;

            return await _context.Tournaments
                .Where(t => t.StartDate.Year == currentYear || t.EndDate.Year == currentYear)
                .OrderBy(t => t.StartDate)
                .ToListAsync();
        }
        public async Task<List<Tournament>> SearchTournamentsByName(string keyword)
        {
            return await _context.Tournaments
                .Where(t => t.Name.Contains(keyword))
                .ToListAsync();
        }
        public async Task<List<Tournament>> GetUpcomingTournamentsAsync()
        {
            var today = DateTime.Today;
            return await _context.Tournaments
                .Where(t => t.StartDate > today)
                .OrderBy(t => t.StartDate)
                .ToListAsync();
        }

        public async Task<bool> TournamentExistsAsync(Guid id)
        {
            return await _context.Tournaments.AnyAsync(t => t.Id == id);
        }

    }
}

