using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;
using System.Collections.Generic;

namespace MANAGE_SOCCER_GAME.Tests
{
    [TestFixture]
    public class RoleTests
    {
        [Test]
        public void Role_DefaultInitialization_SetsCorrectValues()
        {
            var role = new Role();

            Assert.That(role.Id, Is.EqualTo(Guid.Empty), "Mã định danh của vai trò phải rỗng khi chưa gán.");
            Assert.That(role.Name, Is.Null, "Tên vai trò phải trống vì chưa nhập.");
            Assert.That(role.RolePermissions, Is.Null, "Danh sách quyền phải trống vì chưa liên kết.");
            Assert.That(role.UserRoles, Is.Null, "Danh sách người dùng phải trống vì chưa liên kết.");
            Assert.That(role.CreatedAt, Is.EqualTo(DateTime.MinValue), "Thời gian tạo phải là giá trị mặc định khi chưa gán.");
            Assert.That(role.UpdatedAt, Is.EqualTo(DateTime.MinValue), "Thời gian cập nhật phải là giá trị mặc định khi chưa gán.");
        }

        [Test]
        public void Role_SetProperties_UpdatesCorrectly()
        {
            var role = new Role { Id = Guid.NewGuid() }; // Gán Id trước để đảm bảo nhất quán
            var permission = new Permission { PermissionId = Guid.NewGuid() };
            var rolePermission = new RolePermission
            {
                RolePermissionId = Guid.NewGuid(),
                RoleId = role.Id,
                PermissionId = permission.PermissionId,
                Permission = permission,
                Role = role
            };
            var rolePermissions = new List<RolePermission> { rolePermission };
            var user = new User { Id = Guid.NewGuid(), Email = "john.doe@example.com" };
            var userRole = new UserRole
            {
                UserId = user.Id, // Sử dụng UserId thay vì IdUser để khớp với cấu hình EF Core
                User = user,
                RoleId = role.Id, // Đồng bộ với role.Id
                Role = role // Thiết lập Role bắt buộc
            };
            var userRoles = new List<UserRole> { userRole };

            role.Name = "Admin";
            role.RolePermissions = rolePermissions;
            role.UserRoles = userRoles;
            role.CreatedAt = DateTime.Now;
            role.UpdatedAt = DateTime.Now.AddDays(1);

            Assert.That(role.Id, Is.Not.EqualTo(Guid.Empty), "Mã định danh phải có giá trị mới.");
            Assert.That(role.Name, Is.EqualTo("Admin"), "Tên vai trò phải là 'Admin'.");
            Assert.That(role.RolePermissions, Has.Count.EqualTo(1), "Danh sách quyền phải chứa 1 phần tử sau khi gán.");
            Assert.That(role.UserRoles, Has.Count.EqualTo(1), "Danh sách người dùng phải chứa 1 phần tử sau khi gán.");
            Assert.That(role.CreatedAt, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Thời gian tạo phải gần với hiện tại.");
            Assert.That(role.UpdatedAt, Is.GreaterThan(role.CreatedAt), "Thời gian cập nhật phải lớn hơn thời gian tạo.");
        }

        [Test]
        public void Role_SetEmptyName_SetsCorrectly()
        {
            var role = new Role();
            role.Name = "";
            Assert.That(role.Name, Is.Empty, "Tên vai trò phải là chuỗi rỗng khi gán.");
        }

        [Test]
        public void Role_SetEmptyRolePermissions_SetsCorrectly()
        {
            var role = new Role();
            role.RolePermissions = new List<RolePermission>();
            Assert.That(role.RolePermissions, Is.Empty, "Danh sách quyền phải rỗng khi gán danh sách rỗng.");
        }

        [Test]
        public void Role_SetEmptyUserRoles_SetsCorrectly()
        {
            var role = new Role();
            role.UserRoles = new List<UserRole>();
            Assert.That(role.UserRoles, Is.Empty, "Danh sách người dùng phải rỗng khi gán danh sách rỗng.");
        }

        [Test]
        public void Role_SetPastCreatedAt_SetsCorrectly()
        {
            var role = new Role();
            var pastDate = DateTime.Now.AddDays(-1);
            role.CreatedAt = pastDate;
            Assert.That(role.CreatedAt, Is.EqualTo(pastDate), "Thời gian tạo phải khớp với giá trị đã gán.");
        }

        [Test]
        public void Role_SetUpdatedAtEqualToCreatedAt_SetsCorrectly()
        {
            var role = new Role();
            var currentTime = DateTime.Now;
            role.CreatedAt = currentTime;
            role.UpdatedAt = currentTime;
            Assert.That(role.UpdatedAt, Is.EqualTo(role.CreatedAt), "Thời gian cập nhật phải bằng thời gian tạo khi gán cùng giá trị.");
        }

        [Test]
        public void Role_AddMultipleRolePermissions_SetsCorrectly()
        {
            var role = new Role();
            var permission1 = new Permission { PermissionId = Guid.NewGuid() };
            var permission2 = new Permission { PermissionId = Guid.NewGuid() };
            var rolePermission1 = new RolePermission { RolePermissionId = Guid.NewGuid(), Permission = permission1, RoleId = Guid.NewGuid(), Role = role };
            var rolePermission2 = new RolePermission { RolePermissionId = Guid.NewGuid(), Permission = permission2, RoleId = Guid.NewGuid(), Role = role };
            role.RolePermissions = new List<RolePermission> { rolePermission1, rolePermission2 };
            Assert.That(role.RolePermissions, Has.Count.EqualTo(2), "Danh sách quyền phải chứa 2 phần tử sau khi thêm.");
        }

        [Test]
        public void Role_AddMultipleUserRoles_SetsCorrectly()
        {
            var role = new Role { Id = Guid.NewGuid() }; // Gán Id trước
            var user1 = new User { Id = Guid.NewGuid(), Email = "user1@example.com" };
            var user2 = new User { Id = Guid.NewGuid(), Email = "user2@example.com" };
            var userRole1 = new UserRole { UserId = user1.Id, User = user1, RoleId = role.Id, Role = role }; // Thiết lập đầy đủ
            var userRole2 = new UserRole { UserId = user2.Id, User = user2, RoleId = role.Id, Role = role }; // Thiết lập đầy đủ
            role.UserRoles = new List<UserRole> { userRole1, userRole2 };
            Assert.That(role.UserRoles, Has.Count.EqualTo(2), "Danh sách người dùng phải chứa 2 phần tử sau khi thêm.");
        }

        [Test]
        public void Role_SetLongName_SetsCorrectly()
        {
            var role = new Role();
            var longName = new string('A', 100);
            role.Name = longName;
            Assert.That(role.Name, Is.EqualTo(longName), "Tên vai trò phải được lưu đúng dù rất dài.");
        }

        [Test]
        public void Role_UpdateNameMultipleTimes_UpdatesCorrectly()
        {
            var role = new Role();
            role.Name = "Role A";
            role.Name = "Role B";
            Assert.That(role.Name, Is.EqualTo("Role B"), "Tên vai trò phải được cập nhật thành 'Role B'.");
        }

        [Test]
        public void Role_SetFutureUpdatedAt_SetsCorrectly()
        {
            var role = new Role();
            var futureDate = DateTime.Now.AddDays(1);
            role.UpdatedAt = futureDate;
            Assert.That(role.UpdatedAt, Is.EqualTo(futureDate), "Thời gian cập nhật phải khớp với giá trị đã gán.");
        }
    }
}