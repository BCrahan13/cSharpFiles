using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _11TippingTable
{
    class TippingTable
    {
        static void Main(string[] args)
        {
            double dinnerPrice = 10.00;
            double tipRate;
            double tip;

            //const double LOWRATE = 0.10;
            //const double MAXRATE = 0.25;
            const double TIPSTEP = 0.05;
            //const double MAXDINNER = 100.00;
            //const double DINNERSTEP = 10.00;

            Write("Lowest tipping percentage rate: ");
            double lowRate = Convert.ToDouble(ReadLine());

            Write("Max tipping percentage rate: ");
            double maxRate = Convert.ToDouble(ReadLine());

            Write("Lowest possible restaurant bill: ");
            double dinnerStep = Convert.ToDouble(ReadLine());

            Write("Highest restaurant bill: ");
            double maxDinner = Convert.ToDouble(ReadLine());

            Write("Price");
            for (tipRate = lowRate; tipRate <= maxRate; tipRate += TIPSTEP)
                Write("{0,8}", tipRate.ToString("F"));
            WriteLine();
            WriteLine("--------------------------------------");
            
            tipRate = lowRate;

            do
            {
                Write("{0,8}", dinnerPrice.ToString("C"));
                while (tipRate <= maxRate)
                {
                    tip = dinnerPrice * tipRate;
                    Write("{0,8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += dinnerStep;
                tipRate = lowRate;
                WriteLine();
            } while (dinnerPrice <= maxDinner);

        }
    }
}
