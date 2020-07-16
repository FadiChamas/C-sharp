namespace ChamasF_SnakeEyes
{
    partial class frmSnakeEyes
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblSnake = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblRatio = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(12, 20);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(148, 18);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter no. of rolls:";
            // 
            // lblSnake
            // 
            this.lblSnake.AutoSize = true;
            this.lblSnake.Location = new System.Drawing.Point(12, 60);
            this.lblSnake.Name = "lblSnake";
            this.lblSnake.Size = new System.Drawing.Size(162, 18);
            this.lblSnake.TabIndex = 1;
            this.lblSnake.Text = "No. of Snake Eyes:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(166, 17);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(176, 26);
            this.txtNum.TabIndex = 2;
            // 
            // lblNum
            // 
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNum.Location = new System.Drawing.Point(180, 60);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(162, 18);
            this.lblNum.TabIndex = 3;
            // 
            // lblRatio
            // 
            this.lblRatio.AutoSize = true;
            this.lblRatio.Location = new System.Drawing.Point(64, 104);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(57, 18);
            this.lblRatio.TabIndex = 4;
            this.lblRatio.Text = "Ratio:";
            // 
            // lblPercentage
            // 
            this.lblPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPercentage.Location = new System.Drawing.Point(180, 103);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(162, 18);
            this.lblPercentage.TabIndex = 5;
            // 
            // btnRoll
            // 
            this.btnRoll.AutoSize = true;
            this.btnRoll.Location = new System.Drawing.Point(67, 143);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(83, 28);
            this.btnRoll.TabIndex = 6;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(224, 143);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSnakeEyes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(370, 181);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblRatio);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblSnake);
            this.Controls.Add(this.lblEnter);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmSnakeEyes";
            this.Text = "Snake Eyes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblSnake;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnExit;
    }
}

