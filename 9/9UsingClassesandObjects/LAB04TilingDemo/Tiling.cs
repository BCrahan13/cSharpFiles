using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB04TilingDemo
{
    class Tiling
    {
        public int RoomLength { get; set; }
        public int RoomWidth { get; set; }
        public int FloorArea { get; set; }
        public int NumBoxes { get; set; }
        public const int EXTRA_BOXES_LIMIT = 120;

        public Tiling()
        {
            RoomLength = 0;
            RoomWidth = 0;
            FloorArea = 0;
            NumBoxes = 0;
        }
        public Tiling(int length, int width, int FloorArea)
        {
            RoomLength = length;
            RoomWidth = width;
            //FloorArea = length * width;
            NumBoxes = GetNumBoxes(FloorArea);
        }
        public int GetNumBoxes(int FloorArea)
        {
            if (FloorArea % 12 == 0)
            {
                NumBoxes = FloorArea / 12;
                NumBoxes += 1;
            }
            else
            {
                NumBoxes = FloorArea / 12;
                NumBoxes += 2;
            }
            return NumBoxes;
        }
    }
}
