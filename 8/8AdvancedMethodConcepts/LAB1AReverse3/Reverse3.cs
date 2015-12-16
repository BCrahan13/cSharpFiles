using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB1AReverse3
{
    class Reverse3
    {
        static void Main(string[] args)
        {
            int firstInt = 34,
                middleInt = 712,
                lastInt = 257;
            WriteLine("Before swap \nfirst = {0}", firstInt);
            WriteLine("middle = {0}", middleInt);
            WriteLine("last = {0}", lastInt);
            Swap(ref firstInt, ref middleInt, ref lastInt);
            WriteLine("\nAfter swap \nfirst = {0}", firstInt);
            WriteLine("middle = {0}", middleInt);
            WriteLine("last = {0}\n", lastInt);
        }

        private static void Swap(ref int one, ref int two, ref int three)
        {
            int temp;
            temp = one;
            one = three;
            three = temp;
        }
    }
}
