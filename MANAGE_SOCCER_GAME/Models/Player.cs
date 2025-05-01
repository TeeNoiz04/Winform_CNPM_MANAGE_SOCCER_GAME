using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGE_SOCCER_GAME.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public int Number { get; set; }
        public string National { get; set; }
        public bool  isDeleted { get; set; } = false;
        public string Status { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public Guid? IdImage { get; set; }
        public ImagePlayer? Image { get; set; }
        public Guid? IdTeam { get; set; }
        public Team? Team { get; set; }
        public ICollection<SoccerGame> SoccerGamesAsGoalscorer { get; set; }
        public ICollection<SoccerGame> SoccerGamesAsAssitscorer { get; set; }
        public ICollection<PenaltyCard> PenaltyCards { get; set; }
        public ICollection<MatchdaySquad> MatchdaySquads { get; set; }
    }
}
