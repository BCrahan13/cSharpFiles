using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB7Averages
{
    class Averages
    {
        static void Main(string[] args)
        {
            Write("Enter number to average seperated by spaces: ");
            string listOfNumbers = ReadLine();
            string[] numbers = listOfNumbers.Split(' ');

            int numberInt;

            if(!Int32.TryParse(numbers, out numberInt))

           // WriteLine("numbers = " + numbers);

            GetAverage(listOfNumbers, numbers);

            //Array.Sort(words);
        }

        private static void GetAverage(string listOfNumbers, string[] numbers)
        {
            int total = 0;
            for (int i = 0; i < listOfNumbers.Length; ++i)
            {
                int numbersInt = Convert.ToInt32(numbers);
            }
        }
    }
}
