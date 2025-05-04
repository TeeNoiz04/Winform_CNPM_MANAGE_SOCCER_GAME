using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using Microsoft.EntityFrameworkCore;

namespace MANAGE_SOCCER_GAME.Services
{
    public class SoccerGameService
    {
        private readonly ManageSoccerGame _context;
        public SoccerGameService(ManageSoccerGame context)
        {
            _context = context;
        }

        public async Task<SoccerGame?> GetSoccerGameByIdAsync(Guid id)
        {
            return await _context.SoccerGames
                .Include(sg => sg.GoalScorer)
                .Include(sg => sg.Assitant)
                .FirstOrDefaultAsync(sg => sg.Id == id);
        }

        public async Task<SoccerGame> CreateSoccerGameAsync(SoccerGame soccerGame)
        {
            var game = await _context.Games
                .Include(g => g.Round)
                .Include(g => g.HomeTeam)
                .Include(g => g.AwayTeam)
                .FirstOrDefaultAsync(g => g.Id == soccerGame.GameId);

            if (game == null)
                throw new ArgumentException("Game not found.", nameof(soccerGame.GameId));

            if (soccerGame.Assitant != null && soccerGame.GoalScorerId == soccerGame.AssitantId)
                throw new ArgumentException("Goal scorer and assistant must be different.");

            if (soccerGame.Minute < 0 || soccerGame.Minute > 120)
                throw new ArgumentException("Goal time must be between 0 and 120 minutes (including extra time).");

            if (soccerGame.Assitant != null && soccerGame.Assitant.Team.Id != soccerGame.GoalScorer.Team.Id)
                throw new ArgumentException("Goal scorer and assistant must be from the same team.");


            soccerGame.Id = Guid.NewGuid();
            _context.SoccerGames.Add(soccerGame);

            var scorer = await _context.Players.FindAsync(soccerGame.GoalScorerId);
            if (scorer.IdTeam == game.HomeTeamId)
            {
                game.HomeScore += 1;
            }
            else if (scorer.IdTeam == game.AwayTeamId)
            {
                game.AwayScore += 1;
            }

            await _context.SaveChangesAsync();
            return soccerGame;
        }

        public async Task<SoccerGame> UpdateSoccerGameAsync(Guid id, SoccerGame updatedGame)
        {
            var existingGame = await _context.SoccerGames
                .Include(sg => sg.GoalScorer)
                .Include(sg => sg.Assitant)
                .FirstOrDefaultAsync(sg => sg.Id == id);

            if (existingGame == null)
                throw new ArgumentException("SoccerGame not found.");

            var game = await _context.Games
                .Include(g => g.HomeTeam)
                .Include(g => g.AwayTeam)
                .FirstOrDefaultAsync(g => g.Id == existingGame.GameId);

            if (game == null)
                throw new ArgumentException("Game not found.");

            // Trừ đi tỉ số cũ trước khi cập nhật
            var oldScorer = await _context.Players.FindAsync(existingGame.GoalScorerId);
            if (oldScorer.IdTeam == game.HomeTeamId)
                game.HomeScore -= 1;
            else if (oldScorer.IdTeam == game.AwayTeamId)
                game.AwayScore -= 1;

            // Validate thông tin mới
            if (updatedGame.AssitantId != null && updatedGame.GoalScorerId == updatedGame.AssitantId)
                throw new ArgumentException("Goal scorer and assistant must be different.");

            if (updatedGame.Minute < 0 || updatedGame.Minute > 120)
                throw new ArgumentException("Goal time must be between 0 and 120 minutes.");

            if (updatedGame.AssitantId != null)
            {
                var assistant = await _context.Players.FindAsync(updatedGame.AssitantId);
                var newScorer = await _context.Players.FindAsync(updatedGame.GoalScorerId);
                if (assistant.IdTeam != newScorer.IdTeam)
                    throw new ArgumentException("Goal scorer and assistant must be from the same team.");
            }

            // Cập nhật các thuộc tính mới
            existingGame.GoalScorerId = updatedGame.GoalScorerId;
            existingGame.AssitantId = updatedGame.AssitantId;
            existingGame.Minute = updatedGame.Minute;

            // Cộng lại tỉ số mới
            var newScorerAfter = await _context.Players.FindAsync(updatedGame.GoalScorerId);
            if (newScorerAfter.IdTeam == game.HomeTeamId)
                game.HomeScore += 1;
            else if (newScorerAfter.IdTeam == game.AwayTeamId)
                game.AwayScore += 1;

            await _context.SaveChangesAsync();

            return existingGame;
        }

        public async Task<bool> DeleteSoccerGameAsync(Guid id)
        {
            try
            {
                var soccerGame = await _context.SoccerGames
                    .Include(s => s.GoalScorer)
                    .FirstOrDefaultAsync(s => s.Id == id);

                if (soccerGame == null)
                    return false;

                var game = await _context.Games.FirstOrDefaultAsync(g => g.Id == soccerGame.GameId);
                if (game == null)
                    throw new InvalidOperationException("Associated game not found.");

                var scorer = soccerGame.GoalScorer;
                if (scorer != null)
                {
                    if (scorer.IdTeam == game.HomeTeamId)
                        game.HomeScore = Math.Max(0, game.HomeScore - 1);
                    else if (scorer.IdTeam == game.AwayTeamId)
                        game.AwayScore = Math.Max(0, game.AwayScore - 1);
                }

                _context.SoccerGames.Remove(soccerGame);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa trận: " + ex.Message);
                return false;
            }
        }

    }
}
