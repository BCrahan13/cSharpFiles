using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HOT5Loan
{       //ChildC  : Parent
    class CarLoan : BankLoan
    {
        public string AutoDealerName { get; set; }
        public double CarLoanAmount { get; set; }
    }
}
