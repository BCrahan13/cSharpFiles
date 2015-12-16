using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB04TilingDemo
{
    class TilingDemo
    {
        static void Main(string[] args)
        {
            Tiling[] tilingArray = new Tiling[10];
            for (int x = 0; x < tilingArray.Length; ++x)
            {
                Write("Enter the length for room {0}: ", x + 1);
                int length = Convert.ToInt32(ReadLine());
                while (length < 0)
                {
                    Write("Negative Number Error\nReenter length for room {0}: ", x + 1);
                    length = Convert.ToInt32(ReadLine());
                }

                Write("Enter the width for room {0}: ", x + 1);
                int width = Convert.ToInt32(ReadLine());
                while (width < 0)
                {
                    Write("Negative Number Error\nReenter width for room {0}: ", x + 1);
                    width = Convert.ToInt32(ReadLine());
                }

                int FloorArea = length * width;

                tilingArray[x] = new Tiling(length, width, FloorArea);
                WriteLine("Room {0}\tL: {1}\tW: {2}\tFloor Area: {3} square feet\tTotal Boxes: {4}", x + 1, length, width, FloorArea, tilingArray[x].NumBoxes);

                //WriteLine("Total boxes: {0}", tilingArray[x].NumBoxes);
            }
        }
    }
}
