using NUnit.Framework;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using MANAGE_SOCCER_GAME.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MANAGE_SOCCER_GAME.Tests
{
    [TestFixture]
    public class CoachServiceTests
    {
        private DbContextOptions<ManageSoccerGame> _options;
        private ManageSoccerGame _context;
        private CoachService _service;

        [SetUp]
        public void Setup()
        {
            // Thiết lập cơ sở dữ liệu in-memory cho mỗi test, đảm bảo không bị xung đột
            _options = new DbContextOptionsBuilder<ManageSoccerGame>()
                .UseInMemoryDatabase(databaseName: $"TestDb_{Guid.NewGuid()}")
                .EnableSensitiveDataLogging()
                .Options;

            _context = new ManageSoccerGame(_options);
            _service = new CoachService(_context);
        }

        [TearDown]
        public void TearDown()
        {
            // Dọn dẹp cơ sở dữ liệu sau mỗi test để tránh dữ liệu thừa
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        // ### Test cases cho GetAllCoachesAsync ###
        [Test]
        public async Task GetAllCoachesAsync_KhiKhongCoCoach_TraVeDanhSachRong()
        {
            // Arrange: Không có dữ liệu trong DB

            // Act: Gọi phương thức lấy tất cả huấn luyện viên
            var result = await _service.GetAllCoachesAsync();

            // Assert: Kiểm tra danh sách trả về rỗng
            Assert.That(result, Is.Empty, "Danh sách phải rỗng khi không có huấn luyện viên.");
        }

        [Test]
        public async Task GetAllCoachesAsync_KhiCoCoach_TraVeDanhSachChuaBiXoa()
        {
            // Arrange: Thêm hai huấn luyện viên, một chưa xóa và một đã xóa
            var coaches = new List<Coach>
            {
                new Coach { Id = Guid.NewGuid(), Name = "Coach A", IsDeleted = false, Email = "a@example.com", National = "Vietnam", PhoneNumber = "1234567890" },
                new Coach { Id = Guid.NewGuid(), Name = "Coach B", IsDeleted = true, Email = "b@example.com", National = "USA", PhoneNumber = "0987654321" }
            };
            _context.Coaches.AddRange(coaches);
            await _context.SaveChangesAsync();

            // Act: Lấy danh sách huấn luyện viên
            var result = await _service.GetAllCoachesAsync();

            // Assert: Chỉ có huấn luyện viên chưa xóa được trả về
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result.First().Name, Is.EqualTo("Coach A"));
        }

        [Test]
        public async Task GetAllCoachesAsync_KhiCoNhieuCoach_TraVeDanhSachDung()
        {
            // Arrange: Thêm 5 huấn luyện viên chưa xóa
            var coaches = Enumerable.Range(1, 5).Select(i => new Coach
            {
                Id = Guid.NewGuid(),
                Name = $"Coach {i}",
                IsDeleted = false,
                Email = $"coach{i}@example.com",
                National = "Vietnam",
                PhoneNumber = $"123456789{i}"
            });
            _context.Coaches.AddRange(coaches);
            await _context.SaveChangesAsync();

            // Act: Lấy danh sách
            var result = await _service.GetAllCoachesAsync();

            // Assert: Kiểm tra số lượng huấn luyện viên
            Assert.That(result.Count, Is.EqualTo(5));
        }

        [Test]
        public async Task GetAllCoachesAsync_KhiTatCaDaXoa_TraVeRong()
        {
            // Arrange: Thêm huấn luyện viên đã xóa
            _context.Coaches.Add(new Coach
            {
                Id = Guid.NewGuid(),
                Name = "Coach X",
                IsDeleted = true,
                Email = "x@example.com",
                National = "Vietnam",
                PhoneNumber = "1234567890"
            });
            await _context.SaveChangesAsync();

            // Act: Lấy danh sách
            var result = await _service.GetAllCoachesAsync();

            // Assert: Danh sách rỗng vì tất cả đã xóa
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task GetAllCoachesAsync_KhiCo100Coach_TraVeDungSoLuong()
        {
            // Arrange: Thêm 100 huấn luyện viên chưa xóa
            var coaches = Enumerable.Range(1, 100).Select(i => new Coach
            {
                Id = Guid.NewGuid(),
                Name = $"Coach {i}",
                IsDeleted = false,
                Email = $"coach{i}@example.com",
                National = "Vietnam",
                PhoneNumber = $"123456789{i}"
            });
            _context.Coaches.AddRange(coaches);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.GetAllCoachesAsync();

            // Assert: Kiểm tra số lượng
            Assert.That(result.Count, Is.EqualTo(100));
        }

        // ### Test cases cho GetCoachByIdAsync ###
        [Test]
        public async Task GetCoachByIdAsync_KhiIdTonTai_TraVeCoachDung()
        {
            // Arrange: Thêm huấn luyện viên mẫu
            var coach = new Coach
            {
                Id = Guid.NewGuid(),
                Name = "Coach A",
                IsDeleted = false,
                Email = "a@example.com",
                National = "Vietnam",
                PhoneNumber = "1234567890"
            };
            _context.Coaches.Add(coach);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.GetCoachByIdAsync(coach.Id);

            // Assert: Kiểm tra huấn luyện viên trả về
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Name, Is.EqualTo("Coach A"));
        }

        [Test]
        public async Task GetCoachByIdAsync_KhiIdKhongTonTai_TraVeNull()
        {
            // Act
            var result = await _service.GetCoachByIdAsync(Guid.NewGuid());

            // Assert: Kiểm tra null
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetCoachByIdAsync_KhiIdLaGuidEmpty_TraVeNull()
        {
            // Act
            var result = await _service.GetCoachByIdAsync(Guid.Empty);

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetCoachByIdAsync_KhiCoNhieuCoach_TraVeDungCoach()
        {
            // Arrange: Thêm nhiều huấn luyện viên
            var coach1 = new Coach
            {
                Id = Guid.NewGuid(),
                Name = "Coach 1",
                IsDeleted = false,
                Email = "1@example.com",
                National = "Vietnam",
                PhoneNumber = "1234567891"
            };
            var coach2 = new Coach
            {
                Id = Guid.NewGuid(),
                Name = "Coach 2",
                IsDeleted = false,
                Email = "2@example.com",
                National = "USA",
                PhoneNumber = "1234567892"
            };
            _context.Coaches.AddRange(coach1, coach2);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.GetCoachByIdAsync(coach1.Id);

            // Assert
            Assert.That(result.Name, Is.EqualTo("Coach 1"));
        }

        // ### Test cases cho CreateCoachAsync ###
        [Test]
        public async Task CreateCoachAsync_VoiDuLieuHopLe_TaoThanhCong()
        {
            // Arrange: Tạo huấn luyện viên hợp lệ
            var coach = new Coach
            {
                Name = "Coach New",
                National = "Vietnam",
                ExpYear = 5,
                PhoneNumber = "0123456789",
                Email = "new@example.com"
            };

            // Act
            var result = await _service.CreateCoachAsync(coach);

            // Assert: Kiểm tra huấn luyện viên được tạo
            Assert.That(result.Id, Is.Not.EqualTo(Guid.Empty));
            Assert.That(result.Name, Is.EqualTo("Coach New"));
            Assert.That(result.IsDeleted, Is.False);
        }

        // ### Test cases cho UpdateCoachAsync ###
        [Test]
        public async Task UpdateCoachAsync_KhiDuLieuHopLe_CapNhatThanhCong()
        {
            // Arrange: Thêm huấn luyện viên và cập nhật
            var coach = new Coach
            {
                Id = Guid.NewGuid(),
                Name = "Old",
                IsDeleted = false,
                Email = "old@example.com",
                National = "Vietnam",
                PhoneNumber = "1234567890"
            };
            _context.Coaches.Add(coach);
            await _context.SaveChangesAsync();
            var updatedCoach = new Coach
            {
                Id = coach.Id,
                Name = "New",
                National = "USA",
                ExpYear = 10,
                PhoneNumber = "0987654321",
                Email = "new@example.com"
            };

            // Act
            var result = await _service.UpdateCoachAsync(coach.Id, updatedCoach);

            // Assert
            Assert.That(result.Name, Is.EqualTo("New"));
            Assert.That(result.National, Is.EqualTo("USA"));
        }

        [Test]
        public async Task UpdateCoachAsync_KhiCoachKhongTonTai_TraVeNull()
        {
            // Arrange: Huấn luyện viên không tồn tại
            var coach = new Coach
            {
                Id = Guid.NewGuid(),
                Name = "New",
                Email = "new@example.com",
                National = "Vietnam",
                PhoneNumber = "1234567890"
            };

            // Act
            var result = await _service.UpdateCoachAsync(coach.Id, coach);

            // Assert
            Assert.That(result, Is.Null);
        }


        // ### Test cases cho CoachExistsAsync ###
        [Test]
        public async Task CoachExistsAsync_KhiCoachTonTai_TraVeTrue()
        {
            // Arrange: Thêm huấn luyện viên
            var coach = new Coach
            {
                Id = Guid.NewGuid(),
                Name = "Coach",
                IsDeleted = false,
                Email = "coach@example.com",
                National = "Vietnam",
                PhoneNumber = "1234567890"
            };
            _context.Coaches.Add(coach);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.CoachExistsAsync(coach.Id);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task CoachExistsAsync_KhiCoachKhongTonTai_TraVeFalse()
        {
            // Act
            var result = await _service.CoachExistsAsync(Guid.NewGuid());

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task CoachExistsAsync_KhiIdLaGuidEmpty_TraVeFalse()
        {
            // Act
            var result = await _service.CoachExistsAsync(Guid.Empty);

            // Assert
            Assert.That(result, Is.False);
        }

        // ### Test cases cho DeleteCoachAsync ###
        [Test]
        public async Task DeleteCoachAsync_KhiCoachTonTai_XoaThanhCong()
        {
            // Arrange: Thêm huấn luyện viên
            var coach = new Coach
            {
                Id = Guid.NewGuid(),
                Name = "Coach",
                IsDeleted = false,
                Email = "coach@example.com",
                National = "Vietnam",
                PhoneNumber = "1234567890"
            };
            _context.Coaches.Add(coach);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.DeleteCoachAsync(coach.Id);

            // Assert: Kiểm tra huấn luyện viên đã bị đánh dấu xóa
            Assert.That(result.IsDeleted, Is.True);
        }

        [Test]
        public async Task DeleteCoachAsync_KhiCoachKhongTonTai_TraVeNull()
        {
            // Act
            var result = await _service.DeleteCoachAsync(Guid.NewGuid());

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task DeleteCoachAsync_KhiIdLaGuidEmpty_TraVeNull()
        {
            // Act
            var result = await _service.DeleteCoachAsync(Guid.Empty);

            // Assert
            Assert.That(result, Is.Null);
        }
    }
}