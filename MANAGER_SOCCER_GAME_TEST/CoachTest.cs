using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin của huấn luyện viên được thiết lập đúng.
    [TestFixture]
    public class CoachTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo một huấn luyện viên mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void Coach_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một huấn luyện viên mới, như khi bạn bắt đầu nhập thông tin cho một huấn luyện viên.
            var coach = new Coach();

            // Kiểm tra các thông tin ban đầu:
            // - Mã định danh (Id) phải rỗng vì chưa gán huấn luyện viên cụ thể.
            Assert.That(coach.Id, Is.EqualTo(Guid.Empty), "Mã định danh của huấn luyện viên phải rỗng khi chưa gán.");
            // - Tên (Name) phải trống vì chưa nhập tên.
            Assert.That(coach.Name, Is.Null, "Tên huấn luyện viên phải trống vì chưa nhập.");
            // - Quốc tịch (National) phải trống vì chưa chọn quốc gia.
            Assert.That(coach.National, Is.Null, "Quốc tịch phải trống vì chưa chọn.");
            // - Số năm kinh nghiệm (ExpYear) phải là 0 vì chưa nhập kinh nghiệm.
            Assert.That(coach.ExpYear, Is.EqualTo(0), "Số năm kinh nghiệm phải là 0 vì chưa nhập.");
            // - Số điện thoại (PhoneNumber) phải trống vì chưa nhập số.
            Assert.That(coach.PhoneNumber, Is.Null, "Số điện thoại phải trống vì chưa nhập.");
            // - Email phải trống vì chưa nhập email.
            Assert.That(coach.Email, Is.Null, "Email phải trống vì chưa nhập.");
            // - Mã hình ảnh (IdImage) phải trống vì chưa liên kết với hình ảnh.
            Assert.That(coach.IdImage, Is.Null, "Mã hình ảnh phải trống vì chưa liên kết.");
            // - Hình ảnh (Image) phải trống vì chưa có ảnh.
            Assert.That(coach.Image, Is.Null, "Hình ảnh phải trống vì chưa có ảnh.");
            // - Đội bóng (Team) phải trống vì chưa liên kết với đội nào.
            Assert.That(coach.Team, Is.Null, "Đội bóng phải trống vì chưa liên kết.");
        }

        // Bài kiểm tra 2: Kiểm tra xem khi nhập đầy đủ thông tin cho huấn luyện viên, các giá trị có được cập nhật đúng không.
        [Test]
        public void Coach_SetProperties_UpdatesCorrectly()
        {
            // Tạo một huấn luyện viên mới.
            var coach = new Coach();
            // Chuẩn bị hình ảnh và đội bóng để liên kết với huấn luyện viên.
            var image = new ImageCoacher { Url = "http://example.com/coach.jpg", PublicId = "coach123" };
            var team = new Team { Id = Guid.NewGuid(), Name = "Team A" };

            // Nhập thông tin cho huấn luyện viên:
            // - Gán mã định danh mới (như số nhận diện huấn luyện viên).
            coach.Id = Guid.NewGuid();
            // - Đặt tên là "Coach A".
            coach.Name = "Coach A";
            // - Đặt quốc tịch là "USA".
            coach.National = "USA";
            // - Đặt số năm kinh nghiệm là 10 năm.
            coach.ExpYear = 10;
            // - Đặt số điện thoại là "123-456-7890".
            coach.PhoneNumber = "123-456-7890";
            // - Đặt email là "coach.a@example.com".
            coach.Email = "coach.a@example.com";
            // - Gán mã hình ảnh mới.
            coach.IdImage = Guid.NewGuid();
            // - Liên kết với hình ảnh.
            coach.Image = image;
            // - Liên kết với đội bóng.
            coach.Team = team;

            // Kiểm tra xem các thông tin đã được cập nhật đúng chưa:
            // - Mã định danh phải khác giá trị rỗng.
            Assert.That(coach.Id, Is.Not.EqualTo(Guid.Empty), "Mã định danh phải có giá trị mới.");
            // - Tên phải là "Coach A".
            Assert.That(coach.Name, Is.EqualTo("Coach A"), "Tên huấn luyện viên phải là 'Coach A'.");
            // - Quốc tịch phải là "USA".
            Assert.That(coach.National, Is.EqualTo("USA"), "Quốc tịch phải là 'USA'.");
            // - Số năm kinh nghiệm phải là 10.
            Assert.That(coach.ExpYear, Is.EqualTo(10), "Số năm kinh nghiệm phải là 10.");
            // - Số điện thoại phải là "123-456-7890".
            Assert.That(coach.PhoneNumber, Is.EqualTo("123-456-7890"), "Số điện thoại phải là '123-456-7890'.");
            // - Email phải là "coach.a@example.com".
            Assert.That(coach.Email, Is.EqualTo("coach.a@example.com"), "Email phải là 'coach.a@example.com'.");
            // - Mã hình ảnh phải có giá trị.
            Assert.That(coach.IdImage, Is.Not.Null, "Mã hình ảnh phải có giá trị mới.");
            // - Hình ảnh phải khớp với hình đã liên kết.
            Assert.That(coach.Image, Is.EqualTo(image), "Hình ảnh phải khớp với ảnh đã chọn.");
            // - Đội bóng phải khớp với đội đã liên kết.
            Assert.That(coach.Team, Is.EqualTo(team), "Đội bóng phải khớp với đội đã chọn.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể đặt số năm kinh nghiệm là 0 không.
        [Test]
        public void Coach_SetZeroExpYear_SetsCorrectly()
        {
            // Tạo một huấn luyện viên mới.
            var coach = new Coach();
            // Đặt số năm kinh nghiệm là 0 (như một huấn luyện viên mới bắt đầu).
            coach.ExpYear = 0;
            // Kiểm tra xem số năm kinh nghiệm đã được lưu đúng chưa.
            Assert.That(coach.ExpYear, Is.EqualTo(0), "Số năm kinh nghiệm phải là 0 khi gán.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể đặt tên huấn luyện viên rất dài (100 ký tự) không.
        [Test]
        public void Coach_SetLongName_SetsCorrectly()
        {
            // Tạo một huấn luyện viên mới.
            var coach = new Coach();
            // Tạo một tên dài 100 ký tự 'A'.
            var longName = new string('A', 100);
            // Gán tên dài này cho huấn luyện viên.
            coach.Name = longName;
            // Kiểm tra xem tên đã được lưu đúng chưa.
            Assert.That(coach.Name, Is.EqualTo(longName), "Tên huấn luyện viên phải được lưu đúng dù rất dài.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể đặt email là chuỗi rỗng không.
        [Test]
        public void Coach_SetEmptyEmail_SetsCorrectly()
        {
            // Tạo một huấn luyện viên mới.
            var coach = new Coach();
            // Đặt email là chuỗi rỗng (không có email).
            coach.Email = "";
            // Kiểm tra xem email đã được lưu là rỗng chưa.
            Assert.That(coach.Email, Is.Empty, "Email phải là chuỗi rỗng khi gán.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể bỏ liên kết với đội bóng (đặt thành trống) không.
        [Test]
        public void Coach_SetNullTeam_SetsCorrectly()
        {
            // Tạo một huấn luyện viên mới.
            var coach = new Coach();
            // Bỏ liên kết với đội bóng (đặt thành trống).
            coach.Team = null;
            // Kiểm tra xem thông tin đội bóng đã trống chưa.
            Assert.That(coach.Team, Is.Null, "Thông tin đội bóng phải trống khi bỏ liên kết.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể đặt mã hình ảnh thành rỗng không.
        [Test]
        public void Coach_SetIdImageToEmpty_SetsCorrectly()
        {
            // Tạo một huấn luyện viên mới.
            var coach = new Coach();
            // Đặt mã hình ảnh là rỗng.
            coach.IdImage = Guid.Empty;
            // Kiểm tra xem mã hình ảnh đã rỗng chưa.
            Assert.That(coach.IdImage, Is.EqualTo(Guid.Empty), "Mã hình ảnh phải rỗng khi gán.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể đặt quốc tịch với ký tự đặc biệt (như @#$%) không.
        [Test]
        public void Coach_SetNationalWithSpecialCharacters_SetsCorrectly()
        {
            // Tạo một huấn luyện viên mới.
            var coach = new Coach();
            // Đặt quốc tịch với các ký tự đặc biệt.
            coach.National = "Country@#$";
            // Kiểm tra xem quốc tịch đã được lưu đúng chưa.
            Assert.That(coach.National, Is.EqualTo("Country@#$"), "Quốc tịch phải được lưu đúng với ký tự đặc biệt.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể đặt số điện thoại với khoảng trắng (như "123 456 7890") không.
        [Test]
        public void Coach_SetPhoneNumberWithSpaces_SetsCorrectly()
        {
            // Tạo một huấn luyện viên mới.
            var coach = new Coach();
            // Đặt số điện thoại với khoảng trắng.
            coach.PhoneNumber = "123 456 7890";
            // Kiểm tra xem số điện thoại đã được lưu đúng chưa.
            Assert.That(coach.PhoneNumber, Is.EqualTo("123 456 7890"), "Số điện thoại phải được lưu đúng với khoảng trắng.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể liên kết với hình ảnh không có đường dẫn không.
        [Test]
        public void Coach_SetImageWithNullUrl_HandlesCorrectly()
        {
            // Tạo một huấn luyện viên mới.
            var coach = new Coach();
            // Tạo một hình ảnh nhưng không có đường dẫn (Url).
            var image = new ImageCoacher { Url = null, PublicId = "coach123" };
            // Liên kết hình ảnh này với huấn luyện viên.
            coach.Image = image;
            // Kiểm tra xem hình ảnh đã được liên kết đúng chưa.
            Assert.That(coach.Image, Is.EqualTo(image), "Hình ảnh phải được liên kết dù không có đường dẫn.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể thay đổi tên huấn luyện viên nhiều lần không.
        [Test]
        public void Coach_UpdateNameMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một huấn luyện viên mới.
            var coach = new Coach();
            // Đặt tên là "Coach A".
            coach.Name = "Coach A";
            // Thay đổi tên thành "Coach B".
            coach.Name = "Coach B";
            // Kiểm tra xem tên cuối cùng là "Coach B" không.
            Assert.That(coach.Name, Is.EqualTo("Coach B"), "Tên huấn luyện viên phải được cập nhật thành 'Coach B'.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể đặt số năm kinh nghiệm rất lớn (giá trị tối đa) không.
        [Test]
        public void Coach_SetMaxExpYear_SetsCorrectly()
        {
            // Tạo một huấn luyện viên mới.
            var coach = new Coach();
            // Đặt số năm kinh nghiệm là giá trị lớn nhất có thể (rất nhiều năm).
            coach.ExpYear = int.MaxValue;
            // Kiểm tra xem số năm kinh nghiệm đã được lưu đúng chưa.
            Assert.That(coach.ExpYear, Is.EqualTo(int.MaxValue), "Số năm kinh nghiệm phải được lưu đúng với giá trị lớn nhất.");
        }
    }
}