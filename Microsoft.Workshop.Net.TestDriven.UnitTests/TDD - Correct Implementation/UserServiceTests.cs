using NUnit.Framework;
using Microsoft.Workshop.Net.TestDriven.TDD___Correct_Implementation;
using Moq;

namespace Microsoft.Workshop.Net.TestDriven.UnitTests.TDD___Correct_Implementation
{
    public class UserServiceTests
    {
        IUserRepository userRepository;
        Mock<IUserRepository> userRepositoryMock;

        [SetUp]
        public void Init() {
            userRepositoryMock = new Mock<IUserRepository>();
            userRepository = userRepositoryMock.Object;
        }

        [TestCase("John","Snow")]
        public void UserService_ShouldSuccess(string username, string password) {
            // Prepare
            var userService = new UserService(userRepository);
            userRepositoryMock.Setup(_ => _.GetByUsername(username)).Returns(
                new User() {
                    Username = username,
                    Password = password
                }
            );

            // Act
            var result = userService.Login(username, password);

            // Assert
            userRepositoryMock.Verify(_ => _.GetByUsername(username), Times.Once);
            Assert.IsTrue(result);
        }
    }
}