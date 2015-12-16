using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _17Payroll
{
    class Program
    {
        static void Main()
        {
            Write("Enter Name: ");
            string name = ReadLine();

            Write("Enter SSN: ");
            string ssnString = ReadLine();
            double ssn = Convert.ToDouble(ssnString);

            Write("Enter hourly pay rate: ");
            string payRateString = ReadLine();
            double payRate = Convert.ToDouble(payRateString);

            Write("Enter number of hours worked: ");
            string hoursWorkedString = ReadLine();
            double hoursWorked = Convert.ToDouble(hoursWorkedString);

            

            double grossPay = hoursWorked * payRate;
            double federalWithholding = grossPay * 0.15;
            double stateWithholding = grossPay * 0.05;
            double netPay = grossPay - (federalWithholding + stateWithholding);

            WriteLine(grossPay);
            WriteLine(federalWithholding);
            WriteLine(stateWithholding);
            WriteLine(netPay);

            WriteLine("name={0}, ssn={1}, payRate={2:c}, hoursWorked={3}", name, ssn, payRate, hoursWorked);
            //WriteLine("\nGross Pay: {0:c}\nFederal withholding: {1:c}\nState Withholding: (2:c}\nTotal net pay: {3:c}", grossPay, federalWithholding, stateWithholding, netPay);
        }
    }
}
