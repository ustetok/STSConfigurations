﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
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
        public frmSettingDatabase(frmSettingsMain ownerForm) : this()
        {
            SetOwnerForm(ownerForm);
        }

        private void frmSettingDatabase_Load(object sender, EventArgs e)
        {
            object sett = LoadFromXmlFile(typeof(CLSSaveDataDatabase), lblTitle.Text);
            if (sett != null)
            {
                ServerName = ((CLSSaveDataDatabase)sett).ServerName;
                DatabaseName = ((CLSSaveDataDatabase)sett).DatabaseName;

                cbxServer.Text = ServerName;
                List<string> dummy = new List<string>() { DatabaseName };
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
                private void cbxDatabase_DropDown(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (SqlConnection connection = new SqlConnection())
            {
                List<string> dbNames = new List<string>();
                try
                {
                    cbxDatabase.DataSource = null;
                    connection.ConnectionString = "Data Source=" + cbxServer.Text + ";Integrated Security=SSPI";
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

                    cbxDatabase.DataSource = dbNames;
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
            ServerName= saveDataDatabase.ServerName = cbxServer.Text;
            DatabaseName = saveDataDatabase.DatabaseName = cbxDatabase.Text;
        }
        [Serializable()]
        public class CLSSaveDataDatabase : CLSSaveData
        {
            public CLSSaveDataDatabase() { }
            public string ServerName;
            public string DatabaseName;
        }

        private void DatasChanged(object sender, EventArgs e)
        {
            FormModified = true;
        }

        private void frmSettingDatabase_Shown(object sender, EventArgs e)
        {
            //this.cbxServer.TextChanged += new System.EventHandler(this.DatasChanged);
            //this.cbxDatabase.TextChanged += new System.EventHandler(this.DatasChanged);

        }
    }
}
