using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _10HoursAndMinutes
{
    class HoursAndMinutes
    {
        static void Main(string[] args)
        {
            const int MINPERHOUR = 60;                     
            Write("Enter total minutes worked: ");
            string minString = ReadLine();
            int min = Convert.ToInt32(minString);         
            int hour = min / MINPERHOUR;
            int minAfterHour = min % MINPERHOUR;
            WriteLine("You have worked for {0} hour(s) and {1} minute(s).", hour, minAfterHour);
        }
    }
}
