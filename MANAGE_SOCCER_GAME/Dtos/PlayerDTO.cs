namespace MANAGE_SOCCER_GAME.Dtos
{
    public class PlayerDTO
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string National { get; set; }
        public string Position { get; set; }
        public int TotalGoals { get; set; }
        public int TotalAssists { get; set; }
        public float Height { get; set; }
        public string? TeamName { get; set; }

        public int TotalYellowCards { get; set; }
        public int TotalRedCards { get; set; }
        public int TotalMatches { get; set; }
    }
}
