using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB01SubscriptExceptionTest
{
    class SubscriptExceptionTest
    {
        static void Main(string[] args)
        {
            //declare array of 20 doubles           store vals in array
            double[] subscriptArray = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };


            //try block loop to prompt user for subscript val &display the val in correct array position
            try
            {
                for (int i = 0; i < subscriptArray.Length; i++)
                {
                    Write("Enter subscript: ");
                    int sub = Convert.ToInt32(ReadLine());
                    i = sub;
                    WriteLine("subscriptArray[{0}] = {1}\n", i, subscriptArray[i]);
                }
            }
            //catch block to catch any IndexOutOfRangeException & display appropriate error message
            catch (IndexOutOfRangeException ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
