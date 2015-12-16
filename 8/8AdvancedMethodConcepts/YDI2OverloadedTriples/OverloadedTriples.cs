using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace YDI2OverloadedTriples
{
    class OverloadedTriples
    {
        static void Main(string[] args)
        {
            int num = 20;
            string message = "Go team!";
            Triple(num);
            Triple(message);
        }

        private static void Triple(int num)
        {
            const int MULT_FACTOR = 3;
            WriteLine("{0} * {1} = {2}\n", num, MULT_FACTOR, num * MULT_FACTOR);
        }

        private static void Triple(string message)
        {
            WriteLine("{0}\t{0}\t{0}\n", message);
        }
    }
}
