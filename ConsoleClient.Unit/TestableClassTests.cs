using HelperLibrary;
using Moq;
using NUnit.Framework;

namespace ConsoleClient.Unit
{
    [TestFixture]
    public class TestableClassTests
    {
        [Test]
        public void DependentMethod_LowValues_ReturnsExpectedResult()
        {
            //Arrange
            int baseNumber = 4;
            int powerNumber = 4;
            int expectedResult = 256;
            
            var converterStub = new Mock<IConverter>();
            //configuring Stub 
            converterStub.Setup(x => x.ConvertPoweredNumber(It.IsAny<double>())).Returns(0);
            converterStub.Setup(x => x.ConvertPoweredNumber(256)).Returns(256);
            
            var classToBeTested = new TestableClass(converterStub.Object);
            //Act
            var result = classToBeTested.DependentMethod(baseNumber,powerNumber);
            //Assert	
            Assert.AreEqual(expectedResult, result);
        }
    }
}
