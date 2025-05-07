using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin về quyền của vai trò (như vai trò nào có quyền gì) được thiết lập đúng.
    [TestFixture]
    public class RolePermissionTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo một quyền vai trò mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void RolePermission_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một quyền vai trò mới, như khi bạn bắt đầu gán quyền cho một vai trò.
            var rolePermission = new RolePermission();

            // Kiểm tra các thông tin ban đầu:
            // - Mã định danh (RolePermissionId) phải rỗng, như khi bạn chưa gán số nhận diện cho quyền này.
            Assert.That(rolePermission.RolePermissionId, Is.EqualTo(Guid.Empty), "Mã định danh của quyền vai trò phải rỗng vì chưa gán.");
            // - Mã vai trò (RoleId) phải rỗng vì chưa liên kết với vai trò nào.
            Assert.That(rolePermission.RoleId, Is.EqualTo(Guid.Empty), "Mã vai trò phải rỗng vì chưa chọn vai trò.");
            // - Thông tin vai trò (Role) phải trống vì chưa liên kết với vai trò cụ thể.
            Assert.That(rolePermission.Role, Is.Null, "Thông tin vai trò phải trống vì chưa chọn vai trò.");
            // - Mã quyền (PermissionId) phải rỗng vì chưa liên kết với quyền nào.
            Assert.That(rolePermission.PermissionId, Is.EqualTo(Guid.Empty), "Mã quyền phải rỗng vì chưa chọn quyền.");
            // - Thông tin quyền (Permission) phải trống vì chưa liên kết với quyền cụ thể.
            Assert.That(rolePermission.Permission, Is.Null, "Thông tin quyền phải trống vì chưa chọn quyền.");
        }

        // Bài kiểm tra 2: Kiểm tra xem khi nhập thông tin cho quyền vai trò, các giá trị có được lưu đúng không.
        [Test]
        public void RolePermission_SetProperties_UpdatesCorrectly()
        {
            // Tạo một quyền vai trò mới.
            var rolePermission = new RolePermission();
            // Chuẩn bị một vai trò và một quyền để liên kết, như khi bạn gán quyền "AdminAccess" cho vai trò "Admin".
            var role = new Role { Id = Guid.NewGuid(), Name = "Admin" };
            var permission = new Permission { PermissionId = Guid.NewGuid(), Name = "AdminAccess" };

            // Nhập thông tin cho quyền vai trò:
            // - Gán mã định danh mới, như một số nhận diện riêng cho quyền vai trò này.
            rolePermission.RolePermissionId = Guid.NewGuid();
            // - Gán mã vai trò để biết quyền này thuộc vai trò nào.
            rolePermission.RoleId = role.Id;
            // - Liên kết với thông tin vai trò "Admin".
            rolePermission.Role = role;
            // - Gán mã quyền để biết đây là quyền gì.
            rolePermission.PermissionId = permission.PermissionId;
            // - Liên kết với thông tin quyền "AdminAccess".
            rolePermission.Permission = permission;

            // Kiểm tra xem các thông tin đã được lưu đúng chưa:
            // - Mã định danh phải là một giá trị mới, không rỗng.
            Assert.That(rolePermission.RolePermissionId, Is.Not.EqualTo(Guid.Empty), "Mã định danh phải có giá trị mới.");
            // - Mã vai trò phải khớp với mã của vai trò đã chọn.
            Assert.That(rolePermission.RoleId, Is.EqualTo(role.Id), "Mã vai trò phải khớp với vai trò đã chọn.");
            // - Thông tin vai trò phải khớp với vai trò "Admin".
            Assert.That(rolePermission.Role, Is.EqualTo(role), "Thông tin vai trò phải khớp với vai trò đã chọn.");
            // - Mã quyền phải khớp với mã của quyền đã chọn.
            Assert.That(rolePermission.PermissionId, Is.EqualTo(permission.PermissionId), "Mã quyền phải khớp với quyền đã chọn.");
            // - Thông tin quyền phải khớp với quyền "AdminAccess".
            Assert.That(rolePermission.Permission, Is.EqualTo(permission), "Thông tin quyền phải khớp với quyền đã chọn.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể bỏ liên kết với vai trò (đặt thành trống) không.
        [Test]
        public void RolePermission_SetNullRole_SetsCorrectly()
        {
            // Tạo một quyền vai trò mới.
            var rolePermission = new RolePermission();
            // Bỏ liên kết với vai trò, như khi quyền này chưa thuộc vai trò nào.
            rolePermission.RoleId = Guid.Empty;
            rolePermission.Role = null;
            // Kiểm tra xem mã vai trò và thông tin vai trò đã trống chưa.
            Assert.That(rolePermission.RoleId, Is.EqualTo(Guid.Empty), "Mã vai trò phải rỗng khi không chọn vai trò.");
            Assert.That(rolePermission.Role, Is.Null, "Thông tin vai trò phải trống khi không chọn vai trò.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể bỏ liên kết với quyền (đặt thành trống) không.
        [Test]
        public void RolePermission_SetNullPermission_SetsCorrectly()
        {
            // Tạo một quyền vai trò mới.
            var rolePermission = new RolePermission();
            // Bỏ liên kết với quyền, như khi vai trò chưa được gán quyền nào.
            rolePermission.PermissionId = Guid.Empty;
            rolePermission.Permission = null;
            // Kiểm tra xem mã quyền và thông tin quyền đã trống chưa.
            Assert.That(rolePermission.PermissionId, Is.EqualTo(Guid.Empty), "Mã quyền phải rỗng khi không chọn quyền.");
            Assert.That(rolePermission.Permission, Is.Null, "Thông tin quyền phải trống khi không chọn quyền.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể đặt mã định danh thành một giá trị rỗng không.
        [Test]
        public void RolePermission_SetEmptyRolePermissionId_SetsCorrectly()
        {
            // Tạo một quyền vai trò mới.
            var rolePermission = new RolePermission();
            // Đặt mã định danh là rỗng, như khi bạn chưa gán số nhận diện.
            rolePermission.RolePermissionId = Guid.Empty;
            // Kiểm tra xem mã định danh đã được lưu là rỗng chưa.
            Assert.That(rolePermission.RolePermissionId, Is.EqualTo(Guid.Empty), "Mã định danh phải rỗng khi không gán.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể thay đổi mã vai trò nhiều lần không.
        [Test]
        public void RolePermission_UpdateRoleIdMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một quyền vai trò mới.
            var rolePermission = new RolePermission();
            // Gán mã vai trò đầu tiên, như khi quyền thuộc vai trò A.
            var roleId1 = Guid.NewGuid();
            rolePermission.RoleId = roleId1;
            // Thay đổi sang mã vai trò thứ hai, như khi quyền được chuyển sang vai trò B.
            var roleId2 = Guid.NewGuid();
            rolePermission.RoleId = roleId2;
            // Kiểm tra xem mã vai trò cuối cùng là mã thứ hai không.
            Assert.That(rolePermission.RoleId, Is.EqualTo(roleId2), "Mã vai trò phải được cập nhật thành mã mới.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể thay đổi mã quyền nhiều lần không.
        [Test]
        public void RolePermission_UpdatePermissionIdMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một quyền vai trò mới.
            var rolePermission = new RolePermission();
            // Gán mã quyền đầu tiên, như khi vai trò có quyền A.
            var permissionId1 = Guid.NewGuid();
            rolePermission.PermissionId = permissionId1;
            // Thay đổi sang mã quyền thứ hai, như khi vai trò được gán quyền B.
            var permissionId2 = Guid.NewGuid();
            rolePermission.PermissionId = permissionId2;
            // Kiểm tra xem mã quyền cuối cùng là mã thứ hai không.
            Assert.That(rolePermission.PermissionId, Is.EqualTo(permissionId2), "Mã quyền phải được cập nhật thành mã mới.");
        }

        // Bài kiểm tra 8: Kiểm tra xem có thể liên kết với vai trò không có tên không.
        [Test]
        public void RolePermission_SetRoleWithNullName_SetsCorrectly()
        {
            // Tạo một quyền vai trò mới.
            var rolePermission = new RolePermission();
            // Tạo một vai trò nhưng không có tên, như khi thông tin vai trò chưa đầy đủ.
            var role = new Role { Id = Guid.NewGuid(), Name = null };
            // Liên kết quyền vai trò với vai trò này.
            rolePermission.Role = role;
            rolePermission.RoleId = role.Id;
            // Kiểm tra xem vai trò đã được liên kết đúng chưa, dù không có tên.
            Assert.That(rolePermission.Role, Is.EqualTo(role), "Quyền vai trò phải liên kết được với vai trò dù vai trò không có tên.");
        }

        // Bài kiểm tra 9: Kiểm tra xem có thể liên kết với quyền không có tên không.
        [Test]
        public void RolePermission_SetPermissionWithNullName_SetsCorrectly()
        {
            // Tạo một quyền vai trò mới.
            var rolePermission = new RolePermission();
            // Tạo một quyền nhưng không có tên, như khi thông tin quyền chưa đầy đủ.
            var permission = new Permission { PermissionId = Guid.NewGuid(), Name = null };
            // Liên kết quyền vai trò với quyền này.
            rolePermission.Permission = permission;
            rolePermission.PermissionId = permission.PermissionId;
            // Kiểm tra xem quyền đã được liên kết đúng chưa, dù không có tên.
            Assert.That(rolePermission.Permission, Is.EqualTo(permission), "Quyền vai trò phải liên kết được với quyền dù quyền không có tên.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể đặt mã vai trò không hợp lệ (rỗng) sau khi đã gán không.
        [Test]
        public void RolePermission_SetEmptyRoleIdAfterAssignment_SetsCorrectly()
        {
            // Tạo một quyền vai trò mới.
            var rolePermission = new RolePermission();
            // Gán mã vai trò ban đầu, như khi quyền thuộc một vai trò.
            rolePermission.RoleId = Guid.NewGuid();
            // Đặt lại mã vai trò thành rỗng, như khi bạn bỏ liên kết với vai trò.
            rolePermission.RoleId = Guid.Empty;
            // Kiểm tra xem mã vai trò đã được đặt lại thành rỗng chưa.
            Assert.That(rolePermission.RoleId, Is.EqualTo(Guid.Empty), "Mã vai trò phải rỗng sau khi bỏ liên kết.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể đặt mã quyền không hợp lệ (rỗng) sau khi đã gán không.
        [Test]
        public void RolePermission_SetEmptyPermissionIdAfterAssignment_SetsCorrectly()
        {
            // Tạo một quyền vai trò mới.
            var rolePermission = new RolePermission();
            // Gán mã quyền ban đầu, như khi vai trò có một quyền.
            rolePermission.PermissionId = Guid.NewGuid();
            // Đặt lại mã quyền thành rỗng, như khi bạn bỏ liên kết với quyền.
            rolePermission.PermissionId = Guid.Empty;
            // Kiểm tra xem mã quyền đã được đặt lại thành rỗng chưa.
            Assert.That(rolePermission.PermissionId, Is.EqualTo(Guid.Empty), "Mã quyền phải rỗng sau khi bỏ liên kết.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể thay đổi thông tin vai trò nhiều lần không.
        [Test]
        public void RolePermission_UpdateRoleMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một quyền vai trò mới.
            var rolePermission = new RolePermission();
            // Gán vai trò đầu tiên, như vai trò "Admin".
            var role1 = new Role { Id = Guid.NewGuid(), Name = "Admin" };
            rolePermission.Role = role1;
            // Thay đổi sang vai trò thứ hai, như vai trò "User".
            var role2 = new Role { Id = Guid.NewGuid(), Name = "User" };
            rolePermission.Role = role2;
            // Kiểm tra xem thông tin vai trò cuối cùng là vai trò thứ hai không.
            Assert.That(rolePermission.Role, Is.EqualTo(role2), "Thông tin vai trò phải được cập nhật thành vai trò mới.");
        }
    }
}