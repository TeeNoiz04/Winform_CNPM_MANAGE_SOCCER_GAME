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
    public class ImageCoacherServiceTests
    {
        private DbContextOptions<ManageSoccerGame> _options; // Database configuration
        private ManageSoccerGame _context; // Database context
        private ImageCoacherService _service; // Service being tested

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
            _service = new ImageCoacherService(_context);
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
            // Purpose: Ensure that adding a new image for a coach works correctly
            // Arrange: Create a coach and an image
            var coachId = Guid.NewGuid();
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "Coach A",
                Email = "coach@example.com",
                National = "USA",
                PhoneNumber = "123-456-7890"
            });
            await _context.SaveChangesAsync();

            var image = new ImageCoacher
            {
                Url = "http://example.com/coach.jpg",
                PublicId = "coach123",
                CoachId = coachId,
                AltText = "Coach Photo"
            };

            // Act: Try creating the image
            var result = await _service.CreateImageAsync(image);

            // Assert: Check that the image was created with correct details
            Assert.That(result, Is.Not.Null, "Image should be created.");
            Assert.That(result.Id, Is.Not.EqualTo(Guid.Empty), "Image should have a new ID.");
            Assert.That(result.Url, Is.EqualTo("http://example.com/coach.jpg"), "URL should match.");
            Assert.That(result.PublicId, Is.EqualTo("coach123"), "Public ID should match.");
            Assert.That(result.CoachId, Is.EqualTo(coachId), "Coach ID should match.");
            Assert.That(result.CreateAt, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Create time should be recent.");
            Assert.That(result.UpdateAt, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)), "Update time should be recent.");

            // Verify the image is saved in the database
            var savedImage = await _context.ImageCoachers.FindAsync(result.Id);
            Assert.That(savedImage, Is.Not.Null, "Image should exist in database.");
        }

        // Test 2: Checks if creating an image with an invalid URL throws an error
        [Test]
        public async Task CreateImageAsync_InvalidUrl_ThrowsException()
        {
            // Purpose: Ensure that an invalid image URL (e.g., empty) causes an error
            // Arrange: Create a coach and an image with an empty URL
            var coachId = Guid.NewGuid();
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "Coach A",
                Email = "coach@example.com",
                National = "USA",
                PhoneNumber = "123-456-7890"
            });
            await _context.SaveChangesAsync();

            var image = new ImageCoacher
            {
                Url = "",
                PublicId = "coach123",
                CoachId = coachId
            };

            // Act & Assert: Expect an error for the invalid URL
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.CreateImageAsync(image),
                "Should throw exception for invalid URL.");
            Assert.That(exception.Message, Is.EqualTo("URL không được để trống."), "Error message should indicate empty URL.");
        }

        // Test 3: Checks if creating an image with a duplicate PublicId throws an error
        [Test]
        public async Task CreateImageAsync_DuplicatePublicId_ThrowsException()
        {
            // Purpose: Ensure that using an existing PublicId causes an error
            // Arrange: Create a coach and an existing image
            var coachId = Guid.NewGuid();
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "Coach A",
                Email = "coach@example.com",
                National = "USA",
                PhoneNumber = "123-456-7890"
            });
            _context.ImageCoachers.Add(new ImageCoacher
            {
                Id = Guid.NewGuid(),
                Url = "http://example.com/coach1.jpg",
                PublicId = "coach123",
                CoachId = coachId
            });
            await _context.SaveChangesAsync();

            // Create a new image with the same PublicId
            var image = new ImageCoacher
            {
                Url = "http://example.com/coach2.jpg",
                PublicId = "coach123",
                CoachId = coachId
            };

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.CreateImageAsync(image),
                "Should throw exception for duplicate PublicId.");
            Assert.That(exception.Message, Is.EqualTo("publicId đã tồn tại."), "Error message should indicate duplicate PublicId.");
        }

        // Test 4: Checks if creating an image with a non-existent CoachId throws an error
        [Test]
        public async Task CreateImageAsync_InvalidCoachId_ThrowsException()
        {
            // Purpose: Ensure that an invalid CoachId causes an error
            // Arrange: Create an image with a random CoachId
            var image = new ImageCoacher
            {
                Url = "http://example.com/coach.jpg",
                PublicId = "coach123",
                CoachId = Guid.NewGuid()
            };

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.CreateImageAsync(image),
                "Should throw exception for invalid CoachId.");
            Assert.That(exception.Message, Is.EqualTo("CoachId không tồn tại."), "Error message should indicate invalid CoachId.");
        }

        // Test 5: Checks if creating an image with a null PublicId throws an error
        [Test]
        public async Task CreateImageAsync_NullPublicId_ThrowsException()
        {
            // Purpose: Ensure that a missing PublicId causes an error
            // Arrange: Create a coach and an image with null PublicId
            var coachId = Guid.NewGuid();
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "Coach A",
                Email = "coach@example.com",
                National = "USA",
                PhoneNumber = "123-456-7890"
            });
            await _context.SaveChangesAsync();

            var image = new ImageCoacher
            {
                Url = "http://example.com/coach.jpg",
                PublicId = null,
                CoachId = coachId
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
            // Arrange: Create two coaches and two images
            var coachId1 = Guid.NewGuid();
            var coachId2 = Guid.NewGuid();
            _context.Coaches.AddRange(
                new Coach { Id = coachId1, Name = "Coach 1", Email = "coach1@example.com", National = "USA", PhoneNumber = "111-222-3333" },
                new Coach { Id = coachId2, Name = "Coach 2", Email = "coach2@example.com", National = "Brazil", PhoneNumber = "444-555-6666" }
            );
            _context.ImageCoachers.AddRange(
                new ImageCoacher { Id = Guid.NewGuid(), Url = "http://example.com/coach1.jpg", PublicId = "coach1", CoachId = coachId1 },
                new ImageCoacher { Id = Guid.NewGuid(), Url = "http://example.com/coach2.jpg", PublicId = "coach2", CoachId = coachId2 }
            );
            await _context.SaveChangesAsync();

            // Act: Get all images
            var result = await _service.GetAllImagesAsync();

            // Assert: Check that both images are returned
            Assert.That(result.Count, Is.EqualTo(2), "Should return two images.");
            Assert.That(result.Any(i => i.PublicId == "coach1"), Is.True, "Should include coach1 image.");
            Assert.That(result.Any(i => i.PublicId == "coach2"), Is.True, "Should include coach2 image.");
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

        // Test 8: Checks if getting all images includes coach details
        [Test]
        public async Task GetAllImagesAsync_IncludesCoachDetails()
        {
            // Purpose: Ensure that retrieved images include associated coach information
            // Arrange: Create a coach and an image
            var coachId = Guid.NewGuid();
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "Coach A",
                Email = "coach@example.com",
                National = "USA",
                PhoneNumber = "123-456-7890"
            });
            _context.ImageCoachers.Add(new ImageCoacher
            {
                Id = Guid.NewGuid(),
                Url = "http://example.com/coach.jpg",
                PublicId = "coach123",
                CoachId = coachId
            });
            await _context.SaveChangesAsync();

            // Act: Get all images
            var result = await _service.GetAllImagesAsync();

            // Assert: Check that the coach details are included
            Assert.That(result.Count, Is.EqualTo(1), "Should return one image.");
            Assert.That(result.First().Coach, Is.Not.Null, "Coach details should be included.");
            Assert.That(result.First().Coach.Name, Is.EqualTo("Coach A"), "Coach name should match.");
        }

        #endregion

        #region GetImageByIdAsync Tests

        // Test 9: Checks if getting an image by valid ID works
        [Test]
        public async Task GetImageByIdAsync_ExistingId_ReturnsImage()
        {
            // Purpose: Ensure that retrieving an image by its ID returns the correct image
            // Arrange: Create a coach and an image
            var coachId = Guid.NewGuid();
            var imageId = Guid.NewGuid();
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "Coach A",
                Email = "coach@example.com",
                National = "USA",
                PhoneNumber = "123-456-7890"
            });
            _context.ImageCoachers.Add(new ImageCoacher
            {
                Id = imageId,
                Url = "http://example.com/coach.jpg",
                PublicId = "coach123",
                CoachId = coachId
            });
            await _context.SaveChangesAsync();

            // Act: Get the image by ID
            var result = await _service.GetImageByIdAsync(imageId);

            // Assert: Check that the correct image is returned
            Assert.That(result, Is.Not.Null, "Image should be found.");
            Assert.That(result.Id, Is.EqualTo(imageId), "Image ID should match.");
            Assert.That(result.PublicId, Is.EqualTo("coach123"), "Public ID should match.");
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

        // Test 12: Checks if getting an image includes coach details
        [Test]
        public async Task GetImageByIdAsync_IncludesCoachDetails()
        {
            // Purpose: Ensure that retrieving an image includes associated coach information
            // Arrange: Create a coach and an image
            var coachId = Guid.NewGuid();
            var imageId = Guid.NewGuid();
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "Coach A",
                Email = "coach@example.com",
                National = "USA",
                PhoneNumber = "123-456-7890"
            });
            _context.ImageCoachers.Add(new ImageCoacher
            {
                Id = imageId,
                Url = "http://example.com/coach.jpg",
                PublicId = "coach123",
                CoachId = coachId
            });
            await _context.SaveChangesAsync();

            // Act: Get the image by ID
            var result = await _service.GetImageByIdAsync(imageId);

            // Assert: Check that coach details are included
            Assert.That(result.Coach, Is.Not.Null, "Coach details should be included.");
            Assert.That(result.Coach.Name, Is.EqualTo("Coach A"), "Coach name should match.");
        }

        #endregion

        #region UpdateImageAsync Tests

        // Test 13: Checks if updating an existing image works
        [Test]
        public async Task UpdateImageAsync_ValidImage_ReturnsTrue()
        {
            // Purpose: Ensure that updating an image’s details works correctly
            // Arrange: Create a coach and an image
            var coachId = Guid.NewGuid();
            var imageId = Guid.NewGuid();
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "Coach A",
                Email = "coach@example.com",
                National = "USA",
                PhoneNumber = "123-456-7890"
            });
            _context.ImageCoachers.Add(new ImageCoacher
            {
                Id = imageId,
                Url = "http://example.com/old.jpg",
                PublicId = "old123",
                CoachId = coachId
            });
            await _context.SaveChangesAsync();

            // Create updated image data
            var updatedImage = new ImageCoacher
            {
                Id = imageId,
                Url = "http://example.com/new.jpg",
                PublicId = "new123",
                CoachId = coachId,
                AltText = "Updated Photo"
            };

            // Act: Update the image
            var result = await _service.UpdateImageAsync(updatedImage);

            // Assert: Check that the update succeeded
            Assert.That(result, Is.True, "Update should succeed.");
            var savedImage = await _context.ImageCoachers.FindAsync(imageId);
            Assert.That(savedImage.Url, Is.EqualTo("http://example.com/new.jpg"), "URL should be updated.");
            Assert.That(savedImage.PublicId, Is.EqualTo("new123"), "Public ID should be updated.");
            Assert.That(savedImage.AltText, Is.EqualTo("Updated Photo"), "Alt text should be updated.");
            Assert.That(savedImage.UpdateAt, Is.GreaterThan(savedImage.CreateAt), "Update time should be newer.");
        }

        // Test 14: Checks if updating a non-existent image throws an error
        [Test]
        public async Task UpdateImageAsync_NonExistentImage_ThrowsException()
        {
            // Purpose: Ensure that updating an image that doesn’t exist causes an error
            // Arrange: Create an image with a random ID
            var updatedImage = new ImageCoacher
            {
                Id = Guid.NewGuid(),
                Url = "http://example.com/coach.jpg",
                PublicId = "coach123",
                CoachId = Guid.NewGuid()
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
            // Arrange: Create a coach and an image
            var coachId = Guid.NewGuid();
            var imageId = Guid.NewGuid();
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "Coach A",
                Email = "coach@example.com",
                National = "USA",
                PhoneNumber = "123-456-7890"
            });
            _context.ImageCoachers.Add(new ImageCoacher
            {
                Id = imageId,
                Url = "http://example.com/coach.jpg",
                PublicId = "coach123",
                CoachId = coachId
            });
            await _context.SaveChangesAsync();

            // Create updated image with invalid URL
            var updatedImage = new ImageCoacher
            {
                Id = imageId,
                Url = "invalid_url",
                PublicId = "new123",
                CoachId = coachId
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
            var updatedImage = new ImageCoacher
            {
                Id = Guid.Empty,
                Url = "http://example.com/coach.jpg",
                PublicId = "coach123",
                CoachId = Guid.NewGuid()
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
            // Arrange: Create a coach and an image
            var coachId = Guid.NewGuid();
            var imageId = Guid.NewGuid();
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "Coach A",
                Email = "coach@example.com",
                National = "USA",
                PhoneNumber = "123-456-7890"
            });
            _context.ImageCoachers.Add(new ImageCoacher
            {
                Id = imageId,
                Url = "http://example.com/coach.jpg",
                PublicId = "coach123",
                CoachId = coachId
            });
            await _context.SaveChangesAsync();

            // Act: Delete the image
            var result = await _service.DeleteImageAsync(imageId);

            // Assert: Check that the deletion succeeded
            Assert.That(result, Is.True, "Deletion should succeed.");
            var deletedImage = await _context.ImageCoachers.FindAsync(imageId);
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

        #region GetImagesByCoachIdAsync Tests

        // Test 21: Checks if getting images by non-existent CoachId throws an error
        [Test]
        public async Task GetImagesByCoachIdAsync_NonExistentCoachId_ThrowsException()
        {
            // Purpose: Ensure that an invalid CoachId causes an error
            // Arrange: Use a random CoachId
            var nonExistentCoachId = Guid.NewGuid();

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.GetImagesByCoachIdAsync(nonExistentCoachId),
                "Should throw exception for non-existent CoachId.");
            Assert.That(exception.Message, Is.EqualTo("Không tìm thấy huấn luyện viên."), "Error message should indicate coach not found.");
        }

        // Test 22: Checks if getting images by empty CoachId throws an error
        [Test]
        public async Task GetImagesByCoachIdAsync_EmptyCoachId_ThrowsException()
        {
            // Purpose: Ensure that an empty CoachId causes an error
            // Arrange: Use Guid.Empty
            var emptyCoachId = Guid.Empty;

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(
                async () => await _service.GetImagesByCoachIdAsync(emptyCoachId),
                "Should throw exception for empty CoachId.");
            Assert.That(exception.Message, Is.EqualTo("CoachId không hợp lệ."), "Error message should indicate invalid CoachId.");
        }

        // Test 23: Checks if getting images for a coach with no images returns an empty list
        [Test]
        public async Task GetImagesByCoachIdAsync_NoImages_ReturnsEmptyList()
        {
            // Purpose: Ensure that a coach with no images returns an empty list
            // Arrange: Create a coach with no images
            var coachId = Guid.NewGuid();
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "Coach A",
                Email = "coach@example.com",
                National = "USA",
                PhoneNumber = "123-456-7890"
            });
            await _context.SaveChangesAsync();

            // Act: Get images for the coach
            var result = await _service.GetImagesByCoachIdAsync(coachId);

            // Assert: Check that the result is empty
            Assert.That(result, Is.Empty, "Should return an empty list for coach with no images.");
        }

        #endregion

        #region ExistsByPublicIdAsync Tests

        // Test 24: Checks if checking an existing PublicId returns true
        [Test]
        public async Task ExistsByPublicIdAsync_ExistingPublicId_ReturnsTrue()
        {
            // Purpose: Ensure that checking an existing PublicId confirms it exists
            // Arrange: Create a coach and an image
            var coachId = Guid.NewGuid();
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "Coach A",
                Email = "coach@example.com",
                National = "USA",
                PhoneNumber = "123-456-7890"
            });
            _context.ImageCoachers.Add(new ImageCoacher
            {
                Id = Guid.NewGuid(),
                Url = "http://example.com/coach.jpg",
                PublicId = "coach123",
                CoachId = coachId
            });
            await _context.SaveChangesAsync();

            // Act: Check if the PublicId exists
            var result = await _service.ExistsByPublicIdAsync("coach123");

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
            // Arrange: Create a coach
            var coachId = Guid.NewGuid();
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "Coach A",
                Email = "coach@example.com",
                National = "USA",
                PhoneNumber = "123-456-7890"
            });
            await _context.SaveChangesAsync();

            // Step 1: Create an image
            var image = new ImageCoacher
            {
                Url = "http://example.com/coach.jpg",
                PublicId = "coach123",
                CoachId = coachId
            };
            var createdImage = await _service.CreateImageAsync(image);
            Assert.That(createdImage, Is.Not.Null, "Image should be created.");

            // Step 2: Update the image
            var updatedImage = new ImageCoacher
            {
                Id = createdImage.Id,
                Url = "http://example.com/updated.jpg",
                PublicId = "updated123",
                CoachId = coachId,
                AltText = "Updated Photo"
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
            // Arrange: Create a coach and an image with a long URL
            var coachId = Guid.NewGuid();
            _context.Coaches.Add(new Coach
            {
                Id = coachId,
                Name = "Coach A",
                Email = "coach@example.com",
                National = "USA",
                PhoneNumber = "123-456-7890"
            });
            await _context.SaveChangesAsync();

            var longUrl = "http://example.com/" + new string('a', 1000) + ".jpg";
            var image = new ImageCoacher
            {
                Url = longUrl,
                PublicId = "coach123",
                CoachId = coachId
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