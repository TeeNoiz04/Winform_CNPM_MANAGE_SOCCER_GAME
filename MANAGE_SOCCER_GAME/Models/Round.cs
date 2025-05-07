namespace MANAGE_SOCCER_GAME.Models
{
    public class Round
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid TournamentId { get; set; }
        public Tournament Tournament { get; set; }
        public ICollection<Game> Games { get; set; } = new List<Game>();

        public static implicit operator Round(string v)
        {
            throw new NotImplementedException();
        }
    }
}
