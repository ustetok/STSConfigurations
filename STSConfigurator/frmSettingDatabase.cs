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
using WindowsFormControlsLibrary;

namespace STSConfigurator
{
    public partial class frmSettingDatabase : frmSettingBase
    {
        private CLSSaveDataDatabase saveDataDatabase;
        public override CLSSaveData ClassSaveData { get { return saveDataDatabase; } }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public static string ConnectingString
        {
            get
            {
                CLSSaveDataDatabase obj = (CLSSaveDataDatabase)LoadFromXmlFile(typeof(CLSSaveDataDatabase), "● データベース接続および初期設定");
                if (obj == null) return "";
                return "Data Source=" + obj.ServerName + ";Initial Catalog=" + obj.DatabaseName + ";Integrated Security=SSPI";
            }
        }
        private DataTable servers;
        
        public frmSettingDatabase()
        {
            InitializeComponent();
            saveDataDatabase = new CLSSaveDataDatabase();
            SaveModeXML = true;
        }
        public frmSettingDatabase(frmSettingsMain ownerForm, string formTitle) : this()
        {
            this.Title = formTitle;
            this.HeadingForm = false;
            SetOwnerForm(ownerForm);
        }

        private void frmSettingDatabase_Load(object sender, EventArgs e)
        {
            object sett = LoadFromXmlFile(typeof(CLSSaveDataDatabase), lblTitle.Text);
            if (sett != null)
            {
                ServerName = ((CLSSaveDataDatabase)sett).ServerName;
                DatabaseName = ((CLSSaveDataDatabase)sett).DatabaseName;

                cbxMServer.Text = ServerName;
                List<string> dummy = new List<string>() { DatabaseName };
                cbxMDatabase.DataSource = dummy;
                cbxMDatabase.SelectedIndex = 0;
                SetOrigin();
            }
            btnDBTestEnable();
        }
        public override void SetOrigin()
        {
            this.Controls.OfType<ComboBoxModified>().ToList().ForEach(cbx => cbx.Original = cbx.Text);
        }
        public override void ResumeToOrigin()
        {
            this.Controls.OfType<ComboBoxModified>().ToList().ForEach(cbx => cbx.Text = cbx.Original);
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
        }
        private void DatasChanged(object sender, EventArgs e)
        {
            IsValidated = Controls.OfType<ComboBoxModified>().All(cbx => cbx.Text.Length > 0);
            FormModified = cbxMServer.Modified || cbxMDatabase.Modified;
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
        }

    }
}
