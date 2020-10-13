namespace Hangman
{
    public class GameController
    {
        private Guess guess;
        private WordToGuess wordToGuess;
        public void startGame()
        {
            guess = new Guess();
            wordToGuess = new WordToGuess();
        }
        public int getWrongGuesses()
        {
            return guess.getWrongGuesses();
        }
        public void setWord(string word)
        {
            wordToGuess.setWord(word);
        }
        public string getHiddenWord()
        {
            return wordToGuess.getHiddenWord();
        }
        public void guessedLetter(string letter)
        {
            guess.guessedLetter(letter, wordToGuess);
        }
        public bool isLetterInWord()
        {
            return wordToGuess.isLetterInWord(guess.getMostRecentGuess());
        }
        public string getGuessedSoFar()
        {
            return wordToGuess.getGuessesSoFar(guess.getMostRecentGuess());
        }
        public bool isWin()
        {
            return wordToGuess.isWin();
        }
    }
}
