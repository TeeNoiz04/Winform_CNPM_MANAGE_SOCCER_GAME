using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin về trọng tài của trận đấu được thiết lập đúng.
    [TestFixture]
    public class MatchOfficialsTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo thông tin trọng tài mới, các giá trị có được đặt về mặc định đúng không.
        [Test]
        public void MatchOfficials_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo thông tin trọng tài mới, như khi bạn bắt đầu chọn trọng tài cho một trận đấu.
            var matchOfficials = new MatchOfficials();

            // Kiểm tra các thông tin ban đầu:
            // - Mã trận đấu (IdGame) phải rỗng vì chưa liên kết với trận đấu nào.
            Assert.That(matchOfficials.IdGame, Is.EqualTo(Guid.Empty), "Mã trận đấu phải rỗng khi chưa liên kết.");
            // - Thông tin trận đấu (Game) phải trống vì chưa chọn trận đấu.
            Assert.That(matchOfficials.Game, Is.Null, "Thông tin trận đấu phải trống khi chưa chọn.");
            // - Mã trọng tài (IdReferee) phải rỗng vì chưa chọn trọng tài nào.
            Assert.That(matchOfficials.IdReferee, Is.EqualTo(Guid.Empty), "Mã trọng tài phải rỗng khi chưa chọn.");
            // - Thông tin trọng tài (Referee) phải trống vì chưa có trọng tài.
            Assert.That(matchOfficials.Referee, Is.Null, "Thông tin trọng tài phải trống khi chưa có.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể liên kết với trận đấu không có tên vòng đấu không.
        [Test]
        public void MatchOfficials_SetGameWithNullRound_SetsCorrectly()
        {
            // Tạo thông tin trọng tài mới.
            var matchOfficials = new MatchOfficials();
            // Tạo một trận đấu nhưng không có tên vòng đấu.
            var game = new Game { Id = Guid.NewGuid(), Round = null };
            // Liên kết thông tin trọng tài với trận đấu này.
            matchOfficials.Game = game;
            // Kiểm tra xem trận đấu đã được liên kết đúng chưa.
            Assert.That(matchOfficials.Game, Is.EqualTo(game), "Trận đấu phải được liên kết dù không có tên vòng đấu.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể liên kết với trọng tài không có tên không.
        [Test]
        public void MatchOfficials_SetRefereeWithEmptyName_SetsCorrectly()
        {
            // Tạo thông tin trọng tài mới.
            var matchOfficials = new MatchOfficials();
            // Tạo một trọng tài với tên rỗng.
            var referee = new Referee { Id = Guid.NewGuid(), Name = "" };
            // Liên kết thông tin trọng tài với trọng tài này.
            matchOfficials.Referee = referee;
            // Kiểm tra xem trọng tài đã được liên kết đúng chưa.
            Assert.That(matchOfficials.Referee, Is.EqualTo(referee), "Trọng tài phải được liên kết dù tên rỗng.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể đặt mã trận đấu thành rỗng không.
        [Test]
        public void MatchOfficials_SetIdGameToEmpty_SetsCorrectly()
        {
            // Tạo thông tin trọng tài mới.
            var matchOfficials = new MatchOfficials();
            // Đặt mã trận đấu là rỗng.
            matchOfficials.IdGame = Guid.Empty;
            // Kiểm tra xem mã trận đấu đã rỗng chưa.
            Assert.That(matchOfficials.IdGame, Is.EqualTo(Guid.Empty), "Mã trận đấu phải rỗng khi gán.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể đặt mã trọng tài thành rỗng không.
        [Test]
        public void MatchOfficials_SetIdRefereeToEmpty_SetsCorrectly()
        {
            // Tạo thông tin trọng tài mới.
            var matchOfficials = new MatchOfficials();
            // Đặt mã trọng tài là rỗng.
            matchOfficials.IdReferee = Guid.Empty;
            // Kiểm tra xem mã trọng tài đã rỗng chưa.
            Assert.That(matchOfficials.IdReferee, Is.EqualTo(Guid.Empty), "Mã trọng tài phải rỗng khi gán.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể bỏ liên kết với trận đấu (đặt thành trống) không.
        [Test]
        public void MatchOfficials_SetNullGame_SetsCorrectly()
        {
            // Tạo thông tin trọng tài mới.
            var matchOfficials = new MatchOfficials();
            // Bỏ liên kết với trận đấu (đặt thành trống).
            matchOfficials.Game = null;
            // Kiểm tra xem thông tin trận đấu đã trống chưa.
            Assert.That(matchOfficials.Game, Is.Null, "Thông tin trận đấu phải trống khi bỏ liên kết.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể bỏ liên kết với trọng tài (đặt thành trống) không.
        [Test]
        public void MatchOfficials_SetNullReferee_SetsCorrectly()
        {
            // Tạo thông tin trọng tài mới.
            var matchOfficials = new MatchOfficials();
            // Bỏ liên kết với trọng tài (đặt thành trống).
            matchOfficials.Referee = null;
            // Kiểm tra xem thông tin trọng tài đã trống chưa.
            Assert.That(matchOfficials.Referee, Is.Null, "Thông tin trọng tài phải trống khi bỏ liên kết.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể liên kết với trận đấu đã bị xóa không.
        [Test]
        public void MatchOfficials_SetGameWithDeletedFlag_SetsCorrectly()
        {
            // Tạo thông tin trọng tài mới.
            var matchOfficials = new MatchOfficials();
            // Tạo một trận đấu đã bị đánh dấu xóa.
            var game = new Game { Id = Guid.NewGuid(), IsDeleted = true };
            // Liên kết thông tin trọng tài với trận đấu này.
            matchOfficials.Game = game;
            // Kiểm tra xem trận đấu đã được liên kết đúng chưa.
            Assert.That(matchOfficials.Game, Is.EqualTo(game), "Trận đấu phải được liên kết dù đã bị xóa.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể liên kết với trọng tài không có mã định danh không.
        [Test]
        public void MatchOfficials_SetRefereeWithNullId_SetsCorrectly()
        {
            // Tạo thông tin trọng tài mới.
            var matchOfficials = new MatchOfficials();
            // Tạo một trọng tài với mã định danh rỗng.
            var referee = new Referee { Id = Guid.Empty };
            // Liên kết thông tin trọng tài với trọng tài này.
            matchOfficials.Referee = referee;
            // Kiểm tra xem trọng tài đã được liên kết đúng chưa.
            Assert.That(matchOfficials.Referee, Is.EqualTo(referee), "Trọng tài phải được liên kết dù không có mã định danh.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể gán mã trận đấu mà không liên kết với trận đấu không.
        [Test]
        public void MatchOfficials_SetIdGameWithNullGame_SetsCorrectly()
        {
            // Tạo thông tin trọng tài mới.
            var matchOfficials = new MatchOfficials();
            // Gán một mã trận đấu mới.
            matchOfficials.IdGame = Guid.NewGuid();
            // Đặt thông tin trận đấu là trống.
            matchOfficials.Game = null;
            // Kiểm tra xem mã trận đấu có giá trị và thông tin trận đấu trống như mong đợi không.
            Assert.That(matchOfficials.IdGame, Is.Not.EqualTo(Guid.Empty), "Mã trận đấu phải có giá trị mới.");
            Assert.That(matchOfficials.Game, Is.Null, "Thông tin trận đấu phải trống.");
        }
    }
}