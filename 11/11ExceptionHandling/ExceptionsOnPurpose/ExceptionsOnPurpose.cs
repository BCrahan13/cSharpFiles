using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExceptionsOnPurpose
{
    //You Do It
    //Purposely Causing Exceptions
    //C# generates SystemExceptions automatically under many circumstances
    //In the next steps, you purposely generate a SystemException by executing 
    //a program that provides multiple opportunities for Exceptions.
    class ExceptionsOnPurpose
    {
        static void Main(string[] args)
        {
            int answer;
            int result;
            int zero = 0;
            try
            {
                Write("Enter an integer >> ");
                answer = Convert.ToInt32(ReadLine());
                result = answer / zero;
            }
            catch (Exception ex)
            {
                WriteLine("You did not enter an integer");
            }
            //catch(DivideByZeroException ex)
            {
                WriteLine("This is not your fault.\nYou entered the integer incorrectly.\nThe program divides by zero.");
            }
        }
    }
}
