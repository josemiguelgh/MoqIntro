using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            int baseNumber = 4;
            int powerNumber = 4;
            var x = new SupposedlyTestableClass();
            var result = x.SimplestCaseEver(baseNumber, powerNumber);
            Console.WriteLine("{0} ^ {1} = {2}", baseNumber, powerNumber, result);
            Console.ReadLine();
        }
    }
}
