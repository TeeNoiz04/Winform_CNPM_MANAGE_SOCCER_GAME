using NUnit.Framework;
using Moq;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using MANAGE_SOCCER_GAME.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;

namespace MANAGE_SOCCER_GAME.Tests
{
    /// <summary>
    /// Test class kiểm tra chức năng của UserService
    /// </summary>
    [TestFixture]
    public class UserServiceTests
    {
        // DbContext options để cấu hình database trong bộ nhớ cho việc test
        private DbContextOptions<ManageSoccerGame> _options;
        // Context database được sử dụng cho test
        private ManageSoccerGame _context;
        // Service được test
        private UserService _service;
        // Mock của UserManager để kiểm soát hành vi
        private UserManager<User> _userManager;
        // Mock của IUserStore để khởi tạo UserManager
        private Mock<IUserStore<User>> _userStoreMock;

        /// <summary>
        /// Khởi tạo môi trường test trước mỗi test case
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Sử dụng cơ sở dữ liệu trong bộ nhớ cho việc test với ID duy nhất để tránh xung đột
            _options = new DbContextOptionsBuilder<ManageSoccerGame>()
                .UseInMemoryDatabase(databaseName: $"TestDb_{Guid.NewGuid()}")
                .EnableSensitiveDataLogging() // Cho phép ghi log chi tiết để debug
                .Options;

            // Tạo context với database trong bộ nhớ
            _context = new ManageSoccerGame(_options);

            // Khởi tạo các mock cần thiết cho UserManager
            _userStoreMock = new Mock<IUserStore<User>>();
            var options = new Mock<IOptions<IdentityOptions>>();
            var passwordHasher = new PasswordHasher<User>();
            var userValidators = new List<IUserValidator<User>> { new UserValidator<User>() };
            var passwordValidators = new List<IPasswordValidator<User>> { new PasswordValidator<User>() };
            var logger = new Mock<ILogger<UserManager<User>>>();

            _userManager = new UserManager<User>(
                _userStoreMock.Object,
                options.Object,
                passwordHasher,
                userValidators,
                passwordValidators,
                new Mock<ILookupNormalizer>().Object,
                new IdentityErrorDescriber(),
                new Mock<IServiceProvider>().Object,
                logger.Object);

            // Thay thế UserManager bằng mock có hành vi giả lập
            _userManager = MockUserManager(_context.Users);

            // Tạo service với context thật và UserManager đã mock
            _service = new UserService(_userManager, _context);
        }

