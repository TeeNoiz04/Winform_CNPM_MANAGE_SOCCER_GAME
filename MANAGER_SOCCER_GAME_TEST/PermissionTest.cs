using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using System;
using System.Collections.Generic;

namespace MANAGE_SOCCER_GAME.Tests
{
    // Đây là một nhóm các bài kiểm tra để đảm bảo thông tin về quyền (như quyền truy cập của người dùng) được thiết lập đúng.
    [TestFixture]
    public class PermissionTests
    {
        // Bài kiểm tra 1: Kiểm tra xem khi tạo một quyền mới, các thông tin có được đặt về giá trị mặc định đúng không.
        [Test]
        public void Permission_DefaultInitialization_SetsCorrectValues()
        {
            // Tạo một quyền mới, như khi bạn bắt đầu thiết lập một quyền truy cập.
            var permission = new Permission();

            // Kiểm tra các thông tin ban đầu:
            // - Mã định danh (PermissionId) phải rỗng, như khi bạn chưa gán số nhận diện cho quyền.
            Assert.That(permission.PermissionId, Is.EqualTo(Guid.Empty), "Mã định danh của quyền phải rỗng vì chưa gán.");
            // - Tên quyền (Name) phải trống vì bạn chưa nhập tên.
            Assert.That(permission.Name, Is.Null, "Tên quyền phải trống vì chưa nhập tên.");
            // - Mô tả quyền (Description) phải trống vì bạn chưa nhập mô tả.
            Assert.That(permission.Description, Is.Null, "Mô tả quyền phải trống vì chưa nhập mô tả.");
            // - Quyền cốt lõi (IsCorePermission) phải là "không", vì quyền mới chưa được đánh dấu là cốt lõi.
            Assert.That(permission.IsCorePermission, Is.False, "Quyền cốt lõi phải là 'không' vì chưa được đánh dấu.");
            // - Thời gian tạo (CreatedAt) phải là giá trị mặc định (rất xa trong quá khứ) vì chưa nhập.
            Assert.That(permission.CreatedAt, Is.EqualTo(DateTime.MinValue), "Thời gian tạo phải là giá trị mặc định vì chưa nhập.");
            // - Thời gian cập nhật (UpdatedAt) cũng phải là giá trị mặc định vì chưa nhập.
            Assert.That(permission.UpdatedAt, Is.EqualTo(DateTime.MinValue), "Thời gian cập nhật phải là giá trị mặc định vì chưa nhập.");
            // - Danh sách quyền vai trò (RolePermissions) phải trống vì quyền chưa được gán cho vai trò nào.
            Assert.That(permission.RolePermissions, Is.Null, "Danh sách quyền vai trò phải trống vì chưa gán.");
        }

