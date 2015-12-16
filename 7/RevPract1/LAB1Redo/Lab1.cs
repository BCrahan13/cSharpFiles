using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB1Redo
{
    class Lab1
    {
        static void Main(string[] args)
        {
            WriteLine("MethodA: Console.WriteLine()");
            MethodA();

            WriteLine("\nMethodB: String.Equals()");
            MethodB();

            WriteLine("\nMethodC: String.Compare()");
            MethodC();

            WriteLine("\nMethodD: Convert.ToInt32()");
            MethodD();

            WriteLine("\nMethodE: Convert.ToChar()");
            MethodE();

            WriteLine("\nMethodF: Array.Sort()");
            int[] integerArray = { 10, 44, 22, 35, 85 };
            int x;
            Write("At beginning of Main() method...");
            for (x = 0; x < integerArray.Length; ++x)
                Write("{0, 6}", integerArray[x]);
            WriteLine();
            MethodF(integerArray);
            Write("At the end of Main() ...................");
            for (x = 0; x < integerArray.Length; ++x)
                Write("{0, 6}", integerArray[x]);
        }
        private static void MethodA()
        {
            WriteLine("Write Line");
        }
        private static void MethodB()
        {
            string string1 = "Hi Im string 1";
            string string2 = "Hi Im string 2";
            if (string1.Equals(string2))
                WriteLine("IS equal");
            else
                WriteLine("NOT equal");
        }
        private static void MethodC()
        {
            
        }
        private static void MethodD()
        {
            int initialInt = 0;
            int total = 0;
            string integerString = "1";
            int int1 = Convert.ToInt32(integerString);
            WriteLine("String Convert.ToInt32 = " + int1);
            total = initialInt + int1;
            WriteLine("Test: {0} + {1} = {2}", initialInt, int1, total);
        }
        private static void MethodE()
        {
            string inputString = "A";
            char charConversion = Convert.ToChar(inputString);
            WriteLine("String Convert.ToChar = " + charConversion);
        }
        private static void MethodF(int[] vals)
        {
            int x;
            Write("MethodF()");
            for (x = 0; x < vals.Length; ++x)
                Write(" {0}", vals[x]);
            WriteLine();
            for (x = 0; x < vals.Length; ++x)
                vals[x] = 999;
            Write("After change");
            for (x = 0; x < vals.Length; ++x)
                Write(" {0}", vals[x]);
            WriteLine();
            //int[] integerArray = new int[] { 1, 55, 22, 85, 13 };
            //Array.Sort(integerArray);
            //WriteLine("Array.Sort() = " + integerArray);
        }
    }
}
