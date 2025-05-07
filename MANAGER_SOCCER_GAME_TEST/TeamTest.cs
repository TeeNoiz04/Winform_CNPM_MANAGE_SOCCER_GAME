using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;
using System.Collections.Generic;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin về đội bóng (như tên, giải đấu) được thiết lập đúng.
    [TestFixture]
    public class TeamTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo một đội bóng mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void Team_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một đội bóng mới, giống như khi bạn bắt đầu nhập thông tin cho một đội bóng.
            var team = new Team();

            // Kiểm tra xem các thông tin được đặt đúng giá trị ban đầu chưa:
            // - Mã định danh (Id) phải là một giá trị rỗng vì chưa có đội bóng cụ thể nào.
            Assert.That(team.Id, Is.EqualTo(Guid.Empty), "Mã định danh của đội bóng phải rỗng khi chưa gán.");
            // - Tên đội bóng (Name) phải trống vì chưa nhập tên.
            Assert.That(team.Name, Is.Null, "Tên đội bóng phải trống vì chưa nhập.");
            // - Tỉnh (Province) phải trống vì chưa nhập tỉnh.
            Assert.That(team.Province, Is.Null, "Tỉnh phải trống vì chưa nhập.");
            // - Trạng thái xóa (IsDeleted) phải là "chưa xóa" vì đội bóng mới tạo không bị xóa.
            Assert.That(team.IsDeleted, Is.False, "Trạng thái xóa phải là chưa xóa.");
            // - Mã giải đấu (IdTournament) phải rỗng vì chưa chọn giải đấu.
            Assert.That(team.IdTournament, Is.EqualTo(Guid.Empty), "Mã giải đấu phải rỗng vì chưa chọn giải đấu.");
            // - Giải đấu (Tournament) phải trống vì chưa chọn giải đấu.
            Assert.That(team.Tournament, Is.Null, "Giải đấu phải trống vì chưa chọn giải đấu.");
            // - Mã hình ảnh (IdImage) phải trống vì chưa chọn ảnh.
            Assert.That(team.IdImage, Is.Null, "Mã hình ảnh phải trống vì chưa chọn ảnh.");
            // - Hình ảnh (Image) phải trống vì chưa chọn ảnh.
            Assert.That(team.Image, Is.Null, "Hình ảnh phải trống vì chưa chọn ảnh.");
            // - Mã huấn luyện viên (IdCoach) phải rỗng vì chưa chọn huấn luyện viên.
            Assert.That(team.IdCoach, Is.EqualTo(Guid.Empty), "Mã huấn luyện viên phải rỗng vì chưa chọn huấn luyện viên.");
            // - Huấn luyện viên (Coach) phải trống vì chưa chọn huấn luyện viên.
            Assert.That(team.Coach, Is.Null, "Huấn luyện viên phải trống vì chưa chọn huấn luyện viên.");
            // - Danh sách cầu thủ (Player) phải rỗng vì chưa thêm cầu thủ nào.
            Assert.That(team.Player, Is.Empty, "Danh sách cầu thủ phải rỗng vì chưa thêm cầu thủ.");
            // - Danh sách trận sân nhà (HomeGames) phải rỗng vì chưa có trận sân nhà.
            Assert.That(team.HomeGames, Is.Empty, "Danh sách trận sân nhà phải rỗng vì chưa có trận sân nhà.");
            // - Danh sách trận sân khách (AwayGames) phải rỗng vì chưa có trận sân khách.
            Assert.That(team.AwayGames, Is.Empty, "Danh sách trận sân khách phải rỗng vì chưa có trận sân khách.");
        }

        // Bài kiểm tra 2: Kiểm tra xem khi nhập thông tin cho đội bóng, các giá trị có được lưu đúng không.
        [Test]
        public void Team_SetProperties_UpdatesCorrectly()
        {
            // Tạo một đội bóng mới.
            var team = new Team();
            // Chuẩn bị các đối tượng liên quan để liên kết, như khi bạn thêm đội bóng vào giải đấu.
            var tournament = new Tournament { Id = Guid.NewGuid(), Name = "Tournament A" };
            var image = new ImageTeam { Url = "http://example.com/team.jpg", PublicId = "team123" };
            var coach = new Coach { Id = Guid.NewGuid(), Name = "Coach A" };
            var player = new Player { Id = Guid.NewGuid(), Name = "John Doe" };
            var players = new List<Player> { player };
            var homeGame = new Game { Id = Guid.NewGuid(), HomeTeamId = team.Id, HomeTeam = team };
            var homeGames = new List<Game> { homeGame };

            // Nhập thông tin cho đội bóng:
            // - Gán mã định danh mới, như một số nhận diện riêng cho đội bóng.
            team.Id = Guid.NewGuid();
            // - Đặt tên là "Team A", như tên của đội bóng.
            team.Name = "Team A";
            // - Đặt tỉnh là "Hà Nội", như nơi đội bóng đến từ.
            team.Province = "Hanoi";
            // - Gán mã giải đấu để biết đội bóng thuộc giải nào.
            team.IdTournament = tournament.Id;
            // - Liên kết với thông tin giải đấu "Tournament A".
            team.Tournament = tournament;
            // - Gán mã hình ảnh để liên kết với ảnh của đội bóng.
            team.IdImage = Guid.NewGuid();
            // - Liên kết với hình ảnh của đội bóng.
            team.Image = image;
            // - Gán mã huấn luyện viên để biết ai dẫn dắt đội bóng.
            team.IdCoach = coach.Id;
            // - Liên kết với thông tin huấn luyện viên "Coach A".
            team.Coach = coach;
            // - Gán danh sách cầu thủ, như khi đội bóng có một cầu thủ.
            team.Player = players;
            // - Gán danh sách trận sân nhà, như khi đội bóng có một trận sân nhà.
            team.HomeGames = homeGames;

            // Kiểm tra xem các thông tin đã được lưu đúng chưa:
            // - Mã định danh phải là một giá trị mới, không rỗng.
            Assert.That(team.Id, Is.Not.EqualTo(Guid.Empty), "Mã định danh phải có giá trị mới.");
            // - Tên phải là "Team A" như đã nhập.
            Assert.That(team.Name, Is.EqualTo("Team A"), "Tên đội bóng phải là 'Team A'.");
            // - Tỉnh phải là "Hà Nội".
            Assert.That(team.Province, Is.EqualTo("Hanoi"), "Tỉnh phải là 'Hà Nội'.");
            // - Mã giải đấu phải khớp với mã của giải đấu đã chọn.
            Assert.That(team.IdTournament, Is.EqualTo(tournament.Id), "Mã giải đấu phải khớp với giải đấu đã chọn.");
            // - Thông tin giải đấu phải khớp với "Tournament A".
            Assert.That(team.Tournament, Is.EqualTo(tournament), "Thông tin giải đấu phải khớp với giải đấu đã chọn.");
            // - Mã hình ảnh phải là một giá trị mới, không rỗng.
            Assert.That(team.IdImage, Is.Not.Null, "Mã hình ảnh phải có giá trị mới.");
            // - Hình ảnh phải khớp với ảnh đã liên kết.
            Assert.That(team.Image, Is.EqualTo(image), "Hình ảnh phải khớp với ảnh đã chọn.");
            // - Mã huấn luyện viên phải khớp với mã của huấn luyện viên đã chọn.
            Assert.That(team.IdCoach, Is.EqualTo(coach.Id), "Mã huấn luyện viên phải khớp với huấn luyện viên đã chọn.");
            // - Thông tin huấn luyện viên phải khớp với "Coach A".
            Assert.That(team.Coach, Is.EqualTo(coach), "Thông tin huấn luyện viên phải khớp với huấn luyện viên đã chọn.");
            // - Danh sách cầu thủ phải có 1 mục, vì đã thêm một cầu thủ.
            Assert.That(team.Player, Has.Count.EqualTo(1), "Danh sách cầu thủ phải có 1 mục sau khi thêm.");
            // - Danh sách trận sân nhà phải có 1 mục, vì đã thêm một trận.
            Assert.That(team.HomeGames, Has.Count.EqualTo(1), "Danh sách trận sân nhà phải có 1 mục sau khi thêm.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể đặt tên đội bóng là chuỗi rỗng không.
        [Test]
        public void Team_SetEmptyName_SetsCorrectly()
        {
            // Tạo một đội bóng mới.
            var team = new Team();
            // Đặt tên đội bóng là chuỗi rỗng, như khi bạn chưa nhập tên.
            team.Name = "";
            // Kiểm tra xem tên đội bóng đã được lưu là chuỗi rỗng chưa.
            Assert.That(team.Name, Is.Empty, "Tên đội bóng phải là chuỗi rỗng khi không nhập tên.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể bỏ liên kết với giải đấu (đặt thành trống) không.
        [Test]
        public void Team_SetNullTournament_SetsCorrectly()
        {
            // Tạo một đội bóng mới.
            var team = new Team();
            // Bỏ liên kết với giải đấu, như khi đội bóng chưa thuộc giải nào.
            team.IdTournament = Guid.Empty;
            team.Tournament = null;
            // Kiểm tra xem mã giải đấu và thông tin giải đấu đã trống chưa.
            Assert.That(team.IdTournament, Is.EqualTo(Guid.Empty), "Mã giải đấu phải rỗng khi không chọn giải đấu.");
            Assert.That(team.Tournament, Is.Null, "Thông tin giải đấu phải trống khi không chọn giải đấu.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể bỏ liên kết với huấn luyện viên (đặt thành trống) không.
        [Test]
        public void Team_SetNullCoach_SetsCorrectly()
        {
            // Tạo một đội bóng mới.
            var team = new Team();
            // Bỏ liên kết với huấn luyện viên, như khi đội bóng chưa có huấn luyện viên.
            team.IdCoach = Guid.Empty;
            team.Coach = null;
            // Kiểm tra xem mã huấn luyện viên và thông tin huấn luyện viên đã trống chưa.
            Assert.That(team.IdCoach, Is.EqualTo(Guid.Empty), "Mã huấn luyện viên phải rỗng khi không chọn huấn luyện viên.");
            Assert.That(team.Coach, Is.Null, "Thông tin huấn luyện viên phải trống khi không chọn huấn luyện viên.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể đặt danh sách cầu thủ thành danh sách rỗng không.
        [Test]
        public void Team_SetEmptyPlayer_SetsCorrectly()
        {
            // Tạo một đội bóng mới.
            var team = new Team();
            // Gán danh sách cầu thủ là danh sách rỗng, như khi đội bóng chưa có cầu thủ nào.
            team.Player = new List<Player>();
            // Kiểm tra xem danh sách cầu thủ đã rỗng chưa.
            Assert.That(team.Player, Is.Empty, "Danh sách cầu thủ phải rỗng khi không thêm cầu thủ.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể đặt tỉnh là chuỗi dài (như 100 ký tự) không.
        [Test]
        public void Team_SetLongProvince_SetsCorrectly()
        {
            // Tạo một đội bóng mới.
            var team = new Team();
            // Đặt tỉnh là một chuỗi dài, như khi bạn nhập tên tỉnh chi tiết.
            var longProvince = new string('a', 100);
            team.Province = longProvince;
            // Kiểm tra xem tỉnh đã được lưu đúng chưa.
            Assert.That(team.Province, Is.EqualTo(longProvince), "Tỉnh phải được lưu đúng với chuỗi dài.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể bỏ liên kết với hình ảnh (đặt thành trống) không.
        [Test]
        public void Team_SetNullImage_SetsCorrectly()
        {
            // Tạo một đội bóng mới.
            var team = new Team();
            // Bỏ liên kết với hình ảnh, như khi đội bóng chưa có ảnh đại diện.
            team.IdImage = null;
            team.Image = null;
            // Kiểm tra xem mã hình ảnh và thông tin hình ảnh đã trống chưa.
            Assert.That(team.IdImage, Is.Null, "Mã hình ảnh phải trống khi không chọn ảnh.");
            Assert.That(team.Image, Is.Null, "Hình ảnh phải trống khi không chọn ảnh.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể thay đổi danh sách trận sân nhà nhiều lần không.
        [Test]
        public void Team_UpdateHomeGamesMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một đội bóng mới.
            var team = new Team();
            // Gán danh sách trận sân nhà đầu tiên, như khi đội bóng có một trận sân nhà.
            var homeGames1 = new List<Game> { new Game { Id = Guid.NewGuid() } };
            team.HomeGames = homeGames1;
            // Thay đổi sang danh sách trận sân nhà mới, như khi đội bóng có lịch thi đấu khác.
            var homeGames2 = new List<Game> { new Game { Id = Guid.NewGuid() } };
            team.HomeGames = homeGames2;
            // Kiểm tra xem danh sách trận sân nhà cuối cùng là danh sách mới không.
            Assert.That(team.HomeGames, Is.EqualTo(homeGames2), "Danh sách trận sân nhà phải được cập nhật thành danh sách mới.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể liên kết với huấn luyện viên không có tên không.
        [Test]
        public void Team_SetCoachWithNullName_SetsCorrectly()
        {
            // Tạo một đội bóng mới.
            var team = new Team();
            // Tạo một huấn luyện viên nhưng không có tên, như khi thông tin huấn luyện viên chưa đầy đủ.
            var coach = new Coach { Id = Guid.NewGuid(), Name = null };
            // Liên kết đội bóng với huấn luyện viên này.
            team.Coach = coach;
            team.IdCoach = coach.Id;
            // Kiểm tra xem huấn luyện viên đã được liên kết đúng chưa, dù không có tên.
            Assert.That(team.Coach, Is.EqualTo(coach), "Đội bóng phải liên kết được với huấn luyện viên dù huấn luyện viên không có tên.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể đặt mã định danh thành một giá trị rỗng không.
        [Test]
        public void Team_SetEmptyId_SetsCorrectly()
        {
            // Tạo một đội bóng mới.
            var team = new Team();
            // Đặt mã định danh là rỗng, như khi bạn chưa gán số nhận diện.
            team.Id = Guid.Empty;
            // Kiểm tra xem mã định danh đã được lưu là rỗng chưa.
            Assert.That(team.Id, Is.EqualTo(Guid.Empty), "Mã định danh phải rỗng khi không gán.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể đặt tên đội bóng với ký tự đặc biệt (như @#$%) không.
        [Test]
        public void Team_SetNameWithSpecialCharacters_SetsCorrectly()
        {
            // Tạo một đội bóng mới.
            var team = new Team();
            // Đặt tên đội bóng với ký tự đặc biệt, như khi bạn dùng ký hiệu để đặt tên.
            team.Name = "Team@#$%";
            // Kiểm tra xem tên đội bóng đã được lưu đúng chưa.
            Assert.That(team.Name, Is.EqualTo("Team@#$%"), "Tên đội bóng phải được lưu đúng với ký tự đặc biệt.");
        }
    }
}