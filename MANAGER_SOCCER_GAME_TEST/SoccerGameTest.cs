using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin về sự kiện trong trận đấu (như bàn thắng, thẻ phạt) được thiết lập đúng.
    [TestFixture]
    public class SoccerGameTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo một sự kiện trận đấu mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void SoccerGame_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một sự kiện trận đấu mới, như khi bạn bắt đầu ghi lại một bàn thắng.
            var soccerGame = new SoccerGame();

            // Kiểm tra các thông tin ban đầu:
            // - Mã định danh (Id) phải rỗng, như khi bạn chưa gán số nhận diện cho sự kiện.
            Assert.That(soccerGame.Id, Is.EqualTo(Guid.Empty), "Mã định danh của sự kiện phải rỗng vì chưa gán.");
            // - Phút xảy ra (Minute) phải là 0, như khi bạn chưa ghi phút xảy ra sự kiện.
            Assert.That(soccerGame.Minute, Is.EqualTo(0), "Phút xảy ra phải là 0 vì chưa ghi phút.");
            // - Loại sự kiện (SoccerType) phải trống vì bạn chưa chọn loại sự kiện.
            Assert.That(soccerGame.SoccerType, Is.Null, "Loại sự kiện phải trống vì chưa chọn loại.");
            // - Mã người ghi bàn (GoalScorerId) phải rỗng vì chưa chọn cầu thủ ghi bàn.
            Assert.That(soccerGame.GoalScorerId, Is.EqualTo(Guid.Empty), "Mã người ghi bàn phải rỗng vì chưa chọn cầu thủ.");
            // - Thông tin người ghi bàn (GoalScorer) phải trống vì chưa chọn cầu thủ.
            Assert.That(soccerGame.GoalScorer, Is.Null, "Thông tin người ghi bàn phải trống vì chưa chọn cầu thủ.");
            // - Mã người kiến tạo (AssitantId) phải trống vì chưa chọn người kiến tạo.
            Assert.That(soccerGame.AssitantId, Is.Null, "Mã người kiến tạo phải trống vì chưa chọn người kiến tạo.");
            // - Thông tin người kiến tạo (Assitant) phải trống vì chưa chọn người kiến tạo.
            Assert.That(soccerGame.Assitant, Is.Null, "Thông tin người kiến tạo phải trống vì chưa chọn người kiến tạo.");
            // - Mã trận đấu (GameId) phải rỗng vì chưa liên kết với trận đấu nào.
            Assert.That(soccerGame.GameId, Is.EqualTo(Guid.Empty), "Mã trận đấu phải rỗng vì chưa chọn trận đấu.");
            // - Thông tin trận đấu (Game) phải trống vì chưa liên kết với trận đấu cụ thể.
            Assert.That(soccerGame.Game, Is.Null, "Thông tin trận đấu phải trống vì chưa chọn trận đấu.");
        }

        // Bài kiểm tra 2: Kiểm tra xem khi nhập thông tin cho sự kiện trận đấu, các giá trị có được lưu đúng không.
        [Test]
        public void SoccerGame_SetProperties_UpdatesCorrectly()
        {
            // Tạo một sự kiện trận đấu mới.
            var soccerGame = new SoccerGame();
            // Chuẩn bị một cầu thủ ghi bàn, cầu thủ kiến tạo và một trận đấu để liên kết.
            var goalScorer = new Player { Id = Guid.NewGuid(), Name = "John Doe" };
            var assitant = new Player { Id = Guid.NewGuid(), Name = "Jane Doe" };
            var game = new Game { Id = Guid.NewGuid(), RoundId = Guid.NewGuid() };

            // Nhập thông tin cho sự kiện:
            // - Gán mã định danh mới, như một số nhận diện riêng cho sự kiện.
            soccerGame.Id = Guid.NewGuid();
            // - Đặt phút xảy ra là phút 45, như khi bàn thắng xảy ra ở phút 45.
            soccerGame.Minute = 45;
            // - Đặt loại sự kiện là "Bàn thắng", như khi đây là một bàn thắng.
            soccerGame.SoccerType = "Goal";
            // - Gán mã người ghi bàn và thông tin người ghi bàn.
            soccerGame.GoalScorerId = goalScorer.Id;
            soccerGame.GoalScorer = goalScorer;
            // - Gán mã người kiến tạo và thông tin người kiến tạo.
            soccerGame.AssitantId = assitant.Id;
            soccerGame.Assitant = assitant;
            // - Gán mã trận đấu và thông tin trận đấu.
            soccerGame.GameId = game.Id;
            soccerGame.Game = game;

            // Kiểm tra xem các thông tin đã được lưu đúng chưa:
            // - Mã định danh phải là một giá trị mới, không rỗng.
            Assert.That(soccerGame.Id, Is.Not.EqualTo(Guid.Empty), "Mã định danh phải có giá trị mới.");
            // - Phút xảy ra phải là phút 45.
            Assert.That(soccerGame.Minute, Is.EqualTo(45), "Phút xảy ra phải là phút 45 như đã ghi.");
            // - Loại sự kiện phải là "Bàn thắng".
            Assert.That(soccerGame.SoccerType, Is.EqualTo("Goal"), "Loại sự kiện phải là 'Bàn thắng'.");
            // - Mã người ghi bàn phải khớp với mã của cầu thủ đã chọn.
            Assert.That(soccerGame.GoalScorerId, Is.EqualTo(goalScorer.Id), "Mã người ghi bàn phải khớp với cầu thủ đã chọn.");
            // - Thông tin người ghi bàn phải khớp với cầu thủ "John Doe".
            Assert.That(soccerGame.GoalScorer, Is.EqualTo(goalScorer), "Thông tin người ghi bàn phải khớp với cầu thủ đã chọn.");
            // - Mã người kiến tạo phải khớp với mã của cầu thủ kiến tạo đã chọn.
            Assert.That(soccerGame.AssitantId, Is.EqualTo(assitant.Id), "Mã người kiến tạo phải khớp với cầu thủ kiến tạo đã chọn.");
            // - Thông tin người kiến tạo phải khớp với cầu thủ "Jane Doe".
            Assert.That(soccerGame.Assitant, Is.EqualTo(assitant), "Thông tin người kiến tạo phải khớp với cầu thủ kiến tạo đã chọn.");
            // - Mã trận đấu phải khớp với mã của trận đấu đã chọn.
            Assert.That(soccerGame.GameId, Is.EqualTo(game.Id), "Mã trận đấu phải khớp với trận đấu đã chọn.");
            // - Thông tin trận đấu phải khớp với trận đấu đã chọn.
            Assert.That(soccerGame.Game, Is.EqualTo(game), "Thông tin trận đấu phải khớp với trận đấu đã chọn.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể đặt loại sự kiện là chuỗi rỗng không.
        [Test]
        public void SoccerGame_SetEmptySoccerType_SetsCorrectly()
        {
            // Tạo một sự kiện trận đấu mới.
            var soccerGame = new SoccerGame();
            // Đặt loại sự kiện là chuỗi rỗng, như khi bạn chưa chọn loại sự kiện.
            soccerGame.SoccerType = "";
            // Kiểm tra xem loại sự kiện đã được lưu là chuỗi rỗng chưa.
            Assert.That(soccerGame.SoccerType, Is.Empty, "Loại sự kiện phải là chuỗi rỗng khi không chọn loại.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể bỏ liên kết với cầu thủ ghi bàn (đặt thành trống) không.
        [Test]
        public void SoccerGame_SetNullGoalScorer_SetsCorrectly()
        {
            // Tạo một sự kiện trận đấu mới.
            var soccerGame = new SoccerGame();
            // Bỏ liên kết với cầu thủ ghi bàn, như khi sự kiện không có người ghi bàn.
            soccerGame.GoalScorerId = Guid.Empty;
            soccerGame.GoalScorer = null;
            // Kiểm tra xem mã cầu thủ và thông tin cầu thủ đã trống chưa.
            Assert.That(soccerGame.GoalScorerId, Is.EqualTo(Guid.Empty), "Mã người ghi bàn phải rỗng khi không chọn cầu thủ.");
            Assert.That(soccerGame.GoalScorer, Is.Null, "Thông tin người ghi bàn phải trống khi không chọn cầu thủ.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể bỏ liên kết với trận đấu (đặt thành trống) không.
        [Test]
        public void SoccerGame_SetNullGame_SetsCorrectly()
        {
            // Tạo một sự kiện trận đấu mới.
            var soccerGame = new SoccerGame();
            // Bỏ liên kết với trận đấu, như khi sự kiện chưa thuộc trận nào.
            soccerGame.GameId = Guid.Empty;
            soccerGame.Game = null;
            // Kiểm tra xem mã trận đấu và thông tin trận đấu đã trống chưa.
            Assert.That(soccerGame.GameId, Is.EqualTo(Guid.Empty), "Mã trận đấu phải rỗng khi không chọn trận đấu.");
            Assert.That(soccerGame.Game, Is.Null, "Thông tin trận đấu phải trống khi không chọn trận đấu.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể đặt người kiến tạo là null không.
        [Test]
        public void SoccerGame_SetNullAssitant_SetsCorrectly()
        {
            // Tạo một sự kiện trận đấu mới.
            var soccerGame = new SoccerGame();
            // Bỏ liên kết với người kiến tạo, như khi bàn thắng không có người kiến tạo.
            soccerGame.AssitantId = null;
            soccerGame.Assitant = null;
            // Kiểm tra xem mã người kiến tạo và thông tin người kiến tạo đã trống chưa.
            Assert.That(soccerGame.AssitantId, Is.Null, "Mã người kiến tạo phải trống khi không chọn người kiến tạo.");
            Assert.That(soccerGame.Assitant, Is.Null, "Thông tin người kiến tạo phải trống khi không chọn người kiến tạo.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể đặt phút xảy ra là một giá trị âm không.
        [Test]
        public void SoccerGame_SetNegativeMinute_SetsCorrectly()
        {
            // Tạo một sự kiện trận đấu mới.
            var soccerGame = new SoccerGame();
            // Đặt phút xảy ra là -10 phút, như khi bạn ghi sai thời gian (giả định).
            soccerGame.Minute = -10;
            // Kiểm tra xem phút xảy ra đã được lưu đúng chưa.
            Assert.That(soccerGame.Minute, Is.EqualTo(-10), "Phút xảy ra phải là -10 phút như đã ghi.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể đặt loại sự kiện với ký tự đặc biệt (như @#$%) không.
        [Test]
        public void SoccerGame_SetSoccerTypeWithSpecialCharacters_SetsCorrectly()
        {
            // Tạo một sự kiện trận đấu mới.
            var soccerGame = new SoccerGame();
            // Đặt loại sự kiện với ký tự đặc biệt, như khi bạn dùng ký hiệu để mô tả sự kiện.
            soccerGame.SoccerType = "Goal@#$%";
            // Kiểm tra xem loại sự kiện đã được lưu đúng chưa.
            Assert.That(soccerGame.SoccerType, Is.EqualTo("Goal@#$%"), "Loại sự kiện phải được lưu đúng với ký tự đặc biệt.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể liên kết với cầu thủ ghi bàn không có tên không.
        [Test]
        public void SoccerGame_SetGoalScorerWithNullName_SetsCorrectly()
        {
            // Tạo một sự kiện trận đấu mới.
            var soccerGame = new SoccerGame();
            // Tạo một cầu thủ nhưng không có tên, như khi thông tin cầu thủ chưa đầy đủ.
            var player = new Player { Id = Guid.NewGuid(), Name = null };
            // Liên kết sự kiện với cầu thủ này.
            soccerGame.GoalScorer = player;
            soccerGame.GoalScorerId = player.Id;
            // Kiểm tra xem cầu thủ đã được liên kết đúng chưa, dù không có tên.
            Assert.That(soccerGame.GoalScorer, Is.EqualTo(player), "Sự kiện phải liên kết được với cầu thủ dù cầu thủ không có tên.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể liên kết với trận đấu không có vòng đấu không.
        [Test]
        public void SoccerGame_SetGameWithNullRound_SetsCorrectly()
        {
            // Tạo một sự kiện trận đấu mới.
            var soccerGame = new SoccerGame();
            // Tạo một trận đấu nhưng không có vòng đấu, như khi thông tin trận chưa đầy đủ.
            var game = new Game { Id = Guid.NewGuid(), Round = null };
            // Liên kết sự kiện với trận đấu này.
            soccerGame.Game = game;
            soccerGame.GameId = game.Id;
            // Kiểm tra xem trận đấu đã được liên kết đúng chưa, dù không có vòng đấu.
            Assert.That(soccerGame.Game, Is.EqualTo(game), "Sự kiện phải liên kết được với trận đấu dù trận không có vòng đấu.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể đặt mã định danh thành một giá trị rỗng không.
        [Test]
        public void SoccerGame_SetEmptyId_SetsCorrectly()
        {
            // Tạo một sự kiện trận đấu mới.
            var soccerGame = new SoccerGame();
            // Đặt mã định danh là rỗng, như khi bạn chưa gán số nhận diện.
            soccerGame.Id = Guid.Empty;
            // Kiểm tra xem mã định danh đã được lưu là rỗng chưa.
            Assert.That(soccerGame.Id, Is.EqualTo(Guid.Empty), "Mã định danh phải rỗng khi không gân.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể đặt phút xảy ra là một giá trị rất lớn (như 120 phút) không.
        [Test]
        public void SoccerGame_SetLargeMinute_SetsCorrectly()
        {
            // Tạo một sự kiện trận đấu mới.
            var soccerGame = new SoccerGame();
            // Đặt phút xảy ra là 120 phút, như khi sự kiện xảy ra ở hiệp phụ.
            soccerGame.Minute = 120;
            // Kiểm tra xem phút xảy ra đã được lưu đúng chưa.
            Assert.That(soccerGame.Minute, Is.EqualTo(120), "Phút xảy ra phải là 120 phút như đã ghi.");
        }
    }
}