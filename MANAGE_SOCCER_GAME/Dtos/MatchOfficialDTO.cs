
namespace MANAGE_SOCCER_GAME.Dtos
{
    public class MatchOfficialDTO
    {
        public Guid RefereeId { get; set; }
        public Guid GameId { get; set; }
        public string RoundName { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public DateTime DateStart { get; set; }
        public string RefereeName { get; set; }
        public string Position { get; set; }
    }
}
