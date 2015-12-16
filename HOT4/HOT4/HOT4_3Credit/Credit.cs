using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HOT4_3Credit
{
    class Credit
    {
        static void Main(string[] args)
        {
            //double creditInput;

            WriteLine("Enter amount of credit granted: ");
            double creditInput = Double.Parse(ReadLine());

            CustomerCreditLimit(creditInput);
            //WriteLine(creditInput);
        }

        private static void CustomerCreditLimit(double creditInput)
        {
            WriteLine("the amount of credit granted to a customer is: {0:c}", creditInput);
        }

        private static void CustomerCreditLimit()
        {
            double defaultCredit = 500.00;
            WriteLine("the amount of credit granted to a customer is: {0:c}", defaultCredit);
        }

        private static void CustomerCreditLimit(double v, double creditInput)
        {
            WriteLine("the credit input = {0}", creditInput);
        }
    }
}
