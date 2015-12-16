using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1YDICompareThreeNumbers
{
    class CompareThreeNumbers
    {
        static void Main(string[] args)
        {
            string numberString;

            Write("Enter an integer ");
            numberString = ReadLine();
            int num1 = Convert.ToInt32(numberString);

            Write("Enter an integer ");
            numberString = ReadLine();
            int num2 = Convert.ToInt32(numberString);

            Write("Enter an integer ");
            numberString = ReadLine();
            int num3 = Convert.ToInt32(numberString);

            if (num1 == num2)
                if (num1 == num3)
                    WriteLine("All 3 numbers are equal");
                else
                    WriteLine("First 2 are equal");
            else
                if (num1 == num3)
                WriteLine("First & last are equal");
            else
                if (num2 == num3)
                WriteLine("Last 2 are equal");
            else
                WriteLine("No 2 numbers are equal");
        }
    }
}
