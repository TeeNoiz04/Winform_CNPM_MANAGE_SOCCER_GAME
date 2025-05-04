using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using Microsoft.EntityFrameworkCore;

namespace MANAGE_SOCCER_GAME.Services
{
    public class GameService
    {
        private readonly ManageSoccerGame _context;

        public GameService(ManageSoccerGame context)
        {
            _context = context;
        }
        public async Task<Game> CreateGameAsync(Game game)
        {
            var round = await _context.Rounds
            .Include(r => r.Tournament)
            .FirstOrDefaultAsync(r => r.Id == game.RoundId);

            if (round == null)
                throw new ArgumentException("Round not found.", nameof(game.RoundId));

            if (game.HomeTeamId == game.AwayTeamId)
                throw new ArgumentException("Home and Away teams must be different.");

            var matchDateTime = game.DateStart.Date + game.TimeStart;
            if (matchDateTime < DateTime.Now)
                throw new ArgumentException("Game start time must be in the future.");

            if (round.StartDate > matchDateTime || round.EndDate < matchDateTime)
                throw new ArgumentException("Game time must be within the round's date range.");

            bool isDuplicate = await _context.Games.AnyAsync(g =>
                !g.IsDeleted &&
                g.RoundId == game.RoundId &&
                (g.HomeTeamId == game.HomeTeamId || g.HomeTeamId == game.AwayTeamId ||
                 g.AwayTeamId == game.HomeTeamId || g.AwayTeamId == game.AwayTeamId) &&
                g.DateStart == game.DateStart &&
                g.TimeStart == game.TimeStart);

            if (isDuplicate)
                throw new ArgumentException("This game conflicts with an existing match for one of the teams.");

            game.Id = Guid.NewGuid();
            game.IsDeleted = false;
            _context.Games.Add(game);
            await _context.SaveChangesAsync();
            return game;
        }

        public async Task<Game?> UpdateGameAsync(Guid Id, Game game)
        {
            var existingGame = await _context.Games.FindAsync(Id);
            if (existingGame == null)
                return null;

            var round = await _context.Rounds
           .Include(r => r.Tournament)
           .FirstOrDefaultAsync(r => r.Id == game.RoundId);

            if (round == null)
                throw new ArgumentException("Round not found.", nameof(game.RoundId));

            if (game.HomeTeamId == game.AwayTeamId)
                throw new ArgumentException("Home and Away teams must be different.");

            var matchDateTime = game.DateStart.Date + game.TimeStart;
            if (matchDateTime < DateTime.Now)
                throw new ArgumentException("Game start time must be in the future.");

            if (round.StartDate > matchDateTime || round.EndDate < matchDateTime)
                throw new ArgumentException("Game time must be within the round's date range.");

            bool isDuplicate = await _context.Games.AnyAsync(g =>
                !g.IsDeleted &&
                 g.Id != Id &&
                g.RoundId == game.RoundId &&
                (g.HomeTeamId == game.HomeTeamId || g.HomeTeamId == game.AwayTeamId ||
                 g.AwayTeamId == game.HomeTeamId || g.AwayTeamId == game.AwayTeamId) &&
                g.DateStart == game.DateStart &&
                g.TimeStart == game.TimeStart);

            if (isDuplicate)
                throw new ArgumentException("This game conflicts with an existing match for one of the teams.");


            existingGame.DateStart = game.DateStart;
            existingGame.TimeStart = game.TimeStart;
            existingGame.HomeTeamId = game.HomeTeamId;
            existingGame.AwayTeamId = game.AwayTeamId;
            existingGame.RoundId = game.RoundId;

            await _context.SaveChangesAsync();
            return existingGame;
        }

        public async Task<Game?> GetGameByIdAsync(Guid id)
        {
            var game = await _context.Games.Include(x => x.AwayTeam)
                                           .ThenInclude(x => x.Player)
                                           .ThenInclude(x => x.Image)
                                           .Include(x => x.HomeTeam)
                                           .ThenInclude(x => x.Player)
                                           .ThenInclude(x => x.Image)
                                           .Include(x => x.SoccerGames)
                                           .FirstOrDefaultAsync(x => x.Id == id && x.IsDeleted == false);

            if (game == null)
                return null;

            return game;
        }

        public async Task<List<Game>?> GetAllGamesAsync()
        {
            var games = await _context.Games.Include(x => x.MatchdaySquads)
                                          .Include(x => x.MatchOfficials)
                                          .Include(x => x.PenaltyCards)
                                          .Include(x => x.SoccerGames)
                                          .Where(x => x.IsDeleted == false && x.Status).ToListAsync();
            if (games == null)
                return null;

            return games;
        }

        public async Task<List<Game>> GetGamesByRoundIdAsync(Guid roundId)
        {
            var games = await _context.Games
                                       .Include(x => x.AwayTeam)
                                       .Include(x => x.HomeTeam)
                                       .Where(x => !x.IsDeleted && !x.Status && x.RoundId == roundId)
                                       .ToListAsync();

            return games;
        }


    }
}
