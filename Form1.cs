using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Text.Json.Nodes;

namespace Master_Investor
{
    public partial class Form1 : Form
    {
        //Variables globales
        DataGridView dgvSaved = new DataGridView();
        bool firstRun = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void refreshMarketData()
        {
            dgvAnalyseMarche.Rows.Clear();

            kuCoinAPI kuCoinAPIOBJ = new kuCoinAPI();

            string stringAllTicker = kuCoinAPIOBJ.getAllTicker();

            //Convert string to JSON
            var JsonData = JsonObject.Parse(stringAllTicker)["data"]["ticker"].AsArray();

            foreach (var ligneJSON in JsonData)
            {
                if (ligneJSON["symbol"].ToString().Contains("-USDT"))
                {
                    //USDT market, add it to datagrid
                    NumberFormatInfo provider = new NumberFormatInfo();
                    provider.NumberDecimalSeparator = ".";

                    string symbole = ligneJSON["symbol"].ToString();
                    string lastPrice = ligneJSON["last"].ToString();

                    double changeRate = Convert.ToDouble(ligneJSON["changeRate"].ToString(), provider) * 100;

                    double changeRateSinceLastUpdate = 0;

                    if (firstRun == false)
                    {
                        //Look for the old changerate to calculate
                        foreach (DataGridViewRow ligne in dgvSaved.Rows)
                        {
                            if (ligne.Cells[0].Value != null && ligne.Cells[0].Value.ToString() == ligneJSON["symbol"].ToString())
                            {
                                //Calcul difference
                                changeRateSinceLastUpdate = changeRate - Convert.ToDouble(ligne.Cells[2].Value.ToString());
                            }
                        }
                    }

                    dgvAnalyseMarche.Rows.Add(symbole, lastPrice, changeRate, changeRateSinceLastUpdate);
                }
            }

            //Order the dataGrid by changeRate changed
            dgvAnalyseMarche.Columns["h24Rate"].ValueType = typeof(decimal);
            dgvAnalyseMarche.Columns["changeRate"].ValueType = typeof(decimal);
            dgvAnalyseMarche.Sort(dgvAnalyseMarche.Columns["changeRate"], ListSortDirection.Descending);

            //Save datagrid to use it later
            dgvSaved.Rows.Clear();
            dgvSaved.Columns.Clear();

            for (int j = 0; j < this.dgvAnalyseMarche.Columns.Count; j++)
            {
                dgvSaved.Columns.Add(dgvAnalyseMarche.Columns[j].Clone() as DataGridViewColumn);
            }

            for (int j = 0; j < this.dgvAnalyseMarche.Rows.Count; j++)
            {
                dgvSaved.Rows.Add(dgvAnalyseMarche.Rows[j].Clone() as DataGridViewRow);
                dgvSaved.Rows[j].Cells[0].Value = dgvAnalyseMarche.Rows[j].Cells[0].Value;
                dgvSaved.Rows[j].Cells[1].Value = dgvAnalyseMarche.Rows[j].Cells[1].Value;
                dgvSaved.Rows[j].Cells[2].Value = dgvAnalyseMarche.Rows[j].Cells[2].Value;
                dgvSaved.Rows[j].Cells[3].Value = dgvAnalyseMarche.Rows[j].Cells[3].Value;
            }

            firstRun = false;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Check if settings are correctly defined
            if(Properties.Settings.Default.browserLocation is null)
            {
                Properties.Settings.Default.browserLocation = "";
                Properties.Settings.Default.Save();
            }

            //Initialise the timer for refresh interval
            timRefreshMarket.Interval = 10000;
        }

        private void btnRefreshMarket_Click(object sender, EventArgs e)
        {
            bool autoRefreshAReactiver = timRefreshMarket.Enabled;

            timRefreshMarket.Enabled = false;

            refreshMarketData();

            if (autoRefreshAReactiver == true)
            {
                timRefreshMarket.Enabled = true;
            }
        }

        private void dgvAnalyseMarche_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ligne = e.RowIndex;
            string emplacementBrowser = Properties.Settings.Default.browserLocation;

            //Open trading page on webbrowser
            if (emplacementBrowser != "")
            {
                System.Diagnostics.Process.Start(emplacementBrowser, "https://www.kucoin.com/trade/" + dgvAnalyseMarche.Rows[ligne].Cells[0].Value.ToString() + "?spm=kcWeb.B1homepage.Header4.1");
            }
            else
            {
                MessageBox.Show("Please specify the webbroser you want to use by going to File > Specify webbrowser location...");
            }
        }

        private void btnAutoRefreshMarket_Click(object sender, EventArgs e)
        {
            //Check si timer actif ou pas
            if(timRefreshMarket.Enabled == true)
            {
                //Timer actif
                timRefreshMarket.Enabled = false;
                btnAutoRefreshMarket.Text = "Auto refresh off";
                btnAutoRefreshMarket.ForeColor = Color.Red;
            }
            else
            {
                //Timer stopped
                timRefreshMarket.Enabled = true;
                btnAutoRefreshMarket.Text = "Auto refresh on";
                btnAutoRefreshMarket.ForeColor = Color.Green;
            }
        }

        private void timRefreshMarket_Tick(object sender, EventArgs e)
        {
            btnAutoRefreshMarket.Enabled = false;
            btnRefreshMarket.Enabled = false;

            refreshMarketData();
        }

        private void définirLemplacementDuNavigateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open window to choose path to browser
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "exe files (*.exe)|*.exe";

            openFileDialog1.ShowDialog();

            //Sauvegarde l'emplacement
            Properties.Settings.Default.browserLocation = openFileDialog1.FileName;
            Properties.Settings.Default.Save();

            MessageBox.Show("Path to webbrowser defined");
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about aboutOBJ = new about();
            aboutOBJ.Show();
        }
    }
}