using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGE_SOCCER_GAME.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Round { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime DateStart { get; set; }
        public TimeSpan TimeStart { get; set; }

        [Timestamp] 
        public byte[] RowVersion { get; set; }
        public ICollection<MatchdaySquad> MatchdaySquads { get; set; }
        public ICollection<MatchSchedule> MatchSchedules { get; set; }
        public ICollection<MatchOfficials> MatchOfficials { get; set; }
        public ICollection<PenaltyCard> PenaltyCards { get; set; }
        public ICollection<SoccerGame> SoccerGames { get; set; }
    }
}
