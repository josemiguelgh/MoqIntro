using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleClient.Unit
{
    [TestFixture]
    public class SupposedlyTestableClassTests
    {
        [Test]
        public void SimplestCaseEver_LowValues_ReturnsExpectedResult()
        {
            //Arrange
            int baseNumber = 4;
            int powerNumber = 4;
            int expectedResult = 256;

            var classToBeTested = new SupposedlyTestableClass();
            //Act
            var result = classToBeTested.SimplestCaseEver(baseNumber, powerNumber);
            //Assert	
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void DependentMethod_LowValues_ReturnsExpectedResult()
        {
            //Arrange
            int baseNumber = 4;
            int powerNumber = 4;
            int expectedResult = 256;

            var classToBeTested = new SupposedlyTestableClass();
            //Act
            var result = classToBeTested.DependentMethod(baseNumber, powerNumber);
            //Assert	
            Assert.AreEqual(expectedResult, result);
        }
    }
}
