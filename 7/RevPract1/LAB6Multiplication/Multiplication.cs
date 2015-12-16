using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB6Multiplication
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            Write("Input an integer: ");
            int userInput = Convert.ToInt32(ReadLine());
            if (userInput > 10 || userInput < 2)
            {
                Write("Error\nInput an integer: ");
                userInput = Convert.ToInt32(ReadLine());
            }
            else
                Calculate(userInput);
        }

        private static void Calculate(int userInput)
        {
            for (int i = 2; i <= 10; i++)
            {
                int result = userInput * i;
                WriteLine("\n{0,1} * {1,2} = {2,2} ", userInput, i, result);
            }
        }
    }
}
