using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;
using System.Collections.Generic;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin về giải đấu (như tên, ngày bắt đầu) được thiết lập đúng.
    [TestFixture]
    public class TournamentTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo một giải đấu mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void Tournament_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một giải đấu mới, như khi bạn bắt đầu tổ chức một giải bóng đá.
            var tournament = new Tournament();

            // Kiểm tra các thông tin ban đầu:
            // - Mã định danh (Id) phải rỗng, như khi bạn chưa gán số nhận diện cho giải đấu.
            Assert.That(tournament.Id, Is.EqualTo(Guid.Empty), "Mã định danh của giải đấu phải rỗng vì chưa gán.");
            // - Tên (Name) phải trống vì bạn chưa nhập tên giải đấu.
            Assert.That(tournament.Name, Is.Null, "Tên giải đấu phải trống vì chưa nhập tên.");
            // - Mô tả (Description) phải trống vì bạn chưa nhập mô tả.
            Assert.That(tournament.Description, Is.Null, "Mô tả giải đấu phải trống vì chưa nhập mô tả.");
            // - Ngày bắt đầu (StartDate) phải là giá trị mặc định (rất xa trong quá khứ) vì chưa nhập.
            Assert.That(tournament.StartDate, Is.EqualTo(DateTime.MinValue), "Ngày bắt đầu phải là giá trị mặc định vì chưa nhập.");
            // - Ngày kết thúc (EndDate) cũng phải là giá trị mặc định vì chưa nhập.
            Assert.That(tournament.EndDate, Is.EqualTo(DateTime.MinValue), "Ngày kết thúc phải là giá trị mặc định vì chưa nhập.");
            // - Danh sách đội bóng (Teams) phải là một danh sách rỗng, vì chưa có đội nào tham gia.
            Assert.That(tournament.Teams, Is.Not.Null, "Danh sách đội bóng phải là một danh sách rỗng như mặc định.");
            Assert.That(tournament.Teams, Has.Count.EqualTo(0), "Danh sách đội bóng phải không có đội nào như mặc định.");
        }

        // Bài kiểm tra 2: Kiểm tra xem khi nhập thông tin cho giải đấu, các giá trị có được lưu đúng không.
        [Test]
        public void Tournament_SetProperties_UpdatesCorrectly()
        {
            // Tạo một giải đấu mới.
            var tournament = new Tournament();
            // Chuẩn bị một đội bóng để liên kết, như khi bạn thêm đội bóng vào giải đấu.
            var team = new Team { Id = Guid.NewGuid(), Name = "Team A" };
            var teams = new List<Team> { team };

            // Nhập thông tin cho giải đấu:
            // - Gán mã định danh mới, như một số nhận diện riêng cho giải đấu.
            tournament.Id = Guid.NewGuid();
            // - Đặt tên là "Tournament A", như tên của giải đấu.
            tournament.Name = "Tournament A";
            // - Đặt mô tả là "Giải đấu thường niên", như để giải thích về giải đấu.
            tournament.Description = "Annual Tournament";
            // - Đặt ngày bắt đầu là 1/1/2025, như ngày giải đấu bắt đầu.
            tournament.StartDate = new DateTime(2025, 1, 1);
            // - Đặt ngày kết thúc là 31/12/2025, như ngày giải đấu kết thúc.
            tournament.EndDate = new DateTime(2025, 12, 31);
            // - Gán danh sách đội bóng, như khi giải đấu có một đội tham gia.
            tournament.Teams = teams;

            // Kiểm tra xem các thông tin đã được lưu đúng chưa:
            // - Mã định danh phải là một giá trị mới, không rỗng.
            Assert.That(tournament.Id, Is.Not.EqualTo(Guid.Empty), "Mã định danh phải có giá trị mới.");
            // - Tên phải là "Tournament A" như đã nhập.
            Assert.That(tournament.Name, Is.EqualTo("Tournament A"), "Tên giải đấu phải là 'Tournament A'.");
            // - Mô tả phải là "Giải đấu thường niên".
            Assert.That(tournament.Description, Is.EqualTo("Annual Tournament"), "Mô tả giải đấu phải là 'Giải đấu thường niên'.");
            // - Ngày bắt đầu phải là 1/1/2025.
            Assert.That(tournament.StartDate, Is.EqualTo(new DateTime(2025, 1, 1)), "Ngày bắt đầu phải là 1/1/2025.");
            // - Ngày kết thúc phải là 31/12/2025.
            Assert.That(tournament.EndDate, Is.EqualTo(new DateTime(2025, 12, 31)), "Ngày kết thúc phải là 31/12/2025.");
            // - Danh sách đội bóng phải có 1 mục, vì đã thêm một đội.
            Assert.That(tournament.Teams, Has.Count.EqualTo(1), "Danh sách đội bóng phải có 1 mục sau khi thêm.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể đặt tên giải đấu là chuỗi rỗng không.
        [Test]
        public void Tournament_SetEmptyName_SetsCorrectly()
        {
            // Tạo một giải đấu mới.
            var tournament = new Tournament();
            // Đặt tên giải đấu là chuỗi rỗng, như khi bạn chưa nhập tên.
            tournament.Name = "";
            // Kiểm tra xem tên giải đấu đã được lưu là chuỗi rỗng chưa.
            Assert.That(tournament.Name, Is.Empty, "Tên giải đấu phải là chuỗi rỗng khi không nhập tên.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể đặt mô tả là chuỗi dài (như 200 ký tự) không.
        [Test]
        public void Tournament_SetLongDescription_SetsCorrectly()
        {
            // Tạo một giải đấu mới.
            var tournament = new Tournament();
            // Đặt mô tả là một chuỗi dài, như khi bạn viết mô tả chi tiết cho giải đấu.
            var longDescription = new string('a', 200);
            tournament.Description = longDescription;
            // Kiểm tra xem mô tả đã được lưu đúng chưa.
            Assert.That(tournament.Description, Is.EqualTo(longDescription), "Mô tả giải đấu phải được lưu đúng với chuỗi dài.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể đặt ngày bắt đầu là một ngày trong quá khứ không.
        [Test]
        public void Tournament_SetPastStartDate_SetsCorrectly()
        {
            // Tạo một giải đấu mới.
            var tournament = new Tournament();
            // Đặt ngày bắt đầu là 1/1/2020, như khi giải đấu đã diễn ra từ lâu.
            var pastDate = new DateTime(2020, 1, 1);
            tournament.StartDate = pastDate;
            // Kiểm tra xem ngày bắt đầu đã được lưu đúng chưa.
            Assert.That(tournament.StartDate, Is.EqualTo(pastDate), "Ngày bắt đầu phải là 1/1/2020 như đã chọn.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể đặt ngày kết thúc sớm hơn ngày bắt đầu không.
        [Test]
        public void Tournament_SetEndDateBeforeStartDate_SetsCorrectly()
        {
            // Tạo một giải đấu mới.
            var tournament = new Tournament();
            // Đặt ngày bắt đầu là ngày mai.
            tournament.StartDate = DateTime.Now.AddDays(1);
            // Đặt ngày kết thúc là ngày hôm nay, như khi bạn nhập sai ngày (giả định).
            tournament.EndDate = DateTime.Now;
            // Kiểm tra xem ngày kết thúc đã được lưu đúng chưa.
            Assert.That(tournament.EndDate, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Ngày kết thúc phải là ngày hôm nay như đã chọn.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể đặt danh sách đội bóng là danh sách rỗng không.
        [Test]
        public void Tournament_SetEmptyTeams_SetsCorrectly()
        {
            // Tạo một giải đấu mới.
            var tournament = new Tournament();
            // Đặt danh sách đội bóng là danh sách rỗng, như khi giải đấu chưa có đội nào.
            tournament.Teams = new List<Team>();
            // Kiểm tra xem danh sách đội bóng đã rỗng chưa.
            Assert.That(tournament.Teams, Has.Count.EqualTo(0), "Danh sách đội bóng phải rỗng khi không có đội nào.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể thay đổi danh sách đội bóng nhiều lần không.
        [Test]
        public void Tournament_UpdateTeamsMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một giải đấu mới.
            var tournament = new Tournament();
            // Gán danh sách đội bóng đầu tiên, như khi giải đấu có một đội.
            var teams1 = new List<Team> { new Team { Id = Guid.NewGuid() } };
            tournament.Teams = teams1;
            // Thay đổi sang danh sách đội bóng mới, như khi giải đấu có đội khác tham gia.
            var teams2 = new List<Team> { new Team { Id = Guid.NewGuid() } };
            tournament.Teams = teams2;
            // Kiểm tra xem danh sách đội bóng cuối cùng là danh sách mới không.
            Assert.That(tournament.Teams, Is.EqualTo(teams2), "Danh sách đội bóng phải được cập nhật thành danh sách mới.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể đặt tên giải đấu với ký tự đặc biệt (như @#$%) không.
        [Test]
        public void Tournament_SetNameWithSpecialCharacters_SetsCorrectly()
        {
            // Tạo một giải đấu mới.
            var tournament = new Tournament();
            // Đặt tên giải đấu với ký tự đặc biệt, như khi bạn dùng ký hiệu để đặt tên.
            tournament.Name = "Tournament@#$%";
            // Kiểm tra xem tên giải đấu đã được lưu đúng chưa.
            Assert.That(tournament.Name, Is.EqualTo("Tournament@#$%"), "Tên giải đấu phải được lưu đúng với ký tự đặc biệt.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể đặt mã định danh thành một giá trị rỗng không.
        [Test]
        public void Tournament_SetEmptyId_SetsCorrectly()
        {
            // Tạo một giải đấu mới.
            var tournament = new Tournament();
            // Đặt mã định danh là rỗng, như khi bạn chưa gán số nhận diện.
            tournament.Id = Guid.Empty;
            // Kiểm tra xem mã định danh đã được lưu là rỗng chưa.
            Assert.That(tournament.Id, Is.EqualTo(Guid.Empty), "Mã định danh phải rỗng khi không gán.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể đặt mô tả là chuỗi rỗng không.
        [Test]
        public void Tournament_SetEmptyDescription_SetsCorrectly()
        {
            // Tạo một giải đấu mới.
            var tournament = new Tournament();
            // Đặt mô tả là chuỗi rỗng, như khi bạn không muốn mô tả gì.
            tournament.Description = "";
            // Kiểm tra xem mô tả đã được lưu là chuỗi rỗng chưa.
            Assert.That(tournament.Description, Is.Empty, "Mô tả giải đấu phải là chuỗi rỗng khi không nhập mô tả.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể thêm nhiều đội bóng vào danh sách không.
        [Test]
        public void Tournament_AddMultipleTeams_SetsCorrectly()
        {
            // Tạo một giải đấu mới.
            var tournament = new Tournament();
            // Thêm 3 đội bóng vào danh sách, như khi giải đấu có nhiều đội tham gia.
            var teams = new List<Team>
            {
                new Team { Id = Guid.NewGuid(), Name = "Team A" },
                new Team { Id = Guid.NewGuid(), Name = "Team B" },
                new Team { Id = Guid.NewGuid(), Name = "Team C" }
            };
            tournament.Teams = teams;
            // Kiểm tra xem danh sách đội bóng có đúng 3 đội không.
            Assert.That(tournament.Teams, Has.Count.EqualTo(3), "Danh sách đội bóng phải có 3 đội sau khi thêm.");
        }
    }
}