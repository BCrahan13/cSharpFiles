using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDI01DemoLoan
{
    class Loan
    {
        protected double loanAmount;
        //public int loanNumber;

        public int LoanNumber {
            get
            {
                return base.LoanNumber;
            }
            set
            {
                if (value < LOWEST_INVALID_NUM)
                    base.LoanNumber = value;
                else
                    base.LoanNumber = value % LOWEST_INVALID_NUM;
            }
        }
        public string LastName { get; set; }
        public double LoanAmount {
            get
            {
                return loanAmount;
            }
            set
            {
                if (value < MINIMUM_LOAN)
                    loanAmount = MINIMUM_LOAN;
                else
                    loanAmount = value;
            }
        }

        public const double MINIMUM_LOAN = 5000;
    }
}
