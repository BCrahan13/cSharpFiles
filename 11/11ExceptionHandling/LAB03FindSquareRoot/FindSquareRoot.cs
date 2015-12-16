using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB03FindSquareRoot
{
    class FindSquareRoot
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;

            do
            {
                try
                {
                    string inputString;
                    double number;

                    Write("Enter a value to calculate the square root: ");

                    //if (Double.TryParse(inputString, out number))

                    string userInput = ReadLine();
                                        

                    //WriteLine("The square root of {0} is {1}", userInput, Math.Sqrt(userInput));
                }
                catch (FormatException formatException)
                {
                    WriteLine(formatException.Message);
                    Write("Format exception!\tReenter a double value: ");
                }
                //catch (NegativeNumberException negativeNumberException)
                //{
                //    WriteLine(negativeNumberException.Message);
                //    Write("Negative number exception!\tReenter a non-negative double value: ");
                //}
            } while (continueLoop);

        }
    }
}
