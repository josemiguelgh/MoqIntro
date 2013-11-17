using System;
using HelperLibrary;

namespace ConsoleClient
{
    public class SupposedlyTestableClass
    {
        public int SimplestCaseEver(int baseNumber, int powerNumber)
        {
            var poweredNumber = Math.Pow(baseNumber, powerNumber);
            return Convert.ToInt32(poweredNumber);
        }

        public int DependentMethod(int baseNumber, int powerNumber)
        {
            var poweredNumber = Math.Pow(baseNumber, powerNumber);
            var converter = new Converter();
            return converter.ConvertPoweredNumber(poweredNumber);
        }
    }
}