using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB07GuessAWordWithExceptionHandling
{
    class GuessAWordWithExceptionHandling
    {
        static void Main(string[] args)
        {
            string[] words = { "apricot", "elephant", "tigers", "fortunate",
                            "impossible", "historical", "colorful", "science" };
            Random RandomClass = new Random();
            int randomNumber;
            randomNumber = RandomClass.Next(0, words.Length);
            string selectedWord = words[randomNumber];
            string guessedWord = "";
            string originalWord = selectedWord;
            string guess;
            char letter;
            int pos;
            char tempChar;
            int foundCount = 0;
            bool letterInWord;
            for (int a = 0; a < selectedWord.Length; ++a)
                guessedWord = guessedWord + "*";
            while (foundCount < selectedWord.Length)
            {
                WriteLine("Word: {0}", guessedWord);

                try
                {
                    Write("Guess a letter >> ");
                    guess = ReadLine();
                    letter = Convert.ToChar(guess.Substring(0, 1));
                    letterInWord = false;
                    for (pos = 0; pos < selectedWord.Length; ++pos)
                    {
                        tempChar = Convert.ToChar(selectedWord.Substring(pos, 1));
                        if (tempChar == letter)
                        {
                            guessedWord = guessedWord.Substring(0, pos) + letter + guessedWord.Substring(pos + 1, (guessedWord.Length - 1 - pos));
                            selectedWord = selectedWord.Substring(0, pos) + '?' + selectedWord.Substring(pos + 1, (guessedWord.Length - 1 - pos));
                            ++foundCount;
                            letterInWord = true;
                        }

                    }




                    if (letterInWord)
                        WriteLine("Yes! {0} is in the word", letter);
                    else
                        throw new Exception();
                        //WriteLine("Sorry. {0} is not in the word", letter);
                }

                catch (Exception ex)
                {
                    WriteLine("Sorry. {0} is not in the word", letter);
                    //WriteLine(ex.Message);
                }

                WriteLine("Good job! Word was {0}", originalWord);
            }
        }
    }
}
