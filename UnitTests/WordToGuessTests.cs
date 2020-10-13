using Hangman;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordToGuessTests
{
    [TestClass]
    public class WordToGuessTests
    {
        [TestMethod]
        public void getHiddenWordIsCorrect()
        {
            // Arrange
            WordToGuess wordToGuess = new WordToGuess();
            const string THE_WORD = "jellybean";
            wordToGuess.setWord(THE_WORD);

            // Act
            string actualHiddenWord = wordToGuess.getHiddenWord();

            // Assert
            const string EXPECTED_HIDDEN_WORD = "_ _ _ _ _ _ _ _ _ ";
            Assert.AreEqual(EXPECTED_HIDDEN_WORD, actualHiddenWord);
        }
        [TestMethod]
        public void isLetterInWordYes()
        {
            // Arrange
            WordToGuess wordToGuess = new WordToGuess();
            const string THE_WORD = "jellybean";
            wordToGuess.setWord(THE_WORD);

            // Act
            const string LETTER = "a";
            bool actualIsLetterInWord = wordToGuess.isLetterInWord(LETTER);

            // Assert
            Assert.IsTrue(actualIsLetterInWord);
        }
        [TestMethod]
        public void isLetterInWordNo()
        {
            // Arrange
            WordToGuess wordToGuess = new WordToGuess();
            const string THE_WORD = "jellybean";
            wordToGuess.setWord(THE_WORD);

            // Act
            const string LETTER = "z";
            bool actualIsLetterInWord = wordToGuess.isLetterInWord(LETTER);

            // Assert
            Assert.IsFalse(actualIsLetterInWord);
        }
        [TestMethod]
        public void getGuessedSoFarCorrect()
        {
            // Arrange
            WordToGuess wordToGuess = new WordToGuess();
            const string THE_WORD = "jellybean";
            wordToGuess.setWord(THE_WORD);
            Guess guess = new Guess();
            const string GUESSED_LETTER = "a";
            guess.guessedLetter(GUESSED_LETTER, wordToGuess);

            // Act
            string actualGuessSoFar = wordToGuess.getGuessesSoFar(GUESSED_LETTER);

            // Assert
            const string EXPECTED_GUESSED_SO_FAR = "_ _ _ _ _ _ _ a _ ";
            Assert.AreEqual(EXPECTED_GUESSED_SO_FAR, actualGuessSoFar);
        }
        [TestMethod]
        public void isWinCorrectForWin()
        {
            // Arrange
            WordToGuess wordToGuess = new WordToGuess();
            const string THE_WORD = "jellybean";
            wordToGuess.setWord(THE_WORD);
            Guess guess = new Guess();
            string guessedLetter = "j";
            guess.guessedLetter(guessedLetter, wordToGuess);
            string ignore = wordToGuess.getGuessesSoFar(guessedLetter);
            guessedLetter = "e";
            guess.guessedLetter(guessedLetter, wordToGuess);
            ignore = wordToGuess.getGuessesSoFar(guessedLetter);
            guessedLetter = "l";
            guess.guessedLetter(guessedLetter, wordToGuess);
            ignore = wordToGuess.getGuessesSoFar(guessedLetter);
            guessedLetter = "l";
            guess.guessedLetter(guessedLetter, wordToGuess);
            ignore = wordToGuess.getGuessesSoFar(guessedLetter);
            guessedLetter = "y";
            guess.guessedLetter(guessedLetter, wordToGuess);
            ignore = wordToGuess.getGuessesSoFar(guessedLetter);
            guessedLetter = "b";
            guess.guessedLetter(guessedLetter, wordToGuess);
            ignore = wordToGuess.getGuessesSoFar(guessedLetter);
            guessedLetter = "e";
            guess.guessedLetter(guessedLetter, wordToGuess);
            ignore = wordToGuess.getGuessesSoFar(guessedLetter);
            guessedLetter = "a";
            guess.guessedLetter(guessedLetter, wordToGuess);
            ignore = wordToGuess.getGuessesSoFar(guessedLetter);
            guessedLetter = "n";
            guess.guessedLetter(guessedLetter, wordToGuess);
            ignore = wordToGuess.getGuessesSoFar(guessedLetter);

            // Act
            bool actualIsWin = wordToGuess.isWin();

            // Assert
            Assert.IsTrue(actualIsWin);
        }
        [TestMethod]
        public void isWinCorrectForLoss()
        {
            // Arrange
            WordToGuess wordToGuess = new WordToGuess();
            const string THE_WORD = "jellybean";
            wordToGuess.setWord(THE_WORD);
            Guess guess = new Guess();
            string guessedLetter = "z";
            guess.guessedLetter(guessedLetter, wordToGuess);

            // Act
            bool actualIsWin = wordToGuess.isWin();

            // Assert
            Assert.IsFalse(actualIsWin);
        }
    }
}
