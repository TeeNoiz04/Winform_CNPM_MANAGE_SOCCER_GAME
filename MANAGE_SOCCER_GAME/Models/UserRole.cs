using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace MANAGE_SOCCER_GAME.Models
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public Guid IdUser { get; set; }
        public required User User { get; set; }
        public Guid IdRole { get; set; }
        public required Role Role { get; set; }
    }
}
