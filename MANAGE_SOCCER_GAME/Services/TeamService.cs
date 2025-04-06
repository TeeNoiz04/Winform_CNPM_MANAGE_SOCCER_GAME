using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Utils.InputValidators;
using Microsoft.EntityFrameworkCore;
namespace MANAGE_SOCCER_GAME.Services
{
    public class TeamService
    {
        private readonly ManageSoccerGame _context;
        private readonly TournamentService _tournamentService;

        public TeamService(ManageSoccerGame context)
        {
            _context = context;
            _tournamentService = new TournamentService(_context);
        }

        public async Task<Team> CreateTeamAsync(Team team)
        {
           await ValidateTeamAsync(team);

            team.Id = Guid.NewGuid();
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();
            return team;
        }

        public async Task<List<Team>> GetAllTeamAsync()
        {
            return await _context.Teams.Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<Team?> GetTeamByIdAsync(Guid id)
        {
            return await _context.Teams.FindAsync(id);
        }


        public async Task<Team?> UpdateTeamAsync(Guid Id, Team team)
        {
            var existingTeam = await _context.Teams.FindAsync(Id);
            if (existingTeam == null)
                return null;

            await ValidateTeamAsync(team);
            existingTeam.Name = team.Name;
            existingTeam.Province = team.Province;
            existingTeam.IdTournament = team.IdTournament;
            existingTeam.IdCoach = team.IdCoach;

            await _context.SaveChangesAsync();
            return existingTeam;
        }

        public async Task<Team?> DeleteTeamAsync(Guid Id)
        {
            var existingTeam = await _context.Teams.FindAsync(Id);
            if (existingTeam == null)
                return null;

            existingTeam.IsDeleted = true;

            await _context.SaveChangesAsync();
            return existingTeam;
        }

        public async Task<bool> TeamExistsAsync(Guid id)
        {
            return await _context.Teams.AnyAsync(t => t.Id == id);
        }

        private async Task ValidateTeamAsync(Team team)
        {
            if (team == null)
            {
                throw new ArgumentException(nameof(team));
            }

            if (!InputValidator.IsValidString(team.Name))
            {
                throw new ArgumentException("Team name must contain only letters and spaces, and cannot be empty.", nameof(team.Name));
            }

            if (!InputValidator.IsValidString(team.Province))
            {
                throw new ArgumentException("Team province must contain only letters and spaces, and cannot be empty.", nameof(team.Province));
            }

            if (!await _tournamentService.TournamentExistsAsync(team.IdTournament))
            {
                throw new ArgumentException("Tournament not found", nameof(team.IdTournament));
            }

            if (await _context.Coaches.FindAsync(team.IdCoach) == null)
            {
                throw new ArgumentException("Coach not found", nameof(team.IdCoach));
            }
        }

    }
}
