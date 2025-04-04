using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGE_SOCCER_GAME.Models
{
    public class Coach
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string National { get; set; }
        public int ExpYear { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Guid? IdImage { get; set; }
        public ImageCoacher? Image { get; set; }
        public Team? Team { get; set; }

    }
}
