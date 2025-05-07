using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;
using System.Collections.Generic;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin của một trận đấu (Game) được thiết lập đúng.
    [TestFixture]
    public class GameTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo một trận đấu mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void Game_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một trận đấu mới, giống như khi bạn bắt đầu nhập thông tin cho một trận bóng đá.
            var game = new Game();

            // Kiểm tra xem các thông tin được đặt đúng giá trị ban đầu chưa:
            // - Mã định danh (Id) phải là một giá trị rỗng vì chưa có trận đấu cụ thể nào.
            Assert.That(game.Id, Is.EqualTo(Guid.Empty), "Mã định danh của trận đấu phải rỗng khi chưa gán.");
            // - Trạng thái xóa (IsDeleted) phải là "chưa xóa" vì trận đấu mới tạo không bị xóa.
            Assert.That(game.IsDeleted, Is.False, "Trạng thái xóa phải là chưa xóa.");
            // - Ngày bắt đầu (DateStart) phải là giá trị mặc định vì chưa chọn ngày.
            Assert.That(game.DateStart, Is.EqualTo(DateTime.MinValue), "Ngày bắt đầu phải là giá trị mặc định vì chưa chọn.");
            // - Giờ bắt đầu (TimeStart) phải là 0 vì chưa chọn giờ.
            Assert.That(game.TimeStart, Is.EqualTo(TimeSpan.Zero), "Giờ bắt đầu phải là 0 vì chưa chọn.");
            // - Mã đội nhà (HomeTeamId) phải rỗng vì chưa chọn đội nhà.
            Assert.That(game.HomeTeamId, Is.EqualTo(Guid.Empty), "Mã đội nhà phải rỗng vì chưa chọn đội.");
            // - Đội nhà (HomeTeam) phải trống vì chưa chọn đội nhà.
            Assert.That(game.HomeTeam, Is.Null, "Đội nhà phải trống vì chưa chọn đội.");
            // - Mã đội khách (AwayTeamId) phải rỗng vì chưa chọn đội khách.
            Assert.That(game.AwayTeamId, Is.EqualTo(Guid.Empty), "Mã đội khách phải rỗng vì chưa chọn đội.");
            // - Đội khách (AwayTeam) phải trống vì chưa chọn đội khách.
            Assert.That(game.AwayTeam, Is.Null, "Đội khách phải trống vì chưa chọn đội.");
            // - Mã vòng đấu (RoundId) phải rỗng vì chưa chọn vòng đấu.
            Assert.That(game.RoundId, Is.EqualTo(Guid.Empty), "Mã vòng đấu phải rỗng vì chưa chọn vòng.");
            // - Vòng đấu (Round) phải trống vì chưa chọn vòng đấu.
            Assert.That(game.Round, Is.Null, "Vòng đấu phải trống vì chưa chọn vòng.");
            // - Tỷ số đội nhà (HomeScore) phải là 0 vì chưa có bàn thắng.
            Assert.That(game.HomeScore, Is.EqualTo(0), "Tỷ số đội nhà phải là 0 khi chưa có bàn thắng.");
            // - Tỷ số đội khách (AwayScore) phải là 0 vì chưa có bàn thắng.
            Assert.That(game.AwayScore, Is.EqualTo(0), "Tỷ số đội khách phải là 0 khi chưa có bàn thắng.");
            // - Trạng thái trận đấu (Status) phải là false vì trận đấu chưa diễn ra.
            Assert.That(game.Status, Is.False, "Trạng thái trận đấu phải là chưa diễn ra.");
            // - Phiên bản dòng (RowVersion) phải trống vì chưa có dữ liệu cần theo dõi.
            Assert.That(game.RowVersion, Is.Null, "Phiên bản dòng phải trống vì chưa cần theo dõi.");
            // - Danh sách đội hình (MatchdaySquads) phải trống vì chưa thêm cầu thủ nào.
            Assert.That(game.MatchdaySquads, Is.Null, "Danh sách đội hình phải trống vì chưa có cầu thủ.");
            // - Danh sách trọng tài (MatchOfficials) phải trống vì chưa chọn trọng tài.
            Assert.That(game.MatchOfficials, Is.Null, "Danh sách trọng tài phải trống vì chưa chọn.");
            // - Danh sách thẻ phạt (PenaltyCards) phải trống vì chưa có thẻ nào.
            Assert.That(game.PenaltyCards, Is.Null, "Danh sách thẻ phạt phải trống vì chưa có thẻ.");
            // - Danh sách sự kiện trận đấu (SoccerGames) phải trống vì chưa có thông tin sự kiện.
            Assert.That(game.SoccerGames, Is.Null, "Danh sách sự kiện trận đấu phải trống vì chưa có thông tin.");
        }

        // Bài kiểm tra 2: Kiểm tra xem khi nhập đầy đủ thông tin cho trận đấu, các giá trị có được cập nhật đúng không.
        [Test]
        public void Game_SetProperties_UpdatesCorrectly()
        {
            // Tạo một trận đấu mới để nhập thông tin.
            var game = new Game();
            // Chuẩn bị các thông tin liên quan, như đội hình, trọng tài, thẻ phạt, và sự kiện trận đấu.
            var homeTeam = new Team { Id = Guid.NewGuid(), Name = "Home Team" };
            var awayTeam = new Team { Id = Guid.NewGuid(), Name = "Away Team" };
            var round = new Round { Id = Guid.NewGuid() };
            var matchdaySquad = new MatchdaySquad { IdGame = game.Id, Game = game };
            var matchdaySquads = new List<MatchdaySquad> { matchdaySquad };
            var matchOfficial = new MatchOfficials { IdGame = game.Id, Game = game };
            var matchOfficials = new List<MatchOfficials> { matchOfficial };
            var penaltyCard = new PenaltyCard { GameId = game.Id, Game = game };
            var penaltyCards = new List<PenaltyCard> { penaltyCard };
            var soccerGame = new SoccerGame { GameId = game.Id, Game = game };
            var soccerGames = new List<SoccerGame> { soccerGame };

            // Nhập thông tin cho trận đấu:
            // - Gán mã định danh mới (như số nhận diện cho trận đấu).
            game.Id = Guid.NewGuid();
            // - Đánh dấu trận đấu đã bị xóa (giả sử cần xóa).
            game.IsDeleted = true;
            // - Đặt ngày thi đấu là ngày 1/1/2025.
            game.DateStart = new DateTime(2025, 1, 1);
            // - Đặt giờ bắt đầu là 3 giờ chiều (15:00).
            game.TimeStart = TimeSpan.FromHours(15);
            // - Gán đội nhà và mã đội nhà.
            game.HomeTeamId = homeTeam.Id;
            game.HomeTeam = homeTeam;
            // - Gán đội khách và mã đội khách.
            game.AwayTeamId = awayTeam.Id;
            game.AwayTeam = awayTeam;
            // - Gán vòng đấu và mã vòng đấu.
            game.RoundId = round.Id;
            game.Round = round;
            // - Đặt tỷ số đội nhà là 2.
            game.HomeScore = 2;
            // - Đặt tỷ số đội khách là 1.
            game.AwayScore = 1;
            // - Đặt trạng thái trận đấu là đã hoàn thành.
            game.Status = true;
            // - Gán danh sách đội hình, trọng tài, thẻ phạt, và sự kiện trận đấu.
            game.MatchdaySquads = matchdaySquads;
            game.MatchOfficials = matchOfficials;
            game.PenaltyCards = penaltyCards;
            game.SoccerGames = soccerGames;

            // Kiểm tra xem các thông tin đã được cập nhật đúng chưa:
            // - Mã định danh phải khác giá trị rỗng vì đã gán mã mới.
            Assert.That(game.Id, Is.Not.EqualTo(Guid.Empty), "Mã định danh phải có giá trị mới.");
            // - Trạng thái xóa phải là "đã xóa".
            Assert.That(game.IsDeleted, Is.True, "Trạng thái xóa phải là đã xóa.");
            // - Ngày thi đấu phải là 1/1/2025.
            Assert.That(game.DateStart, Is.EqualTo(new DateTime(2025, 1, 1)), "Ngày thi đấu phải là 1/1/2025.");
            // - Giờ bắt đầu phải là 15:00.
            Assert.That(game.TimeStart, Is.EqualTo(TimeSpan.FromHours(15)), "Giờ bắt đầu phải là 15:00.");
            // - Mã đội nhà phải khớp với đội nhà đã chọn.
            Assert.That(game.HomeTeamId, Is.EqualTo(homeTeam.Id), "Mã đội nhà phải khớp với đội nhà đã chọn.");
            // - Đội nhà phải khớp với đội nhà đã chọn.
            Assert.That(game.HomeTeam, Is.EqualTo(homeTeam), "Đội nhà phải khớp với đội nhà đã chọn.");
            // - Mã đội khách phải khớp với đội khách đã chọn.
            Assert.That(game.AwayTeamId, Is.EqualTo(awayTeam.Id), "Mã đội khách phải khớp với đội khách đã chọn.");
            // - Đội khách phải khớp với đội khách đã chọn.
            Assert.That(game.AwayTeam, Is.EqualTo(awayTeam), "Đội khách phải khớp với đội khách đã chọn.");
            // - Mã vòng đấu phải khớp với vòng đấu đã chọn.
            Assert.That(game.RoundId, Is.EqualTo(round.Id), "Mã vòng đấu phải khớp với vòng đấu đã chọn.");
            // - Vòng đấu phải khớp với vòng đấu đã chọn.
            Assert.That(game.Round, Is.EqualTo(round), "Vòng đấu phải khớp với vòng đấu đã chọn.");
            // - Tỷ số đội nhà phải là 2.
            Assert.That(game.HomeScore, Is.EqualTo(2), "Tỷ số đội nhà phải là 2 như đã gán.");
            // - Tỷ số đội khách phải là 1.
            Assert.That(game.AwayScore, Is.EqualTo(1), "Tỷ số đội khách phải là 1 như đã gán.");
            // - Trạng thái trận đấu phải là đã hoàn thành.
            Assert.That(game.Status, Is.True, "Trạng thái trận đấu phải là đã hoàn thành.");
            // - Danh sách đội hình phải có 1 mục.
            Assert.That(game.MatchdaySquads, Has.Count.EqualTo(1), "Danh sách đội hình phải có 1 cầu thủ.");
            // - Danh sách trọng tài phải có 1 mục.
            Assert.That(game.MatchOfficials, Has.Count.EqualTo(1), "Danh sách trọng tài phải có 1 người.");
            // - Danh sách thẻ phạt phải có 1 mục.
            Assert.That(game.PenaltyCards, Has.Count.EqualTo(1), "Danh sách thẻ phạt phải có 1 thẻ.");
            // - Danh sách sự kiện trận đấu phải có 1 mục.
            Assert.That(game.SoccerGames, Has.Count.EqualTo(1), "Danh sách sự kiện trận đấu phải có 1 sự kiện.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể đặt mã vòng đấu thành một giá trị cụ thể không.
        [Test]
        public void Game_SetRoundId_SetsCorrectly()
        {
            // Tạo một trận đấu mới.
            var game = new Game();
            // Tạo một mã vòng đấu mới.
            var roundId = Guid.NewGuid();
            // Gán mã vòng đấu này.
            game.RoundId = roundId;
            // Kiểm tra xem mã vòng đấu đã được lưu đúng chưa.
            Assert.That(game.RoundId, Is.EqualTo(roundId), "Mã vòng đấu phải được lưu đúng.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể đặt ngày thi đấu trong quá khứ (như 1/1/2020) không.
        [Test]
        public void Game_SetPastDateStart_SetsCorrectly()
        {
            // Tạo một trận đấu mới.
            var game = new Game();
            // Chọn một ngày trong quá khứ: 1/1/2020.
            var pastDate = new DateTime(2020, 1, 1);
            // Gán ngày này cho trận đấu.
            game.DateStart = pastDate;
            // Kiểm tra xem ngày đã được lưu đúng chưa.
            Assert.That(game.DateStart, Is.EqualTo(pastDate), "Ngày thi đấu phải được lưu là 1/1/2020.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể đặt giờ bắt đầu là 0 (không giờ cụ thể) không.
        [Test]
        public void Game_SetZeroTimeStart_SetsCorrectly()
        {
            // Tạo một trận đấu mới.
            var game = new Game();
            // Gán giờ bắt đầu là 0.
            game.TimeStart = TimeSpan.Zero;
            // Kiểm tra xem giờ bắt đầu đã được lưu đúng chưa.
            Assert.That(game.TimeStart, Is.EqualTo(TimeSpan.Zero), "Giờ bắt đầu phải là 0 khi gán.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể thêm một danh sách đội hình rỗng (không có cầu thủ) không.
        [Test]
        public void Game_AddEmptyMatchdaySquads_SetsCorrectly()
        {
            // Tạo một trận đấu mới.
            var game = new Game();
            // Gán danh sách đội hình là một danh sách rỗng (chưa có cầu thủ).
            game.MatchdaySquads = new List<MatchdaySquad>();
            // Kiểm tra xem danh sách đội hình có rỗng như mong đợi không.
            Assert.That(game.MatchdaySquads, Is.Empty, "Danh sách đội hình phải rỗng khi không thêm cầu thủ.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể đặt danh sách sự kiện trận đấu thành trống không.
        [Test]
        public void Game_SetNullSoccerGames_SetsCorrectly()
        {
            // Tạo một trận đấu mới.
            var game = new Game();
            // Gán danh sách sự kiện trận đấu là trống.
            game.SoccerGames = null;
            // Kiểm tra xem danh sách sự kiện trận đấu có trống như mong đợi không.
            Assert.That(game.SoccerGames, Is.Null, "Danh sách sự kiện trận đấu phải trống khi gán là trống.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể thay đổi trạng thái xóa nhiều lần (xóa rồi khôi phục) không.
        [Test]
        public void Game_ToggleIsDeletedMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một trận đấu mới.
            var game = new Game();
            // Đánh dấu trận đấu là đã xóa.
            game.IsDeleted = true;
            // Sau đó khôi phục lại trạng thái chưa xóa.
            game.IsDeleted = false;
            // Kiểm tra xem trạng thái cuối cùng là chưa xóa.
            Assert.That(game.IsDeleted, Is.False, "Trạng thái xóa phải là chưa xóa sau khi khôi phục.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể thêm nhiều thẻ phạt (như 2 thẻ) không.
        [Test]
        public void Game_SetPenaltyCardsWithMultipleItems_UpdatesCount()
        {
            // Tạo một trận đấu mới.
            var game = new Game();
            // Tạo danh sách 2 thẻ phạt (giả lập 2 thẻ vàng).
            var penaltyCards = new List<PenaltyCard> { new PenaltyCard(), new PenaltyCard() };
            // Gán danh sách này cho trận đấu.
            game.PenaltyCards = penaltyCards;
            // Kiểm tra xem có đúng 2 thẻ phạt được lưu không.
            Assert.That(game.PenaltyCards, Has.Count.EqualTo(2), "Phải có 2 thẻ phạt được lưu.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể thêm một trọng tài duy nhất không.
        [Test]
        public void Game_SetMatchOfficialsWithSingleItem_UpdatesCorrectly()
        {
            // Tạo một trận đấu mới.
            var game = new Game();
            // Tạo một trọng tài.
            var matchOfficial = new MatchOfficials();
            // Gán danh sách có một trọng tài này.
            game.MatchOfficials = new List<MatchOfficials> { matchOfficial };
            // Kiểm tra xem danh sách trọng tài có đúng 1 người không.
            Assert.That(game.MatchOfficials, Has.Count.EqualTo(1), "Danh sách trọng tài phải có 1 người.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể thêm đội nhà và đội khách không.
        [Test]
        public void Game_SetTeams_HandlesCorrectly()
        {
            // Tạo một trận đấu mới.
            var game = new Game();
            // Tạo đội nhà và đội khách.
            var homeTeam = new Team { Id = Guid.NewGuid(), Name = "Home Team" };
            var awayTeam = new Team { Id = Guid.NewGuid(), Name = "Away Team" };
            // Gán đội nhà và đội khách.
            game.HomeTeamId = homeTeam.Id;
            game.HomeTeam = homeTeam;
            game.AwayTeamId = awayTeam.Id;
            game.AwayTeam = awayTeam;
            // Kiểm tra xem đội nhà và đội khách đã được gán đúng chưa.
            Assert.That(game.HomeTeamId, Is.EqualTo(homeTeam.Id), "Mã đội nhà phải khớp với đội nhà đã chọn.");
            Assert.That(game.AwayTeamId, Is.EqualTo(awayTeam.Id), "Mã đội khách phải khớp với đội khách đã chọn.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể đặt phiên bản dòng (RowVersion) không.
        [Test]
        public void Game_SetRowVersion_SetsCorrectly()
        {
            // Tạo một trận đấu mới.
            var game = new Game();
            // Tạo một chuỗi số (byte array) để làm phiên bản dòng, như một dấu thời gian để theo dõi thay đổi.
            var rowVersion = new byte[] { 1, 2, 3 };
            // Gán chuỗi số này cho trận đấu.
            game.RowVersion = rowVersion;
            // Kiểm tra xem chuỗi số đã được lưu đúng chưa.
            Assert.That(game.RowVersion, Is.EqualTo(rowVersion), "Phiên bản dòng phải được lưu đúng.");
        }
    }
}