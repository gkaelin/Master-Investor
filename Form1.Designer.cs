﻿namespace Master_Investor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbAnalyseMarche = new System.Windows.Forms.GroupBox();
            this.dgvAnalyseMarche = new System.Windows.Forms.DataGridView();
            this.Symbole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpRefreshMarket = new System.Windows.Forms.GroupBox();
            this.btnAutoRefreshMarket = new System.Windows.Forms.Button();
            this.btnRefreshMarket = new System.Windows.Forms.Button();
            this.timRefreshMarket = new System.Windows.Forms.Timer(this.components);
            this.pctbMonney = new System.Windows.Forms.PictureBox();
            this.symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h24Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.grpbAnalyseMarche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalyseMarche)).BeginInit();
            this.grpRefreshMarket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMonney)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.quitterToolStripMenuItem.Text = "Quit";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // grpbAnalyseMarche
            // 
            this.grpbAnalyseMarche.Controls.Add(this.dgvAnalyseMarche);
            this.grpbAnalyseMarche.Location = new System.Drawing.Point(12, 27);
            this.grpbAnalyseMarche.Name = "grpbAnalyseMarche";
            this.grpbAnalyseMarche.Size = new System.Drawing.Size(565, 471);
            this.grpbAnalyseMarche.TabIndex = 1;
            this.grpbAnalyseMarche.TabStop = false;
            this.grpbAnalyseMarche.Text = "Analyse des marchés";
            // 
            // dgvAnalyseMarche
            // 
            this.dgvAnalyseMarche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalyseMarche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.symbol,
            this.currentPrice,
            this.h24Rate,
            this.priceChange,
            this.changeRate});
            this.dgvAnalyseMarche.Location = new System.Drawing.Point(11, 22);
            this.dgvAnalyseMarche.MultiSelect = false;
            this.dgvAnalyseMarche.Name = "dgvAnalyseMarche";
            this.dgvAnalyseMarche.ReadOnly = true;
            this.dgvAnalyseMarche.RowTemplate.Height = 25;
            this.dgvAnalyseMarche.Size = new System.Drawing.Size(543, 438);
            this.dgvAnalyseMarche.TabIndex = 0;
            this.dgvAnalyseMarche.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnalyseMarche_CellDoubleClick);
            // 
            // Symbole
            // 
            this.Symbole.HeaderText = "Symbole";
            this.Symbole.Name = "Symbole";
            // 
            // grpRefreshMarket
            // 
            this.grpRefreshMarket.Controls.Add(this.btnAutoRefreshMarket);
            this.grpRefreshMarket.Controls.Add(this.btnRefreshMarket);
            this.grpRefreshMarket.Location = new System.Drawing.Point(583, 27);
            this.grpRefreshMarket.Name = "grpRefreshMarket";
            this.grpRefreshMarket.Size = new System.Drawing.Size(178, 213);
            this.grpRefreshMarket.TabIndex = 12;
            this.grpRefreshMarket.TabStop = false;
            this.grpRefreshMarket.Text = "Refresh Market";
            // 
            // btnAutoRefreshMarket
            // 
            this.btnAutoRefreshMarket.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutoRefreshMarket.ForeColor = System.Drawing.Color.Red;
            this.btnAutoRefreshMarket.Location = new System.Drawing.Point(6, 113);
            this.btnAutoRefreshMarket.Name = "btnAutoRefreshMarket";
            this.btnAutoRefreshMarket.Size = new System.Drawing.Size(160, 71);
            this.btnAutoRefreshMarket.TabIndex = 13;
            this.btnAutoRefreshMarket.Text = "Auto refresh off";
            this.btnAutoRefreshMarket.UseVisualStyleBackColor = true;
            this.btnAutoRefreshMarket.Click += new System.EventHandler(this.btnAutoRefreshMarket_Click);
            // 
            // btnRefreshMarket
            // 
            this.btnRefreshMarket.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshMarket.Location = new System.Drawing.Point(6, 22);
            this.btnRefreshMarket.Name = "btnRefreshMarket";
            this.btnRefreshMarket.Size = new System.Drawing.Size(160, 71);
            this.btnRefreshMarket.TabIndex = 12;
            this.btnRefreshMarket.Text = "Refresh Now";
            this.btnRefreshMarket.UseVisualStyleBackColor = true;
            this.btnRefreshMarket.Click += new System.EventHandler(this.btnRefreshMarket_Click);
            // 
            // timRefreshMarket
            // 
            this.timRefreshMarket.Tick += new System.EventHandler(this.timRefreshMarket_Tick);
            // 
            // pctbMonney
            // 
            this.pctbMonney.Image = ((System.Drawing.Image)(resources.GetObject("pctbMonney.Image")));
            this.pctbMonney.Location = new System.Drawing.Point(583, 246);
            this.pctbMonney.Name = "pctbMonney";
            this.pctbMonney.Size = new System.Drawing.Size(178, 252);
            this.pctbMonney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctbMonney.TabIndex = 13;
            this.pctbMonney.TabStop = false;
            // 
            // symbol
            // 
            this.symbol.HeaderText = "Symbol";
            this.symbol.Name = "symbol";
            this.symbol.ReadOnly = true;
            // 
            // currentPrice
            // 
            this.currentPrice.HeaderText = "Current Price";
            this.currentPrice.Name = "currentPrice";
            this.currentPrice.ReadOnly = true;
            // 
            // h24Rate
            // 
            this.h24Rate.HeaderText = "24h Rate";
            this.h24Rate.Name = "h24Rate";
            this.h24Rate.ReadOnly = true;
            // 
            // priceChange
            // 
            this.priceChange.HeaderText = "Price Change";
            this.priceChange.Name = "priceChange";
            this.priceChange.ReadOnly = true;
            // 
            // changeRate
            // 
            this.changeRate.HeaderText = "Rate Change";
            this.changeRate.Name = "changeRate";
            this.changeRate.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 508);
            this.Controls.Add(this.pctbMonney);
            this.Controls.Add(this.grpRefreshMarket);
            this.Controls.Add(this.grpbAnalyseMarche);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Master Investor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpbAnalyseMarche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalyseMarche)).EndInit();
            this.grpRefreshMarket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbMonney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private GroupBox grpbAnalyseMarche;
        private DataGridView dgvAnalyseMarche;
        private DataGridViewTextBoxColumn Symbole;
        private GroupBox grpRefreshMarket;
        private Button btnRefreshMarket;
        private Button btnAutoRefreshMarket;
        private System.Windows.Forms.Timer timRefreshMarket;
        private PictureBox pctbMonney;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private DataGridViewTextBoxColumn symbol;
        private DataGridViewTextBoxColumn currentPrice;
        private DataGridViewTextBoxColumn h24Rate;
        private DataGridViewTextBoxColumn priceChange;
        private DataGridViewTextBoxColumn changeRate;
    }
}