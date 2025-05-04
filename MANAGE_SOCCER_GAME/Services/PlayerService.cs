using CloudinaryDotNet;
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

        public PlayerService(ManageSoccerGame context, TeamService teamService)
        {
            _context = context;
            _teamService = teamService;
        }

        public async Task<List<PlayerDTO>?> GetAllPlayersAsync()
        {
            var players = await _context.Players.Include(x => x.SoccerGamesAsGoalscorer)
                                         .Include(x => x.PenaltyCards)
                                         .Include(x => x.MatchdaySquads)
                                         .Where(x => x.isDeleted == false).ToListAsync();
            if (!players.Any())
                return new List<PlayerDTO>();

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
                TotalYellowCards = c.PenaltyCards.Count(pc => pc.TypeCard == "Yellow"),
                TotalRedCards = c.PenaltyCards.Count(pc => pc.TypeCard == "Red"),
                TotalMatches = c.MatchdaySquads.Count()
            }).ToList();

            return dtos;
        }

        public async Task<PlayerDTO?> GetPlayerDetailByIdAsync(Guid id)
        {
            var player = await _context.Players.Include(x => x.SoccerGamesAsGoalscorer)
                                         .Include(x => x.PenaltyCards)
                                         .Include(x => x.MatchdaySquads)
                                         .Include(x => x.Team).ThenInclude(x => x.Image)
                                         .Include(x => x.Image).FirstOrDefaultAsync(x => x.Id == id);

            if (player == null)
                return null;

            int totalGoals = await _context.SoccerGames.CountAsync(g => g.GoalScorerId == player.Id);
            int totalAssists = await _context.SoccerGames.CountAsync(g => g.AssitantId == player.Id);

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
                TotalMatches = player.MatchdaySquads.Count(),
                TotalGoals = totalGoals,
                TotalAssists = totalAssists,
                TeamName = player.Team != null ? player.Team.Name : "No Team",
                TeamId = player.IdTeam ?? Guid.Empty,
                urlPlayer = player.Image?.Url,
                urlTeam = player.Team?.Image?.Url,
            };

            return dto;
        }

        public async Task<Player> GetPlayerByIdAsync(Guid id)
        {
            var player = await _context.Players.Include(x => x.SoccerGamesAsGoalscorer)
                                         .Include(x => x.PenaltyCards)
                                         .Include(x => x.MatchdaySquads)
                                         .Include(x => x.Team).FirstOrDefaultAsync(x => x.Id == id);
            if (player == null)
                throw new ArgumentException("Player not found", nameof(id));
            return player;
        }

        public async Task<List<PlayerViewDTO>?> GetAllPlayersDTOByTeamIdAsync(Guid id)
        {
            var players = await _context.Players.Include(x => x.SoccerGamesAsGoalscorer)
                                         .Include(x => x.PenaltyCards)
                                         .Where(x => x.IdTeam == id && !x.isDeleted).ToListAsync();

            if (!players.Any())
                return new List<PlayerViewDTO>();

            var dtos = players.Select(c => new PlayerViewDTO
            {
                Id = c.Id,
                Name = c.Name,
                Nationality = c.National,
                Position = c.Position,
                Age = DateTime.Now.Year - c.BirthDate.Year - (DateTime.Now.DayOfYear < c.BirthDate.DayOfYear ? 1 : 0),
                Goals = c.SoccerGamesAsGoalscorer.Count(),
                YellowCards = c.PenaltyCards.Count(pc => pc.TypeCard == "Yellow"),
                RedCards = c.PenaltyCards.Count(pc => pc.TypeCard == "Red"),
            }).ToList();

            return dtos;
        }

        public async Task<List<Player>> GetPlayersByTeamIdAsync(Guid id)
        {
            return await _context.Players.Include(x => x.SoccerGamesAsGoalscorer)
                                         .Include(x => x.PenaltyCards)
                                         .Where(x => x.IdTeam == id && !x.isDeleted).ToListAsync();
        }

        public async Task<Player> CreatePlayerAsync(Player player)
        {
            await ValidatePlayerAsync(player);

            if (await _context.Players.AnyAsync(t => t.Number == player.Number && t.IdTeam == player.IdTeam))
            {
                throw new ArgumentException("A player with the same Number already exists in this team.", nameof(player));
            }

            if (!await _teamService.TeamExistsAsync(player.IdTeam.Value))
            {
                throw new ArgumentException("Team not found", nameof(player.IdTeam));
            }

            player.Id = Guid.NewGuid();
            player.isDeleted = false;
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

            if (await _context.Players.AnyAsync(t => t.Number == player.Number && t.Id != Id && t.IdTeam == player.IdTeam))
            {
                throw new ArgumentException("A player with the same Number already exists in this team.", nameof(player));
            }

            existingPlayer.Name = player.Name;
            existingPlayer.National = player.National;
            existingPlayer.Position = player.Position;
            existingPlayer.BirthDate = player.BirthDate;
            existingPlayer.Number = player.Number;
            existingPlayer.Height = player.Height;
            existingPlayer.Weight = player.Weight;
            existingPlayer.IdImage = player.IdImage ?? null;

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

        public async Task<List<PlayerDTO>> SearchPlayersAsync(string keyword)
        {
           
            keyword = keyword.Trim().ToLower();

            var players = await _context.Players
                .Where(p => !p.isDeleted && p.Name.ToLower().Contains(keyword))
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

        public async Task<List<PlayerStatDTO>> GetCurrentSeasonPlayerStatsAsync(Guid tournamentId)
        {


            var stats = await _context.Players
                .Where(p => !p.isDeleted)
                .Select(p => new PlayerStatDTO
                {
                    Player = p.Name,
                    Club = p.Team != null ? p.Team.Name : "No Team",
                    Nationality = p.National,
                    Stat = p.SoccerGamesAsGoalscorer
                        .Count(sg => sg.Game.Round.TournamentId == tournamentId)
                })
                .OrderByDescending(p => p.Stat)
                .ToListAsync();

            for (int i = 0; i < stats.Count; i++)
            {
                stats[i].Rank = i + 1;
            }

            return stats;
        }

    }
}
