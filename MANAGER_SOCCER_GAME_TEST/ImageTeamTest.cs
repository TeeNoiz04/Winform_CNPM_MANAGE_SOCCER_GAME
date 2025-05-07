using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin về hình ảnh của đội bóng (như logo đội) được thiết lập đúng.
    [TestFixture]
    public class ImageTeamTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo một hình ảnh đội bóng mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void ImageTeam_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một hình ảnh đội bóng mới, như khi bạn tải lên logo của một đội bóng với đường dẫn ảnh và mã nhận diện.
            var imageTeam = new ImageTeam { Url = "http://example.com/team.jpg", PublicId = "team123" };

            // Kiểm tra các thông tin ban đầu:
            // - Mã định danh (Id) phải là một giá trị mới, không rỗng, giống như một số nhận diện riêng cho hình ảnh này.
            Assert.That(imageTeam.Id, Is.Not.EqualTo(Guid.Empty), "Mã định danh của hình ảnh phải có giá trị mới, không rỗng.");
            // - Đường dẫn ảnh (Url) phải giống với đường dẫn đã nhập, như liên kết đến ảnh logo trên mạng.
            Assert.That(imageTeam.Url, Is.EqualTo("http://example.com/team.jpg"), "Đường dẫn ảnh phải đúng như đã nhập.");
            // - Mã công khai (PublicId) phải giống với mã đã nhập, như một tên ngắn để tìm ảnh.
            Assert.That(imageTeam.PublicId, Is.EqualTo("team123"), "Mã công khai phải đúng như đã nhập.");
            // - Mô tả ảnh (AltText) phải trống vì bạn chưa viết gì để mô tả ảnh.
            Assert.That(imageTeam.AltText, Is.Null, "Mô tả ảnh phải trống vì chưa nhập mô tả.");
            // - Thời gian tạo (CreateAt) phải là thời gian hiện tại, như khi bạn vừa tải ảnh lên.
            Assert.That(imageTeam.CreateAt, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Thời gian tạo phải là thời gian hiện tại khi tải ảnh.");
            // - Thời gian cập nhật (UpdateAt) cũng phải là thời gian hiện tại, vì ảnh vừa được tạo.
            Assert.That(imageTeam.UpdateAt, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Thời gian cập nhật phải là thời gian hiện tại khi tạo ảnh.");
            // - Mã đội bóng (TeamId) phải rỗng vì chưa liên kết ảnh với đội bóng nào.
            Assert.That(imageTeam.TeamId, Is.EqualTo(Guid.Empty), "Mã đội bóng phải rỗng vì chưa chọn đội nào.");
            // - Thông tin đội bóng (Team) phải trống vì chưa liên kết với đội bóng cụ thể.
            Assert.That(imageTeam.Team, Is.Null, "Thông tin đội bóng phải trống vì chưa liên kết với đội nào.");
        }

        // Bài kiểm tra 2: Kiểm tra xem khi cập nhật thông tin cho hình ảnh đội bóng, các giá trị có được lưu đúng không.
        [Test]
        public void ImageTeam_SetProperties_UpdatesCorrectly()
        {
            // Tạo một hình ảnh đội bóng mới, như logo của một đội.
            var imageTeam = new ImageTeam { Url = "http://example.com/team.jpg", PublicId = "team123" };
            // Chuẩn bị thông tin một đội bóng để liên kết với hình ảnh, như đội bóng "Team A".
            var team = new Team { Id = Guid.NewGuid(), Name = "Team A" };

            // Cập nhật thông tin cho hình ảnh:
            // - Thêm mô tả ảnh, như "Logo đội bóng A" để người xem hiểu ảnh này là gì.
            imageTeam.AltText = "Team A Logo";
            // - Gán mã đội bóng để biết ảnh này thuộc đội nào.
            imageTeam.TeamId = team.Id;
            // - Liên kết với thông tin đầy đủ của đội bóng.
            imageTeam.Team = team;
            // - Cập nhật thời gian sửa đổi thành ngày mai, như khi bạn chỉnh sửa ảnh sau một ngày.
            imageTeam.UpdateAt = DateTime.Now.AddDays(1);

            // Kiểm tra xem các thông tin đã được cập nhật đúng chưa:
            // - Mô tả ảnh phải là "Logo đội bóng A" như đã nhập.
            Assert.That(imageTeam.AltText, Is.EqualTo("Team A Logo"), "Mô tả ảnh phải là 'Logo đội bóng A'.");
            // - Mã đội bóng phải khớp với mã của đội đã chọn.
            Assert.That(imageTeam.TeamId, Is.EqualTo(team.Id), "Mã đội bóng phải khớp với đội đã chọn.");
            // - Thông tin đội bóng phải khớp với đội đã liên kết, như đội "Team A".
            Assert.That(imageTeam.Team, Is.EqualTo(team), "Thông tin đội bóng phải khớp với đội đã chọn.");
            // - Thời gian cập nhật phải muộn hơn thời gian tạo, vì ảnh đã được chỉnh sửa.
            Assert.That(imageTeam.UpdateAt, Is.GreaterThan(imageTeam.CreateAt), "Thời gian cập nhật phải muộn hơn thời gian tạo.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể đặt đường dẫn ảnh là một liên kết rất dài (2000 ký tự) không.
        [Test]
        public void ImageTeam_SetLongUrl_SetsCorrectly()
        {
            // Tạo một hình ảnh đội bóng mới.
            var imageTeam = new ImageTeam { Url = new string('a', 2000) + ".jpg", PublicId = "team123" };
            // Kiểm tra xem đường dẫn ảnh dài có được lưu đúng không, như khi bạn dùng một liên kết rất dài trên mạng.
            Assert.That(imageTeam.Url, Has.Length.LessThanOrEqualTo(2048), "Đường dẫn ảnh dài phải được lưu đúng, không vượt quá giới hạn thông thường.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể đặt mã công khai thành chuỗi rỗng (không có mã) không.
        [Test]
        public void ImageTeam_SetEmptyPublicId_SetsCorrectly()
        {
            // Tạo một hình ảnh đội bóng mới với mã công khai rỗng, như khi bạn chưa đặt tên ngắn cho ảnh.
            var imageTeam = new ImageTeam { Url = "http://example.com/team.jpg", PublicId = "" };
            // Kiểm tra xem mã công khai đã được lưu là rỗng chưa.
            Assert.That(imageTeam.PublicId, Is.Empty, "Mã công khai phải là chuỗi rỗng khi bạn không nhập mã.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể bỏ liên kết với đội bóng (đặt thành trống) không.
        [Test]
        public void ImageTeam_SetNullTeam_SetsCorrectly()
        {
            // Tạo một hình ảnh đội bóng mới.
            var imageTeam = new ImageTeam { Url = "http://example.com/team.jpg", PublicId = "team123" };
            // Bỏ liên kết với đội bóng, như khi ảnh chưa thuộc về đội nào.
            imageTeam.Team = null;
            // Kiểm tra xem thông tin đội bóng đã trống chưa, như khi bạn xóa liên kết với đội.
            Assert.That(imageTeam.Team, Is.Null, "Thông tin đội bóng phải trống khi bạn bỏ liên kết.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể đặt mô tả ảnh là chuỗi rỗng (không có mô tả) không.
        [Test]
        public void ImageTeam_SetEmptyAltText_SetsCorrectly()
        {
            // Tạo một hình ảnh đội bóng mới.
            var imageTeam = new ImageTeam { Url = "http://example.com/team.jpg", PublicId = "team123" };
            // Đặt mô tả ảnh là chuỗi rỗng, như khi bạn không muốn mô tả gì về ảnh.
            imageTeam.AltText = "";
            // Kiểm tra xem mô tả ảnh đã được lưu là rỗng chưa.
            Assert.That(imageTeam.AltText, Is.Empty, "Mô tả ảnh phải là chuỗi rỗng khi bạn không nhập gì.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể đặt thời gian tạo thành một ngày trong quá khứ (như 1/1/2020) không.
        [Test]
        public void ImageTeam_SetPastCreateAt_SetsCorrectly()
        {
            // Tạo một hình ảnh đội bóng mới.
            var imageTeam = new ImageTeam { Url = "http://example.com/team.jpg", PublicId = "team123" };
            // Đặt thời gian tạo là ngày 1/1/2020, như khi ảnh được tải lên từ lâu.
            var pastDate = new DateTime(2020, 1, 1);
            imageTeam.CreateAt = pastDate;
            // Kiểm tra xem thời gian tạo đã được lưu đúng chưa.
            Assert.That(imageTeam.CreateAt, Is.EqualTo(pastDate), "Thời gian tạo phải là ngày 1/1/2020 như đã chọn.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể thay đổi mã đội bóng nhiều lần không.
        [Test]
        public void ImageTeam_UpdateTeamIdMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một hình ảnh đội bóng mới.
            var imageTeam = new ImageTeam { Url = "http://example.com/team.jpg", PublicId = "team123" };
            // Gán mã đội bóng đầu tiên, như khi ảnh thuộc đội A.
            var teamId1 = Guid.NewGuid();
            imageTeam.TeamId = teamId1;
            // Thay đổi sang mã đội bóng thứ hai, như khi ảnh được chuyển sang đội B.
            var teamId2 = Guid.NewGuid();
            imageTeam.TeamId = teamId2;
            // Kiểm tra xem mã đội bóng cuối cùng là mã thứ hai không.
            Assert.That(imageTeam.TeamId, Is.EqualTo(teamId2), "Mã đội bóng phải được cập nhật thành mã đội mới.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể liên kết với đội bóng không có tên không.
        [Test]
        public void ImageTeam_SetTeamWithNullName_SetsCorrectly()
        {
            // Tạo một hình ảnh đội bóng mới.
            var imageTeam = new ImageTeam { Url = "http://example.com/team.jpg", PublicId = "team123" };
            // Tạo một đội bóng nhưng không có tên, như khi thông tin đội chưa đầy đủ.
            var team = new Team { Id = Guid.NewGuid(), Name = null };
            // Liên kết hình ảnh với đội bóng này.
            imageTeam.Team = team;
            // Kiểm tra xem đội bóng đã được liên kết đúng chưa, dù không có tên.
            Assert.That(imageTeam.Team, Is.EqualTo(team), "Hình ảnh phải liên kết được với đội bóng dù đội không có tên.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể đặt mã đội bóng thành rỗng không.
        [Test]
        public void ImageTeam_SetEmptyTeamId_SetsCorrectly()
        {
            // Tạo một hình ảnh đội bóng mới.
            var imageTeam = new ImageTeam { Url = "http://example.com/team.jpg", PublicId = "team123" };
            // Đặt mã đội bóng là rỗng, như khi bạn chưa chọn đội nào cho ảnh.
            imageTeam.TeamId = Guid.Empty;
            // Kiểm tra xem mã đội bóng đã được lưu là rỗng chưa.
            Assert.That(imageTeam.TeamId, Is.EqualTo(Guid.Empty), "Mã đội bóng phải rỗng khi bạn không chọn đội.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể đặt mô tả ảnh với ký tự đặc biệt (như @#$%) không.
        [Test]
        public void ImageTeam_SetAltTextWithSpecialCharacters_SetsCorrectly()
        {
            // Tạo một hình ảnh đội bóng mới.
            var imageTeam = new ImageTeam { Url = "http://example.com/team.jpg", PublicId = "team123" };
            // Đặt mô tả ảnh với các ký tự đặc biệt, như khi bạn dùng ký hiệu để mô tả logo.
            imageTeam.AltText = "Team@#$%Logo";
            // Kiểm tra xem mô tả ảnh đã được lưu đúng chưa, bao gồm cả ký tự đặc biệt.
            Assert.That(imageTeam.AltText, Is.EqualTo("Team@#$%Logo"), "Mô tả ảnh phải được lưu đúng với các ký tự đặc biệt.");
        }
    }
}