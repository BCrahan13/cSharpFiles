using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Write("Enter any integer: ");
            int input = Convert.ToInt32(ReadLine());
            Write("\ninput X i = result\n");
            for (int i = 1; i <= 10; i++)
            {
                int result = input * i;
                WriteLine("\n{0,2} X {1,2} = {2,2} ", input, i, result);
            }
        }
    }
}
