using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _16FarenheitToCelsius
{
    class FarenheitToCelsius
    {
        static void Main(string[] args)
        {
            const double CONVERSION = 5.0 / 9.0;

            Write("Enter temperature in farenheit: ");
            string input = ReadLine();
            double farenheit = Convert.ToDouble(input);

            double celsius = (farenheit - 32.0) * CONVERSION;

            WriteLine("\nF={0:f2}, C={1:f2}", farenheit, celsius);

        }
    }
}
