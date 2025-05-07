using System;
using System.IO;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Services;
using Moq;
using NUnit.Framework;

namespace MANAGE_SOCCER_GAME.Tests
{
    [TestFixture]
    public class CloudServiceTests
    {
        private CloudService _cloudService; // The service being tested
        private Mock<Cloudinary> _cloudinaryMock; // Mock for Cloudinary API
        private readonly string _testImagePath = "TestImages/test.jpg"; // Path for test image file
        private readonly Guid _testForeignKeyId = Guid.NewGuid(); // Sample ID for associating images
        private readonly string _testAltText = "Test Image"; // Sample description for images
        private readonly string _testPublicId = "test_public_id"; // Sample Cloudinary public ID

        [SetUp]
        public void Setup()
        {
            // This runs before each test to prepare the environment
            // Create a folder for test images if it doesn't exist
            Directory.CreateDirectory("TestImages");

            // Create a dummy test image file (100 bytes) if it doesn't exist
            if (!File.Exists(_testImagePath))
            {
                File.WriteAllBytes(_testImagePath, new byte[100]);
            }

            // Set up the mock for Cloudinary
            _cloudinaryMock = new Mock<Cloudinary>();
            // Initialize the real CloudService for tests that need actual API calls
            _cloudService = new CloudService();
        }

        [TearDown]
        public void TearDown()
        {
            // This runs after each test to clean up
            // Delete the test image file if it exists
            if (File.Exists(_testImagePath))
            {
                File.Delete(_testImagePath);
            }

            // Delete the test images folder if it exists
            if (Directory.Exists("TestImages"))
            {
                Directory.Delete("TestImages", true);
            }
        }

        #region UploadImageAsync Tests

        // Test 2: Checks if uploading with an invalid file path throws an error
        [Test]
        public async Task UploadImageAsync_InvalidFilePath_ThrowsException()
        {
            // Purpose: Ensure that trying to upload a non-existent file causes an error
            // Arrange: Use a fake file path
            var invalidFilePath = "nonexistent_file.jpg";
            var foreignKeyId = _testForeignKeyId;
            var altText = _testAltText;

            // Act & Assert: Expect an exception when uploading
            Assert.ThrowsAsync<Exception>(
                async () => await _cloudService.UploadImageAsync(invalidFilePath, foreignKeyId, altText),
                "Should throw exception for invalid file path.");
        }

        // Test 6: Checks if uploading with a null file path throws an error
        [Test]
        public async Task UploadImageAsync_NullFilePath_ThrowsException()
        {
            // Purpose: Ensure that trying to upload with no file path causes an error
            // Arrange: Use null file path
            string nullFilePath = null;
            var foreignKeyId = _testForeignKeyId;
            var altText = _testAltText;

            // Act & Assert
            Assert.ThrowsAsync<Exception>(
                async () => await _cloudService.UploadImageAsync(nullFilePath, foreignKeyId, altText),
                "Should throw exception for null file path.");
        }

        // Test 7: Checks if uploading with an empty file path throws an error
        [Test]
        public async Task UploadImageAsync_EmptyFilePath_ThrowsException()
        {
            // Purpose: Ensure that trying to upload with an empty file path causes an error
            // Arrange: Use empty file path
            var emptyFilePath = string.Empty;
            var foreignKeyId = _testForeignKeyId;
            var altText = _testAltText;

            // Act & Assert
            Assert.ThrowsAsync<Exception>(
                async () => await _cloudService.UploadImageAsync(emptyFilePath, foreignKeyId, altText),
                "Should throw exception for empty file path.");
        }

        // Test 9: Checks if uploading a non-image file is handled
        [Test]
        public async Task UploadImageAsync_NonImageFile_HandlesError()
        {
            // Purpose: Ensure that uploading a non-image file (e.g., text) is rejected by Cloudinary
            // Arrange: Create a text file
            var textFilePath = "TestImages/test.txt";
            File.WriteAllText(textFilePath, "This is not an image.");
            var foreignKeyId = _testForeignKeyId;
            var altText = _testAltText;

            // Act & Assert
            try
            {
                await _cloudService.UploadImageAsync(textFilePath, foreignKeyId, altText);
                // If upload succeeds unexpectedly, fail the test
                Assert.Fail("Should have thrown an exception for non-image file.");
            }
            catch (Exception ex)
            {
                // Check that the error is related to upload failure
                Assert.That(ex.Message, Does.Contain("Failed to upload image"), "Should indicate upload failure.");
            }
            finally
            {
                if (File.Exists(textFilePath))
                {
                    File.Delete(textFilePath);
                }
            }
        }

        #endregion

        #region GetImageInfoAsync Tests

        // Test 13: Checks if getting info with an empty public ID throws an error
        [Test]
        public async Task GetImageInfoAsync_EmptyPublicId_ThrowsException()
        {
            // Purpose: Ensure that an empty public ID causes an error
            // Arrange: Use an empty string
            var emptyPublicId = string.Empty;

            // Act & Assert
            Assert.ThrowsAsync<Exception>(
                async () => await _cloudService.GetImageInfoAsync(emptyPublicId),
                "Should throw exception for empty public ID.");
        }

        // Test 14: Checks if getting info with a null public ID throws an error
        [Test]
        public async Task GetImageInfoAsync_NullPublicId_ThrowsException()
        {
            // Purpose: Ensure that a null public ID causes an error
            // Arrange: Use null
            string nullPublicId = null;

            // Act & Assert
            Assert.ThrowsAsync<Exception>(
                async () => await _cloudService.GetImageInfoAsync(nullPublicId),
                "Should throw exception for null public ID.");
        }

        #endregion

        #region DeleteImageAsync Tests


        // Test 18: Checks if deleting with an empty public ID throws an error
        [Test]
        public async Task DeleteImageAsync_EmptyPublicId_ThrowsException()
        {
            // Purpose: Ensure that an empty public ID causes an error
            // Arrange: Use an empty string
            var emptyPublicId = string.Empty;

            // Act & Assert
            Assert.ThrowsAsync<Exception>(
                async () => await _cloudService.DeleteImageAsync(emptyPublicId),
                "Should throw exception for empty public ID.");
        }

        // Test 19: Checks if deleting with a null public ID throws an error
        [Test]
        public async Task DeleteImageAsync_NullPublicId_ThrowsException()
        {
            // Purpose: Ensure that a null public ID causes an error
            // Arrange: Use null
            string nullPublicId = null;

            // Act & Assert
            Assert.ThrowsAsync<Exception>(
                async () => await _cloudService.DeleteImageAsync(nullPublicId),
                "Should throw exception for null public ID.");
        }

        #endregion

        #region Edge Case Tests

        // Test 23: Checks if uploading a very small file is handled
        [Test]
        public async Task UploadImageAsync_TinyFile_HandlesError()
        {
            // Purpose: Ensure that uploading a very small (invalid) file is rejected
            // Arrange: Create a tiny file (1 byte)
            var tinyFilePath = "TestImages/tiny.jpg";
            File.WriteAllBytes(tinyFilePath, new byte[] { 0 });

            // Act & Assert
            try
            {
                await _cloudService.UploadImageAsync(tinyFilePath, _testForeignKeyId, "Tiny Image");
                Assert.Fail("Should have thrown an exception for invalid tiny file.");
            }
            catch (Exception ex)
            {
                Assert.That(ex.Message, Does.Contain("Failed to upload image"), "Should indicate upload failure.");
            }
            finally
            {
                if (File.Exists(tinyFilePath))
                {
                    File.Delete(tinyFilePath);
                }
            }
        }
        #endregion
    }
}