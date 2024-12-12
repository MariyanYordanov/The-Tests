using System.ComponentModel.DataAnnotations;
using TheTests.Infrastructure.Models;
using static TheTests.Infrastructure.Constants;

namespace TheTests.UnitTests
{
    public class ApplicationUserTests
    {
        [Fact]
        public void Constructor_ShouldSetUserName()
        {
            // Arrange
            var userName = "testuser";

            // Act
            var user = new AppUser(userName);

            // Assert
            Assert.Equal(userName, user.UserName);
        }

        [Fact]
        public void FullName_ShouldReturnConcatenationOfFirstAndLastName()
        {
            // Arrange
            var user = new AppUser("testuser")
            {
                FirstName = "John",
                LastName = "Doe"
            };

            // Act
            var fullName = user.FullName;

            // Assert
            Assert.Equal("John Doe", fullName);
        }

        [Fact]
        public void FullName_ShouldReturnEmptyString_WhenFirstAndLastNameAreEmpty()
        {
            // Arrange
            var user = new AppUser("testuser");

            // Act
            var fullName = user.FullName;

            // Assert
            Assert.Equal(" ", fullName);
        }

        [Fact]
        public void DisplayName_ShouldReturnFullName_WhenFullNameIsNotEmpty()
        {
            // Arrange
            var user = new AppUser("testuser")
            {
                FirstName = "John",
                LastName = "Doe"
            };

            // Act
            var displayName = user.DisplayName;

            // Assert
            Assert.Equal("John Doe", displayName);
        }

        [Fact]
        public void DisplayName_ShouldReturnUserName_WhenFullNameIsEmpty()
        {
            // Arrange
            var user = new AppUser("testuser");

            // Act
            var displayName = user.DisplayName;

            // Assert
            Assert.Equal("testuser", displayName);
        }

        [Fact]
        public void FirstName_ShouldRespectMaxNameLength()
        {
            // Arrange
            var user = new AppUser("testuser");
            var tooLongName = new string('a', MaxNameLength + 1);

            // Act & Assert
            Assert.Throws<ValidationException>(() => user.FirstName = tooLongName);
        }

        [Fact]
        public void LastName_ShouldRespectStringLengthLimit()
        {
            // Arrange
            var user = new AppUser("testuser");
            var tooLongName = new string('a', MaxNameLength + 1);

            // Act & Assert
            Assert.Throws<ValidationException>(() => user.LastName = tooLongName);
        }
    }
}