
using System.ComponentModel.DataAnnotations;

namespace MANAGE_SOCCER_GAME.Dtos
{
    public class TournamentDTO
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
    }
}
