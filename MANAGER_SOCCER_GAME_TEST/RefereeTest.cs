using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;
using System.Collections.Generic;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin về trọng tài (như tên, kinh nghiệm) được thiết lập đúng.
    [TestFixture]
    public class RefereeTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo một trọng tài mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void Referee_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một trọng tài mới, như khi bạn bắt đầu nhập thông tin cho một trọng tài.
            var referee = new Referee();

            // Kiểm tra các thông tin ban đầu:
            // - Mã định danh (Id) phải rỗng, như khi bạn chưa gán số nhận diện cho trọng tài.
            Assert.That(referee.Id, Is.EqualTo(Guid.Empty), "Mã định danh của trọng tài phải rỗng vì chưa gán.");
            // - Tên (Name) phải trống vì bạn chưa nhập tên trọng tài.
            Assert.That(referee.Name, Is.Null, "Tên trọng tài phải trống vì chưa nhập tên.");
            // - Ngày sinh (DateOfBirth) phải là giá trị mặc định (rất xa trong quá khứ) vì chưa nhập.
            Assert.That(referee.DateOfBirth, Is.EqualTo(DateTime.MinValue), "Ngày sinh phải là giá trị mặc định vì chưa nhập.");
            // - Vị trí (Position) phải trống vì chưa chọn vị trí của trọng tài.
            Assert.That(referee.Position, Is.Null, "Vị trí phải trống vì chưa chọn vị trí.");
            // - Quốc tịch (National) phải trống vì chưa nhập quốc gia của trọng tài.
            Assert.That(referee.National, Is.Null, "Quốc tịch phải trống vì chưa nhập quốc gia.");
            // - Số năm kinh nghiệm (YearOfExperience) phải là 0 vì chưa nhập kinh nghiệm.
            Assert.That(referee.YearOfExperience, Is.EqualTo(0), "Số năm kinh nghiệm phải là 0 vì chưa nhập.");
            // - Danh sách trận đấu làm nhiệm vụ (MatchOfficials) phải trống vì trọng tài chưa được phân công.
            Assert.That(referee.MatchOfficials, Is.Null, "Danh sách trận đấu làm nhiệm vụ phải trống vì chưa phân công.");
        }

        // Bài kiểm tra 2: Kiểm tra xem khi nhập thông tin cho trọng tài, các giá trị có được lưu đúng không.
        [Test]
        public void Referee_SetProperties_UpdatesCorrectly()
        {
            // Tạo một trọng tài mới.
            var referee = new Referee();
            // Chuẩn bị danh sách trận đấu làm nhiệm vụ để liên kết, như khi trọng tài được phân công làm việc.
            var matchOfficials = new List<MatchOfficials> { new MatchOfficials { IdGame = Guid.NewGuid(), IdReferee = Guid.NewGuid() } };

            // Nhập thông tin cho trọng tài:
            // - Gán mã định danh mới, như một số nhận diện riêng cho trọng tài.
            referee.Id = Guid.NewGuid();
            // - Đặt tên là "Jane Smith", như tên thật của trọng tài.
            referee.Name = "Jane Smith";
            // - Đặt ngày sinh là 1/1/1980, như ngày trọng tài được sinh ra.
            referee.DateOfBirth = new DateTime(1980, 1, 1);
            // - Đặt vị trí là "Trọng tài chính", như vai trò của trọng tài trong trận đấu.
            referee.Position = "Main Referee";
            // - Đặt quốc tịch là "USA", như quốc gia của trọng tài.
            referee.National = "USA";
            // - Đặt số năm kinh nghiệm là 10, như thời gian trọng tài đã làm việc.
            referee.YearOfExperience = 10;
            // - Gán danh sách trận đấu làm nhiệm vụ, như khi trọng tài được phân công.
            referee.MatchOfficials = matchOfficials;

            // Kiểm tra xem các thông tin đã được lưu đúng chưa:
            // - Mã định danh phải là một giá trị mới, không rỗng.
            Assert.That(referee.Id, Is.Not.EqualTo(Guid.Empty), "Mã định danh phải có giá trị mới.");
            // - Tên phải là "Jane Smith" như đã nhập.
            Assert.That(referee.Name, Is.EqualTo("Jane Smith"), "Tên trọng tài phải là 'Jane Smith'.");
            // - Ngày sinh phải là 1/1/1980.
            Assert.That(referee.DateOfBirth, Is.EqualTo(new DateTime(1980, 1, 1)), "Ngày sinh phải là 1/1/1980.");
            // - Vị trí phải là "Trọng tài chính".
            Assert.That(referee.Position, Is.EqualTo("Main Referee"), "Vị trí phải là 'Trọng tài chính'.");
            // - Quốc tịch phải là "USA".
            Assert.That(referee.National, Is.EqualTo("USA"), "Quốc tịch phải là 'USA'.");
            // - Số năm kinh nghiệm phải là 10.
            Assert.That(referee.YearOfExperience, Is.EqualTo(10), "Số năm kinh nghiệm phải là 10 như đã nhập.");
            // - Danh sách trận đấu làm nhiệm vụ phải có 1 mục, vì đã phân công một trận.
            Assert.That(referee.MatchOfficials, Has.Count.EqualTo(1), "Danh sách trận đấu làm nhiệm vụ phải có 1 mục sau khi phân công.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể đặt tên trọng tài là chuỗi rỗng không.
        [Test]
        public void Referee_SetEmptyName_SetsCorrectly()
        {
            // Tạo một trọng tài mới.
            var referee = new Referee();
            // Đặt tên trọng tài là chuỗi rỗng, như khi bạn chưa nhập tên.
            referee.Name = "";
            // Kiểm tra xem tên trọng tài đã được lưu là chuỗi rỗng chưa.
            Assert.That(referee.Name, Is.Empty, "Tên trọng tài phải là chuỗi rỗng khi không nhập tên.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể bỏ danh sách trận đấu làm nhiệm vụ (đặt thành trống) không.
        [Test]
        public void Referee_SetNullMatchOfficials_SetsCorrectly()
        {
            // Tạo một trọng tài mới.
            var referee = new Referee();
            // Bỏ danh sách trận đấu làm nhiệm vụ, như khi trọng tài chưa được phân công.
            referee.MatchOfficials = null;
            // Kiểm tra xem danh sách trận đấu làm nhiệm vụ đã trống chưa.
            Assert.That(referee.MatchOfficials, Is.Null, "Danh sách trận đấu làm nhiệm vụ phải trống khi không phân công.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể đặt số năm kinh nghiệm là một số lớn (như 30) không.
        [Test]
        public void Referee_SetLargeYearOfExperience_SetsCorrectly()
        {
            // Tạo một trọng tài mới.
            var referee = new Referee();
            // Đặt số năm kinh nghiệm là 30, như khi trọng tài có nhiều kinh nghiệm.
            referee.YearOfExperience = 30;
            // Kiểm tra xem số năm kinh nghiệm đã được lưu đúng chưa.
            Assert.That(referee.YearOfExperience, Is.EqualTo(30), "Số năm kinh nghiệm phải là 30 như đã nhập.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể đặt ngày sinh là một ngày trong tương lai (như năm sau) không.
        [Test]
        public void Referee_SetFutureDateOfBirth_SetsCorrectly()
        {
            // Tạo một trọng tài mới.
            var referee = new Referee();
            // Đặt ngày sinh là một ngày trong tương lai, như năm sau.
            var futureDate = DateTime.Now.AddYears(1);
            referee.DateOfBirth = futureDate;
            // Kiểm tra xem ngày sinh đã được lưu đúng chưa.
            Assert.That(referee.DateOfBirth, Is.EqualTo(futureDate), "Ngày sinh phải là ngày trong tương lai như đã chọn.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể đặt quốc tịch là chuỗi dài (như "United States of America") không.
        [Test]
        public void Referee_SetLongNational_SetsCorrectly()
        {
            // Tạo một trọng tài mới.
            var referee = new Referee();
            // Đặt quốc tịch là "United States of America", như khi bạn nhập tên quốc gia đầy đủ.
            referee.National = "United States of America";
            // Kiểm tra xem quốc tịch đã được lưu đúng chưa.
            Assert.That(referee.National, Is.EqualTo("United States of America"), "Quốc tịch phải là 'United States of America' như đã nhập.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể đặt vị trí với ký tự đặc biệt (như @#$%) không.
        [Test]
        public void Referee_SetPositionWithSpecialCharacters_SetsCorrectly()
        {
            // Tạo một trọng tài mới.
            var referee = new Referee();
            // Đặt vị trí với ký tự đặc biệt, như khi bạn dùng ký hiệu để mô tả vị trí.
            referee.Position = "Referee@#$%";
            // Kiểm tra xem vị trí đã được lưu đúng chưa.
            Assert.That(referee.Position, Is.EqualTo("Referee@#$%"), "Vị trí phải được lưu đúng với ký tự đặc biệt.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể thay đổi danh sách trận đấu làm nhiệm vụ nhiều lần không.
        [Test]
        public void Referee_UpdateMatchOfficialsMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một trọng tài mới.
            var referee = new Referee();
            // Gán danh sách trận đấu làm nhiệm vụ đầu tiên, như khi trọng tài được phân công cho một trận.
            var matchOfficials1 = new List<MatchOfficials> { new MatchOfficials { IdGame = Guid.NewGuid(), IdReferee = Guid.NewGuid() } };
            referee.MatchOfficials = matchOfficials1;
            // Thay đổi sang danh sách trận đấu làm nhiệm vụ mới, như khi trọng tài được phân công cho trận khác.
            var matchOfficials2 = new List<MatchOfficials> { new MatchOfficials { IdGame = Guid.NewGuid(), IdReferee = Guid.NewGuid() } };
            referee.MatchOfficials = matchOfficials2;
            // Kiểm tra xem danh sách trận đấu làm nhiệm vụ cuối cùng là danh sách mới không.
            Assert.That(referee.MatchOfficials, Is.EqualTo(matchOfficials2), "Danh sách trận đấu làm nhiệm vụ phải được cập nhật thành danh sách mới.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể đặt mã định danh thành một giá trị rỗng không.
        [Test]
        public void Referee_SetEmptyId_SetsCorrectly()
        {
            // Tạo một trọng tài mới.
            var referee = new Referee();
            // Đặt mã định danh là rỗng, như khi bạn chưa gán số nhận diện.
            referee.Id = Guid.Empty;
            // Kiểm tra xem mã định danh đã được lưu là rỗng chưa.
            Assert.That(referee.Id, Is.EqualTo(Guid.Empty), "Mã định danh phải rỗng khi không gán.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể đặt vị trí là chuỗi rỗng không.
        [Test]
        public void Referee_SetEmptyPosition_SetsCorrectly()
        {
            // Tạo một trọng tài mới.
            var referee = new Referee();
            // Đặt vị trí là chuỗi rỗng, như khi bạn chưa chọn vị trí.
            referee.Position = "";
            // Kiểm tra xem vị trí đã được lưu là chuỗi rỗng chưa.
            Assert.That(referee.Position, Is.Empty, "Vị trí phải là chuỗi rỗng khi không chọn vị trí.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể đặt số năm kinh nghiệm là số âm không.
        [Test]
        public void Referee_SetNegativeYearOfExperience_SetsCorrectly()
        {
            // Tạo một trọng tài mới.
            var referee = new Referee();
            // Đặt số năm kinh nghiệm là -5, như khi bạn nhập sai kinh nghiệm (giả định).
            referee.YearOfExperience = -5;
            // Kiểm tra xem số năm kinh nghiệm đã được lưu đúng chưa.
            Assert.That(referee.YearOfExperience, Is.EqualTo(-5), "Số năm kinh nghiệm phải là -5 như đã nhập.");
        }
    }
}