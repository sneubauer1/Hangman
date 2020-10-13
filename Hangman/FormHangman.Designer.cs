namespace Hangman
{
    partial class FormHangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHangman));
            this.pictureBoxHangMan = new System.Windows.Forms.PictureBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.labelGuessSoFar = new System.Windows.Forms.Label();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangMan)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHangMan
            // 
            this.pictureBoxHangMan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHangMan.Image")));
            this.pictureBoxHangMan.Location = new System.Drawing.Point(298, 57);
            this.pictureBoxHangMan.Name = "pictureBoxHangMan";
            this.pictureBoxHangMan.Size = new System.Drawing.Size(359, 371);
            this.pictureBoxHangMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHangMan.TabIndex = 1;
            this.pictureBoxHangMan.TabStop = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRestart.Location = new System.Drawing.Point(239, 1020);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(213, 60);
            this.buttonRestart.TabIndex = 2;
            this.buttonRestart.Text = "Restart Game";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonQuit.Location = new System.Drawing.Point(572, 1020);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(213, 60);
            this.buttonQuit.TabIndex = 1;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // labelGuessSoFar
            // 
            this.labelGuessSoFar.AutoSize = true;
            this.labelGuessSoFar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuessSoFar.Location = new System.Drawing.Point(449, 944);
            this.labelGuessSoFar.Name = "labelGuessSoFar";
            this.labelGuessSoFar.Size = new System.Drawing.Size(237, 44);
            this.labelGuessSoFar.TabIndex = 8;
            this.labelGuessSoFar.Text = "Change Me!!";
            // 
            // buttonGuess
            // 
            this.buttonGuess.Location = new System.Drawing.Point(906, 1020);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(213, 60);
            this.buttonGuess.TabIndex = 0;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 959);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Guess So Far:";
            // 
            // FormHangman
            // 
            this.AcceptButton = this.buttonGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonQuit;
            this.ClientSize = new System.Drawing.Size(1381, 1143);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.labelGuessSoFar);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.pictureBoxHangMan);
            this.Name = "FormHangman";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.FormHangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxHangMan;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label labelGuessSoFar;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Label label1;
    }
}

