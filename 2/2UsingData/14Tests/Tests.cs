using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _14Tests
{
    class Tests
    {
        static void Main(string[] args)
        {
            const double TESTS = 5.00;

            Write("test1:");
            string test1String = Console.ReadLine();
            double test1 = Convert.ToDouble(test1String)/100.00;

            Write("test2:");
            string test2String = Console.ReadLine();
            double test2 = Convert.ToDouble(test2String)/100.00;

            Write("test3:");
            string test3String = Console.ReadLine();
            double test3 = Convert.ToDouble(test3String)/100.00;

            Write("test4:");
            string test4String = Console.ReadLine();
            double test4 = Convert.ToDouble(test4String)/100.00;

            Write("test5:");
            string test5String = Console.ReadLine();
            double test5 = Convert.ToDouble(test5String)/100.00;

            double average = (test1 + test2 + test3 + test4 + test5) / TESTS;

            WriteLine("\ntest1={0:f2}\ntest2={1:f2}\ntest3={2:f2}\ntest4={3:f2}\ntest5={4:f2}\nAverage={5:f2}", test1, test2, test3, test4, test5, average);




        }
    }
}
