using System.ComponentModel.DataAnnotations;

namespace MANAGE_SOCCER_GAME.Models
{
    public class Referee
    {
        [Display(Name = "Mã trọng tài")]
        public Guid Id { get; set; }
        [Display(Name = "Họ và tên")]
        public string Name { get; set; }
        [Display(Name = "Ngày sinh")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Vị trí")]
        public string Position { get; set; }
        [Display(Name = "Quốc tịch")]
        public string National { get; set; }
        [Display(Name = "Kinh nghiệm")]
        public int YearOfExperience { get; set; }
        public ICollection<MatchOfficials> MatchOfficials { get; set; }
    }
}
