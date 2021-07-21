using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace STSConfigurator
{
    public partial class frmSettingClinic : frmSettingBase
    {
        private CLSSaveDataClinic classSaveDataClinic;
        public override CLSSaveData ClassSaveData { get { return classSaveDataClinic; } }
        private string ConnectingString { get { return frmSettingDatabase.ConnectingString; } }
        private string ClinicName { get; set; }
        private string NameEnglish { get; set; }
        private string Tel { get; set; }
        private string Fax { get; set; }
        private string EMail { get; set; }
        private string PostalCode { get; set; }
        private string Address { get; set; }

        public frmSettingClinic()
        {
            InitializeComponent();
            classSaveDataClinic = new CLSSaveDataClinic();
            HeadingForm = false;
            SaveToSQL = true;
        }
        public frmSettingClinic(frmSettingsMain ownerForm, string title):this()
        {
            SetOwnerForm(ownerForm);
            Title = title;
        }

        private void frmSettingClinic_Load(object sender, EventArgs e)
        {
            object sett = LoadFromXmlFile(typeof(CLSSaveDataClinic), lblTitle.Text);
            if (sett != null)
            {
                ClinicName = ((CLSSaveDataClinic)sett).ClinicName;
                NameEnglish = ((CLSSaveDataClinic)sett).NameEnglish;
                Tel = ((CLSSaveDataClinic)sett).Tel;
                Fax = ((CLSSaveDataClinic)sett).Fax;
                EMail = ((CLSSaveDataClinic)sett).EMail;
                PostalCode = ((CLSSaveDataClinic)sett).PostalCode;
                Address = ((CLSSaveDataClinic)sett).Address;

                tbxClinicName.Text = ClinicName;
                tbxClinicNameEnglish.Text = NameEnglish;
                tbxTel.Text = Tel;
                tbxFax.Text = Fax;
                tbxEmail.Text = EMail;
                tbxPostalCode.Text = PostalCode;
                tbxAddress.Text = Address;

                SetOrigin();
            }

        }
        public override void SetOrigin()
        {
            tbxClinicName.Originalstring = tbxClinicName.Text;
            tbxClinicNameEnglish.Originalstring = tbxClinicNameEnglish.Text;
            tbxTel.Originalstring = tbxTel.Text;
            tbxFax.Originalstring = tbxFax.Text;
            tbxEmail.Originalstring = tbxEmail.Text;
            tbxPostalCode.Originalstring = tbxPostalCode.Text;
            tbxAddress.Originalstring = tbxAddress.Text;
        }
        public override void ResumeToOrigin()
        {
            tbxClinicName.Text = tbxClinicName.Originalstring;
            tbxClinicNameEnglish.Text = tbxClinicNameEnglish.Originalstring;
            tbxTel.Text = tbxTel.Originalstring;
            tbxFax.Text = tbxFax.Originalstring;
            tbxEmail.Text = tbxEmail.Originalstring;
            tbxPostalCode.Text = tbxPostalCode.Originalstring;
            tbxAddress.Text = tbxAddress.Originalstring;

            this.FormModified = false;
        }
        public override void AcceptData()
        {
            ClinicName = classSaveDataClinic.ClinicName = tbxClinicName.Text;
            NameEnglish = classSaveDataClinic.NameEnglish = tbxClinicNameEnglish.Text;
            Tel = classSaveDataClinic.Tel = tbxTel.Text;
            Fax = classSaveDataClinic.Fax = tbxFax.Text;
            EMail = classSaveDataClinic.EMail = tbxEmail.Text;
            PostalCode = classSaveDataClinic.PostalCode = tbxPostalCode.Text;
            Address = classSaveDataClinic.Address = tbxAddress.Text;
        }

        private void DatasChanged(object sender, EventArgs e)
        {
            ((frmSettingsMain)ownerForm).btnConfirm.Enabled = tbxClinicName.isValidated;
        }
        
    }



    [Serializable()]
    public class CLSSaveDataClinic : frmSettingBase.CLSSaveData
    {
        public string ClinicName;
        public string NameEnglish;
        public string Tel;
        public string Fax;
        public string EMail;
        public string PostalCode;
        public string Address;
        public CLSSaveDataClinic() { }

    }

}