        /// <summary>
        /// Dọn dẹp sau mỗi test case
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Xóa database sau mỗi test để đảm bảo môi trường sạch cho test tiếp theo
            _context.Database.EnsureDeleted();
            _context.Dispose();
            _userManager.Dispose();
        }

        /// <summary>
        /// Xóa tất cả người dùng trong database
        /// </summary>
        private async Task ClearUsers()
        {
            // Xóa tất cả người dùng hiện có để đảm bảo trạng thái sạch cho test
            _context.Users.RemoveRange(_context.Users);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Tạo mock cho UserManager để giả lập hành vi của nó
        /// </summary>
        private UserManager<User> MockUserManager(DbSet<User> users)
        {
            var store = new Mock<IUserStore<User>>();
            var mgr = new Mock<UserManager<User>>(
                store.Object,
                null, null, null, null, null, null, null, null);

            // Giả lập phương thức CreateAsync
            mgr.Setup(x => x.CreateAsync(It.IsAny<User>(), It.IsAny<string>()))
                .ReturnsAsync((User user, string password) =>
                {
                    users.Add(user);
                    _context.SaveChanges();
                    return IdentityResult.Success;
                });

            // Giả lập phương thức UpdateAsync
            mgr.Setup(x => x.UpdateAsync(It.IsAny<User>()))
                .ReturnsAsync((User user) =>
                {
                    var existing = users.Find(user.Id);
                    if (existing != null)
                    {
                        _context.Entry(existing).CurrentValues.SetValues(user);
                        _context.SaveChanges();
                    }
                    return IdentityResult.Success;
                });

            // Giả lập phương thức DeleteAsync
            mgr.Setup(x => x.DeleteAsync(It.IsAny<User>()))
                .ReturnsAsync((User user) =>
                {
                    var existing = users.Find(user.Id);
                    if (existing != null)
                    {
                        users.Remove(existing);
                        _context.SaveChanges();
                    }
                    return IdentityResult.Success;
                });

            // Giả lập phương thức FindByIdAsync
            mgr.Setup(x => x.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync((string id) =>
                    users.FirstOrDefault(u => u.Id.ToString() == id));

            // Giả lập phương thức FindByEmailAsync
            mgr.Setup(x => x.FindByEmailAsync(It.IsAny<string>()))
                .ReturnsAsync((string email) =>
                    users.FirstOrDefault(u => u.Email == email));

            // Giả lập property Users
            mgr.Setup(x => x.Users)
                .Returns(users.AsQueryable());

            // Giả lập phương thức ChangePasswordAsync
            mgr.Setup(x => x.ChangePasswordAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);

            // Giả lập phương thức AddToRoleAsync
            mgr.Setup(x => x.AddToRoleAsync(It.IsAny<User>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);

            // Giả lập phương thức RemoveFromRoleAsync
            mgr.Setup(x => x.RemoveFromRoleAsync(It.IsAny<User>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);

            // Giả lập phương thức GetRolesAsync
            mgr.Setup(x => x.GetRolesAsync(It.IsAny<User>()))
                .ReturnsAsync(new List<string>());

            return mgr.Object;
        }

        #region Test CreateUserAsync

        /// <summary>
        /// Test 1: Kiểm tra tạo người dùng hợp lệ thành công
        /// </summary>
        [Test]
        public async Task CreateUserAsync_ValidUser_ReturnsCreatedUser()
        {
            // Arrange - Chuẩn bị dữ liệu test
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                UserName = "john.doe",
                Status = "true",
                IsConfirmedEmail = false,
                CreatedAt = DateTime.Now
            };
            string password = "Password123!";

            // Act - Thực hiện hành động cần test
            var result = await _service.CreateUserAsync(user, password);

            // Assert - Kiểm tra kết quả
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(user.Id));
            Assert.That(result.FirstName, Is.EqualTo("John"));
            Assert.That(result.LastName, Is.EqualTo("Doe"));
            Assert.That(result.Email, Is.EqualTo("john.doe@example.com"));
            Assert.That(result.Status, Is.EqualTo("true"));
            Assert.That(result.IsConfirmedEmail, Is.False);

            // Kiểm tra người dùng đã được lưu vào database
            var savedUser = await _context.Users.FindAsync(result.Id);
            Assert.That(savedUser, Is.Not.Null);
            Assert.That(savedUser.FirstName, Is.EqualTo("John"));
            Assert.That(savedUser.Email, Is.EqualTo("john.doe@example.com"));
        }

        /// <summary>
        /// Test 2: Kiểm tra tạo người dùng khi UserManager trả về lỗi
        /// </summary>
        [Test]
        public void CreateUserAsync_UserManagerFails_ThrowsException()
        {
            // Arrange
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Invalid",
                LastName = "User",
                Email = "invalid.user@example.com",
                UserName = "invalid.user"
            };
            string password = "Password123!";

            // Thiết lập UserManager trả về lỗi
            var store = new Mock<IUserStore<User>>();
            var mgr = new Mock<UserManager<User>>(
                store.Object, null, null, null, null, null, null, null, null);
            mgr.Setup(x => x.CreateAsync(It.IsAny<User>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Failed(new IdentityError { Description = "Tạo người dùng thất bại" }));

            var serviceWithFailingManager = new UserService(mgr.Object, _context);

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(async () =>
                await serviceWithFailingManager.CreateUserAsync(user, password));
            Assert.That(exception.Message, Contains.Substring("Tạo người dùng thất bại"));
        }

        /// <summary>
        /// Test 3: Kiểm tra tạo người dùng với thông tin đầy đủ
        /// </summary>
        [Test]
        public async Task CreateUserAsync_UserWithFullInfo_ReturnsCreatedUser()
        {
            // Arrange
            var now = DateTime.Now;
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Alice",
                LastName = "Johnson",
                Email = "alice.johnson@example.com",
                UserName = "alice.johnson",
                Status = "true",
                IsConfirmedEmail = true,
                CreatedAt = now,
                UpdatedAt = now,
                ProfilePicture = "profile.jpg"
            };
            string password = "StrongPass1!";

            // Act
            var result = await _service.CreateUserAsync(user, password);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ProfilePicture, Is.EqualTo("profile.jpg"));
            Assert.That(result.CreatedAt.Date, Is.EqualTo(now.Date));

            // Kiểm tra người dùng đã được lưu vào database
            var savedUser = await _context.Users.FindAsync(result.Id);
            Assert.That(savedUser, Is.Not.Null);
            Assert.That(savedUser.ProfilePicture, Is.EqualTo("profile.jpg"));
        }

        /// <summary>
        /// Test 4: Kiểm tra tạo người dùng với Status là "false"
        /// </summary>
        [Test]
        public async Task CreateUserAsync_InactiveUser_ReturnsCreatedInactiveUser()
        {
            // Arrange
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Bob",
                LastName = "Smith",
                Email = "bob.smith@example.com",
                UserName = "bob.smith",
                Status = "false",
                IsConfirmedEmail = false,
                CreatedAt = DateTime.Now
            };
            string password = "Password123!";

            // Act
            var result = await _service.CreateUserAsync(user, password);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Status, Is.EqualTo("false"));

            // Kiểm tra người dùng đã được lưu vào database
            var savedUser = await _context.Users.FindAsync(result.Id);
            Assert.That(savedUser, Is.Not.Null);
            Assert.That(savedUser.Status, Is.EqualTo("false"));
        }

        /// <summary>
        /// Test 5: Kiểm tra tạo người dùng với IsConfirmedEmail là true
        /// </summary>
        [Test]
        public async Task CreateUserAsync_ConfirmedEmailUser_ReturnsCreatedUserWithConfirmedEmail()
        {
            // Arrange
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Charlie",
                LastName = "Brown",
                Email = "charlie.brown@example.com",
                UserName = "charlie.brown",
                Status = "true",
                IsConfirmedEmail = true,
                CreatedAt = DateTime.Now
            };
            string password = "Password123!";

            // Act
            var result = await _service.CreateUserAsync(user, password);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.IsConfirmedEmail, Is.True);

            // Kiểm tra người dùng đã được lưu vào database
            var savedUser = await _context.Users.FindAsync(result.Id);
            Assert.That(savedUser, Is.Not.Null);
            Assert.That(savedUser.IsConfirmedEmail, Is.True);
        }

        #endregion

        #region Test GetAllAsync

        /// <summary>
        /// Test 6: Kiểm tra lấy tất cả người dùng khi có nhiều người dùng
        /// </summary>
        [Test]
        public async Task GetAllUsersAsync_ReturnsAllUsers()
        {
            // Arrange - Xóa người dùng cũ và thêm mới
            await ClearUsers();

            var users = new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    UserName = "john.doe",
                    Status = "true",
                    CreatedAt = DateTime.Now
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    UserName = "jane.smith",
                    Status = "true",
                    CreatedAt = DateTime.Now
                }
            };

            foreach (var user in users)
            {
                await _service.CreateUserAsync(user, "Password123!");
            }

            // Act - Lấy tất cả người dùng
            var result = await _service.GetAllAsync();

            // Assert - Kiểm tra kết quả
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result.Any(u => u.FirstName == "John" && u.Email == "john.doe@example.com" && u.Status == "true"), Is.True);
            Assert.That(result.Any(u => u.FirstName == "Jane" && u.Email == "jane.smith@example.com" && u.Status == "true"), Is.True);
        }

        /// <summary>
        /// Test 7: Kiểm tra lấy tất cả người dùng khi database trống
        /// </summary>
        [Test]
        public async Task GetAllUsersAsync_EmptyDatabase_ReturnsEmptyList()
        {
            // Arrange - Xóa tất cả người dùng
            await ClearUsers();

            // Act - Lấy tất cả người dùng
            var result = await _service.GetAllAsync();

            // Assert - Kiểm tra kết quả là danh sách rỗng
            Assert.That(result, Is.Empty);
        }

        /// <summary>
        /// Test 8: Kiểm tra lấy tất cả người dùng với các trạng thái khác nhau
        /// </summary>
        [Test]
        public async Task GetAllUsersAsync_MixedStatusUsers_ReturnsAllUsers()
        {
            // Arrange - Xóa người dùng cũ và thêm mới với trạng thái khác nhau
            await ClearUsers();

            var users = new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Active",
                    LastName = "User",
                    Email = "active@example.com",
                    UserName = "active.user",
                    Status = "true",
                    CreatedAt = DateTime.Now
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Inactive",
                    LastName = "User",
                    Email = "inactive@example.com",
                    UserName = "inactive.user",
                    Status = "false",
                    CreatedAt = DateTime.Now
                }
            };

            foreach (var user in users)
            {
                await _service.CreateUserAsync(user, "Password123!");
            }

            // Act - Lấy tất cả người dùng
            var result = await _service.GetAllAsync();

            // Assert - Kiểm tra kết quả bao gồm cả người dùng active và inactive
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result.Any(u => u.FirstName == "Active" && u.Status == "true"), Is.True);
            Assert.That(result.Any(u => u.FirstName == "Inactive" && u.Status == "false"), Is.True);
        }

        /// <summary>
        /// Test 9: Kiểm tra lấy tất cả người dùng với nhiều người dùng (10+)
        /// </summary>
        [Test]
        public async Task GetAllUsersAsync_ManyUsers_ReturnsAllUsers()
        {
            // Arrange - Xóa người dùng cũ và thêm nhiều người dùng mới (12)
            await ClearUsers();

            var users = new List<User>();
            for (int i = 0; i < 12; i++)
            {
                users.Add(new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = $"User{i}",
                    LastName = $"Last{i}",
                    Email = $"user{i}@example.com",
                    UserName = $"user{i}",
                    Status = i % 2 == 0 ? "true" : "false", // Xen kẽ active/inactive
                    CreatedAt = DateTime.Now
                });
            }

            foreach (var user in users)
            {
                await _service.CreateUserAsync(user, "Password123!");
            }

            // Act - Lấy tất cả người dùng
            var result = await _service.GetAllAsync();

            // Assert - Kiểm tra kết quả
            Assert.That(result.Count, Is.EqualTo(12));
            // Kiểm tra số lượng người dùng active và inactive
            Assert.That(result.Count(u => u.Status == "true"), Is.EqualTo(6));
            Assert.That(result.Count(u => u.Status == "false"), Is.EqualTo(6));
        }

        #endregion

        #region Test GetByIdAsync

        /// <summary>
        /// Test 10: Kiểm tra lấy người dùng theo ID khi tồn tại
        /// </summary>
        [Test]
        public async Task GetUserByIdAsync_ExistingId_ReturnsUser()
        {
            // Arrange - Xóa người dùng cũ và tạo mới
            await ClearUsers();

            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                UserName = "john.doe",
                Status = "true",
                IsConfirmedEmail = true,
                CreatedAt = DateTime.Now
            };

            await _service.CreateUserAsync(user, "Password123!");
            var userId = user.Id;

            // Act - Lấy người dùng theo ID
            var result = await _service.GetByIdAsync(userId);

            // Assert - Kiểm tra kết quả
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(userId));
            Assert.That(result.FirstName, Is.EqualTo("John"));
            Assert.That(result.LastName, Is.EqualTo("Doe"));
            Assert.That(result.Email, Is.EqualTo("john.doe@example.com"));
            Assert.That(result.IsConfirmedEmail, Is.True);
            Assert.That(result.Status, Is.EqualTo("true"));
        }

        /// <summary>
        /// Test 11: Kiểm tra lấy người dùng theo ID không tồn tại
        /// </summary>
        [Test]
        public void GetUserByIdAsync_NonExistingId_ThrowsException()
        {
            // Arrange - ID không tồn tại
            var nonExistingId = Guid.NewGuid();

            // Act & Assert - Kiểm tra ném ra ngoại lệ với thông báo phù hợp
            var exception = Assert.ThrowsAsync<Exception>(async () => await _service.GetByIdAsync(nonExistingId));
            Assert.That(exception.Message, Is.EqualTo("Không tìm thấy người dùng."));
        }

        /// <summary>
        /// Test 12: Kiểm tra lấy người dùng không hoạt động theo ID
        /// </summary>
        [Test]
        public async Task GetUserByIdAsync_InactiveUser_ReturnsInactiveUser()
        {
            // Arrange - Tạo người dùng không hoạt động
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Inactive",
                LastName = "User",
                Email = "inactive@example.com",
                UserName = "inactive.user",
                Status = "false",
                IsConfirmedEmail = false,
                CreatedAt = DateTime.Now
            };

            await _service.CreateUserAsync(user, "Password123!");
            var userId = user.Id;

            // Act - Lấy người dùng theo ID
            var result = await _service.GetByIdAsync(userId);

            // Assert - Kiểm tra kết quả
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Status, Is.EqualTo("false"));
            Assert.That(result.FirstName, Is.EqualTo("Inactive"));
        }

        /// <summary>
        /// Test 13: Kiểm tra lấy nhiều người dùng theo ID liên tiếp
        /// </summary>
        [Test]
        public async Task GetUserByIdAsync_MultipleConsecutiveCalls_ReturnsCorrectUsers()
        {
            // Arrange - Tạo nhiều người dùng
            await ClearUsers();

            var user1 = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "User1",
                LastName = "Test",
                Email = "user1@example.com",
                UserName = "user1",
                Status = "true",
                CreatedAt = DateTime.Now
            };

            var user2 = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "User2",
                LastName = "Test",
                Email = "user2@example.com",
                UserName = "user2",
                Status = "true",
                CreatedAt = DateTime.Now
            };

            await _service.CreateUserAsync(user1, "Password123!");
            await _service.CreateUserAsync(user2, "Password123!");

            // Act & Assert - Lấy người dùng liên tiếp và kiểm tra
            var result1 = await _service.GetByIdAsync(user1.Id);
            Assert.That(result1.FirstName, Is.EqualTo("User1"));
            Assert.That(result1.Email, Is.EqualTo("user1@example.com"));

            var result2 = await _service.GetByIdAsync(user2.Id);
            Assert.That(result2.FirstName, Is.EqualTo("User2"));
            Assert.That(result2.Email, Is.EqualTo("user2@example.com"));
        }

        #endregion

        #region Test UpdateAsync

        /// <summary>
        /// Test 14: Kiểm tra cập nhật người dùng hợp lệ
        /// </summary>
        [Test]
        public async Task UpdateUserAsync_ExistingUser_ReturnsUpdatedUser()
        {
            // Arrange - Tạo người dùng
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                UserName = "john.doe",
                Status = "true",
                CreatedAt = DateTime.Now
            };

            await _service.CreateUserAsync(user, "Password123!");
            var userId = user.Id;

            // Chuẩn bị dữ liệu cập nhật
            var updatedUser = new User
            {
                Id = userId,
                FirstName = "Johnny",
                LastName = "DoeUpdated",
                Email = "johnny.doe@example.com",
                UserName = "john.doe",
                Status = "false",
                IsConfirmedEmail = true
            };

            // Act - Cập nhật người dùng
            var result = await _service.UpdateAsync(updatedUser);

            // Assert - Kiểm tra kết quả
            Assert.That(result, Is.Not.Null);
            Assert.That(result.FirstName, Is.EqualTo("Johnny"));
            Assert.That(result.LastName, Is.EqualTo("DoeUpdated"));
            Assert.That(result.Email, Is.EqualTo("johnny.doe@example.com"));
            Assert.That(result.Status, Is.EqualTo("false"));
            Assert.That(result.IsConfirmedEmail, Is.True);

            // Kiểm tra người dùng đã được cập nhật trong database
            var savedUser = await _context.Users.FindAsync(userId);
            Assert.That(savedUser.FirstName, Is.EqualTo("Johnny"));
            Assert.That(savedUser.Email, Is.EqualTo("johnny.doe@example.com"));

            // Fix for NUnit2023 error - check if UpdatedAt is not default DateTime value instead of null
            Assert.That(savedUser.UpdatedAt, Is.Not.EqualTo(default(DateTime)));
        }

        /// <summary>
        /// Test 15: Kiểm tra cập nhật người dùng không tồn tại
        /// </summary>
        [Test]
        public void UpdateUserAsync_NonExistingUser_ThrowsException()
        {
            // Arrange - Chuẩn bị dữ liệu người dùng không tồn tại
            var nonExistingId = Guid.NewGuid();
            var updatedUser = new User
            {
                Id = nonExistingId,
                FirstName = "NonExisting",
                LastName = "User",
                Email = "nonexisting@example.com",
                UserName = "nonexisting.user"
            };

            // Act & Assert - Kiểm tra ném ra ngoại lệ với thông báo phù hợp
            var exception = Assert.ThrowsAsync<Exception>(async () => await _service.UpdateAsync(updatedUser));
            Assert.That(exception.Message, Is.EqualTo("Không tìm thấy người dùng."));
        }

        /// <summary>
        /// Test 16: Kiểm tra cập nhật khi UserManager trả về lỗi
        /// </summary>
        [Test]
        public async Task UpdateUserAsync_UserManagerFails_ThrowsException()
        {
            // Arrange - Tạo người dùng
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Update",
                LastName = "Fail",
                Email = "update.fail@example.com",
                UserName = "update.fail",
                Status = "true",
                CreatedAt = DateTime.Now
            };

            await _service.CreateUserAsync(user, "Password123!");

            // Thiết lập UserManager mới để trả về lỗi
            var store = new Mock<IUserStore<User>>();
            var mgr = new Mock<UserManager<User>>(
                store.Object, null, null, null, null, null, null, null, null);
            mgr.Setup(x => x.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(user);
            mgr.Setup(x => x.UpdateAsync(It.IsAny<User>()))
                .ReturnsAsync(IdentityResult.Failed(new IdentityError { Description = "Cập nhật thất bại" }));

            var serviceWithFailingManager = new UserService(mgr.Object, _context);

            // Act & Assert - Kiểm tra ném ra ngoại lệ
            var exception = Assert.ThrowsAsync<Exception>(async () => await serviceWithFailingManager.UpdateAsync(user));
            Assert.That(exception.Message, Contains.Substring("Cập nhật thất bại"));
        }

        /// <summary>
        /// Test 17: Kiểm tra cập nhật ảnh hồ sơ người dùng
        /// </summary>
        [Test]
        public async Task UpdateUserAsync_ChangeProfilePicture_ReturnsUpdatedUser()
        {
            // Arrange - Tạo người dùng ban đầu không có ảnh hồ sơ
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Profile",
                LastName = "Test",
                Email = "profile.test@example.com",
                UserName = "profile.test",
                Status = "true",
                CreatedAt = DateTime.Now
            };

            await _service.CreateUserAsync(user, "Password123!");

            // Cập nhật với ảnh hồ sơ mới
            var updatedUser = new User
            {
                Id = user.Id,
                FirstName = "Profile",
                LastName = "Test",
                Email = "profile.test@example.com",
                UserName = "profile.test",
                Status = "true",
                ProfilePicture = "new_profile_picture.jpg"
            };

            // Act - Cập nhật người dùng
            var result = await _service.UpdateAsync(updatedUser);

            // Assert - Kiểm tra kết quả
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ProfilePicture, Is.EqualTo("new_profile_picture.jpg"));

            // Kiểm tra trong database
            var savedUser = await _context.Users.FindAsync(user.Id);
            Assert.That(savedUser.ProfilePicture, Is.EqualTo("new_profile_picture.jpg"));
        }

        /// <summary>
        /// Test 18: Kiểm tra cập nhật trạng thái xác nhận email
        /// </summary>
        [Test]
        public async Task UpdateUserAsync_ChangeEmailConfirmation_ReturnsUpdatedUser()
        {
            // Arrange - Tạo người dùng với email chưa xác nhận
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Email",
                LastName = "Confirmation",
                Email = "email.confirm@example.com",
                UserName = "email.confirm",
                Status = "true",
                IsConfirmedEmail = false,
                CreatedAt = DateTime.Now
            };

            await _service.CreateUserAsync(user, "Password123!");

            // Cập nhật trạng thái xác nhận email
            var updatedUser = new User
            {
                Id = user.Id,
                FirstName = "Email",
                LastName = "Confirmation",
                Email = "email.confirm@example.com",
                UserName = "email.confirm",
                Status = "true",
                IsConfirmedEmail = true
            };

            // Act - Cập nhật người dùng
            var result = await _service.UpdateAsync(updatedUser);

            // Assert - Kiểm tra kết quả
            Assert.That(result, Is.Not.Null);
            Assert.That(result.IsConfirmedEmail, Is.True);

            // Kiểm tra trong database
            var savedUser = await _context.Users.FindAsync(user.Id);
            Assert.That(savedUser.IsConfirmedEmail, Is.True);
        }

        /// <summary>
        /// Test 19: Kiểm tra cập nhật trạng thái người dùng từ active sang inactive
        /// </summary>
        [Test]
        public async Task UpdateUserAsync_ChangeStatusFromActiveToInactive_ReturnsUpdatedUser()
        {
            // Arrange - Tạo người dùng active
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Status",
                LastName = "Change",
                Email = "status.change@example.com",
                UserName = "status.change",
                Status = "true",
                CreatedAt = DateTime.Now
            };

            await _service.CreateUserAsync(user, "Password123!");

            // Cập nhật trạng thái thành inactive
            var updatedUser = new User
            {
                Id = user.Id,
                FirstName = "Status",
                LastName = "Change",
                Email = "status.change@example.com",
                UserName = "status.change",
                Status = "false"
            };

            // Act - Cập nhật người dùng
            var result = await _service.UpdateAsync(updatedUser);

            // Assert - Kiểm tra kết quả
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Status, Is.EqualTo("false"));

            // Kiểm tra trong database
            var savedUser = await _context.Users.FindAsync(user.Id);
            Assert.That(savedUser.Status, Is.EqualTo("false"));
        }

        /// <summary>
        /// Test 20: Kiểm tra cập nhật đồng thời nhiều thông tin người dùng
        /// </summary>
        [Test]
        public async Task UpdateUserAsync_UpdateMultipleFields_ReturnsFullyUpdatedUser()
        {
            // Arrange - Tạo người dùng
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Original",
                LastName = "User",
                Email = "original@example.com",
                UserName = "original.user",
                Status = "true",
                IsConfirmedEmail = false,
                CreatedAt = DateTime.Now
            };

            await _service.CreateUserAsync(user, "Password123!");

            // Cập nhật nhiều thông tin cùng lúc
            var updatedUser = new User
            {
                Id = user.Id,
                FirstName = "Updated",
                LastName = "Completely",
                Email = "updated@example.com",
                UserName = "original.user", // UserName không thay đổi
                Status = "false",
                IsConfirmedEmail = true,
                ProfilePicture = "complete_update.jpg"
            };

            // Act - Cập nhật người dùng
            var result = await _service.UpdateAsync(updatedUser);

            // Assert - Kiểm tra kết quả
            Assert.That(result, Is.Not.Null);
            Assert.That(result.FirstName, Is.EqualTo("Updated"));
            Assert.That(result.LastName, Is.EqualTo("Completely"));
            Assert.That(result.Email, Is.EqualTo("updated@example.com"));
            Assert.That(result.Status, Is.EqualTo("false"));
            Assert.That(result.IsConfirmedEmail, Is.True);
            Assert.That(result.ProfilePicture, Is.EqualTo("complete_update.jpg"));

            // Kiểm tra trong database
            var savedUser = await _context.Users.FindAsync(user.Id);
            Assert.That(savedUser.FirstName, Is.EqualTo("Updated"));
            Assert.That(savedUser.Email, Is.EqualTo("updated@example.com"));
            Assert.That(savedUser.Status, Is.EqualTo("false"));
        }

        #endregion

        #region Test DeleteAsync

        /// <summary>
        /// Test 21: Kiểm tra xóa người dùng tồn tại
        /// </summary>
        [Test]
        public async Task DeleteUserAsync_ExistingUser_ReturnsTrue()
        {
            // Arrange - Tạo người dùng
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                UserName = "john.doe",
                Status = "true",
                CreatedAt = DateTime.Now
            };

            await _service.CreateUserAsync(user, "Password123!");
            var userId = user.Id;

            // Act - Xóa người dùng
            var result = await _service.DeleteAsync(userId);

            // Assert - Kiểm tra kết quả
            Assert.That(result, Is.True);
            // Kiểm tra người dùng đã bị xóa khỏi database
            var deletedUser = await _context.Users.FindAsync(userId);
            Assert.That(deletedUser, Is.Null);
        }

        /// <summary>
        /// Test 22: Kiểm tra xóa người dùng không tồn tại
        /// </summary>
        [Test]
        public void DeleteUserAsync_NonExistingUser_ThrowsException()
        {
            // Arrange - ID không tồn tại
            var nonExistingId = Guid.NewGuid();

            // Act & Assert - Kiểm tra ném ra ngoại lệ với thông báo phù hợp
            var exception = Assert.ThrowsAsync<Exception>(async () => await _service.DeleteAsync(nonExistingId));
            Assert.That(exception.Message, Is.EqualTo("Không tìm thấy người dùng."));
        }

        /// <summary>
        /// Test 23: Kiểm tra xóa người dùng khi UserManager trả về thất bại
        /// </summary>
        [Test]
        public async Task DeleteUserAsync_UserManagerFails_ReturnsFalse()
        {
            // Arrange - Tạo người dùng
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Delete",
                LastName = "Fail",
                Email = "delete.fail@example.com",
                UserName = "delete.fail",
                Status = "true",
                CreatedAt = DateTime.Now
            };

            await _service.CreateUserAsync(user, "Password123!");

            // Thiết lập UserManager mới để trả về lỗi khi xóa
            var store = new Mock<IUserStore<User>>();
            var mgr = new Mock<UserManager<User>>(
                store.Object, null, null, null, null, null, null, null, null);
            mgr.Setup(x => x.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(user);
            mgr.Setup(x => x.DeleteAsync(It.IsAny<User>()))
                .ReturnsAsync(IdentityResult.Failed(new IdentityError { Description = "Xóa thất bại" }));

            var serviceWithFailingManager = new UserService(mgr.Object, _context);

            // Act - Xóa người dùng
            var result = await serviceWithFailingManager.DeleteAsync(user.Id);

            // Assert - Kết quả là false vì xóa thất bại
            Assert.That(result, Is.False);
        }

        /// <summary>
        /// Test 24: Kiểm tra xóa nhiều người dùng liên tiếp
        /// </summary>
        [Test]
        public async Task DeleteUserAsync_DeleteMultipleUsers_AllUsersDeleted()
        {
            // Arrange - Tạo nhiều người dùng
            await ClearUsers();

            var users = new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "User1",
                    LastName = "ToDelete",
                    Email = "user1.delete@example.com",
                    UserName = "user1.delete",
                    Status = "true",
                    CreatedAt = DateTime.Now
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "User2",
                    LastName = "ToDelete",
                    Email = "user2.delete@example.com",
                    UserName = "user2.delete",
                    Status = "true",
                    CreatedAt = DateTime.Now
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "User3",
                    LastName = "ToDelete",
                    Email = "user3.delete@example.com",
                    UserName = "user3.delete",
                    Status = "true",
                    CreatedAt = DateTime.Now
                }
            };

            foreach (var user in users)
            {
                await _service.CreateUserAsync(user, "Password123!");
            }

            // Act - Xóa lần lượt từng người dùng
            var results = new List<bool>();
            foreach (var user in users)
            {
                results.Add(await _service.DeleteAsync(user.Id));
            }

            // Assert - Kiểm tra kết quả xóa
            Assert.That(results.All(r => r), Is.True); // Tất cả đều trả về true

            // Kiểm tra database không còn người dùng nào
            var remainingUsers = await _service.GetAllAsync();
            Assert.That(remainingUsers, Is.Empty);
        }

        /// <summary>
        /// Test 25: Kiểm tra xóa người dùng và sau đó thử lấy về theo ID
        /// </summary>
        [Test]
        public async Task DeleteUserAsync_GetDeletedUserById_ThrowsException()
        {
            // Arrange - Tạo người dùng
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Delete",
                LastName = "Then Get",
                Email = "delete.get@example.com",
                UserName = "delete.get",
                Status = "true",
                CreatedAt = DateTime.Now
            };

            await _service.CreateUserAsync(user, "Password123!");
            var userId = user.Id;

            // Act - Xóa người dùng
            var deleteResult = await _service.DeleteAsync(userId);
            Assert.That(deleteResult, Is.True);

            // Assert - Thử lấy người dùng đã xóa sẽ ném ra ngoại lệ
            var exception = Assert.ThrowsAsync<Exception>(async () => await _service.GetByIdAsync(userId));
            Assert.That(exception.Message, Is.EqualTo("Không tìm thấy người dùng."));
        }

        #endregion

        #region Các Test Case Nâng Cao và Tình Huống Đặc Biệt

        /// <summary>
        /// Test 26: Kiểm tra tạo người dùng với email đã tồn tại (mô phỏng lỗi từ UserManager)
        /// </summary>
        [Test]
        public async Task CreateUserAsync_DuplicateEmail_ThrowsException()
        {
            // Arrange - Tạo người dùng đầu tiên
            var user1 = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "First",
                LastName = "User",
                Email = "duplicate@example.com",
                UserName = "first.user",
                Status = "true",
                CreatedAt = DateTime.Now
            };

            await _service.CreateUserAsync(user1, "Password123!");

            // Tạo người dùng thứ hai với email trùng
            var user2 = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Second",
                LastName = "User",
                Email = "duplicate@example.com", // Email trùng với user1
                UserName = "second.user",
                Status = "true",
                CreatedAt = DateTime.Now
            };

            // Thiết lập UserManager mới để trả về lỗi email trùng
            var store = new Mock<IUserStore<User>>();
            var mgr = new Mock<UserManager<User>>(
                store.Object, null, null, null, null, null, null, null, null);
            mgr.Setup(x => x.CreateAsync(It.IsAny<User>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Failed(new IdentityError { Description = "Email 'duplicate@example.com' đã được sử dụng." }));

            var serviceWithFailingManager = new UserService(mgr.Object, _context);

            // Act & Assert - Kiểm tra ném ra ngoại lệ khi tạo người dùng với email trùng
            var exception = Assert.ThrowsAsync<Exception>(async () =>
                await serviceWithFailingManager.CreateUserAsync(user2, "Password123!"));
            Assert.That(exception.Message, Contains.Substring("Email 'duplicate@example.com' đã được sử dụng."));
        }

        /// <summary>
        /// Test 27: Kiểm tra tính liên tục của dữ liệu - tạo, cập nhật, lấy về và xóa
        /// </summary>
        [Test]
        public async Task DataConsistency_CreateUpdateGetDelete_Success()
        {
            // Arrange - Tạo người dùng mới
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Consistency",
                LastName = "Test",
                Email = "consistency@example.com",
                UserName = "consistency.test",
                Status = "true",
                IsConfirmedEmail = false,
                CreatedAt = DateTime.Now
            };

            // Act 1 - Tạo người dùng
            var createdUser = await _service.CreateUserAsync(user, "Password123!");
            Assert.That(createdUser, Is.Not.Null);
            Assert.That(createdUser.Email, Is.EqualTo("consistency@example.com"));

            // Act 2 - Cập nhật người dùng
            var updatedUserData = new User
            {
                Id = user.Id,
                FirstName = "Updated",
                LastName = "Consistency",
                Email = "updated.consistency@example.com",
                UserName = "consistency.test",
                Status = "true",
                IsConfirmedEmail = true,
                ProfilePicture = "consistency.jpg"
            };

            var updatedUser = await _service.UpdateAsync(updatedUserData);
            Assert.That(updatedUser, Is.Not.Null);
            Assert.That(updatedUser.Email, Is.EqualTo("updated.consistency@example.com"));
            Assert.That(updatedUser.ProfilePicture, Is.EqualTo("consistency.jpg"));

            // Act 3 - Lấy về người dùng
            var retrievedUser = await _service.GetByIdAsync(user.Id);
            Assert.That(retrievedUser, Is.Not.Null);
            Assert.That(retrievedUser.FirstName, Is.EqualTo("Updated"));
            Assert.That(retrievedUser.Email, Is.EqualTo("updated.consistency@example.com"));

            // Act 4 - Xóa người dùng
            var deleteResult = await _service.DeleteAsync(user.Id);
            Assert.That(deleteResult, Is.True);

            // Kiểm tra người dùng đã bị xóa
            var allUsers = await _service.GetAllAsync();
            Assert.That(allUsers.Any(u => u.Id == user.Id), Is.False);
        }

        /// <summary>
        /// Test 28: Kiểm tra việc cập nhật các trường không được định nghĩa trong phương thức UpdateAsync
        /// </summary>
        [Test]
        public async Task UpdateUserAsync_NonUpdatableFields_FieldsRemainUnchanged()
        {
            // Arrange - Tạo người dùng với CreatedAt cố định
            var creationTime = new DateTime(2023, 1, 1, 12, 0, 0);
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Field",
                LastName = "Test",
                Email = "field.test@example.com",
                UserName = "field.test",
                Status = "true",
                CreatedAt = creationTime
            };

            await _service.CreateUserAsync(user, "Password123!");

            // Act - Cập nhật người dùng với các trường thay đổi
            var updatedUser = new User
            {
                Id = user.Id,
                FirstName = "Updated",
                LastName = "Field",
                Email = "updated.field@example.com",
                UserName = "new.username", // Không nên được cập nhật theo phương thức UpdateAsync
                Status = "false",
                CreatedAt = DateTime.Now, // Không nên được cập nhật theo phương thức UpdateAsync
                IsConfirmedEmail = true
            };

            var result = await _service.UpdateAsync(updatedUser);

            // Assert - Kiểm tra kết quả
            // Trường Username không nên thay đổi vì không có trong code UpdateAsync
            var retrievedUser = await _context.Users.FindAsync(user.Id);
            Assert.That(retrievedUser.UserName, Is.EqualTo("field.test")); // UserName không thay đổi
            Assert.That(retrievedUser.CreatedAt, Is.EqualTo(creationTime)); // CreatedAt không thay đổi

            // Trong khi các trường khác đã được cập nhật
            Assert.That(retrievedUser.FirstName, Is.EqualTo("Updated"));
            Assert.That(retrievedUser.Email, Is.EqualTo("updated.field@example.com"));
        }

        /// <summary>
        /// Test 29: Kiểm tra việc tạo người dùng với mật khẩu yếu (mô phỏng lỗi từ UserManager)
        /// </summary>
        [Test]
        public void CreateUserAsync_WeakPassword_ThrowsException()
        {
            // Arrange - Tạo người dùng
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Weak",
                LastName = "Password",
                Email = "weak.password@example.com",
                UserName = "weak.password",
                Status = "true"
            };
            string weakPassword = "123"; // Mật khẩu quá yếu

            // Thiết lập UserManager mới để trả về lỗi mật khẩu yếu
            var store = new Mock<IUserStore<User>>();
            var mgr = new Mock<UserManager<User>>(
                store.Object, null, null, null, null, null, null, null, null);
            mgr.Setup(x => x.CreateAsync(It.IsAny<User>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Failed(new IdentityError { Description = "Mật khẩu phải có ít nhất 6 ký tự." }));

            var serviceWithFailingManager = new UserService(mgr.Object, _context);

            // Act & Assert - Kiểm tra ném ra ngoại lệ khi tạo người dùng với mật khẩu yếu
            var exception = Assert.ThrowsAsync<Exception>(async () =>
                await serviceWithFailingManager.CreateUserAsync(user, weakPassword));
            Assert.That(exception.Message, Contains.Substring("Mật khẩu phải có ít nhất 6 ký tự."));
        }

        /// <summary>
        /// Test 30: Kiểm tra khả năng xử lý nhiều người dùng cùng lúc
        /// </summary>
        [Test]
        public async Task UserService_HandleManyUsers_SuccessfulOperations()
        {
            // Arrange - Xóa người dùng cũ
            await ClearUsers();

            // Tạo 50 người dùng
            var users = new List<User>();
            for (int i = 0; i < 50; i++)
            {
                users.Add(new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = $"BulkUser{i}",
                    LastName = $"Test{i}",
                    Email = $"bulk.user{i}@example.com",
                    UserName = $"bulk.user{i}",
                    Status = i % 2 == 0 ? "true" : "false",
                    CreatedAt = DateTime.Now
                });
            }

            // Act 1 - Tạo nhiều người dùng
            foreach (var user in users)
            {
                await _service.CreateUserAsync(user, "Password123!");
            }

            // Assert 1 - Kiểm tra số lượng người dùng
            var allUsers = await _service.GetAllAsync();
            Assert.That(allUsers.Count, Is.EqualTo(50));

            // Act 2 & Assert 2 - Lấy và kiểm tra từng người dùng
            foreach (var user in users)
            {
                var retrievedUser = await _service.GetByIdAsync(user.Id);
                Assert.That(retrievedUser, Is.Not.Null);
                Assert.That(retrievedUser.Email, Is.EqualTo(user.Email));
            }

            // Act 3 & Assert 3 - Cập nhật và kiểm tra một số người dùng
            for (int i = 0; i < 10; i++)
            {
                var userToUpdate = users[i];
                var updatedData = new User
                {
                    Id = userToUpdate.Id,
                    FirstName = $"Updated{i}",
                    LastName = $"BulkTest{i}",
                    Email = userToUpdate.Email,
                    UserName = userToUpdate.UserName,
                    Status = userToUpdate.Status,
                    IsConfirmedEmail = true
                };

                var updatedUser = await _service.UpdateAsync(updatedData);
                Assert.That(updatedUser.FirstName, Is.EqualTo($"Updated{i}"));
            }

            // Act 4 & Assert 4 - Xóa và kiểm tra một số người dùng
            for (int i = 40; i < 50; i++)
            {
                var deleteResult = await _service.DeleteAsync(users[i].Id);
                Assert.That(deleteResult, Is.True);
            }

            // Kiểm tra số lượng người dùng còn lại
            allUsers = await _service.GetAllAsync();
            Assert.That(allUsers.Count, Is.EqualTo(40));
        }

        #endregion
    }
}