namespace ChamasF_ASSN03_TicTacToe
{
    partial class frmTicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicTacToe));
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblScoreboard = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Image = global::ChamasF_ASSN03_TicTacToe.Properties.Resources.Blank;
            this.pic1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic1.InitialImage")));
            this.pic1.Location = new System.Drawing.Point(12, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(150, 150);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic2.InitialImage")));
            this.pic2.Location = new System.Drawing.Point(196, 12);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(150, 150);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Image = ((System.Drawing.Image)(resources.GetObject("pic3.Image")));
            this.pic3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic3.InitialImage")));
            this.pic3.Location = new System.Drawing.Point(388, 12);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(150, 150);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Image = ((System.Drawing.Image)(resources.GetObject("pic4.Image")));
            this.pic4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic4.InitialImage")));
            this.pic4.Location = new System.Drawing.Point(12, 168);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(150, 150);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic4.TabIndex = 3;
            this.pic4.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.Image = ((System.Drawing.Image)(resources.GetObject("pic5.Image")));
            this.pic5.InitialImage = global::ChamasF_ASSN03_TicTacToe.Properties.Resources.Blank;
            this.pic5.Location = new System.Drawing.Point(196, 168);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(150, 150);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic5.TabIndex = 4;
            this.pic5.TabStop = false;
            // 
            // pic6
            // 
            this.pic6.Image = ((System.Drawing.Image)(resources.GetObject("pic6.Image")));
            this.pic6.InitialImage = global::ChamasF_ASSN03_TicTacToe.Properties.Resources.Blank;
            this.pic6.Location = new System.Drawing.Point(388, 168);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(150, 150);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic6.TabIndex = 5;
            this.pic6.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.Location = new System.Drawing.Point(12, 490);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(150, 36);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(12, 532);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 36);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblStatus.Location = new System.Drawing.Point(196, 490);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(150, 36);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreboard
            // 
            this.lblScoreboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblScoreboard.Location = new System.Drawing.Point(388, 490);
            this.lblScoreboard.Name = "lblScoreboard";
            this.lblScoreboard.Size = new System.Drawing.Size(150, 36);
            this.lblScoreboard.TabIndex = 9;
            this.lblScoreboard.Text = "Scoreboard";
            this.lblScoreboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGame
            // 
            this.lblGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblGame.Location = new System.Drawing.Point(196, 532);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(342, 36);
            this.lblGame.TabIndex = 10;
            this.lblGame.Text = "Click Play to Start";
            this.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic7
            // 
            this.pic7.Image = ((System.Drawing.Image)(resources.GetObject("pic7.Image")));
            this.pic7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic7.InitialImage")));
            this.pic7.Location = new System.Drawing.Point(12, 324);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(150, 150);
            this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic7.TabIndex = 11;
            this.pic7.TabStop = false;
            // 
            // pic8
            // 
            this.pic8.Image = ((System.Drawing.Image)(resources.GetObject("pic8.Image")));
            this.pic8.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic8.InitialImage")));
            this.pic8.Location = new System.Drawing.Point(196, 324);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(150, 150);
            this.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic8.TabIndex = 12;
            this.pic8.TabStop = false;
            // 
            // pic9
            // 
            this.pic9.Image = ((System.Drawing.Image)(resources.GetObject("pic9.Image")));
            this.pic9.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic9.InitialImage")));
            this.pic9.Location = new System.Drawing.Point(388, 324);
            this.pic9.Name = "pic9";
            this.pic9.Size = new System.Drawing.Size(150, 150);
            this.pic9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic9.TabIndex = 13;
            this.pic9.TabStop = false;
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(548, 575);
            this.Controls.Add(this.pic9);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.lblScoreboard);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmTicTacToe";
            this.Text = "Tic-Tac-Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblScoreboard;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic9;
    }
}

