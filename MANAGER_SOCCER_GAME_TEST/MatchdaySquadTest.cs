using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin về đội hình thi đấu (như danh sách cầu thủ ra sân) được thiết lập đúng.
    [TestFixture]
    public class MatchdaySquadTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo một đội hình mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void MatchdaySquad_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một đội hình mới, như khi bạn bắt đầu chọn cầu thủ cho một trận đấu.
            var matchdaySquad = new MatchdaySquad();

            // Kiểm tra các thông tin ban đầu:
            // - Mã trận đấu (IdGame) phải rỗng vì chưa liên kết với trận đấu nào.
            Assert.That(matchdaySquad.IdGame, Is.EqualTo(Guid.Empty), "Mã trận đấu phải rỗng vì chưa chọn trận đấu nào.");
            // - Thông tin trận đấu (Game) phải trống vì chưa có trận đấu được chọn.
            Assert.That(matchdaySquad.Game, Is.Null, "Thông tin trận đấu phải trống vì chưa chọn trận đấu.");
            // - Mã cầu thủ (IdPlayer) phải rỗng vì chưa chọn cầu thủ nào.
            Assert.That(matchdaySquad.IdPlayer, Is.EqualTo(Guid.Empty), "Mã cầu thủ phải rỗng vì chưa chọn cầu thủ nào.");
            // - Thông tin cầu thủ (Player) phải trống vì chưa có cầu thủ nào được chọn.
            Assert.That(matchdaySquad.Player, Is.Null, "Thông tin cầu thủ phải trống vì chưa có cầu thủ.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể đặt mã trận đấu thành rỗng (không liên kết với trận nào) không.
        [Test]
        public void MatchdaySquad_SetEmptyIdGame_SetsCorrectly()
        {
            // Tạo một đội hình mới.
            var matchdaySquad = new MatchdaySquad();
            // Đặt mã trận đấu là rỗng, như khi chưa chọn trận đấu nào.
            matchdaySquad.IdGame = Guid.Empty;
            // Kiểm tra xem mã trận đấu đã được lưu là rỗng chưa.
            Assert.That(matchdaySquad.IdGame, Is.EqualTo(Guid.Empty), "Mã trận đấu phải rỗng khi chưa chọn trận đấu.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể bỏ thông tin trận đấu (đặt thành trống) không.
        [Test]
        public void MatchdaySquad_SetNullGame_SetsCorrectly()
        {
            // Tạo một đội hình mới.
            var matchdaySquad = new MatchdaySquad();
            // Bỏ thông tin trận đấu, như khi đội hình chưa thuộc trận nào.
            matchdaySquad.Game = null;
            // Kiểm tra xem thông tin trận đấu đã trống chưa.
            Assert.That(matchdaySquad.Game, Is.Null, "Thông tin trận đấu phải trống khi không liên kết với trận nào.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể đặt mã cầu thủ thành rỗng (không liên kết với cầu thủ nào) không.
        [Test]
        public void MatchdaySquad_SetEmptyIdPlayer_SetsCorrectly()
        {
            // Tạo một đội hình mới.
            var matchdaySquad = new MatchdaySquad();
            // Đặt mã cầu thủ là rỗng, như khi chưa chọn cầu thủ nào.
            matchdaySquad.IdPlayer = Guid.Empty;
            // Kiểm tra xem mã cầu thủ đã được lưu là rỗng chưa.
            Assert.That(matchdaySquad.IdPlayer, Is.EqualTo(Guid.Empty), "Mã cầu thủ phải rỗng khi chưa chọn cầu thủ.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể bỏ thông tin cầu thủ (đặt thành trống) không.
        [Test]
        public void MatchdaySquad_SetNullPlayer_SetsCorrectly()
        {
            // Tạo một đội hình mới.
            var matchdaySquad = new MatchdaySquad();
            // Bỏ thông tin cầu thủ, như khi đội hình chưa có cầu thủ nào.
            matchdaySquad.Player = null;
            // Kiểm tra xem thông tin cầu thủ đã trống chưa.
            Assert.That(matchdaySquad.Player, Is.Null, "Thông tin cầu thủ phải trống khi không liên kết với cầu thủ nào.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể liên kết đội hình với một trận đấu đã bị xóa không.
        [Test]
        public void MatchdaySquad_SetGameWithDeletedFlag_SetsCorrectly()
        {
            // Tạo một đội hình mới.
            var matchdaySquad = new MatchdaySquad();
            // Tạo một trận đấu và đánh dấu nó đã bị xóa, như khi trận đấu bị hủy.
            var game = new Game { Id = Guid.NewGuid(), IsDeleted = true };
            // Liên kết đội hình với trận đấu này.
            matchdaySquad.Game = game;
            // Kiểm tra xem thông tin trận đấu đã được liên kết đúng chưa.
            Assert.That(matchdaySquad.Game, Is.EqualTo(game), "Đội hình phải liên kết được với trận đấu dù trận đó đã bị xóa.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể liên kết đội hình với cầu thủ không có tên không.
        [Test]
        public void MatchdaySquad_SetPlayerWithNullName_SetsCorrectly()
        {
            // Tạo một đội hình mới.
            var matchdaySquad = new MatchdaySquad();
            // Tạo một cầu thủ nhưng không có tên, như khi thông tin cầu thủ chưa đầy đủ.
            var player = new Player { Id = Guid.NewGuid(), Name = null };
            // Liên kết đội hình với cầu thủ này.
            matchdaySquad.Player = player;
            // Kiểm tra xem cầu thủ đã được liên kết đúng chưa.
            Assert.That(matchdaySquad.Player, Is.EqualTo(player), "Đội hình phải liên kết được với cầu thủ dù cầu thủ không có tên.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể thay đổi cầu thủ trong đội hình nhiều lần không.
        [Test]
        public void MatchdaySquad_UpdatePlayerMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một đội hình mới.
            var matchdaySquad = new MatchdaySquad();
            // Tạo hai cầu thủ khác nhau để kiểm tra thay đổi.
            var player1 = new Player { Id = Guid.NewGuid(), Name = "John" };
            var player2 = new Player { Id = Guid.NewGuid(), Name = "Jane" };
            // Liên kết đội hình với cầu thủ thứ nhất.
            matchdaySquad.Player = player1;
            // Sau đó đổi sang cầu thủ thứ hai.
            matchdaySquad.Player = player2;
            // Kiểm tra xem cầu thủ cuối cùng trong đội hình là cầu thủ thứ hai không.
            Assert.That(matchdaySquad.Player, Is.EqualTo(player2), "Cầu thủ trong đội hình phải được cập nhật thành cầu thủ thứ hai.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể gán mã cầu thủ mà không liên kết với thông tin cầu thủ không.
        [Test]
        public void MatchdaySquad_SetIdPlayerWithNullPlayer_SetsCorrectly()
        {
            // Tạo một đội hình mới.
            var matchdaySquad = new MatchdaySquad();
            // Gán một mã cầu thủ mới, như khi bạn chỉ biết mã nhưng chưa có thông tin cầu thủ.
            matchdaySquad.IdPlayer = Guid.NewGuid();
            // Đặt thông tin cầu thủ là trống.
            matchdaySquad.Player = null;
            // Kiểm tra xem mã cầu thủ đã được lưu và thông tin cầu thủ vẫn trống chưa.
            Assert.That(matchdaySquad.IdPlayer, Is.Not.EqualTo(Guid.Empty), "Mã cầu thủ phải có giá trị mới.");
            Assert.That(matchdaySquad.Player, Is.Null, "Thông tin cầu thủ phải trống khi chưa liên kết.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể liên kết đội hình với trận đấu không có tên vòng đấu không.
        [Test]
        public void MatchdaySquad_SetGameWithNullRound_SetsCorrectly()
        {
            // Tạo một đội hình mới.
            var matchdaySquad = new MatchdaySquad();
            // Tạo một trận đấu nhưng không có tên vòng đấu, như khi vòng đấu chưa được xác định.
            var game = new Game { Id = Guid.NewGuid(), Round = null };
            // Liên kết đội hình với trận đấu này.
            matchdaySquad.Game = game;
            // Kiểm tra xem trận đấu đã được liên kết đúng chưa.
            Assert.That(matchdaySquad.Game, Is.EqualTo(game), "Đội hình phải liên kết được với trận đấu dù trận đó không có tên vòng đấu.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể liên kết đội hình với cầu thủ có tên rỗng không.
        [Test]
        public void MatchdaySquad_SetPlayerWithEmptyName_SetsCorrectly()
        {
            // Tạo một đội hình mới.
            var matchdaySquad = new MatchdaySquad();
            // Tạo một cầu thủ với tên rỗng, như khi tên cầu thủ chưa được nhập.
            var player = new Player { Id = Guid.NewGuid(), Name = "" };
            // Liên kết đội hình với cầu thủ này.
            matchdaySquad.Player = player;
            // Kiểm tra xem cầu thủ đã được liên kết đúng chưa.
            Assert.That(matchdaySquad.Player, Is.EqualTo(player), "Đội hình phải liên kết được với cầu thủ dù tên cầu thủ là rỗng.");
        }
    }
}