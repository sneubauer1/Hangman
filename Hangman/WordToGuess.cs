using System;
using System.Text;

namespace Hangman
{
    public class WordToGuess
    {
        private string theWord = "";
        private string guessedSoFar = "";

        public WordToGuess()
        {
            theWord = "";
            guessedSoFar = "";
        }
        public void setWord(string word)
        {
            theWord = word;
            for (int i = 0; i < theWord.Length; i++)
                guessedSoFar += "_ ";
        }
        public string getHiddenWord()
        {
            string formattedWord = "";
            for (int i = 0; i < theWord.Length; i++)
                formattedWord += "_ ";
            return formattedWord;
        }
        public bool isLetterInWord(string letter)
        {
            return theWord.Contains(letter);
        }
        public string getGuessesSoFar(string letter)
        {
            char newChar = Char.Parse(letter);
            StringBuilder newGuessedSoFar = new StringBuilder(guessedSoFar);
            int i = 0;
            while (theWord.IndexOf(newChar, i) != -1)
            {
                newGuessedSoFar[(((theWord.IndexOf(newChar, i) + 1) * 2) - 2)] = newChar;
                i++;
            }
            guessedSoFar = newGuessedSoFar.ToString();
            return guessedSoFar;
        }
        public bool isWin()
        {
            StringBuilder theGuess = new StringBuilder(guessedSoFar);
            theGuess.Replace(" ", "");
            return theGuess.ToString() == theWord;
        }
    }
}
