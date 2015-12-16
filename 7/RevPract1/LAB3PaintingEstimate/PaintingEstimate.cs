using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB3PaintingEstimate
{
    class PaintingEstimate
    {
        static void Main(string[] args)
        {
            Write("Enter wall 1's length: ");
            double wall1 = Convert.ToDouble(ReadLine());
            Write("Enter wall 2's length: ");
            double wall2 = Convert.ToDouble(ReadLine());
            CalcTotal(wall1, wall2);
        }
        private static void CalcTotal(double wall1, double wall2)
        {
            const double HEIGHT = 9.0;
            const double COSTPERFOOT = 6.00;
            double wall1Dimension = 2*(wall1 * HEIGHT);
            double wall2Dimension = 2*(wall2 * HEIGHT);
            double totalSize = wall1Dimension + wall2Dimension;
            double totalPrice = totalSize * COSTPERFOOT;

            WriteLine();
            WriteLine("wall 1 = " + wall1);
            WriteLine("wall 2 = " + wall2);
            WriteLine("wall 1 Dim = " + wall1Dimension);
            WriteLine("wall 2 Dim = " + wall2Dimension);
            WriteLine("total size = " + totalSize);
            WriteLine("total price = {0:c}", totalPrice);
        }
    }
}
