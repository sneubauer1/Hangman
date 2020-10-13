using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hangman
{
    public partial class FormGuessALetter : Form
    {
        public string letterGuessed = "";
        public FormGuessALetter()
        {
            InitializeComponent();
            this.CenterToParent();
            labelMsg.Hide();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            string letter = textBoxLetter.Text.Trim();
            // Only allow a to z, lower case letters
            string pattern = "^[a-z]+$";
            Regex regEx = new Regex(pattern);
            if (regEx.IsMatch(letter))
            {
                // The entered letter is good
                // Set the public property with the guessed letter
                this.letterGuessed = letter;
                // Indicate that the user clicked OK
                this.DialogResult = DialogResult.OK;
                // Close the form
                this.Close();
            }
            else
            {
                // Set the error message
                labelMsg.Text = "Letter must be a to z.";
                // Show the message label
                labelMsg.Show();
                // Set the focus on the text box
                textBoxLetter.Focus();
                // The entered letter is bad
                textBoxLetter.SelectAll();
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Ensure the public property is set to the empty string
            this.letterGuessed = "";
            // Indicate that the user canceled the form
            this.DialogResult = DialogResult.Cancel;
            // Close the form
            this.Close();
        }
    }
}
