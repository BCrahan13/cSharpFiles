using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB09SalespersonDemo
{
    class SalesPersonDemo
    {
        static void Main(string[] args)
        {
            RealEstateSalesPerson realEstatePerson = new RealEstateSalesPerson("Joe", "Horton", 0.08);
            GirlScout girlScoutPerson = new GirlScout("Kathy", "Jones");

            realEstatePerson.SalesSpeech();
            girlScoutPerson.SalesSpeech();

            realEstatePerson.MakeSale(7500);
            realEstatePerson.MakeSale(2000);
            realEstatePerson.MakeSale(1800);

            girlScoutPerson.MakeSale(150);
            girlScoutPerson.MakeSale(370);
            
            WriteLine("\nReal Estate Sales Person\nName: " + realEstatePerson.getFullName() + "\nTotal Values Sold: " + realEstatePerson.TotalValueSold.ToString("C2") + "\nCommission Rate: " + realEstatePerson.CommissionRate.ToString() + "\nTotal Commission Earned: " + realEstatePerson.TotalCommissionEarned.ToString("C2"));
            WriteLine("\nGirl Scout Sales Person\nName: " + girlScoutPerson.getFullName() + "\nBoxes Sold: " + girlScoutPerson.NumOfBoxesSold.ToString());
        }
    }
}
