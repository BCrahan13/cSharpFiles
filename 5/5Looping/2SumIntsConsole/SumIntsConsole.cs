using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _2SumIntsConsole
{
    class SumIntsConsole
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int endNum = 0;
            while (endNum != 1)
            {
                WriteLine("Enter num: ");
                count = Convert.ToInt32(ReadLine());
                sum += count;
                if (count == 999)
                {
                    endNum = 1;
                    sum -= 999;
                }
            }

            WriteLine("sum = " + sum);
        }
    }
}
