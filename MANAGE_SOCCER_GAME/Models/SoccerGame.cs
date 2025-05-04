
namespace MANAGE_SOCCER_GAME.Models
{
    public class SoccerGame
    {
        public Guid Id { get; set; }
        public int Minute { get; set; }
        public string SoccerType { get; set; }
        public Guid GoalScorerId { get; set; }
        public Player GoalScorer { get; set; }
        public Guid? AssitantId { get; set; }
        public Player? Assitant { get; set; }
        public Guid GameId { get; set; }
        public Game Game { get; set; }

    }
}
