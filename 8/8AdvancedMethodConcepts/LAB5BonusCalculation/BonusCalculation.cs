using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB5BonusCalculation
{
    class BonusCalculation
    {
        static void Main(string[] args)
        {
            Write("Enter salary: ");
            string salaryString = ReadLine();

            double salary;

            double.TryParse(salaryString, out salary);


            Write("Enter bonus: ");
            string bonusString = ReadLine();

            double bonusPercent;
            int bonus;

            int.TryParse(bonusString, out bonus);

            if (!int.TryParse(bonusString, out bonus))
            {
                double.TryParse(bonusString, out bonusPercent);
                GetTotal(salary, bonusPercent);
            }
            else
                GetTotal(salary, bonus);
        }

        private static void GetTotal(double salary, int bonus)
        {
            WriteLine("\nsalary = {0:c} + bonus ({1:c}) = a total of {2:c}", salary, bonus, salary + bonus);
        }

        private static void GetTotal(double salary, double bonusPercent)
        {
            WriteLine("\nsalary = {0:c} x bonusPercent ({1}%) = a total of {2:c}", salary, bonusPercent * 100, salary + (salary * bonusPercent));
        }
    }
}
