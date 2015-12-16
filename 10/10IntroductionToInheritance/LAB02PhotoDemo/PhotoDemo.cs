using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB02PhotoDemo
{
    class PhotoDemo
    {
        static void Main(string[] args)
        {
            Photo photo1 = new Photo(8, 10);
            WriteLine(photo1);

            MattedPhoto photo2 = new MattedPhoto(10, 12, "yellow");
            WriteLine(photo2);

            FramedPhoto photo3 = new FramedPhoto(8, 12, "metal", "jagged");
            WriteLine(photo3);
        }
    }
}
