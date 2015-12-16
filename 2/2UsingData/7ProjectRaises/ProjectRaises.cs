using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7ProjectRaises
{
    class ProjectRaises
    {
        static void Main(string[] args)
        {
            const double RAISE = 0.04;
            double emp1 = 40000;
            double emp1Update = emp1 * RAISE;
            double emp1Salary = emp1 + emp1Update;

            double emp2 = 50000;
            double emp2Update = emp2 * RAISE;
            double emp2Salary = emp2 + emp2Update;

            double emp3 = 60000;
            double emp3Update = emp3 * RAISE;
            double emp3Salary = emp3 + emp3Update;

            WriteLine("Employee 1's year 1 salary is: {0:c}\nEmployee 1's year 2 salary after a 4 percent raise is: {1:c}\n"
                    + "\nEmployee 2's year 1 salary is: {2:c}\nEmployee 2's year 2 salary after a 4 percent raise is: {3:c}\n"
                    + "\nEmployee 3's year 1 salary is: {4:c}\nEmployee 3's year 2 salary after a 4 percent raise is: {5:c}\n", emp1, emp1Salary, emp2, emp2Salary, emp3, emp3Salary);

        }
    }
}
