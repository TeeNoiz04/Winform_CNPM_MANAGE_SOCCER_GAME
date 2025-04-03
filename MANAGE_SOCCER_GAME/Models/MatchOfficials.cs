using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
