using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGE_SOCCER_GAME.Models
{
    public class MatchSchedule
    {
        public Guid IdTeam { get; set; }
        public Team Team { get; set; }
        public Guid IdGame { get; set; }
        public Game Game { get; set; }
        public bool IsHomeGround { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
