using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HOT4_1Fibonacci
{
    class Fibonacci
    {

        static string userInputString = "";

        static void Main(string[] args)
        {
            //index
            //int n;
            int[] fibonacciArray = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            Write("Enter an integer: ");
            int n = Convert.ToInt32(ReadLine());

            BinarySearch(fibonacciArray[n])
            {
                int low = 0;
                int high = n - 1;
                while (low <= high)
                {
                    int mid = low + ((high - low) / 2);
                    if (A[mid] > value)
                        high = mid - 1;
                    else if (A[mid] < value)
                        low = mid + 1;
                    else
                        return mid; // found
                }
                return -1; // not found
            }
            Fibonacci(n);

            //int[] fibonacciArray = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            //int i = 0;
            //int temp = 0;
            //int sum = 0;
            //while (temp < 4000000)
            //{
            //    temp = Fibonacci(i);
            //    WriteLine(temp + "\n");
            //    if (temp % 2 == 0 && temp < 4000000)
            //    {
            //        sum += temp;
            //    }
            //    i++;
            //}
            //WriteLine(sum);
        }

        private static int Fibonacci(int n)
        {
            return n;
            //if (n == 0)
            //{
            //    return 0;
            //}
            //else if (n == 1)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return (fibonacci(n - 2) + fibonacci(n - 1));
            //}
        }

    }
}
