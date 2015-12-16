using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _6MilesToKilometersInteractive
{
    class MilesToKilometersInteractive
    {
        static void Main(string[] args)
        {
            WriteLine("Programming Exercise: 6 Miles To Kilometers Interactive\n");

            Write("Enter total miles: ");
            string milesString = ReadLine();
            double miles = Convert.ToDouble(milesString);
            const double CONVERSION = 1.6;
            double kilometers = miles * CONVERSION;
            WriteLine("\nMiles: {0}\nKilometers: {1}", miles, kilometers);
        }
    }
}
