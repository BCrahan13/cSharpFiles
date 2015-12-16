using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int b = 0;
            try
            {
                MethodA();
            }
            //catch (DivideByZeroException e)
            //{
            //    ++b;
            //}
            //catch (Exception e)
            //{
            //    ++b;
            //}
            catch (CustomException ex)
            {
                WriteLine(ex.Message);
                WriteLine(ex.StackTrace);
            }

            //double numerator = 12;
            //double denominator = 0;
            //int[] array = { 22, 33, 44 };
            //int num = 13;
            //double result;

            //try
            //{
            //    //result = array[num];
            //    //result = numerator / denominator;

            //    int nums = Convert.ToInt32(ReadLine());
            //}
            //catch (DivideByZeroException ex)
            //{
            //    WriteLine("Divide by zero error");
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    WriteLine("Index out of bounds of array");
            //}
            //catch (Exception ex)
            //{
            //    WriteLine("Generic exception");
            //}
            //WriteLine("Prog keeps running");
        }





        private static void MethodA()
        {
            try
            {
                MethodB();
            }
            catch (CustomException ex)
            {
                WriteLine("This was handled in A but rethrown");
                throw;
            }
        }
        private static void MethodB()
        {
            try
            {
                MethodC();
            }
            catch (CustomException ex)
            {
                WriteLine("This was handled in B but rethrown");
                throw;
            }
        }
        private static void MethodC()
        {
            throw (new CustomException());
        }


    }
}
