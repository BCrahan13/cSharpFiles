using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _10Perfect
{
    class Perfect
    {
        static void Main(string[] args)
        {
            int pNum = 0, testNum = 0, sum = 0;
            double dubNum = 0;

            for (pNum = 1; pNum <= 1000; ++pNum)
            {
                //reset
                sum = 0;
                testNum = 1;
                dubNum = pNum;
                while (pNum > testNum)
                {
                    //finds ints and add to sum
                    if ((pNum / testNum)==(dubNum / testNum))
                    {
                        sum += testNum;
                    }
                    ++testNum;
                }
                //prints if its a Pnum
                if (pNum == sum)
                {
                    WriteLine(pNum + " perfect num");
                }
            }
            







        }
    }
}
