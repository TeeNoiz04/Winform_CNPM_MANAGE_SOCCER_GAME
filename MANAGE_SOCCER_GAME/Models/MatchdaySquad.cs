using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGE_SOCCER_GAME.Models
{
    // Player - Game
    public class MatchdaySquad
    {
        public Guid IdGame { get; set; }
        public Game Game { get; set; }
        public Guid IdPlayer { get; set; }
        public Player Player { get; set; }

    }
}
