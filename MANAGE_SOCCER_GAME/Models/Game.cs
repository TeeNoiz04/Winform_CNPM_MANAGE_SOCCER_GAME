using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int HomeScore { get; set; } = 0;
        public int AwayScore { get; set; } = 0;
        public bool Status { get; set; } = false;

        [NotMapped] // Không ánh xạ vào database
        public string Name => $"{HomeTeam?.Name} vs {AwayTeam?.Name}";

        [Timestamp] 
        public byte[] RowVersion { get; set; }
        public ICollection<MatchdaySquad> MatchdaySquads { get; set; }
        public ICollection<MatchOfficials> MatchOfficials { get; set; }
        public ICollection<PenaltyCard> PenaltyCards { get; set; }
        public ICollection<SoccerGame> SoccerGames { get; set; }
       
    }
}
