using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _14GuessingGame2Redo
{
    class GuessingGame2
    {
        static void Main(string[] args)
        {
            const int MIN = 0;
            const int MAX = 11;
            //int playerGuess;
            Random randomNumGenerator = new Random();
            int randomNum = randomNumGenerator.Next(MIN, MAX);
            int guesses = 0;

            //string player1;
            WriteLine("Guessing Game");

            do
            {
                Write("\nPick a number 1-10: ");
                string player1 = ReadLine();
                int playerGuess = Convert.ToInt32(player1);
                if (playerGuess > 10 || playerGuess < 1)
                {
                    WriteLine("Please select a number 1-10.");
                    //++guesses;
                }
                else if (playerGuess < randomNum)
                {
                    WriteLine("Your guess was {0}. Too low", playerGuess);
                    ++guesses;
                }
                else if (playerGuess > randomNum)
                {
                    WriteLine("Your guess was {0}. Too high", playerGuess);
                    ++guesses;
                }
                else if (playerGuess == randomNum)
                {
                    WriteLine("Your guess was {0}. The answer is {1}. You win!", playerGuess, randomNum);
                    ++guesses;
                }
            } while (playerGuess != randomNum);

            WriteLine("\nTotal tries: {0}", guesses);
        }
    }
}
