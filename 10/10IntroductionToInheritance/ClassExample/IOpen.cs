using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public interface IOpen
    {
        //implied it's abstract & public
        void Unlock();
        void TurnOffAlarm();
        void TurnOnLights();

    }
}
