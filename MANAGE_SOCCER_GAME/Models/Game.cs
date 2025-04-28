using System.ComponentModel.DataAnnotations;

namespace MANAGE_SOCCER_GAME.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime DateStart { get; set; }
        public TimeSpan TimeStart { get; set; }

        public Guid HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }

        public Guid AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }

        public Guid RoundId { get; set; }
        public Round Round { get; set; }

        [Timestamp] 
        public byte[] RowVersion { get; set; }
        public ICollection<MatchdaySquad> MatchdaySquads { get; set; }
        public ICollection<MatchOfficials> MatchOfficials { get; set; }
        public ICollection<PenaltyCard> PenaltyCards { get; set; }
        public ICollection<SoccerGame> SoccerGames { get; set; }
       
    }
}
