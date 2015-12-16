using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _9CarRental
{
    class CarRental
    {
        static void Main(string[] args)
        {
            const double COSTPERDAY = 20.00;
            const double COSTPERMILE = 0.25;

            Write("Enter your total miles: ");
            string milesString = ReadLine();
            double miles = Convert.ToDouble(milesString);
            double milesCost = miles * COSTPERMILE;

            Write("Enter your total days: ");
            string daysString = ReadLine();
            double days = Convert.ToDouble(daysString);
            double daysCost = days * COSTPERDAY;

            double total = milesCost + daysCost;

            WriteLine("\nTotal Days: {0}"
                    + "\nDaily Cost: {1:c}"
                    + "\n\nTotal Miles: {2}"
                    + "\nMiles Cost: {3:c}"
                    + "\n\nTotal Cost: {4:c}", days, daysCost, miles, milesCost, total);

        }
    }
}
