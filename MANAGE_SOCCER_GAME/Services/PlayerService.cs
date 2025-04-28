using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Dtos;
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

        public async Task<List<PlayerDTO>> GetAllPlayersAsync()
        {
            var players = await _context.Players.Include(x => x.SoccerGamesAsGoalscorer)
                                         .Include(x => x.PenaltyCards)
                                         .Include(x => x.MatchdaySquads)
                                         .Where(x => x.isDeleted == false).ToListAsync();

            var dtos = players.Select(c => new PlayerDTO
            {
                Id = c.Id,
                Number = c.Number,
                Name = c.Name,
                National = c.National,
                Position = c.Position,
                Height = c.Height,
                TeamName = c.Team != null ? c.Team.Name : "No Team",
                Age = DateTime.Now.Year - c.BirthDate.Year - (DateTime.Now.DayOfYear < c.BirthDate.DayOfYear ? 1 : 0),
                TotalGoals = c.SoccerGamesAsGoalscorer.Count(),
                //
                //TotalAssists = c.SoccerGamesAsGoalscorer.Sum(sg => sg.),
                TotalYellowCards = c.PenaltyCards.Count(pc => pc.TypeCard == "Yellow"),
                TotalRedCards = c.PenaltyCards.Count(pc => pc.TypeCard == "Red"),
                TotalMatches = c.MatchdaySquads.Count()
            }).ToList();

            return dtos;
        }

        public async Task<PlayerDTO?> GetPlayerByIdAsync(Guid id)
        {
            var player = await _context.Players.Include(x => x.SoccerGamesAsGoalscorer)
                                         .Include(x => x.PenaltyCards)
                                         .Include(x => x.MatchdaySquads).FirstOrDefaultAsync(x => x.Id == id);

            if (player == null)
                return null;


            var dto = new PlayerDTO
            {
                Id = player.Id,
                Number = player.Number,
                Name = player.Name,
                National = player.National,
                Position = player.Position,
                Height = player.Height,
                Age = DateTime.Now.Year - player.BirthDate.Year - (DateTime.Now.DayOfYear < player.BirthDate.DayOfYear ? 1 : 0),
                TotalYellowCards = player.PenaltyCards.Count(pc => pc.TypeCard == "Yellow"),
                TotalRedCards = player.PenaltyCards.Count(pc => pc.TypeCard == "Red"),
                TotalMatches = player.MatchdaySquads.Count()
            };

            return dto;
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

        public async Task<List<PlayerDTO>> SearchPlayersAsync(string keyword)
        {
           
            keyword = keyword.Trim().ToLower();

            var players = await _context.Players
                .Where(p => p.isDeleted == false && p.Name.ToLower().Contains(keyword))
                .Include(p => p.PenaltyCards)
                .Include(p => p.MatchdaySquads)
                .ToListAsync();

            var result = players.Select(player => new PlayerDTO
            {
                Id = player.Id,
                Number = player.Number,
                Name = player.Name,
                National = player.National,
                Position = player.Position,
                Height = player.Height,
                Age = DateTime.Now.Year - player.BirthDate.Year - (DateTime.Now.DayOfYear < player.BirthDate.DayOfYear ? 1 : 0),
                TotalYellowCards = player.PenaltyCards.Count(pc => pc.TypeCard == "Yellow"),
                TotalRedCards = player.PenaltyCards.Count(pc => pc.TypeCard == "Red"),
                TotalMatches = player.MatchdaySquads.Count()
            }).ToList();

            return result;
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
