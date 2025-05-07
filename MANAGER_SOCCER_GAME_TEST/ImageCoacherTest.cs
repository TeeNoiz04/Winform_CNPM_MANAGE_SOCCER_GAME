using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin về hình ảnh của huấn luyện viên được thiết lập đúng.
    [TestFixture]
    public class ImageCoacherTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo một hình ảnh huấn luyện viên mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void ImageCoacher_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một hình ảnh huấn luyện viên mới, với đường dẫn ảnh và mã công khai (như mã để nhận diện ảnh).
            var imageCoacher = new ImageCoacher { Url = "http://example.com/coach.jpg", PublicId = "coach123" };

            // Kiểm tra các thông tin ban đầu:
            // - Mã định danh (Id) phải là một giá trị mới, không rỗng, để nhận diện hình ảnh này.
            Assert.That(imageCoacher.Id, Is.Not.EqualTo(Guid.Empty), "Mã định danh của hình ảnh phải có giá trị mới.");
            // - Đường dẫn ảnh (Url) phải đúng như đã nhập: http://example.com/coach.jpg.
            Assert.That(imageCoacher.Url, Is.EqualTo("http://example.com/coach.jpg"), "Đường dẫn ảnh phải đúng như đã nhập.");
            // - Mã công khai (PublicId) phải đúng như đã nhập: coach123.
            Assert.That(imageCoacher.PublicId, Is.EqualTo("coach123"), "Mã công khai phải đúng như đã nhập.");
            // - Mô tả ảnh (AltText) phải trống vì chưa nhập mô tả.
            Assert.That(imageCoacher.AltText, Is.Null, "Mô tả ảnh phải trống vì chưa nhập.");
            // - Thời gian tạo (CreateAt) phải là thời gian hiện tại (khi tạo ảnh).
            Assert.That(imageCoacher.CreateAt, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Thời gian tạo phải là thời gian hiện tại.");
            // - Thời gian cập nhật (UpdateAt) cũng phải là thời gian hiện tại.
            Assert.That(imageCoacher.UpdateAt, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Thời gian cập nhật phải là thời gian hiện tại.");
            // - Mã huấn luyện viên (CoachId) phải rỗng vì chưa liên kết với huấn luyện viên nào.
            Assert.That(imageCoacher.CoachId, Is.EqualTo(Guid.Empty), "Mã huấn luyện viên phải rỗng vì chưa liên kết.");
            // - Thông tin huấn luyện viên (Coach) phải trống vì chưa liên kết.
            Assert.That(imageCoacher.Coach, Is.Null, "Thông tin huấn luyện viên phải trống vì chưa liên kết.");
        }

        // Bài kiểm tra 2: Kiểm tra xem khi cập nhật thông tin cho hình ảnh huấn luyện viên, các giá trị có được lưu đúng không.
        [Test]
        public void ImageCoacher_SetProperties_UpdatesCorrectly()
        {
            // Tạo một hình ảnh huấn luyện viên mới.
            var imageCoacher = new ImageCoacher { Url = "http://example.com/coach.jpg", PublicId = "coach123" };
            // Tạo một huấn luyện viên để liên kết với hình ảnh.
            var coach = new Coach { Id = Guid.NewGuid(), Name = "Coach A" };

            // Cập nhật các thông tin:
            // - Thêm mô tả ảnh: "Hình ảnh huấn luyện viên".
            imageCoacher.AltText = "Coach Image";
            // - Liên kết với mã huấn luyện viên.
            imageCoacher.CoachId = coach.Id;
            // - Liên kết với thông tin huấn luyện viên.
            imageCoacher.Coach = coach;
            // - Cập nhật thời gian sửa đổi thành ngày mai.
            imageCoacher.UpdateAt = DateTime.Now.AddDays(1);

            // Kiểm tra xem các thông tin đã được cập nhật đúng chưa:
            // - Mô tả ảnh phải là "Hình ảnh huấn luyện viên".
            Assert.That(imageCoacher.AltText, Is.EqualTo("Coach Image"), "Mô tả ảnh phải là 'Hình ảnh huấn luyện viên'.");
            // - Mã huấn luyện viên phải khớp với mã của huấn luyện viên đã liên kết.
            Assert.That(imageCoacher.CoachId, Is.EqualTo(coach.Id), "Mã huấn luyện viên phải khớp với huấn luyện viên đã chọn.");
            // - Thông tin huấn luyện viên phải khớp với huấn luyện viên đã liên kết.
            Assert.That(imageCoacher.Coach, Is.EqualTo(coach), "Thông tin huấn luyện viên phải khớp với huấn luyện viên đã chọn.");
            // - Thời gian cập nhật phải muộn hơn thời gian tạo.
            Assert.That(imageCoacher.UpdateAt, Is.GreaterThan(imageCoacher.CreateAt), "Thời gian cập nhật phải muộn hơn thời gian tạo.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể dùng đường dẫn ảnh rất dài (2000 ký tự) không.
        [Test]
        public void ImageCoacher_SetLongUrl_SetsCorrectly()
        {
            // Tạo một hình ảnh huấn luyện viên mới với đường dẫn ảnh dài (2000 ký tự 'a' + đuôi .jpg).
            var imageCoacher = new ImageCoacher { Url = new string('a', 2000) + ".jpg", PublicId = "coach123" };
            // Kiểm tra xem đường dẫn ảnh được lưu đúng, không vượt quá giới hạn thông thường (2048 ký tự).
            Assert.That(imageCoacher.Url, Has.Length.LessThanOrEqualTo(2048), "Đường dẫn ảnh dài phải được lưu đúng.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể đặt mô tả ảnh là chuỗi rỗng (không có chữ) không.
        [Test]
        public void ImageCoacher_SetEmptyAltText_SetsCorrectly()
        {
            // Tạo một hình ảnh huấn luyện viên mới.
            var imageCoacher = new ImageCoacher { Url = "http://example.com/coach.jpg", PublicId = "coach123" };
            // Đặt mô tả ảnh là chuỗi rỗng (không có nội dung).
            imageCoacher.AltText = "";
            // Kiểm tra xem mô tả ảnh đã được lưu là rỗng chưa.
            Assert.That(imageCoacher.AltText, Is.Empty, "Mô tả ảnh phải là chuỗi rỗng khi gán.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể đặt thời gian cập nhật là ngày hôm qua không.
        [Test]
        public void ImageCoacher_SetPastUpdateAt_SetsCorrectly()
        {
            // Tạo một hình ảnh huấn luyện viên mới.
            var imageCoacher = new ImageCoacher { Url = "http://example.com/coach.jpg", PublicId = "coach123" };
            // Chọn thời gian là ngày hôm qua.
            var pastDate = DateTime.Now.AddDays(-1);
            // Gán thời gian này làm thời gian cập nhật.
            imageCoacher.UpdateAt = pastDate;
            // Kiểm tra xem thời gian cập nhật đã được lưu đúng chưa.
            Assert.That(imageCoacher.UpdateAt, Is.EqualTo(pastDate), "Thời gian cập nhật phải là ngày hôm qua.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể bỏ liên kết với huấn luyện viên (đặt thành trống) không.
        [Test]
        public void ImageCoacher_SetNullCoach_SetsCorrectly()
        {
            // Tạo một hình ảnh huấn luyện viên mới.
            var imageCoacher = new ImageCoacher { Url = "http://example.com/coach.jpg", PublicId = "coach123" };
            // Bỏ liên kết với huấn luyện viên (đặt thành trống).
            imageCoacher.Coach = null;
            // Kiểm tra xem thông tin huấn luyện viên đã trống chưa.
            Assert.That(imageCoacher.Coach, Is.Null, "Thông tin huấn luyện viên phải trống khi bỏ liên kết.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể đặt mã huấn luyện viên thành rỗng không.
        [Test]
        public void ImageCoacher_SetCoachIdToEmpty_SetsCorrectly()
        {
            // Tạo một hình ảnh huấn luyện viên mới.
            var imageCoacher = new ImageCoacher { Url = "http://example.com/coach.jpg", PublicId = "coach123" };
            // Đặt mã huấn luyện viên là rỗng.
            imageCoacher.CoachId = Guid.Empty;
            // Kiểm tra xem mã huấn luyện viên đã rỗng chưa.
            Assert.That(imageCoacher.CoachId, Is.EqualTo(Guid.Empty), "Mã huấn luyện viên phải rỗng khi gán.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể thay đổi đường dẫn ảnh nhiều lần không.
        [Test]
        public void ImageCoacher_UpdateUrlMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một hình ảnh huấn luyện viên mới.
            var imageCoacher = new ImageCoacher { Url = "http://example.com/coach.jpg", PublicId = "coach123" };
            // Thay đổi đường dẫn ảnh thành một đường dẫn mới.
            imageCoacher.Url = "http://newurl.com/coach.jpg";
            // Kiểm tra xem đường dẫn ảnh đã được cập nhật đúng chưa.
            Assert.That(imageCoacher.Url, Is.EqualTo("http://newurl.com/coach.jpg"), "Đường dẫn ảnh phải được cập nhật thành đường dẫn mới.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể đặt mã công khai thành chuỗi rỗng không.
        [Test]
        public void ImageCoacher_SetPublicIdToEmpty_SetsCorrectly()
        {
            // Tạo một hình ảnh huấn luyện viên mới với mã công khai rỗng.
            var imageCoacher = new ImageCoacher { Url = "http://example.com/coach.jpg", PublicId = "" };
            // Kiểm tra xem mã công khai đã rỗng chưa.
            Assert.That(imageCoacher.PublicId, Is.Empty, "Mã công khai phải là chuỗi rỗng khi gán.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể đặt thời gian tạo thành giá trị nhỏ nhất không.
        [Test]
        public void ImageCoacher_SetCreateAtToMinValue_SetsCorrectly()
        {
            // Tạo một hình ảnh huấn luyện viên mới.
            var imageCoacher = new ImageCoacher { Url = "http://example.com/coach.jpg", PublicId = "coach123" };
            // Đặt thời gian tạo là giá trị nhỏ nhất (rất xa trong quá khứ).
            imageCoacher.CreateAt = DateTime.MinValue;
            // Kiểm tra xem thời gian tạo đã được lưu đúng chưa.
            Assert.That(imageCoacher.CreateAt, Is.EqualTo(DateTime.MinValue), "Thời gian tạo phải là giá trị nhỏ nhất khi gán.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể liên kết với huấn luyện viên không có tên không.
        [Test]
        public void ImageCoacher_SetCoachWithNullName_HandlesCorrectly()
        {
            // Tạo một hình ảnh huấn luyện viên mới.
            var imageCoacher = new ImageCoacher { Url = "http://example.com/coach.jpg", PublicId = "coach123" };
            // Tạo một huấn luyện viên nhưng không có tên.
            var coach = new Coach { Id = Guid.NewGuid(), Name = null };
            // Liên kết hình ảnh với huấn luyện viên này.
            imageCoacher.Coach = coach;
            // Kiểm tra xem huấn luyện viên đã được liên kết đúng chưa.
            Assert.That(imageCoacher.Coach, Is.EqualTo(coach), "Hình ảnh phải liên kết được với huấn luyện viên dù không có tên.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể đặt mô tả ảnh với ký tự đặc biệt (như @#$%) không.
        [Test]
        public void ImageCoacher_SetAltTextWithSpecialCharacters_SetsCorrectly()
        {
            // Tạo một hình ảnh huấn luyện viên mới.
            var imageCoacher = new ImageCoacher { Url = "http://example.com/coach.jpg", PublicId = "coach123" };
            // Đặt mô tả ảnh với các ký tự đặc biệt.
            imageCoacher.AltText = "Coach@#$%";
            // Kiểm tra xem mô tả ảnh đã được lưu đúng chưa.
            Assert.That(imageCoacher.AltText, Is.EqualTo("Coach@#$%"), "Mô tả ảnh phải được lưu đúng với ký tự đặc biệt.");
        }
    }
}