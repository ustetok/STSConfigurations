using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace STSConfigurator
{
    public partial class frmSettingDatabase : frmSettingBase
    {
        public CLSSaveDataDatabase saveDataDatabase;
        public override CLSSaveData ClassSaveData { get { return saveDataDatabase; } }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string DirectoryWorking { get; set; }
        public static string ConnectingString
        {
            get
            {
                frmSettingDatabase obj = (frmSettingDatabase)LoadFromXmlFile(typeof(CLSSaveDataDatabase), "データベース接続");
                if (obj == null) return "";
                return "Data Source=" + obj.ServerName + ";Initial Catalog=" + obj.DatabaseName + ";Integrated Security=SSPI";
            }
        }
        private DataTable servers;

        public frmSettingDatabase()
        {
            InitializeComponent();
            saveDataDatabase = new CLSSaveDataDatabase();
        }
        public frmSettingDatabase(frmSettingsMain ownerForm, string formTitle, bool isHeader) : this()
        {
            this.Title = formTitle;
            this.HeadingForm = isHeader;
            SetOwnerForm(ownerForm);
            tbxDirectoryWorking.Text = Application.UserAppDataPath;
        }

        private void frmSettingDatabase_Load(object sender, EventArgs e)
        {
            object sett = LoadFromXmlFile(typeof(CLSSaveDataDatabase), lblTitle.Text);
            if (sett != null)
            {
                ServerName = ((CLSSaveDataDatabase)sett).ServerName;
                DatabaseName = ((CLSSaveDataDatabase)sett).DatabaseName;
                DirectoryWorking = ((CLSSaveDataDatabase)sett).DirectoryWorking;

                cbxMServer.Text = ServerName;
                List<string> dummy = new List<string>() { DatabaseName };
                cbxMDatabase.DataSource = dummy;
                cbxMDatabase.SelectedIndex = 0;
                tbxDirectoryWorking.Text = DirectoryWorking;
                SetOrigin();
            }
            btnDBTestEnable();
        }
        public override void SetOrigin()
        {
            cbxMServer.Original = cbxMServer.Text;
            cbxMDatabase.Original = cbxMDatabase.Text;
            tbxDirectoryWorking.Originalstring = tbxDirectoryWorking.Text;
        }
        public override void ResumeToOrigin()
        {
            cbxMServer.Text = cbxMServer.Original;
            cbxMDatabase.Text = cbxMDatabase.Original;
            tsmiDefault_Click(null, null);
            this.FormModified = false;
        }
        private void cbxServer_DropDown(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            List<string> svrs = (from DataRow r in servers.AsEnumerable()
                                 select r.ItemArray[0].ToString() + (r.ItemArray[1].ToString() == string.Empty ? "" : @"\" + r.ItemArray[1].ToString())).ToList();
            cbxMServer.DataSource = svrs;
            Cursor = Cursors.Default;

        }
        private void cbxDatabase_DropDown(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (SqlConnection connection = new SqlConnection())
            {
                List<string> dbNames = new List<string>();
                try
                {
                    cbxMDatabase.DataSource = null;
                    connection.ConnectionString = "Data Source=" + cbxMServer.Text + ";Integrated Security=SSPI";
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "Select name from sys.databases WHERE name <> 'master' AND name <> 'tempdb' AND name <> 'model' AND name <> 'msdb'";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dbNames.Add(reader.GetString(0));
                    }
                    reader.Close();

                    cbxMDatabase.DataSource = dbNames;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "そのデータベースにはアクセスできません");
                }
            }
            Cursor = Cursors.Default;
        }
        public override void AcceptData()
        {
            ServerName = saveDataDatabase.ServerName = cbxMServer.Text;
            DatabaseName = saveDataDatabase.DatabaseName = cbxMDatabase.Text;
            DirectoryWorking = saveDataDatabase.DirectoryWorking = tbxDirectoryWorking.Text;
        }
        private void DatasChanged(object sender, EventArgs e)
        {
            FormModified = cbxMServer.Modified || cbxMDatabase.Modified || tbxDirectoryWorking.isModified;
            btnDBTestEnable();
        }
        private void btnDBTestEnable()
        {
            btnDBTest.Enabled = cbxMServer.Text.Length > 0 && cbxMDatabase.Text.Length > 0;
        }
        private void frmSettingDatabase_Shown(object sender, EventArgs e)
        {
            this.cbxMServer.TextChanged += new System.EventHandler(this.DatasChanged);
            this.cbxMDatabase.TextChanged += new System.EventHandler(this.DatasChanged);
            this.tbxDirectoryWorking.TextChanged += new EventHandler(this.DatasChanged);
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            FBDialog.SelectedPath = Directory.Exists(tbxDirectoryWorking.Text) ? Path.GetDirectoryName(tbxDirectoryWorking.Text) : Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            DialogResult dr = FBDialog.ShowDialog();
            if (dr == DialogResult.OK) tbxDirectoryWorking.Text = FBDialog.SelectedPath + "\\";
        }

        private void tsmiDefault_Click(object sender, EventArgs e)
        {
            tbxDirectoryWorking.Text = Application.UserAppDataPath;
        }

        private void tbxDirectoryWorking_Validating(object sender, CancelEventArgs e)
        {
            if (FormModified && Directory.Exists(tbxDirectoryWorking.Text))
            {
                if (!tbxDirectoryWorking.Text.EndsWith("\\")) tbxDirectoryWorking.Text += "\\";
            }
        }

        private void btnDBTest_Click(object sender, EventArgs e)
        {
            Cursor defaultCursor = Cursor.Current;
            Cursor = Cursors.WaitCursor;
            try
            {
                string connStr = "Data Source=" + cbxMServer.Text + ";Initial Catalog=" + cbxMDatabase.Text + ";Integrated Security=SSPI";

                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    MessageBox.Show("ヽ(´▽｀)/～♪", "データベースに接続できました");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "データベースに接続できません");
            }
            Cursor = defaultCursor;
        }
        [Serializable()]
        public class CLSSaveDataDatabase : CLSSaveData
        {
            public CLSSaveDataDatabase() { }
            public string ServerName;
            public string DatabaseName;
            public string DirectoryWorking;
        }
    }
}
