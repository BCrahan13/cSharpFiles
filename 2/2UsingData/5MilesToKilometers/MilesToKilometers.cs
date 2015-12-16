using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _5MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            double miles = 3;
            const double CONVERSION = 1.6;
            double kilometers = miles * CONVERSION;
            WriteLine("\nMiles: {0}\nKilometers: {1}", miles, kilometers);
        }
    }
}
