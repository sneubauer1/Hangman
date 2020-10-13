using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hangman
{
    public partial class FormSetWord : Form
    {
        public string Word = "";
        public FormSetWord()
        {
            InitializeComponent();
        }

        private void FormSetWord_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            labelMsg.Hide();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string word = textBoxWord.Text.Trim();
            string pattern = "^[a-z]+$";
            if (Regex.IsMatch(word, pattern))
            {
                // Only good characters
                // Set the public property with the word to be guessed
                this.Word = word;
                // Indicate that the user clicked OK
                this.DialogResult = DialogResult.OK;
                // Close the form
                this.Close();

            } else
            {
                // Bad character found
                // Set the error message
                labelMsg.Text = "Only a to z allowed in the word.";
                // Display the error message
                labelMsg.Show();
                // Set the focus on the textbox
                textBoxWord.Focus();
                // Select the entered word as a convenience to the user
                textBoxWord.SelectAll();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Ensure the public property is set to the empty string
            this.Word = "";
            // Indicate that the user canceled the dialog
            this.DialogResult = DialogResult.Cancel;
            // Close the form
            this.Close();
        }
    }
}
