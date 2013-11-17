using System;
using HelperLibrary;

namespace ConsoleClient
{
    public class TestableClass
    {
        private IConverter converter;
        public TestableClass(IConverter converter)
        {
            this.converter = converter;
        }

        public int DependentMethod(int baseNumber, int powerNumber)
        {
            var poweredNumber = Math.Pow(baseNumber, powerNumber);
            return converter.ConvertPoweredNumber(poweredNumber);
        }
    }
}
