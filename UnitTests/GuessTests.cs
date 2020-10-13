using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman;

namespace GuessTests
{
    [TestClass]
    public class GuessTests
    {
        [TestMethod]
        public void GetWrongGuessesIsAccurate()
        {
            // Arrange
            Guess guess = new Guess();
            WordToGuess wordToGuess = new WordToGuess();
            const string THE_WORD = "jellybean";
            wordToGuess.setWord(THE_WORD);
            const string INCORRECT_LETTER = "z";
            guess.guessedLetter(INCORRECT_LETTER, wordToGuess);
            const string ANOTHER_INCORRECT_LETTER = "x";
            guess.guessedLetter(ANOTHER_INCORRECT_LETTER, wordToGuess);

            // Act
            int actualWrongGuessCount = guess.getWrongGuesses();

            // Assert
            const int EXPECTED_WRONG_GUESS_COUNT = 2;
            Assert.AreEqual(EXPECTED_WRONG_GUESS_COUNT, actualWrongGuessCount);
        }
        [TestMethod]
        public void GuessedLetterCorrectLetterIsAccurate()
        {
            // Arrange 
            Guess guess = new Guess();
            WordToGuess wordToGuess = new WordToGuess();
            const string THE_WORD = "jellybean";
            wordToGuess.setWord(THE_WORD);
            const string CORRECT_LETTER = "a";
            guess.guessedLetter(CORRECT_LETTER,wordToGuess);

            // Act
            int actualWrongGuessCount = guess.getWrongGuesses();

            // Assert
            const int EXPECTED_WRONG_GUESS_COUNT = 0;
            Assert.AreEqual(EXPECTED_WRONG_GUESS_COUNT, actualWrongGuessCount);
        }
        [TestMethod]
        public void GuessedLetterMostRecentLetterIsAccurate()
        {
            // Arrange
            Guess guess = new Guess();
            WordToGuess wordToGuess = new WordToGuess();
            const string THE_WORD = "jellybean";
            wordToGuess.setWord(THE_WORD);
            const string GUESSED_LETTER = "a";
            guess.guessedLetter(GUESSED_LETTER, wordToGuess);

            // Act
            string actualMostRecentLetter = guess.getMostRecentGuess();

            // Assert
            Assert.AreEqual(GUESSED_LETTER, actualMostRecentLetter);
        }
    }
}
