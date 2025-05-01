using MANAGE_SOCCER_GAME.Models;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace MANAGE_SOCCER_GAME.Dtos
{
    public class TeamDTO
    {
        [Display(Name = "Code")]
        public Guid Id { get; set; }
        [Display(Name = "Club")]
        public string Name { get; set; }
        [Display(Name = "Played")]
        public int TotalPlayers { get; set; }
        [Display(Name = "Stadium")]
        public string Stadium { get; set; }
    }
}
