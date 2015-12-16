using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HOT3
{
    class HOT3
    {
        static void Main(string[] args)
        {
            const double TSHIRT_COST = 14.99;
            const double TAX = 0.08;

            Write("Enter your name: ");
            string name = ReadLine();

            Write("Street address: ");
            string streetAddress = ReadLine();

            Write("City: ");
            string city = ReadLine();

            Write("State: ");
            string state = ReadLine();

            Write("Zip: ");
            string zip = ReadLine();

            Write("How many T-Shirts did you want to order? ");
            string numTshirtsString = ReadLine();
            double numTshirts = Convert.ToDouble(numTshirtsString);


            WriteLine("\n\nReceipt for:"
                    + "\n{0}"
                    + "\n{1}"
                    + "\n{2}, {3} {4}"
                    + "\n\n{5} T-Shirts ordered @ {6:c} each", name, streetAddress, city, state, zip, numTshirts, TSHIRT_COST);

            double total = numTshirts * TSHIRT_COST;
            double taxAmount = total * TAX;
            double subTotal = total + taxAmount;

            WriteLine("\nTotal:\t{0:c}"
                    + "\nTax:\t{1:c}"
                    + "\n----------------"
                    + "\nDue:\t{2:c}", total, taxAmount, subTotal);
        }
    }
}
