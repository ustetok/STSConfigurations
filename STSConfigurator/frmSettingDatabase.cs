using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STSConfigurator
{
    public partial class frmSettingDatabase : frmSettingBase
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        //private string servername;
        //private string databasename;
        private DataTable servers;

        public frmSettingDatabase()
        {
            InitializeComponent();
        }

        private void frmSettingDatabase_Load(object sender, EventArgs e)
        {
            object sett = frmSettingDatabase.LoadFromXmlFile(typeof(frmSettingDatabase), lblTitle.Text);
            if (sett != null)
            {
                ServerName = ((frmSettingDatabase)sett).ServerName;
                DatabaseName = ((frmSettingDatabase)sett).DatabaseName;

                cbxServer.Text = ServerName;
                List<string> dummy = new List<string>() { DatabaseName};
                cbxDatabase.DataSource = dummy;
                cbxDatabase.SelectedIndex = 0;
            }

        }

        private void cbxServer_DropDown(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            List<string> svrs = (from DataRow r in servers.AsEnumerable()
                                 select r.ItemArray[0].ToString() + (r.ItemArray[1].ToString() == string.Empty ? "" : @"\" + r.ItemArray[1].ToString())).ToList();
            cbxServer.DataSource = svrs;
            Cursor = Cursors.Default;

        }
    }
}
