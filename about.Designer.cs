namespace Master_Investor
{
    partial class about
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.rtbAbout = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(204, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAppName.Location = new System.Drawing.Point(123, 19);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(236, 32);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Master Investor 1.0";
            // 
            // rtbAbout
            // 
            this.rtbAbout.Enabled = false;
            this.rtbAbout.Location = new System.Drawing.Point(12, 64);
            this.rtbAbout.Name = "rtbAbout";
            this.rtbAbout.Size = new System.Drawing.Size(493, 278);
            this.rtbAbout.TabIndex = 2;
            this.rtbAbout.Text = "Released on 19.12.2022\n";
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 383);
            this.Controls.Add(this.rtbAbout);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.btnClose);
            this.Name = "about";
            this.Text = "about";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Label lblAppName;
        private RichTextBox rtbAbout;
    }
}