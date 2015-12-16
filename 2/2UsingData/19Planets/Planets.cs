using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _19Planets
{
    class Planets
    {

        enum Planet
        {
            Mercury = 1, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune, Pluto
        }

        static void Main(string[] args)
        {
            Write("Which planet is your homeland? ");
            string planetString = ReadLine();
            int planetNum = Convert.ToInt32(planetString);
            Planet planet = (Planet)planetNum;
            WriteLine("You live on planet {0}", planet);
        }
    }
}
