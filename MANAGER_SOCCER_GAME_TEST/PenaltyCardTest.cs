using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin về thẻ phạt trong trận đấu được thiết lập đúng.
    [TestFixture]
    public class PenaltyCardTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo thẻ phạt mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void PenaltyCard_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một thẻ phạt mới, như khi bạn ghi nhận một thẻ vàng hoặc đỏ trong trận đấu.
            var penaltyCard = new PenaltyCard();

            // Kiểm tra các thông tin ban đầu:
            // - Mã định danh (Id) phải rỗng vì chưa gán thẻ cụ thể.
            Assert.That(penaltyCard.Id, Is.EqualTo(Guid.Empty), "Mã định danh của thẻ phạt phải rỗng khi chưa gán.");
            // - Loại thẻ (TypeCard) phải trống vì chưa chọn loại thẻ (vàng hay đỏ).
            Assert.That(penaltyCard.TypeCard, Is.Null, "Loại thẻ phải trống vì chưa chọn.");
            // - Mô tả (Description) phải trống vì chưa nhập lý do phạt.
            Assert.That(penaltyCard.Description, Is.Null, "Mô tả phải trống vì chưa nhập lý do.");
            // - Thời gian phạt (Time) phải là 0 vì chưa chọn thời điểm.
            Assert.That(penaltyCard.Time, Is.EqualTo(TimeSpan.Zero), "Thời gian phạt phải là 0 vì chưa chọn.");
            // - Phiên bản dòng (RowVersion) phải trống vì chưa có dữ liệu cần theo dõi.
            Assert.That(penaltyCard.RowVersion, Is.Null, "Phiên bản dòng phải trống vì chưa cần theo dõi.");
            // - Mã cầu thủ (PlayerId) phải rỗng vì chưa liên kết với cầu thủ nào.
            Assert.That(penaltyCard.PlayerId, Is.EqualTo(Guid.Empty), "Mã cầu thủ phải rỗng khi chưa liên kết.");
            // - Thông tin cầu thủ (Player) phải trống vì chưa chọn cầu thủ.
            Assert.That(penaltyCard.Player, Is.Null, "Thông tin cầu thủ phải trống khi chưa chọn.");
            // - Mã trận đấu (GameId) phải rỗng vì chưa liên kết với trận đấu nào.
            Assert.That(penaltyCard.GameId, Is.EqualTo(Guid.Empty), "Mã trận đấu phải rỗng khi chưa liên kết.");
            // - Thông tin trận đấu (Game) phải trống vì chưa chọn trận đấu.
            Assert.That(penaltyCard.Game, Is.Null, "Thông tin trận đấu phải trống khi chưa chọn.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể đặt loại thẻ là "Red" (thẻ đỏ) không.
        [Test]
        public void PenaltyCard_SetRedTypeCard_SetsCorrectly()
        {
            // Tạo một thẻ phạt mới.
            var penaltyCard = new PenaltyCard();
            // Đặt loại thẻ là "Red".
            penaltyCard.TypeCard = "Red";
            // Kiểm tra xem loại thẻ đã được lưu đúng chưa.
            Assert.That(penaltyCard.TypeCard, Is.EqualTo("Red"), "Loại thẻ phải là 'Red' khi gán.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể đặt mô tả thẻ phạt rất dài (500 ký tự) không.
        [Test]
        public void PenaltyCard_SetLongDescription_SetsCorrectly()
        {
            // Tạo một thẻ phạt mới.
            var penaltyCard = new PenaltyCard();
            // Tạo một mô tả dài 500 ký tự 'A'.
            var longDesc = new string('A', 500);
            // Gán mô tả dài này cho thẻ phạt.
            penaltyCard.Description = longDesc;
            // Kiểm tra xem mô tả đã được lưu đúng chưa.
            Assert.That(penaltyCard.Description, Is.EqualTo(longDesc), "Mô tả thẻ phạt phải được lưu đúng dù rất dài.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể đặt thời gian phạt là 2 giờ (tối đa một trận đấu) không.
        [Test]
        public void PenaltyCard_SetMaxTime_SetsCorrectly()
        {
            // Tạo một thẻ phạt mới.
            var penaltyCard = new PenaltyCard();
            // Đặt thời gian phạt là 2 giờ (120 phút).
            var maxTime = TimeSpan.FromHours(2);
            // Gán thời gian này cho thẻ phạt.
            penaltyCard.Time = maxTime;
            // Kiểm tra xem thời gian đã được lưu đúng chưa.
            Assert.That(penaltyCard.Time, Is.EqualTo(maxTime), "Thời gian phạt phải là 2 giờ khi gán.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể bỏ liên kết với cầu thủ (đặt thành trống) không.
        [Test]
        public void PenaltyCard_SetNullPlayer_SetsCorrectly()
        {
            // Tạo một thẻ phạt mới.
            var penaltyCard = new PenaltyCard();
            // Bỏ liên kết với cầu thủ (đặt thành trống).
            penaltyCard.Player = null;
            // Kiểm tra xem thông tin cầu thủ đã trống chưa.
            Assert.That(penaltyCard.Player, Is.Null, "Thông tin cầu thủ phải trống khi bỏ liên kết.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể đặt mã trận đấu thành rỗng không.
        [Test]
        public void PenaltyCard_SetEmptyGameId_SetsCorrectly()
        {
            // Tạo một thẻ phạt mới.
            var penaltyCard = new PenaltyCard();
            // Đặt mã trận đấu là rỗng.
            penaltyCard.GameId = Guid.Empty;
            // Kiểm tra xem mã trận đấu đã rỗng chưa.
            Assert.That(penaltyCard.GameId, Is.EqualTo(Guid.Empty), "Mã trận đấu phải rỗng khi gán.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể đặt phiên bản dòng thành danh sách rỗng không.
        [Test]
        public void PenaltyCard_SetRowVersionToEmpty_SetsCorrectly()
        {
            // Tạo một thẻ phạt mới.
            var penaltyCard = new PenaltyCard();
            // Đặt phiên bản dòng là một danh sách rỗng (không có số nào).
            penaltyCard.RowVersion = Array.Empty<byte>();
            // Kiểm tra xem phiên bản dòng đã rỗng chưa.
            Assert.That(penaltyCard.RowVersion, Is.Empty, "Phiên bản dòng phải rỗng khi gán.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể thay đổi loại thẻ nhiều lần không.
        [Test]
        public void PenaltyCard_UpdateTypeCardMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một thẻ phạt mới.
            var penaltyCard = new PenaltyCard();
            // Đặt loại thẻ là "Yellow".
            penaltyCard.TypeCard = "Yellow";
            // Thay đổi loại thẻ thành "Red".
            penaltyCard.TypeCard = "Red";
            // Kiểm tra xem loại thẻ cuối cùng là "Red" không.
            Assert.That(penaltyCard.TypeCard, Is.EqualTo("Red"), "Loại thẻ phải được cập nhật thành 'Red'.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể liên kết với cầu thủ không có tên không.
        [Test]
        public void PenaltyCard_SetPlayerWithNullName_SetsCorrectly()
        {
            // Tạo một thẻ phạt mới.
            var penaltyCard = new PenaltyCard();
            // Tạo một cầu thủ không có tên.
            var player = new Player { Id = Guid.NewGuid(), Name = null };
            // Liên kết thẻ phạt với cầu thủ này.
            penaltyCard.Player = player;
            // Kiểm tra xem cầu thủ đã được liên kết đúng chưa.
            Assert.That(penaltyCard.Player, Is.EqualTo(player), "Cầu thủ phải được liên kết dù không có tên.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể liên kết với trận đấu không có tên vòng đấu không.
        [Test]
        public void PenaltyCard_SetGameWithNullRound_SetsCorrectly()
        {
            // Tạo một thẻ phạt mới.
            var penaltyCard = new PenaltyCard();
            // Tạo một trận đấu không có tên vòng đấu.
            var game = new Game { Id = Guid.NewGuid(), Round = null };
            // Liên kết thẻ phạt với trận đấu này.
            penaltyCard.Game = game;
            // Kiểm tra xem trận đấu đã được liên kết đúng chưa.
            Assert.That(penaltyCard.Game, Is.EqualTo(game), "Trận đấu phải được liên kết dù không có tên vòng đấu.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể đặt mô tả thẻ phạt thành chuỗi rỗng không.
        [Test]
        public void PenaltyCard_SetEmptyDescription_SetsCorrectly()
        {
            // Tạo một thẻ phạt mới.
            var penaltyCard = new PenaltyCard();
            // Đặt mô tả thẻ phạt là chuỗi rỗng.
            penaltyCard.Description = "";
            // Kiểm tra xem mô tả đã được lưu là rỗng chưa.
            Assert.That(penaltyCard.Description, Is.Empty, "Mô tả thẻ phạt phải là chuỗi rỗng khi gán.");
        }
    }
}