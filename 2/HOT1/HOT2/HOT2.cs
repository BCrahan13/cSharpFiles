using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HOT2
{
    class HOT2
    {
        static void Main(string[] args)
        {
            const double NUM = 3;

            Write("Enter number 1: ");
            string num1String = Console.ReadLine();
            double num1 = Convert.ToDouble(num1String);

            Write("Enter number 2: ");
            string num2String = Console.ReadLine();
            double num2 = Convert.ToDouble(num2String);

            Write("Enter number 3: ");
            string num3String = Console.ReadLine();
            double num3 = Convert.ToDouble(num3String);

            double average = (num1 + num2 + num3) / NUM;

            WriteLine("\nThe average is: {0}", average);
        }
    }
}
