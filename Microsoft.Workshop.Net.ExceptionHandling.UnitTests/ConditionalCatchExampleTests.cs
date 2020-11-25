using System;
using Microsoft.Workshop.Net.ExceptionHandling.Examples;
using NUnit.Framework;

namespace Microsoft.Workshop.Net.ExceptionHandling.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldNotThrowGenericException()
        {
            var conditionalCatchExample = new UnitTestExample();
            Assert.That(() => conditionalCatchExample.Execute(), !Throws.TypeOf<Exception>());
        }

        [Test]
        public void ShouldThrowOverflowException()
        {
            var conditionalCatchExample = new UnitTestExample();
            Assert.That(() => conditionalCatchExample.Execute(), Throws.TypeOf<OverflowException>());
        }

        [Test]
        public void ShouldThrowOverflowExceptionWith()
        {
            var conditionalCatchExample = new UnitTestExample();
            Assert.That(() => conditionalCatchExample.Execute(),
                Throws.TypeOf<OverflowException>()
                    .With.Property("HResult")
                    .EqualTo(-2146233066)
            );
        }

        [Test]
        public void ShouldThrowOverflowExceptionWithoutThat()
        {
            var conditionalCatchExample = new UnitTestExample();
            Assert.Throws<OverflowException>(() => conditionalCatchExample.Execute());
        }
    }
}