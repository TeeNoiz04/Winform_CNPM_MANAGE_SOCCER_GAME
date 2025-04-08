using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Utils.InputValidators;
using Microsoft.EntityFrameworkCore;

    namespace MANAGE_SOCCER_GAME.Services
{
    public class PlayerService
    {
        private readonly ManageSoccerGame _context;
        private readonly TeamService _teamService;

        public PlayerService(ManageSoccerGame context)
        {
            _context = context;
            _teamService = new TeamService(_context);
        }

        public async Task<List<Player>> GetAllPlayersAsync()
        {
            return await _context.Players.Where(x => x.isDeleted == false).ToListAsync();
        }

        public async Task<Player?> GetPlayerByIdAsync(Guid id)
        {
            return await _context.Players.FindAsync(id);
        }

        public async Task<Player> CreatePlayerAsync(Player player)
        {
            await ValidatePlayerAsync(player);

            player.Id = Guid.NewGuid();
            _context.Players.Add(player);
            await _context.SaveChangesAsync();
            return player;
        }

        public async Task<Player?> UpdatePlayerAsync(Guid Id, Player player)
        {
            var existingPlayer = await _context.Players.FindAsync(Id);
            if (existingPlayer == null)
                return null;

            await ValidatePlayerAsync(player);

            existingPlayer.Name = player.Name;
            existingPlayer.National = player.National;
            existingPlayer.Position = player.Position;
            existingPlayer.BirthDate = player.BirthDate;
            existingPlayer.Number = player.Number;
            existingPlayer.Status = player.Status;
            existingPlayer.Height = player.Height;
            existingPlayer.Weight = player.Weight;
            existingPlayer.IdTeam= player.IdTeam;

            await _context.SaveChangesAsync();
            return existingPlayer;
        }

        public async Task<bool> PlayerExistsAsync(Guid id)
        {
            return await _context.Players.AnyAsync(t => t.Id == id);
        }

        public async Task<Player?> DeletePlayerAsync(Guid Id)
        {
            var existingPlayer = await _context.Players.FindAsync(Id);
            if (existingPlayer == null)
                return null;

            existingPlayer.isDeleted = true;

            await _context.SaveChangesAsync();
            return existingPlayer;
        }

        public async Task<List<Player>> GetPlayersByTeamIdAsync(Guid teamId)
        {
            return await _context.Players.Where(x => x.IdTeam == teamId && x.isDeleted == false).ToListAsync();
        }

        private async Task ValidatePlayerAsync(Player player)
        {
            if (player == null)
            {
                throw new ArgumentNullException(nameof(player), "Player cannot be null");
            }

            if (!await _teamService.TeamExistsAsync(player.IdTeam.Value))
            {
                throw new ArgumentException("Team not found", nameof(player.IdTeam));
            }

            if (!InputValidator.IsValidString(player.Name))
            {
                throw new ArgumentException("Player name must contain only letters and spaces, and cannot be empty.", nameof(player.Name));
            }

            if (!InputValidator.IsValidString(player.National))
            {
                throw new ArgumentException("Player national must contain only letters and spaces, and cannot be empty.", nameof(player.National));
            }

            if (!InputValidator.IsValidNumber(player.Number.ToString()))
            {
                throw new ArgumentException("Player's number must be a valid number.", nameof(player.Number));
            }

            if (player.Height <= 0)
            {
                throw new ArgumentException("Player's height must be a positive number.", nameof(player.Height));
            }

            if (player.Weight <= 0)
            {
                throw new ArgumentException("Player's weight must be a positive number.", nameof(player.Weight));
            }

        }
    }
}
