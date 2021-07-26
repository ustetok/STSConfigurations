using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormControlsLibrary;
using STSConfigurator;


namespace STSOrganizer
{
    public partial class formDB : Form, IktsDBForm
    {
        public bool AllowSaveSetting { get; set; } = true;
        public string ConnectingString { get { return frmSettingDatabase.ConnectingString; } }

        public formDB()
        {
            InitializeComponent();
        }

        public void Form_Closed(object sender, FormClosedEventArgs e)
        {
            if (AllowSaveSetting)
            {
                Rectangle rct;
                if (this.WindowState != FormWindowState.Normal)
                {
                    rct = this.RestoreBounds;
                }
                else
                {
                    rct = this.Bounds;
                }

                Properties.Settings.Default.PointStart = rct.Location;
                Properties.Settings.Default.SizeForm = rct.Size;
                Properties.Settings.Default.Save();
            }

        }

        public void Form_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.PointStart;
            this.Size = Properties.Settings.Default.SizeForm;
        }
    }
}
