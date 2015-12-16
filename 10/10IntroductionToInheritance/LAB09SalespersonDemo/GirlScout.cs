using static System.Console;

namespace LAB09SalespersonDemo
{
    class GirlScout : SalesPerson
    {
        public int NumOfBoxesSold { get; set; }

        public GirlScout(string first, string last) : base(first, last)
        {
            NumOfBoxesSold = 0;
        }

        public void SalesSpeech()
        {
            WriteLine("\nGirl Scout Sales Person Speech\nI am a girl scout and My name is: " + getFullName() + ".\nI have 3 years of sales experience.");
        }

        public void MakeSale(int val)
        {
            NumOfBoxesSold += val;
        }
    }
}