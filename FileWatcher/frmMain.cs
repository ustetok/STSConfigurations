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
                if (settingChangedFlag)
                {
                    Properties.Settings.Default.TargetFile =  tbxPathTarget.Text;
                    //Properties.Settings.Default.WatchInterval = Convert.ToInt32(nudTime.Value);
                    Properties.Settings.Default.OpponentFile = tbxPathOpponent.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }
    }
}
