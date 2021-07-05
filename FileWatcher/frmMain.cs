using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileWatcher
{
    public partial class frmMain : Form
    {
        private bool closeFlag = false;
        private bool settingChangedFlag = false;

        public frmMain()
        {
            InitializeComponent();

            tbxPathTarget.Text = Properties.Settings.Default.TargetFile;
            tbxPathOpponent.Text = Properties.Settings.Default.OpponentFile;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeFlag)
            {
                this.Visible = false;
                e.Cancel = true;
            }
            else
            {
                SaveSetting();
            }
        }
        private void SaveSetting()
        {
            if (settingChangedFlag) //変更があるなら保存する
            {
                Properties.Settings.Default.TargetFile =  tbxPathTarget.Text;
                //Properties.Settings.Default.WatchInterval = Convert.ToInt32(nudTime.Value);
                Properties.Settings.Default.OpponentFile = tbxPathOpponent.Text;
                Properties.Settings.Default.Save();
            }
        }
        private void pnlV_Validation(WindowsFormControlsLibrary.IktsValidation obj)
        {
            btnVerify.Enabled = pnlV.isValidated;
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            closeFlag = true;
            Application.Exit();
        }
    }
}
