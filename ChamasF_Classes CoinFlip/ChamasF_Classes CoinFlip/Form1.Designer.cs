namespace ChamasF_Classes_CoinFlip
{
    partial class frmCoinFlip
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
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.pbOne = new System.Windows.Forms.PictureBox();
            this.pbTwo = new System.Windows.Forms.PictureBox();
            this.pbThree = new System.Windows.Forms.PictureBox();
            this.pbFour = new System.Windows.Forms.PictureBox();
            this.pbFive = new System.Windows.Forms.PictureBox();
            this.btnFlip = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFive)).BeginInit();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 18;
            this.lstOutput.Location = new System.Drawing.Point(12, 120);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(418, 112);
            this.lstOutput.TabIndex = 0;
            // 
            // pbOne
            // 
            this.pbOne.Location = new System.Drawing.Point(12, 12);
            this.pbOne.Name = "pbOne";
            this.pbOne.Size = new System.Drawing.Size(100, 90);
            this.pbOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOne.TabIndex = 1;
            this.pbOne.TabStop = false;
            // 
            // pbTwo
            // 
            this.pbTwo.Location = new System.Drawing.Point(118, 12);
            this.pbTwo.Name = "pbTwo";
            this.pbTwo.Size = new System.Drawing.Size(100, 90);
            this.pbTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTwo.TabIndex = 2;
            this.pbTwo.TabStop = false;
            // 
            // pbThree
            // 
            this.pbThree.Location = new System.Drawing.Point(224, 12);
            this.pbThree.Name = "pbThree";
            this.pbThree.Size = new System.Drawing.Size(100, 90);
            this.pbThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThree.TabIndex = 3;
            this.pbThree.TabStop = false;
            // 
            // pbFour
            // 
            this.pbFour.Location = new System.Drawing.Point(330, 12);
            this.pbFour.Name = "pbFour";
            this.pbFour.Size = new System.Drawing.Size(100, 90);
            this.pbFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFour.TabIndex = 4;
            this.pbFour.TabStop = false;
            // 
            // pbFive
            // 
            this.pbFive.Location = new System.Drawing.Point(436, 12);
            this.pbFive.Name = "pbFive";
            this.pbFive.Size = new System.Drawing.Size(100, 90);
            this.pbFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFive.TabIndex = 5;
            this.pbFive.TabStop = false;
            // 
            // btnFlip
            // 
            this.btnFlip.AutoSize = true;
            this.btnFlip.Location = new System.Drawing.Point(453, 120);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(83, 38);
            this.btnFlip.TabIndex = 6;
            this.btnFlip.Text = "FLIP";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(453, 192);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCoinFlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(549, 244);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.pbFive);
            this.Controls.Add(this.pbFour);
            this.Controls.Add(this.pbThree);
            this.Controls.Add(this.pbTwo);
            this.Controls.Add(this.pbOne);
            this.Controls.Add(this.lstOutput);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCoinFlip";
            this.Text = "Coin Flip";
            ((System.ComponentModel.ISupportInitialize)(this.pbOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.PictureBox pbOne;
        private System.Windows.Forms.PictureBox pbTwo;
        private System.Windows.Forms.PictureBox pbThree;
        private System.Windows.Forms.PictureBox pbFour;
        private System.Windows.Forms.PictureBox pbFive;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.Button btnExit;
    }
}

