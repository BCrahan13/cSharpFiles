using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HOT3_1
{
    class HOT3_1
    {
        static void Main(string[] args)
        {
            Write("Please enter a number between 2 and 10: ");
            int userInput = Convert.ToInt32(ReadLine());
            if (userInput > 10 || userInput < 2)
                WriteLine("Error");
            else if (userInput > 1 || userInput < 11)
            {
                for (int i = 1; i < userInput; i++)
                {
                    int result = userInput * i;
                    WriteLine("\n{0,1} * {1,2} = {2,2} ", userInput, i, result);
                }
            }
        }
    }
}
