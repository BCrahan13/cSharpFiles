using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _13Dollars
{
    class Dollars
    {
        static void Main(string[] args)
        {
            WriteLine("How much money do you currently have: ");
            string amountString = ReadLine();
            int amount = Convert.ToInt32(amountString);

            int twenties =  amount/20;
            int tens = (amount - (twenties * 20))/10;
            int fives = (amount - ((twenties * 20) + (tens * 10))) / 5;
            int ones = (amount - ((twenties * 20) + (tens * 10) + (fives * 5))) / 1;

                        

            WriteLine("Your total is {0:c}\n{1} twenties, {2} tens, {3} fives, and {4} ones.", amount, twenties, tens, fives, ones);

        }
    }
}
