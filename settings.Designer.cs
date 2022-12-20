namespace Master_Investor
{
    partial class settings
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
            this.brnChooseWebBrowser = new System.Windows.Forms.Button();
            this.grpbWebBroserSettings = new System.Windows.Forms.GroupBox();
            this.txtbWebbrowserPath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbMarketData = new System.Windows.Forms.GroupBox();
            this.chkbUSDCPaires = new System.Windows.Forms.CheckBox();
            this.chkbKCSPaires = new System.Windows.Forms.CheckBox();
            this.chkbTRXPaires = new System.Windows.Forms.CheckBox();
            this.chkbDOGEPaires = new System.Windows.Forms.CheckBox();
            this.chkbETHPaires = new System.Windows.Forms.CheckBox();
            this.chkbDAIPaires = new System.Windows.Forms.CheckBox();
            this.chkbTUSDPaires = new System.Windows.Forms.CheckBox();
            this.lblSecondes = new System.Windows.Forms.Label();
            this.txtSecondesForTimerRefreshMarket = new System.Windows.Forms.TextBox();
            this.lblLabelTimeForRefreshMarket = new System.Windows.Forms.Label();
            this.chkbBTCPaires = new System.Windows.Forms.CheckBox();
            this.chkbUSDTPaires = new System.Windows.Forms.CheckBox();
            this.lblPairToProcess = new System.Windows.Forms.Label();
            this.grpbWebBroserSettings.SuspendLayout();
            this.grpbMarketData.SuspendLayout();
            this.SuspendLayout();
            // 
            // brnChooseWebBrowser
            // 
            this.brnChooseWebBrowser.Location = new System.Drawing.Point(357, 38);
            this.brnChooseWebBrowser.Name = "brnChooseWebBrowser";
            this.brnChooseWebBrowser.Size = new System.Drawing.Size(159, 23);
            this.brnChooseWebBrowser.TabIndex = 0;
            this.brnChooseWebBrowser.Text = "Choose webbrowser exe...";
            this.brnChooseWebBrowser.UseVisualStyleBackColor = true;
            this.brnChooseWebBrowser.Click += new System.EventHandler(this.brnChooseWebBrowser_Click);
            // 
            // grpbWebBroserSettings
            // 
            this.grpbWebBroserSettings.Controls.Add(this.txtbWebbrowserPath);
            this.grpbWebBroserSettings.Controls.Add(this.brnChooseWebBrowser);
            this.grpbWebBroserSettings.Location = new System.Drawing.Point(12, 12);
            this.grpbWebBroserSettings.Name = "grpbWebBroserSettings";
            this.grpbWebBroserSettings.Size = new System.Drawing.Size(522, 78);
            this.grpbWebBroserSettings.TabIndex = 1;
            this.grpbWebBroserSettings.TabStop = false;
            this.grpbWebBroserSettings.Text = "Webbrowser settings";
            // 
            // txtbWebbrowserPath
            // 
            this.txtbWebbrowserPath.Enabled = false;
            this.txtbWebbrowserPath.Location = new System.Drawing.Point(6, 38);
            this.txtbWebbrowserPath.Name = "txtbWebbrowserPath";
            this.txtbWebbrowserPath.Size = new System.Drawing.Size(337, 23);
            this.txtbWebbrowserPath.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(459, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpbMarketData
            // 
            this.grpbMarketData.Controls.Add(this.chkbUSDCPaires);
            this.grpbMarketData.Controls.Add(this.chkbKCSPaires);
            this.grpbMarketData.Controls.Add(this.chkbTRXPaires);
            this.grpbMarketData.Controls.Add(this.chkbDOGEPaires);
            this.grpbMarketData.Controls.Add(this.chkbETHPaires);
            this.grpbMarketData.Controls.Add(this.chkbDAIPaires);
            this.grpbMarketData.Controls.Add(this.chkbTUSDPaires);
            this.grpbMarketData.Controls.Add(this.lblSecondes);
            this.grpbMarketData.Controls.Add(this.txtSecondesForTimerRefreshMarket);
            this.grpbMarketData.Controls.Add(this.lblLabelTimeForRefreshMarket);
            this.grpbMarketData.Controls.Add(this.chkbBTCPaires);
            this.grpbMarketData.Controls.Add(this.chkbUSDTPaires);
            this.grpbMarketData.Controls.Add(this.lblPairToProcess);
            this.grpbMarketData.Location = new System.Drawing.Point(12, 96);
            this.grpbMarketData.Name = "grpbMarketData";
            this.grpbMarketData.Size = new System.Drawing.Size(522, 286);
            this.grpbMarketData.TabIndex = 4;
            this.grpbMarketData.TabStop = false;
            this.grpbMarketData.Text = "Market Data";
            // 
            // chkbUSDCPaires
            // 
            this.chkbUSDCPaires.AutoSize = true;
            this.chkbUSDCPaires.Location = new System.Drawing.Point(213, 109);
            this.chkbUSDCPaires.Name = "chkbUSDCPaires";
            this.chkbUSDCPaires.Size = new System.Drawing.Size(90, 19);
            this.chkbUSDCPaires.TabIndex = 13;
            this.chkbUSDCPaires.Text = "USDC Paires";
            this.chkbUSDCPaires.UseVisualStyleBackColor = true;
            // 
            // chkbKCSPaires
            // 
            this.chkbKCSPaires.AutoSize = true;
            this.chkbKCSPaires.Location = new System.Drawing.Point(372, 109);
            this.chkbKCSPaires.Name = "chkbKCSPaires";
            this.chkbKCSPaires.Size = new System.Drawing.Size(80, 19);
            this.chkbKCSPaires.TabIndex = 12;
            this.chkbKCSPaires.Text = "KCS Paires";
            this.chkbKCSPaires.UseVisualStyleBackColor = true;
            // 
            // chkbTRXPaires
            // 
            this.chkbTRXPaires.AutoSize = true;
            this.chkbTRXPaires.Location = new System.Drawing.Point(372, 157);
            this.chkbTRXPaires.Name = "chkbTRXPaires";
            this.chkbTRXPaires.Size = new System.Drawing.Size(80, 19);
            this.chkbTRXPaires.TabIndex = 10;
            this.chkbTRXPaires.Text = "TRX Paires";
            this.chkbTRXPaires.UseVisualStyleBackColor = true;
            // 
            // chkbDOGEPaires
            // 
            this.chkbDOGEPaires.AutoSize = true;
            this.chkbDOGEPaires.Location = new System.Drawing.Point(18, 157);
            this.chkbDOGEPaires.Name = "chkbDOGEPaires";
            this.chkbDOGEPaires.Size = new System.Drawing.Size(91, 19);
            this.chkbDOGEPaires.TabIndex = 9;
            this.chkbDOGEPaires.Text = "DOGE Paires";
            this.chkbDOGEPaires.UseVisualStyleBackColor = true;
            // 
            // chkbETHPaires
            // 
            this.chkbETHPaires.AutoSize = true;
            this.chkbETHPaires.Location = new System.Drawing.Point(213, 157);
            this.chkbETHPaires.Name = "chkbETHPaires";
            this.chkbETHPaires.Size = new System.Drawing.Size(81, 19);
            this.chkbETHPaires.TabIndex = 8;
            this.chkbETHPaires.Text = "ETH Paires";
            this.chkbETHPaires.UseVisualStyleBackColor = true;
            // 
            // chkbDAIPaires
            // 
            this.chkbDAIPaires.AutoSize = true;
            this.chkbDAIPaires.Location = new System.Drawing.Point(18, 109);
            this.chkbDAIPaires.Name = "chkbDAIPaires";
            this.chkbDAIPaires.Size = new System.Drawing.Size(79, 19);
            this.chkbDAIPaires.TabIndex = 7;
            this.chkbDAIPaires.Text = "DAI Paires";
            this.chkbDAIPaires.UseVisualStyleBackColor = true;
            // 
            // chkbTUSDPaires
            // 
            this.chkbTUSDPaires.AutoSize = true;
            this.chkbTUSDPaires.Location = new System.Drawing.Point(372, 60);
            this.chkbTUSDPaires.Name = "chkbTUSDPaires";
            this.chkbTUSDPaires.Size = new System.Drawing.Size(88, 19);
            this.chkbTUSDPaires.TabIndex = 6;
            this.chkbTUSDPaires.Text = "TUSD Paires";
            this.chkbTUSDPaires.UseVisualStyleBackColor = true;
            // 
            // lblSecondes
            // 
            this.lblSecondes.AutoSize = true;
            this.lblSecondes.Location = new System.Drawing.Point(357, 248);
            this.lblSecondes.Name = "lblSecondes";
            this.lblSecondes.Size = new System.Drawing.Size(57, 15);
            this.lblSecondes.TabIndex = 5;
            this.lblSecondes.Text = "Secondes";
            // 
            // txtSecondesForTimerRefreshMarket
            // 
            this.txtSecondesForTimerRefreshMarket.Location = new System.Drawing.Point(243, 245);
            this.txtSecondesForTimerRefreshMarket.Name = "txtSecondesForTimerRefreshMarket";
            this.txtSecondesForTimerRefreshMarket.Size = new System.Drawing.Size(100, 23);
            this.txtSecondesForTimerRefreshMarket.TabIndex = 4;
            // 
            // lblLabelTimeForRefreshMarket
            // 
            this.lblLabelTimeForRefreshMarket.AutoSize = true;
            this.lblLabelTimeForRefreshMarket.Location = new System.Drawing.Point(44, 248);
            this.lblLabelTimeForRefreshMarket.Name = "lblLabelTimeForRefreshMarket";
            this.lblLabelTimeForRefreshMarket.Size = new System.Drawing.Size(177, 15);
            this.lblLabelTimeForRefreshMarket.TabIndex = 3;
            this.lblLabelTimeForRefreshMarket.Text = "Interval for refresh market timer:";
            // 
            // chkbBTCPaires
            // 
            this.chkbBTCPaires.AutoSize = true;
            this.chkbBTCPaires.Location = new System.Drawing.Point(213, 60);
            this.chkbBTCPaires.Name = "chkbBTCPaires";
            this.chkbBTCPaires.Size = new System.Drawing.Size(79, 19);
            this.chkbBTCPaires.TabIndex = 2;
            this.chkbBTCPaires.Text = "BTC Paires";
            this.chkbBTCPaires.UseVisualStyleBackColor = true;
            // 
            // chkbUSDTPaires
            // 
            this.chkbUSDTPaires.AutoSize = true;
            this.chkbUSDTPaires.Location = new System.Drawing.Point(18, 60);
            this.chkbUSDTPaires.Name = "chkbUSDTPaires";
            this.chkbUSDTPaires.Size = new System.Drawing.Size(87, 19);
            this.chkbUSDTPaires.TabIndex = 1;
            this.chkbUSDTPaires.Text = "USDT Paires";
            this.chkbUSDTPaires.UseVisualStyleBackColor = true;
            // 
            // lblPairToProcess
            // 
            this.lblPairToProcess.AutoSize = true;
            this.lblPairToProcess.Location = new System.Drawing.Point(18, 32);
            this.lblPairToProcess.Name = "lblPairToProcess";
            this.lblPairToProcess.Size = new System.Drawing.Size(203, 15);
            this.lblPairToProcess.TabIndex = 0;
            this.lblPairToProcess.Text = "Pair to process during getting market";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 439);
            this.Controls.Add(this.grpbMarketData);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpbWebBroserSettings);
            this.Name = "settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.grpbWebBroserSettings.ResumeLayout(false);
            this.grpbWebBroserSettings.PerformLayout();
            this.grpbMarketData.ResumeLayout(false);
            this.grpbMarketData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button brnChooseWebBrowser;
        private GroupBox grpbWebBroserSettings;
        private TextBox txtbWebbrowserPath;
        private Button btnSave;
        private Button btnCancel;
        private GroupBox grpbMarketData;
        private CheckBox chkbBTCPaires;
        private CheckBox chkbUSDTPaires;
        private Label lblPairToProcess;
        private Label lblSecondes;
        private TextBox txtSecondesForTimerRefreshMarket;
        private Label lblLabelTimeForRefreshMarket;
        private CheckBox chkbDAIPaires;
        private CheckBox chkbTUSDPaires;
        private CheckBox chkbUSDCPaires;
        private CheckBox chkbKCSPaires;
        private CheckBox chkbTRXPaires;
        private CheckBox chkbDOGEPaires;
        private CheckBox chkbETHPaires;
    }
}