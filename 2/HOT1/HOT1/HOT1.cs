using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HOT1
{
    class HOT1
    {
        static void Main(string[] args)
        {
            Write("Enter your name: ");
            string yourName = ReadLine();
            WriteLine("Hello, {0}!", yourName);
        }
    }
}
