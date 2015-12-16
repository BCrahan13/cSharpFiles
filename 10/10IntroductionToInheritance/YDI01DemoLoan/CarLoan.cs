using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDI01DemoLoan
{
    class CarLoan : Loan
    {
        private int year;
        public int Year {
            get
            {
                return year;
            }
            set
            {
                if (value < EARLIEST_YEAR)
                {
                    year = value;
                    loanAmount = 0;
                }
                else
                    year = value;
            }
        }
        public string Make { get; set; }
        

        private const int EARLIEST_YEAR = 2006;
        private const int LOWEST_INVALID_NUM = 1000;
    }
}
