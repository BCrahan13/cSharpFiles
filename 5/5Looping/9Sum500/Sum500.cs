using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _9Sum500
{
    class Sum500
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 500; i++)
            {
                sum += i;
            }
            WriteLine("sum = " + sum);
        }
    }
}
