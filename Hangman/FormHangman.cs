using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Hangman
{
    public partial class FormHangman : Form
    {
        const int MAX_TRIES = 8;
        // Plus one becuase the first image is the "new game" image
        Image[] images = new Image[MAX_TRIES + 1];
        GameController gameController = new GameController();

        public FormHangman()
        {
            InitializeComponent();
        }
        private void FormHangman_Load(object sender, EventArgs e)
        {
            // Prepare the array of images
            loadImages();
            this.Width = 650;
            this.Height = 700;
            this.CenterToScreen();
            startGame();
        }
        private void loadImages()
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourceName = asm.GetName().Name + ".Properties.Resources";
            ResourceManager resourceMgr = new ResourceManager(resourceName, asm);
            
            for (int i = 0; i <= MAX_TRIES; i++)
            {
                string imageResourceName = "_" + i.ToString();
                images[i] = (Image)resourceMgr.GetObject(imageResourceName);
            }
        }
        private void startGame()
        {
            //*************************************************
            // Part 1
            //*************************************************
            // Use the game controller to get the game started
            gameController.startGame();
            // initialize the hangman picture to the new game image
            const int NEW_GAME = 0;
            pictureBoxHangMan.Image = images[NEW_GAME];

            // Use the set word form to get the word to be guessed
            FormSetWord formSetWord = new FormSetWord();
            if (formSetWord.ShowDialog() == DialogResult.OK)
            {
                // use the Word public property of the FormSetWord to set the word to be guessed
                gameController.setWord(formSetWord.Word);
                // get the hidden word with all underscores and blanks. Assign it to the
                // label guesses so far
                labelGuessSoFar.Text = gameController.getHiddenWord();
            }
            else
            {
                // The user canceled the set word dialog, so just quit the game with a message
                // use the form's supplied quit method
                quit();
            }
            //*************************************************
            //*************************************************
        }
        private void quit()
        {
            MessageBox.Show("No word selected. Game over.", "Good bye!");
            this.Close();
        }
        private void buttonGuess_Click(object sender, EventArgs e)
        {

            // Use the guess a letter form to get the player's guess
            FormGuessALetter formGuessALetter = new FormGuessALetter();
            if (formGuessALetter.ShowDialog() == DialogResult.OK)
            {
                //*************************************************
                // Part 2
                //*************************************************
                // Use the public property from the guess a letter form
                // as the guessed letter
                gameController.guessedLetter(formGuessALetter.letterGuessed);
                //*************************************************
                //*************************************************

                //*************************************************
                // Part 3
                //*************************************************
                // if letter is in the word
                if ( gameController.isLetterInWord() )
                {
                    // show the letter in the correct place(s)
                    labelGuessSoFar.Text = gameController.getGuessedSoFar();
                }
                else
                {
                    // update the picture of the hangman using the number of wrong guesses
                    // to determine which image to show
                    pictureBoxHangMan.Image = images[gameController.getWrongGuesses()];
                }
                //*************************************************
                //*************************************************
            }
            else
            {
                // The user canceled the dialog so quit the game using the form's quit method
                quit();
            }

            //*************************************************
            // Part 4
            //*************************************************
            // Check to see if there is a win
            if ( gameController.isWin() )
            {
                MessageBox.Show("The word has been guessed!!\nA new game will start!", "Winner!!");
                startGame();
            }
            //*************************************************
            //*************************************************
            //*************************************************
            // Part 5
            //*************************************************
            // else if the maximum number of tries has been exceeded
            else if (gameController.getWrongGuesses() >= MAX_TRIES)
            {
                MessageBox.Show("Too bad, you're hung!\n A new game will start.", "You lose!");
                // Start another game
                startGame();
            }
            //*************************************************
            //*************************************************
        }
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            startGame();
        }
    }
}
