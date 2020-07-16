namespace ChamasF_ProvincePicker
{
    partial class frmProvincePicker
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
            this.lstProvinces = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstProvinces
            // 
            this.lstProvinces.FormattingEnabled = true;
            this.lstProvinces.ItemHeight = 18;
            this.lstProvinces.Items.AddRange(new object[] {
            "AB - Alberta",
            "BC - British Columbia",
            "MB - Manitoba",
            "NB - New Brunswick",
            "NL - NewFoundland and Labrador",
            "NT - Northwest Territories",
            "NS - Nova Scotia",
            "NU - Nunavut",
            "ON - Ontario",
            "PE - Prince Edward Island",
            "QC - Quebec",
            "SK -Saskatchewan",
            "YT- Yukon"});
            this.lstProvinces.Location = new System.Drawing.Point(15, 14);
            this.lstProvinces.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstProvinces.Name = "lstProvinces";
            this.lstProvinces.Size = new System.Drawing.Size(308, 256);
            this.lstProvinces.TabIndex = 0;
            this.lstProvinces.SelectedIndexChanged += new System.EventHandler(this.lstProvinces_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(331, 24);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFact
            // 
            this.lblFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFact.Location = new System.Drawing.Point(15, 284);
            this.lblFact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFact.Name = "lblFact";
            this.lblFact.Size = new System.Drawing.Size(408, 117);
            this.lblFact.TabIndex = 2;
            // 
            // frmProvincePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(433, 410);
            this.Controls.Add(this.lblFact);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstProvinces);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmProvincePicker";
            this.Text = "Canada Province Picker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProvinces;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFact;
    }
}

