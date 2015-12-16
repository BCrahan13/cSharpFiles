using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB6InputMethodDemo2
{
    class InputMethodDemo2
    {
        static void Main(string[] args)
        {
            int first, second;
            InputMethod(out first, out second);
            WriteLine("After InputMethod first is {0}", first);
            WriteLine("and second is {0}", second);
        }

        private static void InputMethod(out int one, out int two)
        {
            one = DataEntry("first");
            two = DataEntry("second");
        }

        private static int DataEntry(string s)
        {
            Write("Enter {0} int: ", s);
            int userInt = Convert.ToInt32(ReadLine());
            return userInt;
        }

    }
}
