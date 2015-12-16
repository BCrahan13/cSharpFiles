using static System.Console;

namespace LAB09SalespersonDemo
{
    class RealEstateSalesPerson : SalesPerson
    {
        public double TotalValueSold { get; set; }
        public double TotalCommissionEarned { get; set; }
        public double CommissionRate { get; set; }

        public RealEstateSalesPerson(string first, string last, double rate) : base(first, last)
        {
            TotalValueSold = 0;
            TotalCommissionEarned = 0;
            CommissionRate = rate;
        }

        public void SalesSpeech()
        {
            WriteLine("\nReal Estate Sales Person Speech\nI am a Real Estate Sales Person and My name is: " + getFullName() + ".\nI have 20 years experience in real estate sales.");
        }
        
        public void MakeSale(int val)
        {
            TotalValueSold += val;
            TotalCommissionEarned = CommissionRate * TotalValueSold;
        }
    }
}