using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;
using Microsoft.AspNetCore.Identity;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin của UserRole được thiết lập đúng.
    [TestFixture]
    public class UserRoleTests
    {
        // Hàm hỗ trợ để tạo một UserRole với các giá trị mặc định hoặc tùy chỉnh.
        private UserRole CreateUserRole(Guid? userId = null, Guid? roleId = null, User user = null, Role role = null)
        {
            // Đảm bảo User và Role luôn được gán để tránh lỗi CS9035.
            var defaultUser = new User { Id = userId ?? Guid.NewGuid(), Email = "default@example.com" };
            var defaultRole = new Role { Id = roleId ?? Guid.NewGuid(), Name = "DefaultRole" };
            return new UserRole
            {
                IdUser = userId ?? defaultUser.Id,
                IdRole = roleId ?? defaultRole.Id,
                User = user ?? defaultUser,
                Role = role ?? defaultRole
            };
        }

        // Bài kiểm tra 1: Kiểm tra xem khi tạo một UserRole mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void UserRole_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một UserRole mới với các giá trị mặc định.
            var userRole = CreateUserRole();

            // Kiểm tra các thông tin ban đầu:
            // - Mã người dùng (IdUser) phải không rỗng vì đã gán mặc định.
            Assert.That(userRole.IdUser, Is.Not.EqualTo(Guid.Empty), "Mã người dùng phải không rỗng khi đã gán mặc định.");
            // - Mã vai trò (IdRole) phải không rỗng vì đã gán mặc định.
            Assert.That(userRole.IdRole, Is.Not.EqualTo(Guid.Empty), "Mã vai trò phải không rỗng khi đã gán mặc định.");
            // - Người dùng (User) phải không trống vì đã gán mặc định.
            Assert.That(userRole.User, Is.Not.Null, "Người dùng phải không trống vì đã gán mặc định.");
            // - Vai trò (Role) phải không trống vì đã gán mặc định.
            Assert.That(userRole.Role, Is.Not.Null, "Vai trò phải không trống vì đã gán mặc định.");
        }

        // Bài kiểm tra 2: Kiểm tra xem khi nhập đầy đủ thông tin cho UserRole, các giá trị có được cập nhật đúng không.
        [Test]
        public void UserRole_SetProperties_UpdatesCorrectly()
        {
            // Chuẩn bị người dùng và vai trò để liên kết với UserRole.
            var user = new User { Id = Guid.NewGuid(), Email = "john.doe@example.com" };
            var role = new Role { Id = Guid.NewGuid(), Name = "Admin" };
            // Tạo một UserRole mới với các giá trị cụ thể.
            var userRole = CreateUserRole(user.Id, role.Id, user, role);

            // Kiểm tra xem các thông tin đã được cập nhật đúng chưa:
            // - Mã người dùng phải khớp với Id của người dùng.
            Assert.That(userRole.IdUser, Is.EqualTo(user.Id), "Mã người dùng phải khớp với Id của người dùng đã gán.");
            // - Người dùng phải khớp với đối tượng người dùng đã liên kết.
            Assert.That(userRole.User, Is.EqualTo(user), "Người dùng phải khớp với đối tượng đã liên kết.");
            // - Mã vai trò phải khớp với Id của vai trò.
            Assert.That(userRole.IdRole, Is.EqualTo(role.Id), "Mã vai trò phải khớp với Id của vai trò đã gán.");
            // - Vai trò phải khớp với đối tượng vai trò đã liên kết.
            Assert.That(userRole.Role, Is.EqualTo(role), "Vai trò phải khớp với đối tượng đã liên kết.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể cập nhật IdUser sau khi tạo không.
        [Test]
        public void UserRole_UpdateIdUser_SetsCorrectly()
        {
            // Tạo một UserRole mới với các giá trị mặc định.
            var userRole = CreateUserRole();
            // Tạo một IdUser mới.
            var newIdUser = Guid.NewGuid();
            // Cập nhật IdUser.
            userRole.IdUser = newIdUser;
            // Kiểm tra xem IdUser đã được cập nhật đúng chưa.
            Assert.That(userRole.IdUser, Is.EqualTo(newIdUser), "Mã người dùng phải được cập nhật đúng.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể cập nhật IdRole sau khi tạo không.
        [Test]
        public void UserRole_UpdateIdRole_SetsCorrectly()
        {
            // Tạo một UserRole mới với các giá trị mặc định.
            var userRole = CreateUserRole();
            // Tạo một IdRole mới.
            var newIdRole = Guid.NewGuid();
            // Cập nhật IdRole.
            userRole.IdRole = newIdRole;
            // Kiểm tra xem IdRole đã được cập nhật đúng chưa.
            Assert.That(userRole.IdRole, Is.EqualTo(newIdRole), "Mã vai trò phải được cập nhật đúng.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể thay đổi người dùng sau khi tạo không.
        [Test]
        public void UserRole_ChangeUser_SetsCorrectly()
        {
            // Tạo một UserRole mới với các giá trị mặc định.
            var userRole = CreateUserRole();
            // Tạo một người dùng mới.
            var newUser = new User { Id = Guid.NewGuid(), Email = "newuser@example.com" };
            // Cập nhật người dùng.
            userRole.User = newUser;
            // Kiểm tra xem người dùng đã được cập nhật đúng chưa.
            Assert.That(userRole.User, Is.EqualTo(newUser), "Người dùng phải được cập nhật đúng.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể thay đổi vai trò sau khi tạo không.
        [Test]
        public void UserRole_ChangeRole_SetsCorrectly()
        {
            // Tạo một UserRole mới với các giá trị mặc định.
            var userRole = CreateUserRole();
            // Tạo một vai trò mới.
            var newRole = new Role { Id = Guid.NewGuid(), Name = "NewRole" };
            // Cập nhật vai trò.
            userRole.Role = newRole;
            // Kiểm tra xem vai trò đã được cập nhật đúng chưa.
            Assert.That(userRole.Role, Is.EqualTo(newRole), "Vai trò phải được cập nhật đúng.");
        }

        // Bài kiểm tra 7: Kiểm tra xem IdUser có khớp với User.Id không.
        [Test]
        public void UserRole_IdUserMatchesUserId_HandlesCorrectly()
        {
            // Tạo người dùng với Id cụ thể.
            var user = new User { Id = Guid.NewGuid(), Email = "test@example.com" };
            var role = new Role { Id = Guid.NewGuid(), Name = "TestRole" };
            // Tạo UserRole với IdUser không khớp.
            var userRole = CreateUserRole(Guid.NewGuid(), role.Id, user, role);
            // Kiểm tra xem IdUser không ảnh hưởng đến User.Id.
            Assert.That(userRole.User.Id, Is.EqualTo(user.Id), "User.Id phải giữ nguyên bất kể IdUser.");
        }

        // Bài kiểm tra 8: Kiểm tra xem IdRole có khớp với Role.Id không.
        [Test]
        public void UserRole_IdRoleMatchesRoleId_HandlesCorrectly()
        {
            // Tạo vai trò với Id cụ thể.
            var user = new User { Id = Guid.NewGuid(), Email = "test@example.com" };
            var role = new Role { Id = Guid.NewGuid(), Name = "TestRole" };
            // Tạo UserRole với IdRole không khớp.
            var userRole = CreateUserRole(user.Id, Guid.NewGuid(), user, role);
            // Kiểm tra xem IdRole không ảnh hưởng đến Role.Id.
            Assert.That(userRole.Role.Id, Is.EqualTo(role.Id), "Role.Id phải giữ nguyên bất kể IdRole.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể gán cùng một User và Role nhiều lần không.
        [Test]
        public void UserRole_SetSameUserAndRoleMultipleTimes_SetsCorrectly()
        {
            // Tạo người dùng và vai trò.
            var user = new User { Id = Guid.NewGuid(), Email = "test@example.com" };
            var role = new Role { Id = Guid.NewGuid(), Name = "TestRole" };
            // Tạo một UserRole mới.
            var userRole = CreateUserRole(user.Id, role.Id, user, role);
            // Gán lại cùng User và Role.
            userRole.User = user;
            userRole.Role = role;
            // Kiểm tra xem User và Role vẫn giữ nguyên.
            Assert.That(userRole.User, Is.EqualTo(user), "Người dùng phải giữ nguyên sau khi gán lại.");
            Assert.That(userRole.Role, Is.EqualTo(role), "Vai trò phải giữ nguyên sau khi gán lại.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể cập nhật email của User sau khi gán không.
        [Test]
        public void UserRole_UpdateUserEmail_HandlesCorrectly()
        {
            // Tạo một UserRole mới.
            var userRole = CreateUserRole();
            // Cập nhật email của User.
            userRole.User.Email = "updated@example.com";
            // Kiểm tra xem email đã được cập nhật đúng chưa.
            Assert.That(userRole.User.Email, Is.EqualTo("updated@example.com"), "Email của người dùng phải được cập nhật đúng.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể cập nhật tên của Role sau khi gán không.
        [Test]
        public void UserRole_UpdateRoleName_HandlesCorrectly()
        {
            // Tạo một UserRole mới.
            var userRole = CreateUserRole();
            // Cập nhật tên của Role.
            userRole.Role.Name = "UpdatedRole";
            // Kiểm tra xem tên của Role đã được cập nhật đúng chưa.
            Assert.That(userRole.Role.Name, Is.EqualTo("UpdatedRole"), "Tên của vai trò phải được cập nhật đúng.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể tạo UserRole với User có email rất dài không.
        [Test]
        public void UserRole_SetUserWithLongEmail_HandlesCorrectly()
        {
            // Tạo người dùng với email rất dài.
            var longEmail = new string('a', 100) + "@example.com";
            var user = new User { Id = Guid.NewGuid(), Email = longEmail };
            var role = new Role { Id = Guid.NewGuid(), Name = "Admin" };
            // Tạo một UserRole mới.
            var userRole = CreateUserRole(user.Id, role.Id, user, role);
            // Kiểm tra xem người dùng đã được liên kết đúng chưa.
            Assert.That(userRole.User.Email, Is.EqualTo(longEmail), "Email dài của người dùng phải được lưu đúng.");
        }
    }
}