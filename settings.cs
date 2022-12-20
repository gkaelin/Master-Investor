using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Investor
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            //Load settings from user profile
            txtbWebbrowserPath.Text = Properties.Settings.Default.browserLocation;

            chkbUSDTPaires.Checked = Properties.Settings.Default.USDTPairesEnabled;
            chkbBTCPaires.Checked = Properties.Settings.Default.BTCPairesEnabled;
            chkbTUSDPaires.Checked = Properties.Settings.Default.TUSDPairesEnabled;
            chkbDAIPaires.Checked = Properties.Settings.Default.DAIPairesEnabled;
            chkbUSDCPaires.Checked = Properties.Settings.Default.USDCPairesEnabled;
            chkbKCSPaires.Checked = Properties.Settings.Default.KCSPAiresEnabled;
            chkbETHPaires.Checked = Properties.Settings.Default.ETHPairesEnabled;
            chkbTRXPaires.Checked = Properties.Settings.Default.TRXPairesEnabled;
            chkbDOGEPaires.Checked = Properties.Settings.Default.DOGEPairesEnabled;

            txtSecondesForTimerRefreshMarket.Text = Properties.Settings.Default.timeForTimer.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool saveData = true;
            int secondeRefreshMarketData = 0;

            //Check if input timer refresh market is in integer value
            if(int.TryParse(txtSecondesForTimerRefreshMarket.Text, out secondeRefreshMarketData) == false)
            {
                MessageBox.Show("Please provide a number for timer refresh market data");
                saveData = false;
            }

            if (saveData == true)
            {
                //Save settings
                Properties.Settings.Default.browserLocation = txtbWebbrowserPath.Text;

                Properties.Settings.Default.USDTPairesEnabled = chkbUSDTPaires.Checked;
                Properties.Settings.Default.BTCPairesEnabled = chkbBTCPaires.Checked;
                Properties.Settings.Default.TUSDPairesEnabled = chkbTUSDPaires.Checked;
                Properties.Settings.Default.DAIPairesEnabled = chkbDAIPaires.Checked;
                Properties.Settings.Default.USDCPairesEnabled = chkbUSDCPaires.Checked;
                Properties.Settings.Default.KCSPAiresEnabled = chkbKCSPaires.Checked;
                Properties.Settings.Default.ETHPairesEnabled = chkbETHPaires.Checked;
                Properties.Settings.Default.TRXPairesEnabled = chkbTRXPaires.Checked;
                Properties.Settings.Default.DOGEPairesEnabled = chkbDOGEPaires.Checked;

                Properties.Settings.Default.timeForTimer = secondeRefreshMarketData;

                Properties.Settings.Default.Save();

                MessageBox.Show("Settings saved");

                this.Close();
            }
        }

        private void brnChooseWebBrowser_Click(object sender, EventArgs e)
        {
            //Open window to choose path to browser
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "exe files (*.exe)|*.exe";

            openFileDialog1.ShowDialog();

            //Sauvegarde l'emplacement
            txtbWebbrowserPath.Text = openFileDialog1.FileName;
        }
    }
}
