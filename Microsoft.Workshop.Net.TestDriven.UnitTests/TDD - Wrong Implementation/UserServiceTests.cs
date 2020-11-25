using NUnit.Framework;
using Microsoft.Workshop.Net.TestDriven.TDD___Wrong_Implementation;
namespace Microsoft.Workshop.Net.TestDriven.UnitTests.TDD___Wrong_Implementation
{
    public class UserServiceTests
    {
        [TestCase("John","Snow")]
        public void UserService_ShouldSuccess(string username, string password) {
            // Prepare
            var userService = new UserService();

            // Act
            var result = userService.Login(username, password);

            // Assert
            Assert.IsTrue(result);
        }
    }
}