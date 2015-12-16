using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB10Movie
{
    class Movie
    {
        static void Main(string[] args)
        {
            Write("Enter the movie name: ");
            string movieName = ReadLine();

            int movieTime;
            Write("Enter movie length(min): ");
            string time = ReadLine();
            if (!Int32.TryParse(time, out movieTime))
                GetDetails(movieName);
            else
                GetDetails(movieName, movieTime);
        }

        private static void GetDetails(string movieName)
        {
            int movieTime = 90;
            WriteLine("The movie is: {0} and its length is {1} minutes long", movieName, movieTime);
        }

        private static void GetDetails(string movieName, int movieTime)
        {
            WriteLine("The movie is: {0} and its length is {1} minutes long", movieName, movieTime);
        }
    }
}
