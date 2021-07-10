using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace STSConfigurator
{
    public partial class frmSettingBase : Form
    {
        public frmSettingBase SettingOwner { get; set; }
        [XmlIgnore()]
        public static string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\STS3Settings\";
        [XmlIgnore()]
        public frmSettingBase SettingForm { get; set; }
        [XmlIgnore()]
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
        #endregion
        public void SaveToXmlFile(frmSettingBase frmB)
        {
            using (StreamWriter sw = new StreamWriter(GetFilename(frmB.Title), false, new UTF8Encoding(false)))
            {
                try
                {
                    System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(frmB.GetType());
                    xs.Serialize(sw, frmB);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }

    }
}
