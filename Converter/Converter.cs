using System;

// ReSharper disable once CheckNamespace
namespace HelperLibrary
{
    public interface IConverter
    {
        int ConvertPoweredNumber(double poweredNumber);
    }

    public class Converter
    {
        public int ConvertPoweredNumber(double poweredNumber)
        {
            //Logic put here just for demo purposes
            return Convert.ToInt32(poweredNumber);
        }
    }

    public class TestableConverter : IConverter
    {
        public int ConvertPoweredNumber(double poweredNumber)
        {
            //Logic put here just for demo purposes
            return Convert.ToInt32(poweredNumber);
        }
    }
}
