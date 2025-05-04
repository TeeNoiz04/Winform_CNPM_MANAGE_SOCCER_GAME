
namespace MANAGE_SOCCER_GAME.Dtos
{
    public class LeagueTableEntry
    {
        public int Rank { get; set; } // #
        public string TeamName { get; set; } // Team
        public int Played { get; set; }
        public int Won { get; set; }
        public int Drawn { get; set; }
        public int Lost { get; set; }
        public int GoalsFor { get; set; } // GF
        public int GoalsAgainst { get; set; } // GA
        public int GoalDifference { get; set; } // GD
        public int Points { get; set; }
        public string Form { get; set; } // Ch
    }
}
