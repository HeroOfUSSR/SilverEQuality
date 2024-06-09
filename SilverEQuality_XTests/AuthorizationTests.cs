using FluentAssertions;
using SilverEQuality;
using SilverEQuality_Context;
using SilverEQuality_Context.Models;

namespace SilverEQuality_XTests
{
    public class AuthorizationTests
    {
        [Fact]
        public void LoginAsAdmin_Success()
        {
            // Arrange
            User result;
            var adminLogin = "admin";
            var adminPassword = MD5Encryptor.HashPassword("admin");

            // Act
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                result = db.Users.FirstOrDefault(x => x.LoginUser == adminLogin && x.PasswordUser == adminPassword);
            }

            // Assert
            result.Should().NotBeNull();
        }

        [Fact]
        public void LoginAsAdmin_Fail()
        {
            // Arrange
            User result;
            var adminLogin = "notAdmin";
            var adminPassword = MD5Encryptor.HashPassword("notAdmin");

            // Act
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                result = db.Users.FirstOrDefault(x => x.LoginUser == adminLogin && x.PasswordUser == adminPassword);
            }

            // Assert
            result.Should().BeNull();
        }
    }
}