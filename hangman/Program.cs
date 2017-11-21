using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Console
{
    class Program
    {

        static string strLettersGuessed;
        static string strSecretWord = GetWord();
        static int nWrongGuesses = 0;
        static string[] WordDisplay = InitilizeWordDisplay(strSecretWord);
        static bool guessedIt = false;

        static void Main(string[] args)
        {

            //display all gallows
            while (!guessedIt && nWrongGuesses < 11)
            {
                HangmanGallows.DrawGallow(nWrongGuesses);
                PrintSecretWord(WordDisplay);
                Console.WriteLine("Letters Guessed: " + strLettersGuessed);
                nWrongGuesses += PlayerGuess(WordDisplay, strSecretWord);
                guessedIt = GuessedWord(WordDisplay);

                Console.ReadLine();
            }
            if (guessedIt)
            {
                Console.WriteLine("You got it!! " + strSecretWord);
            }
            else
            {
                Console.WriteLine("You have been Executed! The Word Was.... " + strSecretWord);
            }
            Console.ReadLine();
        }

        private static string GetWord()
        {
            StreamReader textIn = new StreamReader("wordbank-1.txt");

            //get random word
            Random random = new Random();
            int randNum = random.Next(1, 479781);

            //read through file to get that word
            for (int n = 0; n < randNum; n++)
            {
                textIn.ReadLine();
            }

            return textIn.ReadLine();

        }

        private static bool GuessedWord(string[] WordDisplay)
        {
            for (int n = 0; n < WordDisplay.Length; n++)
            {
                if (WordDisplay[n] == "  _  ")
                {
                    return false;
                }

            }
            return true;
        }

        private static int PlayerGuess(string[] WordDislpaly, string strSecretWord)
        {
            string strUserGuess;
            int nWrongGuess = 1;
            //prompt user
            Console.Write("\nGuess a letter");
            strUserGuess = Console.ReadLine();
            strLettersGuessed += strUserGuess;

            //prompt guess
            for (int n = 0; n < strSecretWord.Length; n++)
            {
                if (strSecretWord[n].ToString() == strUserGuess)
                {
                    WordDislpaly[n] = strUserGuess;
                    nWrongGuess = 0;
                }
            }
            return nWrongGuess;
        }

        private static void PrintSecretWord(string[] wordDisplay)
        {
            //print word display
            for (int n = 0; n < wordDisplay.Length; n++)
            {
                Console.Write(wordDisplay[n]);
            }
            Console.WriteLine();
        }
        public static string[] InitilizeWordDisplay(string strSecretWord)
        {
            string[] wordDisplay = new string[strSecretWord.Length];

            //fill wordDisplay array with _
            for (int n = 0; n < wordDisplay.Length; n++)
            {
                wordDisplay[n] = "  _  ";
            }
            return wordDisplay;
        }

    }
}
