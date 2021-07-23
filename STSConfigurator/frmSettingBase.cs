using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Reflection;

namespace STSConfigurator
{
    public partial class frmSettingBase : Form
    {
        public frmSettingsMain ownerForm;
        public bool HeadingForm { get; set; }
        public bool SaveModeXML { get; set; }
        public virtual CLSSaveData ClassSaveData { get { return null; } }
        private bool modified = false;
        public bool FormModified
        {
            get { return modified; }
            set
            {
                modified = value;
                ownerForm.ModifiedChanged(this.Title, value);
            }
        }
        public static string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\STS3Settings\";
        public frmSettingBase SettingForm { get; set; }
        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public frmSettingBase() 
        {
            InitializeComponent();
            TopLevel = false;
        }
        public frmSettingBase(string formTitle, bool isHeader):this()
        {
            Title = formTitle;
            HeadingForm = isHeader;
        }
        public void SetOwnerForm(frmSettingsMain frm)
        {
            ownerForm = frm;
        }
        public virtual void SetOrigin() { }
        public virtual void ResumeToOrigin() { }
        #region static method
        public static bool ExsistFile(string title)
        {
            return Directory.Exists(FilePath + title + ".config");
        }
        public static string GetFilename(string title)
        {
            if (Directory.Exists(FilePath) == false) Directory.CreateDirectory(FilePath);

            return FilePath + title + ".config";
        }
        public static object LoadFromXmlFile(Type type, string title)
        {
            if (File.Exists(GetFilename(title)))
            {
                using (StreamReader sr = new StreamReader(GetFilename(title), new UTF8Encoding(false)))
                {
                    System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(type);
                    return xs.Deserialize(sr);
                }
            }
            else return null;
        }
        public static object LoadFromDatabase(object csd)
        {
            Cursor c = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            Type type = csd.GetType();
            var fieldInfo = type.GetFields();

            using (var conn = new SqlConnection(frmSettingDatabase.ConnectingString))
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM T_Configuration";  //  ほかの設定で使うとき条件分岐させること
                try
                {
                    conn.Open();
                    using (var sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)    //一回だけ読む（複数登録を認めていない）
                        {
                            sdr.Read();

                            for(int i = 0;i<fieldInfo.Length;i++)
                            {
                                fieldInfo[i].SetValue(csd, sdr[fieldInfo[i].Name] );
                            }
                        }
                    }
                    return csd;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString(), "データベースが開けません");
                    throw;
                }
                finally
                {
                    Cursor.Current = c;
                }
            }
        }
        #endregion
        public virtual void SaveToDatabase()
        {

        }
        public void SaveToXmlFile(frmSettingBase frmsettingbase)
        {
            frmSettingBase.CLSSaveData csd = frmsettingbase.ClassSaveData;
            var xmlserializer = new XmlSerializer(csd.GetType());
            using (TextWriter tw = new StreamWriter(frmSettingBase.GetFilename(frmsettingbase.Title)))
            {
                try
                {
                    xmlserializer.Serialize(tw, csd);
                    tw.Flush();
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message);
                    throw;
                }
            }
        }
        
        public virtual void AcceptData() { }
        [Serializable()]
        public class CLSSaveData
        {
            public CLSSaveData() { }
        }
    }
}
