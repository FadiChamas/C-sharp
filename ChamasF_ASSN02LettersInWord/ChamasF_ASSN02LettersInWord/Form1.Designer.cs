namespace ChamasF_ASSN02LettersInWord
{
    partial class frmLettersinWord
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
            this.lblGuess = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.lblLetter = new System.Windows.Forms.Label();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(12, 9);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(121, 18);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "Enter a Word:";
            // 
            // btnEnter
            // 
            this.btnEnter.AutoSize = true;
            this.btnEnter.Enabled = false;
            this.btnEnter.Location = new System.Drawing.Point(245, 7);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 28);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(139, 7);
            this.txtWord.Name = "txtWord";
            this.txtWord.PasswordChar = '*';
            this.txtWord.Size = new System.Drawing.Size(100, 26);
            this.txtWord.TabIndex = 1;
            this.txtWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWord.TextChanged += new System.EventHandler(this.txtWord_TextChanged);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 18;
            this.lstOutput.Location = new System.Drawing.Point(13, 40);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(307, 184);
            this.lstOutput.TabIndex = 3;
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Location = new System.Drawing.Point(10, 233);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(129, 18);
            this.lblLetter.TabIndex = 4;
            this.lblLetter.Text = "Enter a Letter:";
            // 
            // txtLetter
            // 
            this.txtLetter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetter.Enabled = false;
            this.txtLetter.Location = new System.Drawing.Point(139, 230);
            this.txtLetter.MaxLength = 1;
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(100, 26);
            this.txtLetter.TabIndex = 5;
            this.txtLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetter.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            // 
            // btnGuess
            // 
            this.btnGuess.AutoSize = true;
            this.btnGuess.Enabled = false;
            this.btnGuess.Location = new System.Drawing.Point(245, 228);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 28);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.AutoSize = true;
            this.btnFinish.Enabled = false;
            this.btnFinish.Location = new System.Drawing.Point(11, 262);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(122, 28);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Finish Round";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(198, 262);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 28);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLettersinWord
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(326, 292);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.lblLetter);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblGuess);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmLettersinWord";
            this.Text = "Letters In Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnExit;
    }
}

