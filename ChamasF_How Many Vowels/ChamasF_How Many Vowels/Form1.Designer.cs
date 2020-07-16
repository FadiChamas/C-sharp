namespace ChamasF_How_Many_Vowels
{
    partial class frmHowManyVowels
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnHowMany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(28, 29);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(282, 109);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "label1";
            // 
            // btnHowMany
            // 
            this.btnHowMany.AutoSize = true;
            this.btnHowMany.Location = new System.Drawing.Point(83, 163);
            this.btnHowMany.Name = "btnHowMany";
            this.btnHowMany.Size = new System.Drawing.Size(178, 28);
            this.btnHowMany.TabIndex = 1;
            this.btnHowMany.Text = "How Many Vowels";
            this.btnHowMany.UseVisualStyleBackColor = true;
            this.btnHowMany.Click += new System.EventHandler(this.btnHowMany_Click);
            // 
            // frmHowManyVowels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(344, 257);
            this.Controls.Add(this.btnHowMany);
            this.Controls.Add(this.lblOutput);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmHowManyVowels";
            this.Text = "How Many Vowels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnHowMany;
    }
}

