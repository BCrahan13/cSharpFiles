using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB1ArrayDemoRedo
{
    class ArrayDemoRedo
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 15, 88, 85, 22, 54, 62, 77, 22 };
            int x;
            int userInput;
            char response = ' ';
            WriteLine("1. View in order"
              + "\n2. View in reverse"
              + "\n3. Choose specific pos to view");
            do
            {
                WriteLine("Enter 1, 2, or 3");
                userInput = Convert.ToInt32(ReadLine());
                switch (userInput)
                {
                    case 1:
                        for (x = 0; x < intArray.Length; ++x)
                            Write("{0, 3}", intArray[x]);
                        break;
                    case 2:
                        Array.Reverse(intArray);
                        for (x = 0; x < intArray.Length; ++x)
                            Write("{0, 3}", intArray[x]);
                        break;
                    case 3:
                        WriteLine();
                        int pos = 0;
                        WriteLine("Pick position 0-7: ");
                        pos = Convert.ToInt32(ReadLine());
                        if (pos >= 0 && pos <= 7)
                            WriteLine(intArray[pos]);
                        else
                            WriteLine("Invalid position");
                        break;
                    default:
                        WriteLine("Invalid entry");
                        break;
                }

                WriteLine("\nContinue? Y or N:");
                response = Convert.ToChar(ReadLine());
            } while (response != 'N' && response != 'n');
        }
    }
}
