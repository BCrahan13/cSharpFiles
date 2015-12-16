using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7OddNums
{
    class OddNums
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 99; x+=2)
            {
                Write("{0,5}", x);
            }
            Read();

        }
    }
}
