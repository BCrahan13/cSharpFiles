using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18MonthNames
{
    class MonthNames
    {

        enum Month
        {
            January = 1, Februrary, March, April, May, June, July, August, September, October, November, December
        }

        static void Main(string[] args)
        {
            Write("Which month were you born? ");
            string monthString = ReadLine();
            int monthNum = Convert.ToInt32(monthString);
            Month month = (Month)monthNum;
            WriteLine("You were born in {0}", month);
        }
    }
}
