using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8DisplayMultiplicationTable
{
    class DisplayMultiplicationTable
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 10; x++)
            {
                WriteLine("\n");
                for (int y = 1; y <= 10; y++)
                    Write("{0,5}", x * y);
            }
            Read();

        }
    }
}
