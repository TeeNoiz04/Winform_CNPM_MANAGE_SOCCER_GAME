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
    public class ImageTeamServiceTests
    {
        private DbContextOptions<ManageSoccerGame> _options; // Database configuration
        private ManageSoccerGame _context; // Database context
        private ImageTeamService _service; // Service being tested

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
            _service = new ImageTeamService(_context);
        }

        [TearDown]
        public void TearDown()
        {
            // This runs after each test to clean up
            // Delete the in-memory database and free resources
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        #region CreateImageAsync Tests

        // Test 1: Checks if creating a valid image works
        [Test]
        public async Task CreateImageAsync_ValidImage_ReturnsCreatedImage()
        {
            // Purpose: Ensure that adding a new image for a team works correctly
            // Arrange: Create a team and an image
            var teamId = Guid.NewGuid();
            _context.Teams.Add(new Team
            {
                Id = teamId,
                Name = "Team A",
                Province = "Province A"
            });
            await _context.SaveChangesAsync();

            var image = new ImageTeam
            {
                Url = "http://example.com/team.jpg",
                PublicId = "team123",
                TeamId = teamId,
                AltText = "Team Logo"
            };

            // Act: Try creating the image
            var result = await _service.CreateImageAsync(image);

            // Assert: Check that the image was created with correct details
            Assert.That(result, Is.Not.Null, "Image should be created.");
            Assert.That(result.Id, Is.Not.EqualTo(Guid.Empty), "Image should have a new ID.");
            Assert.That(result.Url, Is.EqualTo("http://example.com/team.jpg"), "URL should match.");
            Assert.That(result.PublicId, Is.EqualTo("team123"), "Public ID should match.");
            Assert.That(result.TeamId, Is.EqualTo(teamId), "Team ID should match.");
            Assert.That(result.AltText, Is.EqualTo("Team Logo"), "Alt text should match.");
            Assert.That(result.CreateAt, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Create time should be recent.");
            Assert.That(result.UpdateAt, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Update time should be recent.");

            // Verify the image is saved in the database
            var savedImage = await _context.ImageTeams.FindAsync(result.Id);
            Assert.That(savedImage, Is.Not.Null, "Image should exist in database.");
        }

        // Test 2: Checks if creating an image with an invalid URL throws an error
        [Test]
        public async Task CreateImageAsync_EmptyUrl_ThrowsException()
        {
            // Purpose: Ensure that an empty image URL causes an error
            // Arrange: Create a team and an image with an empty URL
            var teamId = Guid.NewGuid();
            _context.Teams.Add(new Team
            {
                Id = teamId,
                Name = "Team A",
                Province = "Province A"
            });
            await _context.SaveChangesAsync();

            var image = new ImageTeam
            {
                Url = "",
                PublicId = "team123",
                TeamId = teamId
            };

            // Act & Assert: Expect an error for the empty URL
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.CreateImageAsync(image),
                "Should throw exception for empty URL.");
            Assert.That(exception.Message, Is.EqualTo("URL không được để trống."), "Error message should indicate empty URL.");
        }

        // Test 3: Checks if creating an image with a duplicate PublicId throws an error
        [Test]
        public async Task CreateImageAsync_DuplicatePublicId_ThrowsException()
        {
            // Purpose: Ensure that using an existing PublicId causes an error
            // Arrange: Create a team and an existing image
            var teamId = Guid.NewGuid();
            _context.Teams.Add(new Team
            {
                Id = teamId,
                Name = "Team A",
                Province = "Province A"
            });
            _context.ImageTeams.Add(new ImageTeam
            {
                Id = Guid.NewGuid(),
                Url = "http://example.com/team1.jpg",
                PublicId = "team123",
                TeamId = teamId
            });
            await _context.SaveChangesAsync();

            // Create a new image with the same PublicId
            var image = new ImageTeam
            {
                Url = "http://example.com/team2.jpg",
                PublicId = "team123",
                TeamId = teamId
            };

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.CreateImageAsync(image),
                "Should throw exception for duplicate PublicId.");
            Assert.That(exception.Message, Is.EqualTo("publicId đã tồn tại."), "Error message should indicate duplicate PublicId.");
        }

        // Test 4: Checks if creating an image with a non-existent TeamId throws an error
        [Test]
        public async Task CreateImageAsync_InvalidTeamId_ThrowsException()
        {
            // Purpose: Ensure that an invalid TeamId causes an error
            // Arrange: Create an image with a random TeamId
            var image = new ImageTeam
            {
                Url = "http://example.com/team.jpg",
                PublicId = "team123",
                TeamId = Guid.NewGuid()
            };

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.CreateImageAsync(image),
                "Should throw exception for invalid TeamId.");
            Assert.That(exception.Message, Is.EqualTo("TeamId không tồn tại."), "Error message should indicate invalid TeamId.");
        }

        // Test 5: Checks if creating an image with a null PublicId throws an error
        [Test]
        public async Task CreateImageAsync_NullPublicId_ThrowsException()
        {
            // Purpose: Ensure that a missing PublicId causes an error
            // Arrange: Create a team and an image with null PublicId
            var teamId = Guid.NewGuid();
            _context.Teams.Add(new Team
            {
                Id = teamId,
                Name = "Team A",
                Province = "Province A"
            });
            await _context.SaveChangesAsync();

            var image = new ImageTeam
            {
                Url = "http://example.com/team.jpg",
                PublicId = null,
                TeamId = teamId
            };

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.CreateImageAsync(image),
                "Should throw exception for null PublicId.");
            Assert.That(exception.Message, Is.EqualTo("publicId là bắt buộc."), "Error message should indicate missing PublicId.");
        }

        #endregion

        #region GetAllImagesAsync Tests

        // Test 6: Checks if getting all images returns all images
        [Test]
        public async Task GetAllImagesAsync_MultipleImages_ReturnsAll()
        {
            // Purpose: Ensure that all images are retrieved when multiple exist
            // Arrange: Create two teams and two images
            var teamId1 = Guid.NewGuid();
            var teamId2 = Guid.NewGuid();
            _context.Teams.AddRange(
                new Team { Id = teamId1, Name = "Team 1", Province = "Province 1" },
                new Team { Id = teamId2, Name = "Team 2", Province = "Province 2" }
            );
            _context.ImageTeams.AddRange(
                new ImageTeam { Id = Guid.NewGuid(), Url = "http://example.com/team1.jpg", PublicId = "team1", TeamId = teamId1 },
                new ImageTeam { Id = Guid.NewGuid(), Url = "http://example.com/team2.jpg", PublicId = "team2", TeamId = teamId2 }
            );
            await _context.SaveChangesAsync();

            // Act: Get all images
            var result = await _service.GetAllImagesAsync();

            // Assert: Check that both images are returned
            Assert.That(result.Count, Is.EqualTo(2), "Should return two images.");
            Assert.That(result.Any(i => i.PublicId == "team1"), Is.True, "Should include team1 image.");
            Assert.That(result.Any(i => i.PublicId == "team2"), Is.True, "Should include team2 image.");
        }

        // Test 7: Checks if getting all images returns an empty list when none exist
        [Test]
        public async Task GetAllImagesAsync_NoImages_ReturnsEmptyList()
        {
            // Purpose: Ensure that an empty database returns no images
            // Arrange: No images are added

            // Act: Get all images
            var result = await _service.GetAllImagesAsync();

            // Assert: Check that the result is empty
            Assert.That(result, Is.Empty, "Should return an empty list when no images exist.");
        }

        // Test 8: Checks if getting all images includes team details
        [Test]
        public async Task GetAllImagesAsync_IncludesTeamDetails()
        {
            // Purpose: Ensure that retrieved images include associated team information
            // Arrange: Create a team and an image
            var teamId = Guid.NewGuid();
            _context.Teams.Add(new Team
            {
                Id = teamId,
                Name = "Team A",
                Province = "Province A"
            });
            _context.ImageTeams.Add(new ImageTeam
            {
                Id = Guid.NewGuid(),
                Url = "http://example.com/team.jpg",
                PublicId = "team123",
                TeamId = teamId
            });
            await _context.SaveChangesAsync();

            // Act: Get all images
            var result = await _service.GetAllImagesAsync();

            // Assert: Check that team details are included
            Assert.That(result.Count, Is.EqualTo(1), "Should return one image.");
            Assert.That(result.First().Team, Is.Not.Null, "Team details should be included.");
            Assert.That(result.First().Team.Name, Is.EqualTo("Team A"), "Team name should match.");
        }

        #endregion

        #region GetImageByIdAsync Tests

        // Test 9: Checks if getting an image by valid ID works
        [Test]
        public async Task GetImageByIdAsync_ExistingId_ReturnsImage()
        {
            // Purpose: Ensure that retrieving an image by its ID returns the correct image
            // Arrange: Create a team and an image
            var teamId = Guid.NewGuid();
            var imageId = Guid.NewGuid();
            _context.Teams.Add(new Team
            {
                Id = teamId,
                Name = "Team A",
                Province = "Province A"
            });
            _context.ImageTeams.Add(new ImageTeam
            {
                Id = imageId,
                Url = "http://example.com/team.jpg",
                PublicId = "team123",
                TeamId = teamId
            });
            await _context.SaveChangesAsync();

            // Act: Get the image by ID
            var result = await _service.GetImageByIdAsync(imageId);

            // Assert: Check that the correct image is returned
            Assert.That(result, Is.Not.Null, "Image should be found.");
            Assert.That(result.Id, Is.EqualTo(imageId), "Image ID should match.");
            Assert.That(result.PublicId, Is.EqualTo("team123"), "Public ID should match.");
        }

        // Test 10: Checks if getting an image by non-existent ID throws an error
        [Test]
        public async Task GetImageByIdAsync_NonExistentId_ThrowsException()
        {
            // Purpose: Ensure that a non-existent image ID causes an error
            // Arrange: Use a random ID
            var nonExistentId = Guid.NewGuid();

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.GetImageByIdAsync(nonExistentId),
                "Should throw exception for non-existent ID.");
            Assert.That(exception.Message, Is.EqualTo("Không tìm thấy ảnh."), "Error message should indicate image not found.");
        }

        // Test 11: Checks if getting an image by empty ID throws an error
        [Test]
        public async Task GetImageByIdAsync_EmptyId_ThrowsException()
        {
            // Purpose: Ensure that an empty ID causes an error
            // Arrange: Use Guid.Empty
            var emptyId = Guid.Empty;

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.GetImageByIdAsync(emptyId),
                "Should throw exception for empty ID.");
            Assert.That(exception.Message, Is.EqualTo("Id không hợp lệ."), "Error message should indicate invalid ID.");
        }

        // Test 12: Checks if getting an image includes team details
        [Test]
        public async Task GetImageByIdAsync_IncludesTeamDetails()
        {
            // Purpose: Ensure that retrieving an image includes associated team information
            // Arrange: Create a team and an image
            var teamId = Guid.NewGuid();
            var imageId = Guid.NewGuid();
            _context.Teams.Add(new Team
            {
                Id = teamId,
                Name = "Team A",
                Province = "Province A"
            });
            _context.ImageTeams.Add(new ImageTeam
            {
                Id = imageId,
                Url = "http://example.com/team.jpg",
                PublicId = "team123",
                TeamId = teamId
            });
            await _context.SaveChangesAsync();

            // Act: Get the image by ID
            var result = await _service.GetImageByIdAsync(imageId);

            // Assert: Check that team details are included
            Assert.That(result.Team, Is.Not.Null, "Team details should be included.");
            Assert.That(result.Team.Name, Is.EqualTo("Team A"), "Team name should match.");
        }

        #endregion

        #region UpdateImageAsync Tests

        // Test 13: Checks if updating an existing image works
        [Test]
        public async Task UpdateImageAsync_ValidImage_ReturnsTrue()
        {
            // Purpose: Ensure that updating an image’s details works correctly
            // Arrange: Create a team and an image
            var teamId = Guid.NewGuid();
            var imageId = Guid.NewGuid();
            _context.Teams.Add(new Team
            {
                Id = teamId,
                Name = "Team A",
                Province = "Province A"
            });
            _context.ImageTeams.Add(new ImageTeam
            {
                Id = imageId,
                Url = "http://example.com/old.jpg",
                PublicId = "old123",
                TeamId = teamId
            });
            await _context.SaveChangesAsync();

            // Create updated image data
            var updatedImage = new ImageTeam
            {
                Id = imageId,
                Url = "http://example.com/new.jpg",
                PublicId = "new123",
                TeamId = teamId,
                AltText = "Updated Logo"
            };

            // Act: Update the image
            var result = await _service.UpdateImageAsync(updatedImage);

            // Assert: Check that the update succeeded
            Assert.That(result, Is.True, "Update should succeed.");
            var savedImage = await _context.ImageTeams.FindAsync(imageId);
            Assert.That(savedImage.Url, Is.EqualTo("http://example.com/new.jpg"), "URL should be updated.");
            Assert.That(savedImage.PublicId, Is.EqualTo("new123"), "Public ID should be updated.");
            Assert.That(savedImage.AltText, Is.EqualTo("Updated Logo"), "Alt text should be updated.");
            Assert.That(savedImage.UpdateAt, Is.GreaterThan(savedImage.CreateAt), "Update time should be newer.");
        }

        // Test 14: Checks if updating a non-existent image throws an error
        [Test]
        public async Task UpdateImageAsync_NonExistentImage_ThrowsException()
        {
            // Purpose: Ensure that updating an image that doesn’t exist causes an error
            // Arrange: Create an image with a random ID
            var updatedImage = new ImageTeam
            {
                Id = Guid.NewGuid(),
                Url = "http://example.com/team.jpg",
                PublicId = "team123",
                TeamId = Guid.NewGuid()
            };

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.UpdateImageAsync(updatedImage),
                "Should throw exception for non-existent image.");
            Assert.That(exception.Message, Is.EqualTo("Không tìm thấy ảnh để cập nhật."), "Error message should indicate image not found.");
        }

        // Test 15: Checks if updating with an invalid URL throws an error
        [Test]
        public async Task UpdateImageAsync_InvalidUrl_ThrowsException()
        {
            // Purpose: Ensure that an invalid URL during update causes an error
            // Arrange: Create a team and an image
            var teamId = Guid.NewGuid();
            var imageId = Guid.NewGuid();
            _context.Teams.Add(new Team
            {
                Id = teamId,
                Name = "Team A",
                Province = "Province A"
            });
            _context.ImageTeams.Add(new ImageTeam
            {
                Id = imageId,
                Url = "http://example.com/team.jpg",
                PublicId = "team123",
                TeamId = teamId
            });
            await _context.SaveChangesAsync();

            // Create updated image with invalid URL
            var updatedImage = new ImageTeam
            {
                Id = imageId,
                Url = "invalid_url",
                PublicId = "new123",
                TeamId = teamId
            };

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.UpdateImageAsync(updatedImage),
                "Should throw exception for invalid URL.");
            Assert.That(exception.Message, Is.EqualTo("URL không hợp lệ."), "Error message should indicate invalid URL.");
        }

        // Test 16: Checks if updating with an empty ID throws an error
        [Test]
        public async Task UpdateImageAsync_EmptyId_ThrowsException()
        {
            // Purpose: Ensure that an empty image ID causes an error
            // Arrange: Create an image with Guid.Empty
            var updatedImage = new ImageTeam
            {
                Id = Guid.Empty,
                Url = "http://example.com/team.jpg",
                PublicId = "team123",
                TeamId = Guid.NewGuid()
            };

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.UpdateImageAsync(updatedImage),
                "Should throw exception for empty ID.");
            Assert.That(exception.Message, Is.EqualTo("Id không hợp lệ."), "Error message should indicate invalid ID.");
        }

        #endregion

        #region DeleteImageAsync Tests

        // Test 17: Checks if deleting an existing image works
        [Test]
        public async Task DeleteImageAsync_ExistingId_ReturnsTrue()
        {
            // Purpose: Ensure that deleting an image by its ID works correctly
            // Arrange: Create a team and an image
            var teamId = Guid.NewGuid();
            var imageId = Guid.NewGuid();
            _context.Teams.Add(new Team
            {
                Id = teamId,
                Name = "Team A",
                Province = "Province A"
            });
            _context.ImageTeams.Add(new ImageTeam
            {
                Id = imageId,
                Url = "http://example.com/team.jpg",
                PublicId = "team123",
                TeamId = teamId
            });
            await _context.SaveChangesAsync();

            // Act: Delete the image
            var result = await _service.DeleteImageAsync(imageId);

            // Assert: Check that the deletion succeeded
            Assert.That(result, Is.True, "Deletion should succeed.");
            var deletedImage = await _context.ImageTeams.FindAsync(imageId);
            Assert.That(deletedImage, Is.Null, "Image should no longer exist.");
        }

        // Test 18: Checks if deleting a non-existent image throws an error
        [Test]
        public async Task DeleteImageAsync_NonExistentId_ThrowsException()
        {
            // Purpose: Ensure that deleting an image that doesn’t exist causes an error
            // Arrange: Use a random ID
            var nonExistentId = Guid.NewGuid();

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.DeleteImageAsync(nonExistentId),
                "Should throw exception for non-existent ID.");
            Assert.That(exception.Message, Is.EqualTo("Không tìm thấy ảnh để xoá."), "Error message should indicate image not found.");
        }

        // Test 19: Checks if deleting with an empty ID throws an error
        [Test]
        public async Task DeleteImageAsync_EmptyId_ThrowsException()
        {
            // Purpose: Ensure that an empty ID causes an error
            // Arrange: Use Guid.Empty
            var emptyId = Guid.Empty;

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.DeleteImageAsync(emptyId),
                "Should throw exception for empty ID.");
            Assert.That(exception.Message, Is.EqualTo("Id không hợp lệ."), "Error message should indicate invalid ID.");
        }

        #endregion

        #region GetImagesByTeamIdAsync Tests 

        // Test 21: Checks if getting images by non-existent TeamId throws an error
        [Test]
        public async Task GetImagesByTeamIdAsync_NonExistentTeamId_ThrowsException()
        {
            // Purpose: Ensure that an invalid TeamId causes an error
            // Arrange: Use a random TeamId
            var nonExistentTeamId = Guid.NewGuid();

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.GetImagesByTeamIdAsync(nonExistentTeamId),
                "Should throw exception for non-existent TeamId.");
            Assert.That(exception.Message, Is.EqualTo("Không tìm thấy đội bóng."), "Error message should indicate team not found.");
        }

        // Test 22: Checks if getting images by empty TeamId throws an error
        [Test]
        public async Task GetImagesByTeamIdAsync_EmptyTeamId_ThrowsException()
        {
            // Purpose: Ensure that an empty TeamId causes an error
            // Arrange: Use Guid.Empty
            var emptyTeamId = Guid.Empty;

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.GetImagesByTeamIdAsync(emptyTeamId),
                "Should throw exception for empty TeamId.");
            Assert.That(exception.Message, Is.EqualTo("TeamId không hợp lệ."), "Error message should indicate invalid TeamId.");
        }

        // Test 23: Checks if getting images for a team with no images returns an empty list
        [Test]
        public async Task GetImagesByTeamIdAsync_NoImages_ReturnsEmptyList()
        {
            // Purpose: Ensure that a team with no images returns an empty list
            // Arrange: Create a team with no images
            var teamId = Guid.NewGuid();
            _context.Teams.Add(new Team
            {
                Id = teamId,
                Name = "Team A",
                Province = "Province A"
            });
            await _context.SaveChangesAsync();

            // Act: Get images for the team
            var result = await _service.GetImagesByTeamIdAsync(teamId);

            // Assert: Check that the result is empty
            Assert.That(result, Is.Empty, "Should return an empty list for team with no images.");
        }

        #endregion

        #region ExistsByPublicIdAsync Tests

        // Test 24: Checks if checking an existing PublicId returns true
        [Test]
        public async Task ExistsByPublicIdAsync_ExistingPublicId_ReturnsTrue()
        {
            // Purpose: Ensure that checking an existing PublicId confirms it exists
            // Arrange: Create a team and an image
            var teamId = Guid.NewGuid();
            _context.Teams.Add(new Team
            {
                Id = teamId,
                Name = "Team A",
                Province = "Province A"
            });
            _context.ImageTeams.Add(new ImageTeam
            {
                Id = Guid.NewGuid(),
                Url = "http://example.com/team.jpg",
                PublicId = "team123",
                TeamId = teamId
            });
            await _context.SaveChangesAsync();

            // Act: Check if the PublicId exists
            var result = await _service.ExistsByPublicIdAsync("team123");

            // Assert: Check that it exists
            Assert.That(result, Is.True, "PublicId should exist.");
        }

        // Test 25: Checks if checking a non-existent PublicId returns false
        [Test]
        public async Task ExistsByPublicIdAsync_NonExistentPublicId_ReturnsFalse()
        {
            // Purpose: Ensure that checking a non-existent PublicId confirms it doesn’t exist
            // Arrange: No images are added

            // Act: Check a random PublicId
            var result = await _service.ExistsByPublicIdAsync("nonexistent123");

            // Assert: Check that it doesn’t exist
            Assert.That(result, Is.False, "PublicId should not exist.");
        }

        // Test 26: Checks if checking an empty PublicId throws an error
        [Test]
        public async Task ExistsByPublicIdAsync_EmptyPublicId_ThrowsException()
        {
            // Purpose: Ensure that an empty PublicId causes an error
            // Arrange: Use an empty string
            var emptyPublicId = "";

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.ExistsByPublicIdAsync(emptyPublicId),
                "Should throw exception for empty PublicId.");
            Assert.That(exception.Message, Is.EqualTo("publicId không hợp lệ."), "Error message should indicate invalid PublicId.");
        }

        #endregion

        #region Integration Tests

        // Test 27: Checks the full flow of creating, updating, and deleting an image
        [Test]
        public async Task IntegrationTest_CreateUpdateDelete_CompleteFlow()
        {
            // Purpose: Ensure that creating, updating, and deleting an image works together
            // Arrange: Create a team
            var teamId = Guid.NewGuid();
            _context.Teams.Add(new Team
            {
                Id = teamId,
                Name = "Team A",
                Province = "Province A"
            });
            await _context.SaveChangesAsync();

            // Step 1: Create an image
            var image = new ImageTeam
            {
                Url = "http://example.com/team.jpg",
                PublicId = "team123",
                TeamId = teamId
            };
            var createdImage = await _service.CreateImageAsync(image);
            Assert.That(createdImage, Is.Not.Null, "Image should be created.");

            // Step 2: Update the image
            var updatedImage = new ImageTeam
            {
                Id = createdImage.Id,
                Url = "http://example.com/updated.jpg",
                PublicId = "updated123",
                TeamId = teamId,
                AltText = "Updated Logo"
            };
            var updateResult = await _service.UpdateImageAsync(updatedImage);
            Assert.That(updateResult, Is.True, "Update should succeed.");

            // Step 3: Verify the update
            var fetchedImage = await _service.GetImageByIdAsync(createdImage.Id);
            Assert.That(fetchedImage.Url, Is.EqualTo("http://example.com/updated.jpg"), "URL should be updated.");
            Assert.That(fetchedImage.PublicId, Is.EqualTo("updated123"), "Public ID should be updated.");

            // Step 4: Delete the image
            var deleteResult = await _service.DeleteImageAsync(createdImage.Id);
            Assert.That(deleteResult, Is.True, "Deletion should succeed.");

            // Step 5: Verify deletion
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.GetImageByIdAsync(createdImage.Id),
                "Should throw exception for deleted image.");
            Assert.That(exception.Message, Is.EqualTo("Không tìm thấy ảnh."), "Image should no longer exist.");
        }

        #endregion

        #region Edge Case Tests

        // Test 29: Checks creating an image with a very long URL
        [Test]
        public async Task CreateImageAsync_VeryLongUrl_ValidatesSuccessfully()
        {
            // Purpose: Ensure that a long but valid URL is accepted
            // Arrange: Create a team and an image with a long URL
            var teamId = Guid.NewGuid();
            _context.Teams.Add(new Team
            {
                Id = teamId,
                Name = "Team A",
                Province = "Province A"
            });
            await _context.SaveChangesAsync();

            var longUrl = "http://example.com/" + new string('a', 1000) + ".jpg";
            var image = new ImageTeam
            {
                Url = longUrl,
                PublicId = "team123",
                TeamId = teamId
            };

            // Act: Create the image
            var result = await _service.CreateImageAsync(image);

            // Assert: Check that the image was created
            Assert.That(result, Is.Not.Null, "Image should be created.");
            Assert.That(result.Url, Is.EqualTo(longUrl), "URL should match long URL.");
        }

        #endregion
    }
}