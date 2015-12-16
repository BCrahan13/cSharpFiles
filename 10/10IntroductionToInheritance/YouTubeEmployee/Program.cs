using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace YouTubeEmployee
{
    //BaseClass
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public void PrintFullName()
        {
            WriteLine(FirstName + " " + LastName);
        }
    }
                //DerivedClassName : BaseClassName 
    public class FullTimeEmployee : Employee
    {
        public float YearlySalary { get; set; }
    }

                //DerivedClassName : BaseClassName 
    public class PartTimeEmployee : Employee
    {
        public float HourlyRate { get; set; }
    }

    public class A : PartTimeEmployee
    {

    }

    //ApplicationClass
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.FirstName = "Fred";
            fte.LastName = "Thompson";
            fte.YearlySalary = 50000;
            
            fte.PrintFullName();

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.FirstName = "Pat";
            pte.LastName = "Tilroy";
            pte.PrintFullName();
        }
    }
}
