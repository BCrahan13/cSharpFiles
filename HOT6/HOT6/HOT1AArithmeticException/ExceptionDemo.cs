using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Exception;

namespace HOT1AArithmeticException
{
    class ExceptionDemo
    {
        static void Main(string[] args)
        {
            int userInput = 0;

            //ArithmeticException
            double myNan = Double.NaN;

            //InvalidCastException
            object obj = new Object();
            int i;

            //NullReferenceException

            try
            {
             //   Write("Enter an integer: ");
             //   userInput = Convert.ToInt32(ReadLine());

                //ArithmeticException
              //  Math.Sign(myNan);

                //InvalidCastException
                i = (int)obj;

                //NullReferenceException

            }
            catch (ArithmeticException ex)
            {
                WriteLine("ArithmeticException thrown");
            }
            catch(FormatException ex)
            {
                WriteLine("FormatException thrown");
            }
            catch (InvalidCastException ex)
            {
                WriteLine("InvalidCastException thrown");
            }
            catch (NullReferenceException ex)
            {
                WriteLine("NullReferenceException thrown");
            }
            WriteLine("userInput = " + userInput);
        }
    }
}
