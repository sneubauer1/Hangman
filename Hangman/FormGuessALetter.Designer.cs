namespace Hangman
{
    partial class FormGuessALetter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLetter = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter your next letter:";
            // 
            // textBoxLetter
            // 
            this.textBoxLetter.Location = new System.Drawing.Point(326, 62);
            this.textBoxLetter.MaxLength = 1;
            this.textBoxLetter.Name = "textBoxLetter";
            this.textBoxLetter.Size = new System.Drawing.Size(56, 31);
            this.textBoxLetter.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(293, 176);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(151, 56);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(98, 176);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(151, 56);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsg.ForeColor = System.Drawing.Color.Red;
            this.labelMsg.Location = new System.Drawing.Point(107, 114);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(113, 25);
            this.labelMsg.TabIndex = 4;
            this.labelMsg.Text = "Hide Me!!";
            // 
            // FormGuessALetter
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(549, 265);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLetter);
            this.Name = "FormGuessALetter";
            this.Text = "Hangman - Guess A Letter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLetter;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMsg;
    }
}