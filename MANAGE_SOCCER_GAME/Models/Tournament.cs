namespace MANAGE_SOCCER_GAME.Models
{
    public class Tournament
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Team> Teams { get; set; } = new List<Team>();
        public ICollection<Round> Rounds { get; set; } = new List<Round>();

    }
}
