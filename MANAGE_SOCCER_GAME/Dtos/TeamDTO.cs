using MANAGE_SOCCER_GAME.Models;
using System.Numerics;

namespace MANAGE_SOCCER_GAME.Dtos
{
    public class TeamDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int TotalPlayers { get; set; }
    }
}
