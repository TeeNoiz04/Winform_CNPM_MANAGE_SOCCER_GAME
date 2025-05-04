
namespace MANAGE_SOCCER_GAME.Dtos
{
    public class ResultDTO
    {
        public Guid Id { get; set; }
        public int Minute { get; set; }
        public string? GoalScorerHome { get; set; }
        public string? GoalScorerAway { get; set; }
    }
}
