using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace MANAGE_SOCCER_GAME.Tests
{
    [TestFixture]
    public class TeamServiceTests
    {
        private DbContextOptions<ManageSoccerGame> _options; // Database configuration
        private ManageSoccerGame _context; // Database context
        private TeamService _service; // Service being tested

        [SetUp]
        public void Setup()
        {
            // This runs before each test to set up a fresh environment
            // Create a unique in-memory database for each test to avoid conflicts
            _options = new DbContextOptionsBuilder<ManageSoccerGame>()
                .UseInMemoryDatabase(databaseName: $"TestDb_{Guid.NewGuid()}")
                .EnableSensitiveDataLogging() // Helps with debugging
                .Options;

            // Initialize the database context and service
            _context = new ManageSoccerGame(_options);
            _service = new TeamService(_context);
        }

        [TearDown]
        public void TearDown()
        {
            // This runs after each test to clean up
            // Delete the in-memory database and free resources
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        #region CreateTeamAsync Tests

        // Test 1: Checks if creating a valid team works
        [Test]
        public async Task CreateTeamAsync_ValidTeam_ReturnsCreatedTeam()
        {
            // Purpose: Ensure that adding a new team works correctly
            // Arrange: Create a tournament and coach
            var tournamentId = Guid.NewGuid();
            var coachId = Guid.NewGuid();
            _context.Tournaments.Add(new Tournament
            {
                Id = tournamentId,
                Name = "Tournament A",
                Description = "Test Tournament",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(30)
            });
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "John Doe",
                National = "USA",
                ExpYear = 5,
                PhoneNumber = "123-456-7890",
                Email = "john@example.com"
            });
            await _context.SaveChangesAsync();

            var team = new Team
            {
                Name = "Team A",
                Province = "Province A",
                IdTournament = tournamentId,
                IdCoach = coachId
            };

            // Act: Try creating the team
            var result = await _service.CreateTeamAsync(team);

            // Assert: Check that the team was created with correct details
            Assert.That(result, Is.Not.Null, "Team should be created.");
            Assert.That(result.Id, Is.Not.EqualTo(Guid.Empty), "Team should have a new ID.");
            Assert.That(result.Name, Is.EqualTo("Team A"), "Name should match.");
            Assert.That(result.Province, Is.EqualTo("Province A"), "Province should match.");
            Assert.That(result.IdTournament, Is.EqualTo(tournamentId), "Tournament ID should match.");
            Assert.That(result.IdCoach, Is.EqualTo(coachId), "Coach ID should match.");
            Assert.That(result.IsDeleted, Is.False, "Team should not be deleted.");

            // Verify the team is saved in the database
            var savedTeam = await _context.Teams.FindAsync(result.Id);
            Assert.That(savedTeam, Is.Not.Null, "Team should exist in database.");
        }

        #endregion

        #region GetAllTeamAsync Tests

        // Test 7: Checks if getting all teams returns an empty list when none exist
        [Test]
        public async Task GetAllTeamAsync_NoTeams_ReturnsEmptyList()
        {
            // Purpose: Ensure that an empty database returns no teams
            // Arrange: No teams are added

            // Act: Get all teams
            var result = await _service.GetAllTeamAsync();

            // Assert: Check that the result is empty
            Assert.That(result, Is.Empty, "Should return an empty list when no teams exist.");
        }

        #endregion

        #region GetTeamByIdAsync Tests

        // Test 10: Checks if getting a team by non-existent ID returns null
        [Test]
        public async Task GetTeamByIdAsync_NonExistentId_ReturnsNull()
        {
            // Purpose: Ensure that a non-existent team ID returns null
            // Arrange: Use a random ID
            var nonExistentId = Guid.NewGuid();

            // Act: Get the team by ID
            var result = await _service.GetTeamByIdAsync(nonExistentId);

            // Assert: Check that null is returned
            Assert.That(result, Is.Null, "Should return null for non-existent team.");
        }

        #endregion

        #region UpdateTeamAsync Tests

        // Test 14: Checks if updating a non-existent team returns null
        [Test]
        public async Task UpdateTeamAsync_NonExistentTeam_ReturnsNull()
        {
            // Purpose: Ensure that updating a non-existent team returns null
            // Arrange: Create a team object but no database entry
            var updatedTeam = new Team
            {
                Name = "Team A",
                Province = "Province A",
                IdTournament = Guid.NewGuid(),
                IdCoach = Guid.NewGuid()
            };

            // Act: Try to update with a random ID
            var result = await _service.UpdateTeamAsync(Guid.NewGuid(), updatedTeam);

            // Assert: Check that null is returned
            Assert.That(result, Is.Null, "Should return null for non-existent team.");
        }

        #endregion

        #region DeleteTeamAsync Tests

        // Test 18: Checks if deleting a non-existent team returns null
        [Test]
        public async Task DeleteTeamAsync_NonExistentTeam_ReturnsNull()
        {
            // Purpose: Ensure that deleting a non-existent team returns null
            // Arrange: Use a random ID
            var nonExistentId = Guid.NewGuid();

            // Act: Try to delete the team
            var result = await _service.DeleteTeamAsync(nonExistentId);

            // Assert: Check that null is returned
            Assert.That(result, Is.Null, "Should return null for non-existent team.");
        }

        #endregion

        #region TeamExistsAsync Tests

        // Test 25: Checks if checking a non-existent team ID returns false
        [Test]
        public async Task TeamExistsAsync_NonExistentTeamId_ReturnsFalse()
        {
            // Purpose: Ensure that checking a non-existent team ID confirms it doesn’t exist
            // Arrange: No teams added
            var nonExistentId = Guid.NewGuid();

            // Act: Check if the team exists
            var result = await _service.TeamExistsAsync(nonExistentId);

            // Assert: Check that it doesn’t exist
            Assert.That(result, Is.False, "Team should not exist.");
        }

        #endregion
    }
}