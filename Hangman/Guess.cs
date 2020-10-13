namespace Hangman
{
    public class Guess
    {
        private int wrongGuesses = 0;
        private string mostRecentLetter = "";
        public Guess()
        {
            mostRecentLetter = "";
            wrongGuesses = 0;
        }
        public int getWrongGuesses()
        {
            return wrongGuesses;
        }
        public void guessedLetter(string letter, WordToGuess wordToGuess)
        {
            mostRecentLetter = letter;
          
            if (!wordToGuess.isLetterInWord(letter))
            {
                wrongGuesses++;
            }

        }
        public string getMostRecentGuess()
        {
            return mostRecentLetter;
        }
    }
}
