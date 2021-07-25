using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using WindowsFormControlsLibrary;

namespace STSConfigurator
{
    public partial class frmSettingClinic : frmSettingBase
    {
        private CLSSaveDataClinic classSaveDataClinic;
        public override CLSSaveData ClassSaveData { get { return classSaveDataClinic; } }
        public static CLSSaveDataClinic ClassSaveDataClinic
        {
            get
            {
                return LoadFromDatabase(new CLSSaveDataClinic()) as CLSSaveDataClinic;
            }
        }
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
            SaveModeXML = false;
        }
        public frmSettingClinic(frmSettingsMain ownerForm, string title) : this()
        {
            SetOwnerForm(ownerForm);
            Title = title;
        }

        private void frmSettingClinic_Load(object sender, EventArgs e)
        {
            classSaveDataClinic = LoadFromDatabase(classSaveDataClinic) as CLSSaveDataClinic;

            tbxClinicName.Text = classSaveDataClinic.ClinicName;
            tbxClinicNameEnglish.Text = classSaveDataClinic.ClinicNameEnglish;
            tbxTel.Text = classSaveDataClinic.ClinicTel;
            tbxFax.Text = classSaveDataClinic.ClinicFax;
            tbxEmail.Text = classSaveDataClinic.ClinicEMailAddress;
            tbxPostalCode.Text = classSaveDataClinic.ClinicPostalCode;
            tbxAddress.Text = classSaveDataClinic.ClinicAddress;
        }
        private void frmSettingClinic_Shown(object sender, EventArgs e)
        {
            SetOrigin();
            this.Controls.OfType<TextBoxFWValidation>().ToList().ForEach(tbx =>
            {
                tbx.isModified = false;
                tbx.TextChanged += DatasChanged;
            }
            );
        }
        public override void SetOrigin()
        {
            this.Controls.OfType<TextBoxFWValidation>().ToList().ForEach(tbx => tbx.Originalstring = tbx.Text);
        }
        public override void ResumeToOrigin()
        {
            this.Controls.OfType<TextBoxFWValidation>().ToList().ForEach(tbx => tbx.Text = tbx.Originalstring);
            this.FormModified = false;
        }
        public override AcceptDataError AcceptData()
        {
            ClinicName = classSaveDataClinic.ClinicName = tbxClinicName.Text;
            NameEnglish = classSaveDataClinic.ClinicNameEnglish = tbxClinicNameEnglish.Text;
            Tel = classSaveDataClinic.ClinicTel = tbxTel.Text;
            Fax = classSaveDataClinic.ClinicFax = tbxFax.Text;
            EMail = classSaveDataClinic.ClinicEMailAddress = tbxEmail.Text;
            PostalCode = classSaveDataClinic.ClinicPostalCode = tbxPostalCode.Text;
            Address = classSaveDataClinic.ClinicAddress = tbxAddress.Text;

            return new AcceptDataError(false);
        }
        private void DatasChanged(object sender, EventArgs e)
        {
            IsValidated = tbxClinicName.isValidated;
            FormModified = Controls.OfType<TextBoxFWValidation>().Any(n => n.isModified);
        }
    }


    [Serializable()]
    public class CLSSaveDataClinic : frmSettingBase.CLSSaveData
    {
        public string ClinicName;
        public string ClinicNameEnglish;
        public string ClinicTel;
        public string ClinicFax;
        public string ClinicEMailAddress;
        public string ClinicPostalCode;
        public string ClinicAddress;
        public CLSSaveDataClinic() { }

    }

}
