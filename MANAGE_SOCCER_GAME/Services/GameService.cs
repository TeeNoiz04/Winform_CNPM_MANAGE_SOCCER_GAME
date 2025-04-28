using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Utils.InputValidators;
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

            existingGame.Round = game.Round;

            existingGame.DateStart = game.DateStart;
            existingGame.TimeStart = game.TimeStart;
            await _context.SaveChangesAsync();
            return game;
        }

        public async Task<Game?> GetGameByIdAsync(Guid id)
        {
            var game = await _context.Games.Include(x => x.MatchdaySquads)
                                          .Include(x => x.MatchOfficials)
                                          .Include(x => x.PenaltyCards)
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
                                          .Where(x => x.IsDeleted == false).ToListAsync();
            if (games == null)
                return null;

            return games;
        }
    }
}
