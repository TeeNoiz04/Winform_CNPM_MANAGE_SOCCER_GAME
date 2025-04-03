using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGE_SOCCER_GAME.Models
{
    public class SoccerGame
    {
        public Guid Id { get; set; }
        public TimeSpan Time { get; set; }
        public string SoccerType { get; set; }
        public Guid GoalScorerId { get; set; }
        public Player GoalScorer { get; set; }
        public int NumberAssitant { get; set; }
        public Guid GameId { get; set; }
        public Game Game { get; set; }

    }
}
