using System;
using static System.Console;
class MilesPerGallon2
{
   static void Main()
   {
      int milesDriven;
      int gallonsOfGas;
      int mpg;
      try
      {
         Write("Enter miles driven ");
         milesDriven = Convert.ToInt32(ReadLine());
         Write("Enter gallons of gas purchased ");
         gallonsOfGas = Convert.ToInt32(ReadLine());
         mpg = milesDriven / gallonsOfGas;
      }
      catch(Exception e)
      {
         mpg = 0;
         WriteLine("You attempted to divide by zero!");
      }
      WriteLine("You got {0} miles per gallon", mpg);
   }
}
