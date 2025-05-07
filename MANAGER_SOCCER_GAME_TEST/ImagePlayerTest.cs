using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin về hình ảnh của cầu thủ được thiết lập đúng.
    [TestFixture]
    public class ImagePlayerTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo một hình ảnh cầu thủ mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void ImagePlayer_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một hình ảnh cầu thủ mới, với đường dẫn ảnh và mã công khai (như mã để nhận diện ảnh).
            var imagePlayer = new ImagePlayer { Url = "http://example.com/player.jpg", PublicId = "player123" };

            // Kiểm tra các thông tin ban đầu:
            // - Mã định danh (Id) phải là một giá trị mới, không rỗng, để nhận diện hình ảnh này.
            Assert.That(imagePlayer.Id, Is.Not.EqualTo(Guid.Empty), "Mã định danh của hình ảnh phải có giá trị mới.");
            // - Đường dẫn ảnh (Url) phải đúng như đã nhập: http://example.com/player.jpg.
            Assert.That(imagePlayer.Url, Is.EqualTo("http://example.com/player.jpg"), "Đường dẫn ảnh phải đúng như đã nhập.");
            // - Mã công khai (PublicId) phải đúng như đã nhập: player123.
            Assert.That(imagePlayer.PublicId, Is.EqualTo("player123"), "Mã công khai phải đúng như đã nhập.");
            // - Mô tả ảnh (AltText) phải trống vì chưa nhập mô tả.
            Assert.That(imagePlayer.AltText, Is.Null, "Mô tả ảnh phải trống vì chưa nhập.");
            // - Thời gian tạo (CreateAt) phải là thời gian hiện tại (khi tạo ảnh).
            Assert.That(imagePlayer.CreateAt, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Thời gian tạo phải là thời gian hiện tại.");
            // - Thời gian cập nhật (UpdateAt) cũng phải là thời gian hiện tại.
            Assert.That(imagePlayer.UpdateAt, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Thời gian cập nhật phải là thời gian hiện tại.");
            // - Mã cầu thủ (PlayerId) phải rỗng vì chưa liên kết với cầu thủ nào.
            Assert.That(imagePlayer.PlayerId, Is.EqualTo(Guid.Empty), "Mã cầu thủ phải rỗng vì chưa liên kết.");
            // - Thông tin cầu thủ (Player) phải trống vì chưa liên kết.
            Assert.That(imagePlayer.Player, Is.Null, "Thông tin cầu thủ phải trống vì chưa liên kết.");
        }

        // Bài kiểm tra 2: Kiểm tra xem khi cập nhật thông tin cho hình ảnh cầu thủ, các giá trị có được lưu đúng không.
        [Test]
        public void ImagePlayer_SetProperties_UpdatesCorrectly()
        {
            // Tạo một hình ảnh cầu thủ mới.
            var imagePlayer = new ImagePlayer { Url = "http://example.com/player.jpg", PublicId = "player123" };
            // Tạo một cầu thủ để liên kết với hình ảnh.
            var player = new Player { Id = Guid.NewGuid(), Name = "John Doe" };

            // Cập nhật các thông tin:
            // - Thêm mô tả ảnh: "Hình ảnh cầu thủ".
            imagePlayer.AltText = "Player Image";
            // - Liên kết với mã cầu thủ.
            imagePlayer.PlayerId = player.Id;
            // - Liên kết với thông tin cầu thủ.
            imagePlayer.Player = player;
            // - Cập nhật thời gian sửa đổi thành ngày mai.
            imagePlayer.UpdateAt = DateTime.Now.AddDays(1);

            // Kiểm tra xem các thông tin đã được cập nhật đúng chưa:
            // - Mô tả ảnh phải là "Hình ảnh cầu thủ".
            Assert.That(imagePlayer.AltText, Is.EqualTo("Player Image"), "Mô tả ảnh phải là 'Hình ảnh cầu thủ'.");
            // - Mã cầu thủ phải khớp với mã của cầu thủ đã liên kết.
            Assert.That(imagePlayer.PlayerId, Is.EqualTo(player.Id), "Mã cầu thủ phải khớp với cầu thủ đã chọn.");
            // - Thông tin cầu thủ phải khớp với cầu thủ đã liên kết.
            Assert.That(imagePlayer.Player, Is.EqualTo(player), "Thông tin cầu thủ phải khớp với cầu thủ đã chọn.");
            // - Thời gian cập nhật phải muộn hơn thời gian tạo.
            Assert.That(imagePlayer.UpdateAt, Is.GreaterThan(imagePlayer.CreateAt), "Thời gian cập nhật phải muộn hơn thời gian tạo.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể đặt mã công khai thành chuỗi rỗng không.
        [Test]
        public void ImagePlayer_SetEmptyPublicId_SetsCorrectly()
        {
            // Tạo một hình ảnh cầu thủ mới với mã công khai rỗng.
            var imagePlayer = new ImagePlayer { Url = "http://example.com/player.jpg", PublicId = "" };
            // Kiểm tra xem mã công khai đã được lưu là rỗng chưa.
            Assert.That(imagePlayer.PublicId, Is.Empty, "Mã công khai phải là chuỗi rỗng khi gán.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể đặt mô tả ảnh rất dài (500 ký tự) không.
        [Test]
        public void ImagePlayer_SetLongAltText_SetsCorrectly()
        {
            // Tạo một hình ảnh cầu thủ mới.
            var imagePlayer = new ImagePlayer { Url = "http://example.com/player.jpg", PublicId = "player123" };
            // Tạo một mô tả dài 500 ký tự 'A'.
            var longAltText = new string('A', 500);
            // Gán mô tả dài này cho hình ảnh.
            imagePlayer.AltText = longAltText;
            // Kiểm tra xem mô tả đã được lưu đúng chưa.
            Assert.That(imagePlayer.AltText, Is.EqualTo(longAltText), "Mô tả ảnh phải được lưu đúng dù rất dài.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể bỏ liên kết với cầu thủ (đặt thành trống) không.
        [Test]
        public void ImagePlayer_SetNullPlayer_SetsCorrectly()
        {
            // Tạo một hình ảnh cầu thủ mới.
            var imagePlayer = new ImagePlayer { Url = "http://example.com/player.jpg", PublicId = "player123" };
            // Bỏ liên kết với cầu thủ, như khi hình ảnh chưa thuộc về cầu thủ nào.
            imagePlayer.Player = null;
            // Kiểm tra xem thông tin cầu thủ đã trống chưa.
            Assert.That(imagePlayer.Player, Is.Null, "Thông tin cầu thủ phải trống khi bỏ liên kết.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể đặt mã cầu thủ thành rỗng không.
        [Test]
        public void ImagePlayer_SetEmptyPlayerId_SetsCorrectly()
        {
            // Tạo một hình ảnh cầu thủ mới.
            var imagePlayer = new ImagePlayer { Url = "http://example.com/player.jpg", PublicId = "player123" };
            // Đặt mã cầu thủ là rỗng, như khi chưa chọn cầu thủ nào.
            imagePlayer.PlayerId = Guid.Empty;
            // Kiểm tra xem mã cầu thủ đã được lưu là rỗng chưa.
            Assert.That(imagePlayer.PlayerId, Is.EqualTo(Guid.Empty), "Mã cầu thủ phải rỗng khi gán.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể đặt thời gian tạo thành giá trị nhỏ nhất không.
        [Test]
        public void ImagePlayer_SetCreateAtToMinValue_SetsCorrectly()
        {
            // Tạo một hình ảnh cầu thủ mới.
            var imagePlayer = new ImagePlayer { Url = "http://example.com/player.jpg", PublicId = "player123" };
            // Đặt thời gian tạo là giá trị nhỏ nhất, như một thời điểm rất xa trong quá khứ.
            imagePlayer.CreateAt = DateTime.MinValue;
            // Kiểm tra xem thời gian tạo đã được lưu đúng chưa.
            Assert.That(imagePlayer.CreateAt, Is.EqualTo(DateTime.MinValue), "Thời gian tạo phải là giá trị nhỏ nhất khi gán.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể đặt thời gian cập nhật thành giá trị nhỏ nhất không.
        [Test]
        public void ImagePlayer_SetUpdateAtToMinValue_SetsCorrectly()
        {
            // Tạo một hình ảnh cầu thủ mới.
            var imagePlayer = new ImagePlayer { Url = "http://example.com/player.jpg", PublicId = "player123" };
            // Đặt thời gian cập nhật là giá trị nhỏ nhất, như một thời điểm rất xa trong quá khứ.
            imagePlayer.UpdateAt = DateTime.MinValue;
            // Kiểm tra xem thời gian cập nhật đã được lưu đúng chưa.
            Assert.That(imagePlayer.UpdateAt, Is.EqualTo(DateTime.MinValue), "Thời gian cập nhật phải là giá trị nhỏ nhất khi gán.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể thay đổi đường dẫn ảnh nhiều lần không.
        [Test]
        public void ImagePlayer_UpdateUrlMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một hình ảnh cầu thủ mới.
            var imagePlayer = new ImagePlayer { Url = "http://example.com/player.jpg", PublicId = "player123" };
            // Thay đổi đường dẫn ảnh thành một đường dẫn mới.
            imagePlayer.Url = "http://newurl.com/player.jpg";
            // Kiểm tra xem đường dẫn ảnh đã được cập nhật đúng chưa.
            Assert.That(imagePlayer.Url, Is.EqualTo("http://newurl.com/player.jpg"), "Đường dẫn ảnh phải được cập nhật thành đường dẫn mới.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể liên kết hình ảnh với cầu thủ không có tên không.
        [Test]
        public void ImagePlayer_SetPlayerWithNullName_SetsCorrectly()
        {
            // Tạo một hình ảnh cầu thủ mới.
            var imagePlayer = new ImagePlayer { Url = "http://example.com/player.jpg", PublicId = "player123" };
            // Tạo một cầu thủ nhưng không có tên, như khi thông tin cầu thủ chưa đầy đủ.
            var player = new Player { Id = Guid.NewGuid(), Name = null };
            // Liên kết hình ảnh với cầu thủ này.
            imagePlayer.Player = player;
            // Kiểm tra xem cầu thủ đã được liên kết đúng chưa.
            Assert.That(imagePlayer.Player, Is.EqualTo(player), "Hình ảnh phải liên kết được với cầu thủ dù cầu thủ không có tên.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể đặt mô tả ảnh với ký tự đặc biệt (như @#$%) không.
        [Test]
        public void ImagePlayer_SetAltTextWithSpecialCharacters_SetsCorrectly()
        {
            // Tạo một hình ảnh cầu thủ mới.
            var imagePlayer = new ImagePlayer { Url = "http://example.com/player.jpg", PublicId = "player123" };
            // Đặt mô tả ảnh với các ký tự đặc biệt, như khi mô tả có ký hiệu lạ.
            imagePlayer.AltText = "Player@#$%";
            // Kiểm tra xem mô tả ảnh đã được lưu đúng chưa.
            Assert.That(imagePlayer.AltText, Is.EqualTo("Player@#$%"), "Mô tả ảnh phải được lưu đúng với ký tự đặc biệt.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể gán mã cầu thủ mà không liên kết với thông tin cầu thủ không.
        [Test]
        public void ImagePlayer_SetPlayerIdWithNullPlayer_SetsCorrectly()
        {
            // Tạo một hình ảnh cầu thủ mới.
            var imagePlayer = new ImagePlayer { Url = "http://example.com/player.jpg", PublicId = "player123" };
            // Gán một mã cầu thủ mới, như khi bạn chỉ biết mã nhưng chưa có thông tin cầu thủ.
            imagePlayer.PlayerId = Guid.NewGuid();
            // Đặt thông tin cầu thủ là trống.
            imagePlayer.Player = null;
            // Kiểm tra xem mã cầu thủ đã được lưu và thông tin cầu thủ vẫn trống chưa.
            Assert.That(imagePlayer.PlayerId, Is.Not.EqualTo(Guid.Empty), "Mã cầu thủ phải có giá trị mới.");
            Assert.That(imagePlayer.Player, Is.Null, "Thông tin cầu thủ phải trống khi chưa liên kết.");
        }
    }
}