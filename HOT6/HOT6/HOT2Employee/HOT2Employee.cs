using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace HOT2Employee
{
    class HOT2Employee
    {
        static void Main()
        {
            const int END = 999;
            const string DELIM = ",";
            const string FILENAME = "EmployeeData3.txt";
            double maxSalary = 0.00;

            Employee emp = new Employee();

            Write("Enter Max Salary to read >> ");
            maxSalary = Convert.ToDouble(ReadLine());

            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            Write("Enter Employee Id or " + END + " to quit >> ");
            emp.EmpId = Convert.ToInt32(ReadLine());
            while (emp.EmpId != END)
            {
                Write("Enter First Name >> ");
                emp.FirstName = ReadLine();
                Write("Enter Last Name >> ");
                emp.LastName = ReadLine();
                Write("Enter Salary >> ");
                emp.Salary = Convert.ToDouble(ReadLine());

                if (emp.Salary > maxSalary)
                {
                    emp.EmpId = 00000;
                    emp.Salary = 0.00;
                }
                writer.WriteLine(emp.EmpId + DELIM + emp.FirstName + DELIM + emp.LastName + DELIM + emp.Salary);
                Write("Enter next Employee Id or " + END + " to quit >> ");
                emp.EmpId = Convert.ToInt32(ReadLine());
            }
            writer.Close();
            outFile.Close();
        }
    }
    class Employee
    {
        double maxSalary = 0.00;

        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public double MaxSalary
        {
            get
            {
                return maxSalary;
            }
            set
            {
                MaxSalary = value;
            }
        }

    }
}
