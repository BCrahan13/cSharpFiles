using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FastFood myPlace = new FastFood();
            Restaurant myRestaurant = new Restaurant();
            FastFood yourFastFoodPlace = new FastFood(30, "Dennys", 3.99, 4);
            School ranken = new School();

            myRestaurant.LockBuilding();
            ranken.LockBuilding();
            myRestaurant.Unlock();
            myPlace.Unlock();
            ranken.TurnOffAlarm();

            int num = 100;
            
            
        }
    }
}
