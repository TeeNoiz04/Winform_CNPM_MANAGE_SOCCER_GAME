using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Utils.InputValidators;
using Microsoft.EntityFrameworkCore;
namespace MANAGE_SOCCER_GAME.Services
{
    public class TeamService
    {
        private readonly ManageSoccerGame _context;

        public TeamService(ManageSoccerGame context)
        {
            _context = context;
        }

        public async Task<Team> CreateTeamAsync(Team team)
        {
           await ValidateTeamAsync(team);

            if (await _context.Teams.AnyAsync(t => 
                t.Name == team.Name && 
                t.IdTournament == team.IdTournament))
            {
                throw new ArgumentException("A team with the same name already exists in this tournament.", nameof(team));
            }

            if (await _context.Teams.AnyAsync(t => 
                t.Name == team.Name && 
                t.IdTournament == team.IdTournament && 
                t.IdCoach == team.IdCoach))
            {
                throw new ArgumentException("A team with the same name and coach already exists in this tournament.", nameof(team));
            }

            if (await _context.Teams.AnyAsync(t => 
                t.IdCoach == team.IdCoach && 
                t.IdTournament == team.IdTournament))
            {
                throw new ArgumentException("A coach can only coach one team in a tournament.", nameof(team));
            }

            team.Id = Guid.NewGuid();
            team.IsDeleted = false;
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();
            return team;
        }

        public async Task<List<TeamDTO>?> GetAllTeamByTournamentIdAsync(Guid id)
        {
            var teams = await _context.Teams.Include(x => x.Player)
                                        .Include(x => x.Coach)
                                        .Include(x => x.Tournament)
                                        .Where(x => x.IdTournament == id && x.IsDeleted == false)
                                        .ToListAsync();

            var dtos = teams.Select(c => new TeamDTO
            {
                Id = c.Id,
                Name = c.Name,
                TotalPlayers = c.Player.Count(),
                Stadium = c.Province
            }).ToList();

            return dtos;
        }

        public async Task<Team?> GetTeamByIdAsync(Guid id)
        {
            return await _context.Teams.Include(x => x.Player)
                                        .Include(x => x.Coach)
                                        .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Team?> UpdateTeamAsync(Guid Id, Team team)
        {
            var existingTeam = await _context.Teams.FindAsync(Id);
            if (existingTeam == null)
                return null;

            await ValidateTeamAsync(team);

            if (await _context.Teams.AnyAsync(t =>
                t.Name == team.Name && 
                t.IdTournament == team.IdTournament && 
                t.Id != Id))
            {
                throw new ArgumentException("A team with the same name already exists in this tournament.", nameof(team));
            }

            if (await _context.Teams.AnyAsync(t => 
                t.Name == team.Name && 
                t.IdTournament == team.IdTournament && 
                t.IdCoach == team.IdCoach &&
                t.Id != Id))
            {
                throw new ArgumentException("A team with the same name and coach already exists in this tournament.", nameof(team));
            }

            if (await _context.Teams.AnyAsync(t => 
                t.IdCoach == team.IdCoach && 
                t.IdTournament == team.IdTournament &&
                t.Id != Id))
            {
                throw new ArgumentException("A coach can only coach one team in a tournament.", nameof(team));
            }

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

        public async Task<bool> TeamNameExistsAsync(Guid id, string name)
        {
            return await _context.Teams.AnyAsync(t => t.Name == name && t.IdTournament == id);
        }

        public async Task<List<TeamDTO>> SearchTeamsAsync(string keyword)
        {
            keyword = keyword.Trim().ToLower();
            var teams = await _context.Teams
                .Include(x => x.Coach)
                .Include(x => x.Tournament)
                .Where(t => t.Name.ToLower().Contains(keyword) && !t.IsDeleted)
                .ToListAsync();

            var dtos = teams.Select(c => new TeamDTO
            {
                Id = c.Id,
                Name = c.Name,
                TotalPlayers = c.Player.Count(),
            }).ToList();

            return dtos;
        }

        public async Task<int> GetTotalPagesAsync(Guid id,int pageSize)
        {
            var total = await _context.Teams.Where(x => !x.IsDeleted && x.IdTournament == id).CountAsync();
            return (int)Math.Ceiling((double)total / pageSize);
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

            if (!await _context.Tournaments.AnyAsync(t => t.Id == team.IdTournament))
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
