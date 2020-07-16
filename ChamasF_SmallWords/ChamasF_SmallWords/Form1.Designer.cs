namespace ChamasF_SmallWords
{
    partial class frmSmallWords
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
            this.txtWords = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblFound = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(244, 17);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(123, 26);
            this.txtWords.TabIndex = 0;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 18;
            this.lstOutput.Location = new System.Drawing.Point(244, 80);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(123, 148);
            this.lstOutput.TabIndex = 1;
            // 
            // lblEnter
            // 
            this.lblEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnter.Location = new System.Drawing.Point(23, 19);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(203, 24);
            this.lblEnter.TabIndex = 2;
            this.lblEnter.Text = "Enter a 5-letter word:";
            this.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFound
            // 
            this.lblFound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFound.Location = new System.Drawing.Point(244, 46);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(125, 31);
            this.lblFound.TabIndex = 3;
            this.lblFound.Text = "Words Found:";
            this.lblFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut
            // 
            this.lblOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOut.Location = new System.Drawing.Point(23, 48);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(203, 157);
            this.lblOut.TabIndex = 4;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(23, 220);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(203, 34);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "FIND";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // frmSmallWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(379, 268);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblFound);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtWords);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmSmallWords";
            this.Text = "Finding 3 Letter Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Button btnFind;
    }
}

