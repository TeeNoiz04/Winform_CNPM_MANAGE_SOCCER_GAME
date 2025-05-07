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
    public class TournamentServiceTests
    {
        private DbContextOptions<ManageSoccerGame> _options;
        private ManageSoccerGame _context;
        private TournamentService _service;

        [SetUp]
        public void Setup()
        {
            // Thiết lập cơ sở dữ liệu in-memory cho mỗi test
            _options = new DbContextOptionsBuilder<ManageSoccerGame>()
                .UseInMemoryDatabase(databaseName: $"TestDb_{Guid.NewGuid()}")
                .EnableSensitiveDataLogging()
                .Options;

            _context = new ManageSoccerGame(_options);
            _service = new TournamentService(_context);
        }

        [TearDown]
        public void TearDown()
        {
            // Dọn dẹp cơ sở dữ liệu sau mỗi test
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        // ### Test cases cho GetAllTournamentsAsync ###
        [Test]
        public async Task GetAllTournamentsAsync_KhiKhongCoTournament_TraVeDanhSachRong()
        {
            // Arrange: Không có dữ liệu trong DB

            // Act: Gọi phương thức lấy tất cả giải đấu
            var result = await _service.GetAllTournamentsAsync();

            // Assert: Kiểm tra danh sách trả về rỗng
            Assert.That(result, Is.Empty, "Danh sách phải rỗng khi không có giải đấu.");
        }

        [Test]
        public async Task GetTournamentByIdAsync_KhiIdKhongTonTai_TraVeNull()
        {
            // Act
            var result = await _service.GetTournamentByIdAsync(Guid.NewGuid());

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetTournamentByIdAsync_KhiIdLaGuidEmpty_TraVeNull()
        {
            // Act
            var result = await _service.GetTournamentByIdAsync(Guid.Empty);

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task UpdateTournamentAsync_KhiTournamentKhongTonTai_TraVeFalse()
        {
            // Arrange: Giải đấu không tồn tại
            var tournament = new Tournament
            {
                Id = Guid.NewGuid(),
                Name = "Tournament",
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(10)
            };

            // Act
            var result = await _service.UpdateTournamentAsync(tournament);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task DeleteTournamentAsync_KhiTournamentKhongTonTai_TraVeFalse()
        {
            // Act
            var result = await _service.DeleteTournamentAsync(Guid.NewGuid());

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task DeleteTournamentAsync_KhiIdLaGuidEmpty_TraVeFalse()
        {
            // Act
            var result = await _service.DeleteTournamentAsync(Guid.Empty);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task TournamentExistsAsync_KhiTournamentKhongTonTai_TraVeFalse()
        {
            // Act
            var result = await _service.TournamentExistsAsync(Guid.NewGuid());

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task TournamentExistsAsync_KhiIdLaGuidEmpty_TraVeFalse()
        {
            // Act
            var result = await _service.TournamentExistsAsync(Guid.Empty);

            // Assert
            Assert.That(result, Is.False);
        }
    }
}