using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;
using System.Collections.Generic;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin về người dùng (như email, tên) được thiết lập đúng.
    [TestFixture]
    public class UserTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo một người dùng mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void User_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một người dùng mới, cần nhập email bắt buộc và UserName (do kế thừa từ IdentityUser), như khi bạn đăng ký tài khoản.
            var user = new User { Email = "john.doe@example.com", UserName = "john.doe" };

            // Kiểm tra các thông tin ban đầu:
            // - Mã định danh (Id) phải rỗng, như khi bạn chưa gán số nhận diện cho người dùng.
            Assert.That(user.Id, Is.EqualTo(Guid.Empty), "Mã định danh của người dùng phải rỗng vì chưa gán.");
            // - Tên (FirstName) phải trống vì bạn chưa nhập tên.
            Assert.That(user.FirstName, Is.Null, "Tên phải trống vì chưa nhập tên.");
            // - Họ (LastName) phải trống vì bạn chưa nhập họ.
            Assert.That(user.LastName, Is.Null, "Họ phải trống vì chưa nhập họ.");
            // - Ảnh đại diện (ProfilePicture) phải trống vì chưa chọn ảnh.
            Assert.That(user.ProfilePicture, Is.Null, "Ảnh đại diện phải trống vì chưa chọn ảnh.");
            // - Email phải là "john.doe@example.com" như đã nhập.
            Assert.That(user.Email, Is.EqualTo("john.doe@example.com"), "Email phải là giá trị đã nhập.");
            // - UserName phải là "john.doe" như đã nhập.
            Assert.That(user.UserName, Is.EqualTo("john.doe"), "Tên người dùng phải là giá trị đã nhập.");
            // - Trạng thái (Status) phải là "True", như mặc định tài khoản đang hoạt động.
            Assert.That(user.Status, Is.EqualTo("True"), "Trạng thái phải là 'True' như mặc định.");
            // - Xác nhận email (IsConfirmedEmail) phải là "không", vì tài khoản mới chưa xác nhận.
            Assert.That(user.IsConfirmedEmail, Is.False, "Xác nhận email phải là 'không' vì chưa xác nhận.");
            // - Thời gian tạo (CreatedAt) phải là thời gian hiện tại, như khi tài khoản vừa được tạo.
            Assert.That(user.CreatedAt, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Thời gian tạo phải là thời gian hiện tại.");
            // - Thời gian cập nhật (UpdatedAt) cũng phải là thời gian hiện tại.
            Assert.That(user.UpdatedAt, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Thời gian cập nhật phải là thời gian hiện tại.");
            // - Danh sách vai trò (UserRoles) phải trống vì người dùng chưa được gán vai trò.
            Assert.That(user.UserRoles, Is.Null, "Danh sách vai trò phải trống vì chưa gán.");
        }

        // Bài kiểm tra 2: Kiểm tra xem khi nhập thông tin cho người dùng, các giá trị có được lưu đúng không.
        [Test]
        public void User_SetProperties_UpdatesCorrectly()
        {
            // Tạo một người dùng mới.
            var user = new User { Email = "john.doe@example.com", UserName = "john.doe" };
            // Chuẩn bị một vai trò để liên kết, như khi bạn gán vai trò cho người dùng.
            var role = new Role { Id = Guid.NewGuid(), Name = "Admin" };
            var userRole = new UserRole
            {
                IdUser = Guid.NewGuid(),
                User = user,
                IdRole = role.Id,
                Role = role
            };
            var userRoles = new List<UserRole> { userRole };

            // Nhập thông tin cho người dùng:
            // - Gán mã định danh mới, như một số nhận diện riêng cho người dùng.
            user.Id = Guid.NewGuid();
            // - Đặt tên là "John", như tên thật của người dùng.
            user.FirstName = "John";
            // - Đặt họ là "Doe", như họ của người dùng.
            user.LastName = "Doe";
            // - Đặt ảnh đại diện là một đường dẫn, như khi bạn tải ảnh lên.
            user.ProfilePicture = "http://example.com/profile.jpg";
            // - Đặt trạng thái là "False", như khi tài khoản bị khóa.
            user.Status = "False";
            // - Đánh dấu email đã xác nhận, như khi người dùng đã xác minh email.
            user.IsConfirmedEmail = true;
            // - Đặt thời gian tạo là ngày hôm qua, như khi tài khoản được tạo trước đó.
            user.CreatedAt = DateTime.Now.AddDays(-1);
            // - Đặt thời gian cập nhật là hôm nay, như khi bạn vừa chỉnh sửa tài khoản.
            user.UpdatedAt = DateTime.Now;
            // - Gán danh sách vai trò, như khi người dùng được gán vai trò "Admin".
            user.UserRoles = userRoles;

            // Kiểm tra xem các thông tin đã được lưu đúng chưa:
            // - Mã định danh phải là một giá trị mới, không rỗng.
            Assert.That(user.Id, Is.Not.EqualTo(Guid.Empty), "Mã định danh phải có giá trị mới.");
            // - Tên phải là "John" như đã nhập.
            Assert.That(user.FirstName, Is.EqualTo("John"), "Tên phải là 'John'.");
            // - Họ phải là "Doe" như đã nhập.
            Assert.That(user.LastName, Is.EqualTo("Doe"), "Họ phải là 'Doe'.");
            // - Ảnh đại diện phải là đường dẫn đã nhập.
            Assert.That(user.ProfilePicture, Is.EqualTo("http://example.com/profile.jpg"), "Ảnh đại diện phải là đường dẫn đã nhập.");
            // - Trạng thái phải là "False".
            Assert.That(user.Status, Is.EqualTo("False"), "Trạng thái phải là 'False' như đã chọn.");
            // - Xác nhận email phải là "có".
            Assert.That(user.IsConfirmedEmail, Is.True, "Xác nhận email phải là 'có' như đã đánh dấu.");
            // - Thời gian tạo phải sớm hơn thời gian cập nhật.
            Assert.That(user.CreatedAt, Is.LessThan(user.UpdatedAt), "Thời gian tạo phải sớm hơn thời gian cập nhật.");
            // - Danh sách vai trò phải có 1 mục, vì đã gán một vai trò.
            Assert.That(user.UserRoles, Has.Count.EqualTo(1), "Danh sách vai trò phải có 1 mục sau khi gán.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể đặt email là một chuỗi khác không.
        [Test]
        public void User_SetDifferentEmail_SetsCorrectly()
        {
            // Tạo một người dùng mới.
            var user = new User { Email = "john.doe@example.com", UserName = "john.doe" };
            // Đặt email mới là "jane.smith@example.com", như khi bạn đổi email.
            user.Email = "jane.smith@example.com";
            // Kiểm tra xem email đã được lưu đúng chưa.
            Assert.That(user.Email, Is.EqualTo("jane.smith@example.com"), "Email phải là 'jane.smith@example.com' như đã đổi.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể đặt tên là chuỗi rỗng không.
        [Test]
        public void User_SetEmptyFirstName_SetsCorrectly()
        {
            // Tạo một người dùng mới.
            var user = new User { Email = "john.doe@example.com", UserName = "john.doe" };
            // Đặt tên là chuỗi rỗng, như khi bạn không nhập tên.
            user.FirstName = "";
            // Kiểm tra xem tên đã được lưu là chuỗi rỗng chưa.
            Assert.That(user.FirstName, Is.Empty, "Tên phải là chuỗi rỗng khi không nhập tên.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể đặt họ là chuỗi dài (như 100 ký tự) không.
        [Test]
        public void User_SetLongLastName_SetsCorrectly()
        {
            // Tạo một người dùng mới.
            var user = new User { Email = "john.doe@example.com", UserName = "john.doe" };
            // Đặt họ là một chuỗi dài, như khi bạn nhập họ chi tiết.
            var longLastName = new string('a', 100);
            user.LastName = longLastName;
            // Kiểm tra xem họ đã được lưu đúng chưa.
            Assert.That(user.LastName, Is.EqualTo(longLastName), "Họ phải được lưu đúng với chuỗi dài.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể bỏ danh sách vai trò (đặt thành trống) không.
        [Test]
        public void User_SetNullUserRoles_SetsCorrectly()
        {
            // Tạo một người dùng mới.
            var user = new User { Email = "john.doe@example.com", UserName = "john.doe" };
            // Bỏ danh sách vai trò, như khi người dùng chưa được gán vai trò.
            user.UserRoles = null;
            // Kiểm tra xem danh sách vai trò đã trống chưa.
            Assert.That(user.UserRoles, Is.Null, "Danh sách vai trò phải trống khi không gán.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể đặt trạng thái là "True" sau khi đã đặt là "False" không.
        [Test]
        public void User_ToggleStatus_SetsCorrectly()
        {
            // Tạo một người dùng mới.
            var user = new User { Email = "john.doe@example.com", UserName = "john.doe" };
            // Đặt trạng thái là "False", như khi tài khoản bị khóa.
            user.Status = "False";
            // Đổi lại thành "True", như khi bạn mở khóa tài khoản.
            user.Status = "True";
            // Kiểm tra xem trạng thái cuối cùng là "True" không.
            Assert.That(user.Status, Is.EqualTo("True"), "Trạng thái phải là 'True' sau khi mở khóa.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể đặt ảnh đại diện là một đường dẫn dài không.
        [Test]
        public void User_SetLongProfilePicture_SetsCorrectly()
        {
            // Tạo một người dùng mới.
            var user = new User { Email = "john.doe@example.com", UserName = "john.doe" };
            // Đặt ảnh đại diện là một đường dẫn dài, như khi ảnh được lưu trên máy chủ.
            var longUrl = "http://example.com/" + new string('a', 200) + ".jpg";
            user.ProfilePicture = longUrl;
            // Kiểm tra xem ảnh đại diện đã được lưu đúng chưa.
            Assert.That(user.ProfilePicture, Is.EqualTo(longUrl), "Ảnh đại diện phải được lưu đúng với đường dẫn dài.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể đặt thời gian tạo là một ngày trong quá khứ không.
        [Test]
        public void User_SetPastCreatedAt_SetsCorrectly()
        {
            // Tạo một người dùng mới.
            var user = new User { Email = "john.doe@example.com", UserName = "john.doe" };
            // Đặt thời gian tạo là ngày 1/1/2020, như khi tài khoản được tạo từ lâu.
            var pastDate = new DateTime(2020, 1, 1);
            user.CreatedAt = pastDate;
            // Kiểm tra xem thời gian tạo đã được lưu đúng chưa.
            Assert.That(user.CreatedAt, Is.EqualTo(pastDate), "Thời gian tạo phải là ngày 1/1/2020 như đã chọn.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể đặt xác nhận email là "không" sau khi đã đặt là "có" không.
        [Test]
        public void User_ToggleIsConfirmedEmail_SetsCorrectly()
        {
            // Tạo một người dùng mới.
            var user = new User { Email = "john.doe@example.com", UserName = "john.doe" };
            // Đặt xác nhận email là "có", như khi email đã được xác minh.
            user.IsConfirmedEmail = true;
            // Đổi lại thành "không", như khi bạn hủy xác nhận.
            user.IsConfirmedEmail = false;
            // Kiểm tra xem trạng thái xác nhận email cuối cùng là "không" không.
            Assert.That(user.IsConfirmedEmail, Is.False, "Xác nhận email phải là 'không' sau khi hủy xác nhận.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể thay đổi danh sách vai trò nhiều lần không.
        [Test]
        public void User_UpdateUserRolesMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một người dùng mới.
            var user = new User { Email = "john.doe@example.com", UserName = "john.doe" };
            // Gán danh sách vai trò đầu tiên, như khi người dùng được gán vai trò "Admin".
            var userRoles1 = new List<UserRole> { new UserRole { IdUser = Guid.NewGuid(), IdRole = Guid.NewGuid(), User = user, Role = new Role { Id = Guid.NewGuid(), Name = "Admin" } } };
            user.UserRoles = userRoles1;
            // Thay đổi sang danh sách vai trò mới, như khi người dùng được gán vai trò "User".
            var userRoles2 = new List<UserRole> { new UserRole { IdUser = Guid.NewGuid(), IdRole = Guid.NewGuid(), User = user, Role = new Role { Id = Guid.NewGuid(), Name = "User" } } };
            user.UserRoles = userRoles2;
            // Kiểm tra xem danh sách vai trò cuối cùng là danh sách mới không.
            Assert.That(user.UserRoles, Is.EqualTo(userRoles2), "Danh sách vai trò phải được cập nhật thành danh sách mới.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể đặt mã định danh thành một giá trị rỗng không.
        [Test]
        public void User_SetEmptyId_SetsCorrectly()
        {
            // Tạo một người dùng mới.
            var user = new User { Email = "john.doe@example.com", UserName = "john.doe" };
            // Đặt mã định danh là rỗng, như khi bạn chưa gán số nhận diện.
            user.Id = Guid.Empty;
            // Kiểm tra xem mã định danh đã được lưu là rỗng chưa.
            Assert.That(user.Id, Is.EqualTo(Guid.Empty), "Mã định danh phải rỗng khi không gán.");
        }
    }
}