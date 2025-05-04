using System.ComponentModel.DataAnnotations;

namespace MANAGE_SOCCER_GAME.Dtos
{
    public class CoachDTO
    {
        [Display(Name = "Manager")]
        public string Name { get; set; }
        [Display(Name = "Club")]
        public string TeamName { get; set; }
        [Display(Name = "Nationality")]
        public string National { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
