namespace MANAGE_SOCCER_GAME.Models
{
    public class MatchOfficials
    {
        public Guid IdGame { get; set; }
        public Game Game { get; set; }
        public Guid IdReferee { get; set; }
        public Referee Referee { get; set; }
    }
}
