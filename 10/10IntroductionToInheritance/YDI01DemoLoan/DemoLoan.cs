using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace YDI01DemoLoan
{
    class DemoLoan
    {
        static void Main(string[] args)
        {
            Loan aLoan = new Loan();
            CarLoan aCarLoan = new CarLoan();

            aLoan.LoanNumber = 2239;
            aLoan.LastName = "Mitchell";
            aLoan.LoanAmount = 1000.00;

            aCarLoan.LoanNumber = 3358;
            aCarLoan.LastName = "Jansen";
            aCarLoan.LoanAmount = 20000.00;
            aCarLoan.Make = "Ford";
            aCarLoan.Year = 2005;

            WriteLine("Loan #{0} for {1} is for {2:c}", aLoan.LoanNumber, aLoan.LastName, aLoan.LoanAmount);

            WriteLine("Loan #{0} for {1} is for {2:c}", aCarLoan.LoanNumber, aCarLoan.LastName, aCarLoan.LoanAmount);
            WriteLine("\tLoan #{0} is for {1} {2}", aCarLoan.LoanNumber, aCarLoan.Year, aCarLoan.Make);
        }
    }
}
