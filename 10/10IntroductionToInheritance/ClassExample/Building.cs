using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassExample
{
    public abstract class Building : IOpen, IClose
    {
        public int NumWindows { get; set; }
        public int NumDoors { get; set; }

        //Abstract method
        public abstract void LockBuilding();

        //implement interface
        //IOpen
        public void Unlock()
        {
            WriteLine("Unlock the door");
        }
        public void TurnOffAlarm()
        {
            WriteLine("The code to turn off the alarm is 555");
        }
        public void TurnOnLights()
        {
            WriteLine("Turn on lights");
        }
        //IClose
        public void TurnOnAlarm()
        {
            WriteLine("The alarm is now armed");
        }
    }
}
