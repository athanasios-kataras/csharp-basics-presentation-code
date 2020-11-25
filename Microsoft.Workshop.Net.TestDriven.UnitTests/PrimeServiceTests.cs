using NUnit.Framework;

namespace Microsoft.Workshop.Net.TestDriven.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2)]
        public void IsPrime_ReturnTrue(int num)
        {
            // Prepare
            var primeservice = new PrimeService();
            // Act
            var result = primeservice.IsPrime(num);
            // Assert
            Assert.IsTrue(result);
        }

        [TestCase(1)]
        [TestCase(15)]
        [TestCase(20)]
        public void IsPrime_ReturnFalse(int num)
        {
            // Prepare
            var primeservice = new PrimeService();
            // Act
            var result = primeservice.IsPrime(num);
            // Assert            
            Assert.IsFalse(result);
        }
    }
}