using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB1BReverse4
{
    class Reverse4
    {
        static void Main(string[] args)
        {
            int firstInt = 1,
                secondInt = 2,
                thirdInt = 3,
                fourthInt = 4;
            WriteLine("Before swap \nfirst = {0}", firstInt);
            WriteLine("second = {0}", secondInt);
            WriteLine("third = {0}", thirdInt);
            WriteLine("fourth = {0}", fourthInt);
            Swap(ref firstInt, ref secondInt, ref thirdInt, ref fourthInt);
            WriteLine("\nAfter swap \nfirst = {0}", firstInt);
            WriteLine("second = {0}", secondInt);
            WriteLine("third = {0}", thirdInt);
            WriteLine("fourth = {0}\n", fourthInt);
        }

        private static void Swap(ref int one, ref int two, ref int three, ref int four)
        {
            int temp1 = one;
            int temp2 = two;
            int temp3 = three;
            one = four;
            two = temp3;
            three = temp2;
            four = temp1;
        }
    }
}
