using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGE_SOCCER_GAME.Models
{
    public class Referee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public string National { get; set; }
        public int YearOfExperience { get; set; }
        public ICollection<MatchOfficials> MatchOfficials { get; set; }
    }
}
