namespace Hangman
{
    partial class FormSetWord
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the word to guess";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(51, 137);
            this.textBoxWord.MaxLength = 25;
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.PasswordChar = '*';
            this.textBoxWord.Size = new System.Drawing.Size(518, 31);
            this.textBoxWord.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(539, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "**Max of 25 characters. Only lower case a to z allowed.";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(413, 302);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(155, 53);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(195, 302);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 53);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsg.ForeColor = System.Drawing.Color.Red;
            this.labelMsg.Location = new System.Drawing.Point(51, 235);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(113, 25);
            this.labelMsg.TabIndex = 5;
            this.labelMsg.Text = "Hide Me!!";
            // 
            // FormSetWord
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(649, 384);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.label1);
            this.Name = "FormSetWord";
            this.Text = "Hangman - Set the Word";
            this.Load += new System.EventHandler(this.FormSetWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMsg;
    }
}