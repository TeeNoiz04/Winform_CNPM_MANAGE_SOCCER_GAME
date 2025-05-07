using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;
using System.Collections.Generic;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin về cầu thủ (như tên, số áo, đội bóng) được thiết lập đúng.
    [TestFixture]
    public class PlayerTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo một cầu thủ mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void Player_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một cầu thủ mới, như khi bạn bắt đầu nhập thông tin cho một cầu thủ bóng đá.
            var player = new Player();

            // Kiểm tra các thông tin ban đầu:
            // - Mã định danh (Id) phải rỗng, như khi bạn chưa gán số nhận diện cho cầu thủ.
            Assert.That(player.Id, Is.EqualTo(Guid.Empty), "Mã định danh của cầu thủ phải rỗng vì chưa chọn cầu thủ.");
            // - Tên (Name) phải trống vì bạn chưa nhập tên cầu thủ.
            Assert.That(player.Name, Is.Null, "Tên cầu thủ phải trống vì chưa nhập tên.");
            // - Ngày sinh (BirthDate) phải là giá trị mặc định (rất xa trong quá khứ) vì chưa nhập ngày sinh.
            Assert.That(player.BirthDate, Is.EqualTo(DateTime.MinValue), "Ngày sinh phải là giá trị mặc định vì chưa nhập.");
            // - Vị trí thi đấu (Position) phải trống vì chưa chọn vị trí trên sân.
            Assert.That(player.Position, Is.Null, "Vị trí thi đấu phải trống vì chưa chọn vị trí.");
            // - Số áo (Number) phải là 0 vì chưa chọn số áo cho cầu thủ.
            Assert.That(player.Number, Is.EqualTo(0), "Số áo phải là 0 vì chưa chọn số áo.");
            // - Quốc tịch (National) phải trống vì chưa nhập quốc gia của cầu thủ.
            Assert.That(player.National, Is.Null, "Quốc tịch phải trống vì chưa chọn quốc gia.");
            // - Trạng thái xóa (isDeleted) phải là "không", vì cầu thủ mới chưa bị xóa.
            Assert.That(player.isDeleted, Is.False, "Trạng thái xóa phải là 'không' vì cầu thủ mới chưa bị xóa.");
            // - Trạng thái (Status) phải trống vì chưa ghi chú trạng thái của cầu thủ.
            Assert.That(player.Status, Is.Null, "Trạng thái phải trống vì chưa nhập trạng thái.");
            // - Chiều cao (Height) phải là 0 vì chưa nhập chiều cao của cầu thủ.
            Assert.That(player.Height, Is.EqualTo(0f), "Chiều cao phải là 0 vì chưa nhập.");
            // - Cân nặng (Weight) phải là 0 vì chưa nhập cân nặng của cầu thủ.
            Assert.That(player.Weight, Is.EqualTo(0f), "Cân nặng phải là 0 vì chưa nhập.");
            // - Mã hình ảnh (IdImage) phải trống vì chưa liên kết với ảnh nào.
            Assert.That(player.IdImage, Is.Null, "Mã hình ảnh phải trống vì chưa chọn ảnh.");
            // - Hình ảnh (Image) phải trống vì chưa có ảnh của cầu thủ.
            Assert.That(player.Image, Is.Null, "Hình ảnh cầu thủ phải trống vì chưa có ảnh.");
            // - Mã đội bóng (IdTeam) phải trống vì chưa gán cầu thủ vào đội nào.
            Assert.That(player.IdTeam, Is.Null, "Mã đội bóng phải trống vì chưa chọn đội.");
            // - Đội bóng (Team) phải trống vì cầu thủ chưa thuộc đội nào.
            Assert.That(player.Team, Is.Null, "Thông tin đội bóng phải trống vì chưa chọn đội.");
            // - Danh sách trận đấu ghi bàn (SoccerGamesAsGoalscorer) phải trống vì cầu thủ chưa ghi bàn trong trận nào.
            Assert.That(player.SoccerGamesAsGoalscorer, Is.Null, "Danh sách trận đấu ghi bàn phải trống vì chưa có dữ liệu.");
            // - Danh sách thẻ phạt (PenaltyCards) phải trống vì cầu thủ chưa nhận thẻ nào.
            Assert.That(player.PenaltyCards, Is.Null, "Danh sách thẻ phạt phải trống vì chưa có dữ liệu.");
            // - Danh sách đội hình thi đấu (MatchdaySquads) phải trống vì cầu thủ chưa được chọn vào đội hình nào.
            Assert.That(player.MatchdaySquads, Is.Null, "Danh sách đội hình thi đấu phải trống vì chưa có dữ liệu.");
        }

        // Bài kiểm tra 2: Kiểm tra xem khi nhập thông tin cho cầu thủ, các giá trị có được lưu đúng không.
        [Test]
        public void Player_SetProperties_UpdatesCorrectly()
        {
            // Tạo một cầu thủ mới.
            var player = new Player();
            // Chuẩn bị một đội bóng và hình ảnh để liên kết với cầu thủ, như khi bạn thêm cầu thủ vào đội và có ảnh của họ.
            var team = new Team { Id = Guid.NewGuid(), Name = "Team A" };
            var image = new ImagePlayer { Id = Guid.NewGuid(), Url = "http://example.com/player.jpg", PublicId = "player123" };
            var soccerGames = new List<SoccerGame> { new SoccerGame { Id = Guid.NewGuid() } };
            var penaltyCards = new List<PenaltyCard> { new PenaltyCard { Id = Guid.NewGuid() } };
            var matchdaySquads = new List<MatchdaySquad> { new MatchdaySquad { IdGame = Guid.NewGuid(), IdPlayer = Guid.NewGuid() } };

            // Nhập thông tin cho cầu thủ:
            // - Gán mã định danh mới, như một số nhận diện riêng cho cầu thủ.
            player.Id = Guid.NewGuid();
            // - Đặt tên là "John Doe", như tên thật của cầu thủ.
            player.Name = "John Doe";
            // - Đặt ngày sinh là 15/5/1995, như ngày cầu thủ được sinh ra.
            player.BirthDate = new DateTime(1995, 5, 15);
            // - Đặt vị trí thi đấu là "Tiền đạo", như vai trò của cầu thủ trên sân.
            player.Position = "Forward";
            // - Đặt số áo là 10, như số áo cầu thủ mặc khi thi đấu.
            player.Number = 10;
            // - Đặt quốc tịch là "USA", như quốc gia của cầu thủ.
            player.National = "USA";
            // - Đặt trạng thái xóa là "có", như khi cầu thủ bị xóa khỏi danh sách.
            player.isDeleted = true;
            // - Đặt trạng thái là "Đang thi đấu", như ghi chú tình trạng của cầu thủ.
            player.Status = "Active";
            // - Đặt chiều cao là 180 cm.
            player.Height = 180f;
            // - Đặt cân nặng là 75 kg.
            player.Weight = 75f;
            // - Gán mã hình ảnh để liên kết với ảnh của cầu thủ.
            player.IdImage = image.Id;
            // - Liên kết với hình ảnh của cầu thủ.
            player.Image = image;
            // - Gán mã đội bóng để liên kết với đội.
            player.IdTeam = team.Id;
            // - Liên kết với đội bóng "Team A".
            player.Team = team;
            // - Gán danh sách trận đấu ghi bàn, như khi cầu thủ ghi bàn trong một trận.
            player.SoccerGamesAsGoalscorer = soccerGames;
            // - Gán danh sách thẻ phạt, như khi cầu thủ nhận thẻ vàng.
            player.PenaltyCards = penaltyCards;
            // - Gán danh sách đội hình thi đấu, như khi cầu thủ được chọn ra sân.
            player.MatchdaySquads = matchdaySquads;

            // Kiểm tra xem các thông tin đã được lưu đúng chưa:
            // - Mã định danh phải là một giá trị mới, không rỗng.
            Assert.That(player.Id, Is.Not.EqualTo(Guid.Empty), "Mã định danh phải có giá trị mới.");
            // - Tên phải là "John Doe" như đã nhập.
            Assert.That(player.Name, Is.EqualTo("John Doe"), "Tên cầu thủ phải là 'John Doe'.");
            // - Ngày sinh phải là 15/5/1995.
            Assert.That(player.BirthDate, Is.EqualTo(new DateTime(1995, 5, 15)), "Ngày sinh phải là 15/5/1995.");
            // - Vị trí thi đấu phải là "Forward".
            Assert.That(player.Position, Is.EqualTo("Forward"), "Vị trí thi đấu phải là 'Tiền đạo'.");
            // - Số áo phải là 10.
            Assert.That(player.Number, Is.EqualTo(10), "Số áo phải là 10.");
            // - Quốc tịch phải là "USA".
            Assert.That(player.National, Is.EqualTo("USA"), "Quốc tịch phải là 'USA'.");
            // - Trạng thái xóa phải là "có".
            Assert.That(player.isDeleted, Is.True, "Trạng thái xóa phải là 'có' như đã chọn.");
            // - Trạng thái phải là "Active".
            Assert.That(player.Status, Is.EqualTo("Active"), "Trạng thái phải là 'Đang thi đấu'.");
            // - Chiều cao phải là 180 cm.
            Assert.That(player.Height, Is.EqualTo(180f), "Chiều cao phải là 180 cm.");
            // - Cân nặng phải là 75 kg.
            Assert.That(player.Weight, Is.EqualTo(75f), "Cân nặng phải là 75 kg.");
            // - Mã hình ảnh phải khớp với ảnh đã chọn.
            Assert.That(player.IdImage, Is.EqualTo(image.Id), "Mã hình ảnh phải khớp với ảnh đã chọn.");
            // - Hình ảnh phải khớp với ảnh đã liên kết.
            Assert.That(player.Image, Is.EqualTo(image), "Hình ảnh phải khớp với ảnh đã chọn.");
            // - Mã đội bóng phải khớp với đội đã chọn.
            Assert.That(player.IdTeam, Is.EqualTo(team.Id), "Mã đội bóng phải khớp với đội đã chọn.");
            // - Đội bóng phải khớp với đội "Team A".
            Assert.That(player.Team, Is.EqualTo(team), "Đội bóng phải khớp với đội đã chọn.");
            // - Danh sách trận đấu ghi bàn phải khớp với danh sách đã gán.
            Assert.That(player.SoccerGamesAsGoalscorer, Is.EqualTo(soccerGames), "Danh sách trận đấu ghi bàn phải khớp với danh sách đã gán.");
            // - Danh sách thẻ phạt phải khớp với danh sách đã gán.
            Assert.That(player.PenaltyCards, Is.EqualTo(penaltyCards), "Danh sách thẻ phạt phải khớp với danh sách đã gán.");
            // - Danh sách đội hình thi đấu phải khớp với danh sách đã gán.
            Assert.That(player.MatchdaySquads, Is.EqualTo(matchdaySquads), "Danh sách đội hình thi đấu phải khớp với danh sách đã gán.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể đặt tên cầu thủ là chuỗi rỗng (không có tên) không.
        [Test]
        public void Player_SetEmptyName_SetsCorrectly()
        {
            // Tạo một cầu thủ mới.
            var player = new Player();
            // Đặt tên cầu thủ là chuỗi rỗng, như khi bạn chưa nhập tên.
            player.Name = "";
            // Kiểm tra xem tên đã được lưu là chuỗi rỗng chưa.
            Assert.That(player.Name, Is.Empty, "Tên cầu thủ phải là chuỗi rỗng khi bạn không nhập tên.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể bỏ liên kết với đội bóng (đặt mã và thông tin đội thành trống) không.
        [Test]
        public void Player_SetNullTeam_SetsCorrectly()
        {
            // Tạo một cầu thủ mới.
            var player = new Player();
            // Bỏ liên kết với đội bóng, như khi cầu thủ chưa thuộc đội nào.
            player.IdTeam = null;
            player.Team = null;
            // Kiểm tra xem mã đội và thông tin đội đã trống chưa.
            Assert.That(player.IdTeam, Is.Null, "Mã đội bóng phải trống khi bạn không gán đội.");
            Assert.That(player.Team, Is.Null, "Thông tin đội bóng phải trống khi bạn không gán đội.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể đặt số áo là một số lớn (như 99) không.
        [Test]
        public void Player_SetLargeNumber_SetsCorrectly()
        {
            // Tạo một cầu thủ mới.
            var player = new Player();
            // Đặt số áo là 99, như khi cầu thủ chọn một số áo lớn.
            player.Number = 99;
            // Kiểm tra xem số áo đã được lưu đúng chưa.
            Assert.That(player.Number, Is.EqualTo(99), "Số áo phải là 99 như đã chọn.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể đặt trạng thái xóa là "không" sau khi đã đặt là "có" không.
        [Test]
        public void Player_ToggleIsDeleted_SetsCorrectly()
        {
            // Tạo một cầu thủ mới.
            var player = new Player();
            // Đặt trạng thái xóa là "có", như khi cầu thủ bị xóa khỏi danh sách.
            player.isDeleted = true;
            // Sau đó đổi lại thành "không", như khi bạn khôi phục cầu thủ.
            player.isDeleted = false;
            // Kiểm tra xem trạng thái xóa cuối cùng là "không" không.
            Assert.That(player.isDeleted, Is.False, "Trạng thái xóa phải là 'không' sau khi khôi phục.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể đặt ngày sinh là một ngày trong tương lai (như năm sau) không.
        [Test]
        public void Player_SetFutureBirthDate_SetsCorrectly()
        {
            // Tạo một cầu thủ mới.
            var player = new Player();
            // Đặt ngày sinh là một ngày trong tương lai, như năm sau.
            var futureDate = DateTime.Now.AddYears(1);
            player.BirthDate = futureDate;
            // Kiểm tra xem ngày sinh đã được lưu đúng chưa.
            Assert.That(player.BirthDate, Is.EqualTo(futureDate), "Ngày sinh phải là ngày trong tương lai như đã chọn.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể bỏ liên kết với hình ảnh (đặt mã và thông tin ảnh thành trống) không.
        [Test]
        public void Player_SetNullImage_SetsCorrectly()
        {
            // Tạo một cầu thủ mới.
            var player = new Player();
            // Bỏ liên kết với hình ảnh, như khi cầu thủ chưa có ảnh đại diện.
            player.IdImage = null;
            player.Image = null;
            // Kiểm tra xem mã ảnh và thông tin ảnh đã trống chưa.
            Assert.That(player.IdImage, Is.Null, "Mã hình ảnh phải trống khi bạn không gán ảnh.");
            Assert.That(player.Image, Is.Null, "Hình ảnh phải trống khi bạn không gán ảnh.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể đặt quốc tịch là chuỗi dài (như "United States of America") không.
        [Test]
        public void Player_SetLongNational_SetsCorrectly()
        {
            // Tạo một cầu thủ mới.
            var player = new Player();
            // Đặt quốc tịch là "United States of America", như khi bạn nhập tên quốc gia đầy đủ.
            player.National = "United States of America";
            // Kiểm tra xem quốc tịch đã được lưu đúng chưa.
            Assert.That(player.National, Is.EqualTo("United States of America"), "Quốc tịch phải là 'United States of America' như đã nhập.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể đặt trạng thái với ký tự đặc biệt (như "Active@#") không.
        [Test]
        public void Player_SetStatusWithSpecialCharacters_SetsCorrectly()
        {
            // Tạo một cầu thủ mới.
            var player = new Player();
            // Đặt trạng thái với ký tự đặc biệt, như khi bạn dùng ký hiệu để ghi chú trạng thái.
            player.Status = "Active@#";
            // Kiểm tra xem trạng thái đã được lưu đúng chưa.
            Assert.That(player.Status, Is.EqualTo("Active@#"), "Trạng thái phải được lưu đúng với ký tự đặc biệt.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể đặt chiều cao là một số thập phân (như 180.5 cm) không.
        [Test]
        public void Player_SetDecimalHeight_SetsCorrectly()
        {
            // Tạo một cầu thủ mới.
            var player = new Player();
            // Đặt chiều cao là 180.5 cm, như khi bạn nhập chiều cao chính xác hơn.
            player.Height = 180.5f;
            // Kiểm tra xem chiều cao đã được lưu đúng chưa.
            Assert.That(player.Height, Is.EqualTo(180.5f), "Chiều cao phải là 180.5 cm như đã nhập.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể thay đổi danh sách đội hình thi đấu nhiều lần không.
        [Test]
        public void Player_UpdateMatchdaySquadsMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một cầu thủ mới.
            var player = new Player();
            // Gán danh sách đội hình thi đấu đầu tiên, như khi cầu thủ được chọn cho một trận.
            var squads1 = new List<MatchdaySquad> { new MatchdaySquad { IdGame = Guid.NewGuid(), IdPlayer = Guid.NewGuid() } };
            player.MatchdaySquads = squads1;
            // Thay đổi sang danh sách đội hình thi đấu mới, như khi cầu thủ được chọn cho trận khác.
            var squads2 = new List<MatchdaySquad> { new MatchdaySquad { IdGame = Guid.NewGuid(), IdPlayer = Guid.NewGuid() } };
            player.MatchdaySquads = squads2;
            // Kiểm tra xem danh sách đội hình cuối cùng là danh sách mới không.
            Assert.That(player.MatchdaySquads, Is.EqualTo(squads2), "Danh sách đội hình thi đấu phải được cập nhật thành danh sách mới.");
        }
    }
}