        // Bài kiểm tra 2: Kiểm tra xem khi nhập thông tin cho quyền, các giá trị có được lưu đúng không.
        [Test]
        public void Permission_SetProperties_UpdatesCorrectly()
        {
            // Tạo một quyền mới.
            var permission = new Permission();
            // Chuẩn bị một vai trò và một quyền vai trò để liên kết, như khi bạn gán quyền này cho vai trò "Admin".
            var role = new Role { Id = Guid.NewGuid(), Name = "Admin" };
            var rolePermission = new RolePermission
            {
                RolePermissionId = Guid.NewGuid(),
                RoleId = role.Id,
                Role = role,
                PermissionId = Guid.NewGuid(),
                Permission = permission
            };
            var rolePermissions = new List<RolePermission> { rolePermission };

            // Nhập thông tin cho quyền:
            // - Gán mã định danh mới, như một số nhận diện riêng cho quyền.
            permission.PermissionId = Guid.NewGuid();
            // - Đặt tên là "AdminAccess", như tên của quyền.
            permission.Name = "AdminAccess";
            // - Đặt mô tả là "Cấp quyền quản trị", như để giải thích quyền này làm gì.
            permission.Description = "Grants admin privileges";
            // - Đánh dấu là quyền cốt lõi, như khi đây là quyền quan trọng.
            permission.IsCorePermission = true;
            // - Đặt thời gian tạo là thời gian hiện tại, như khi bạn vừa tạo quyền.
            permission.CreatedAt = DateTime.Now;
            // - Đặt thời gian cập nhật là ngày mai, như khi bạn chỉnh sửa quyền sau một ngày.
            permission.UpdatedAt = DateTime.Now.AddDays(1);
            // - Gán danh sách quyền vai trò, như khi quyền này được gán cho một vai trò.
            permission.RolePermissions = rolePermissions;

            // Kiểm tra xem các thông tin đã được lưu đúng chưa:
            // - Mã định danh phải là một giá trị mới, không rỗng.
            Assert.That(permission.PermissionId, Is.Not.EqualTo(Guid.Empty), "Mã định danh phải có giá trị mới.");
            // - Tên phải là "AdminAccess" như đã nhập.
            Assert.That(permission.Name, Is.EqualTo("AdminAccess"), "Tên quyền phải là 'AdminAccess'.");
            // - Mô tả phải là "Cấp quyền quản trị".
            Assert.That(permission.Description, Is.EqualTo("Grants admin privileges"), "Mô tả quyền phải là 'Cấp quyền quản trị'.");
            // - Quyền cốt lõi phải là "có".
            Assert.That(permission.IsCorePermission, Is.True, "Quyền cốt lõi phải là 'có' như đã đánh dấu.");
            // - Thời gian tạo phải là thời gian hiện tại.
            Assert.That(permission.CreatedAt, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Thời gian tạo phải là thời gian hiện tại.");
            // - Thời gian cập nhật phải muộn hơn thời gian tạo.
            Assert.That(permission.UpdatedAt, Is.GreaterThan(permission.CreatedAt), "Thời gian cập nhật phải muộn hơn thời gian tạo.");
            // - Danh sách quyền vai trò phải có 1 mục, vì đã gán một vai trò.
            Assert.That(permission.RolePermissions, Has.Count.EqualTo(1), "Danh sách quyền vai trò phải có 1 mục sau khi gán.");
        }

        // Bài kiểm tra 3: Kiểm tra xem có thể đặt tên quyền là chuỗi rỗng không.
        [Test]
        public void Permission_SetEmptyName_SetsCorrectly()
        {
            // Tạo một quyền mới.
            var permission = new Permission();
            // Đặt tên quyền là chuỗi rỗng, như khi bạn chưa nhập tên.
            permission.Name = "";
            // Kiểm tra xem tên quyền đã được lưu là chuỗi rỗng chưa.
            Assert.That(permission.Name, Is.Empty, "Tên quyền phải là chuỗi rỗng khi không nhập tên.");
        }

        // Bài kiểm tra 4: Kiểm tra xem có thể đặt mô tả quyền là chuỗi dài (như 200 ký tự) không.
        [Test]
        public void Permission_SetLongDescription_SetsCorrectly()
        {
            // Tạo một quyền mới.
            var permission = new Permission();
            // Đặt mô tả quyền là một chuỗi dài, như khi bạn viết mô tả chi tiết cho quyền.
            var longDescription = new string('a', 200);
            permission.Description = longDescription;
            // Kiểm tra xem mô tả đã được lưu đúng chưa.
            Assert.That(permission.Description, Is.EqualTo(longDescription), "Mô tả quyền phải được lưu đúng với chuỗi dài.");
        }

        // Bài kiểm tra 5: Kiểm tra xem có thể bỏ danh sách quyền vai trò (đặt thành trống) không.
        [Test]
        public void Permission_SetNullRolePermissions_SetsCorrectly()
        {
            // Tạo một quyền mới.
            var permission = new Permission();
            // Bỏ danh sách quyền vai trò, như khi quyền chưa được gán cho vai trò nào.
            permission.RolePermissions = null;
            // Kiểm tra xem danh sách quyền vai trò đã trống chưa.
            Assert.That(permission.RolePermissions, Is.Null, "Danh sách quyền vai trò phải trống khi không gán.");
        }

        // Bài kiểm tra 6: Kiểm tra xem có thể đặt quyền cốt lõi là "không" sau khi đã đặt là "có" không.
        [Test]
        public void Permission_ToggleIsCorePermission_SetsCorrectly()
        {
            // Tạo một quyền mới.
            var permission = new Permission();
            // Đặt quyền cốt lõi là "có", như khi quyền này quan trọng.
            permission.IsCorePermission = true;
            // Đổi lại thành "không", như khi quyền không còn quan trọng.
            permission.IsCorePermission = false;
            // Kiểm tra xem trạng thái quyền cốt lõi cuối cùng là "không" không.
            Assert.That(permission.IsCorePermission, Is.False, "Quyền cốt lõi phải là 'không' sau khi đổi.");
        }

        // Bài kiểm tra 7: Kiểm tra xem có thể đặt thời gian tạo là một ngày trong quá khứ không.
        [Test]
        public void Permission_SetPastCreatedAt_SetsCorrectly()
        {
            // Tạo một quyền mới.
            var permission = new Permission();
            // Đặt thời gian tạo là ngày 1/1/2020, như khi quyền được tạo từ lâu.
            var pastDate = new DateTime(2020, 1, 1);
            permission.CreatedAt = pastDate;
            // Kiểm tra xem thời gian tạo đã được lưu đúng chưa.
            Assert.That(permission.CreatedAt, Is.EqualTo(pastDate), "Thời gian tạo phải là ngày 1/1/2020 như đã chọn.");
        }

         // Bài kiểm tra 9: Kiểm tra xem có thể đặt tên quyền với ký tự đặc biệt (như @#$%) không.
        [Test]
        public void Permission_SetNameWithSpecialCharacters_SetsCorrectly()
        {
            // Tạo một quyền mới.
            var permission = new Permission();
            // Đặt tên quyền với ký tự đặc biệt, như khi bạn dùng ký hiệu để đặt tên.
            permission.Name = "Access@#$%";
            // Kiểm tra xem tên quyền đã được lưu đúng chưa.
            Assert.That(permission.Name, Is.EqualTo("Access@#$%"), "Tên quyền phải được lưu đúng với ký tự đặc biệt.");
        }

        // Bài kiểm tra 10: Kiểm tra xem có thể thay đổi danh sách quyền vai trò nhiều lần không.
        [Test]
        public void Permission_UpdateRolePermissionsMultipleTimes_UpdatesCorrectly()
        {
            // Tạo một quyền mới.
            var permission = new Permission();
            // Gán danh sách quyền vai trò đầu tiên, như khi quyền được gán cho một vai trò.
            var rolePermissions1 = new List<RolePermission> { new RolePermission { RolePermissionId = Guid.NewGuid() } };
            permission.RolePermissions = rolePermissions1;
            // Thay đổi sang danh sách quyền vai trò mới, như khi quyền được gán cho vai trò khác.
            var rolePermissions2 = new List<RolePermission> { new RolePermission { RolePermissionId = Guid.NewGuid() } };
            permission.RolePermissions = rolePermissions2;
            // Kiểm tra xem danh sách quyền vai trò cuối cùng là danh sách mới không.
            Assert.That(permission.RolePermissions, Is.EqualTo(rolePermissions2), "Danh sách quyền vai trò phải được cập nhật thành danh sách mới.");
        }

        // Bài kiểm tra 11: Kiểm tra xem có thể đặt mô tả quyền là chuỗi rỗng không.
        [Test]
        public void Permission_SetEmptyDescription_SetsCorrectly()
        {
            // Tạo một quyền mới.
            var permission = new Permission();
            // Đặt mô tả quyền là chuỗi rỗng, như khi bạn không muốn mô tả gì.
            permission.Description = "";
            // Kiểm tra xem mô tả quyền đã được lưu là chuỗi rỗng chưa.
            Assert.That(permission.Description, Is.Empty, "Mô tả quyền phải là chuỗi rỗng khi không nhập mô tả.");
        }

        // Bài kiểm tra 12: Kiểm tra xem có thể đặt mã định danh thành một giá trị rỗng không.
        [Test]
        public void Permission_SetEmptyPermissionId_SetsCorrectly()
        {
            // Tạo một quyền mới.
            var permission = new Permission();
            // Đặt mã định danh là rỗng, như khi bạn chưa gán số nhận diện.
            permission.PermissionId = Guid.Empty;
            // Kiểm tra xem mã định danh đã được lưu là rỗng chưa.
            Assert.That(permission.PermissionId, Is.EqualTo(Guid.Empty), "Mã định danh phải rỗng khi không gán.");
        }
    }
}