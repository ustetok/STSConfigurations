using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using WindowsFormControlsLibrary;

namespace STSConfigurator
{
    public partial class frmSettingPhoto : STSConfigurator.frmSettingBase
    {
        private CLSSaveDataPhoto saveDataPhoto;
        public frmSettingPhoto()
        {
            InitializeComponent();
            saveDataPhoto = new CLSSaveDataPhoto();
            HeadingForm = false;
            SaveModeXML = true;

        }
        public frmSettingPhoto(frmSettingsMain ownerForm, string formTitle) : this()
        {
            this.Title = formTitle;
            SetOwnerForm(ownerForm);
        }


        private void frmSettingPhoto_Load(object sender, EventArgs e)
        {
            saveDataPhoto = LoadFromDatabase(saveDataPhoto) as CLSSaveDataPhoto;
        }
        private void frmSettingPhoto_Shown(object sender, EventArgs e)
        {
            SetOrigin();
            foreach (var cnt in Controls.OfType<TextBoxFWValidation>())
            {
                cnt.isModified = false;
                cnt.TextChanged += DatasChanged;
            }

        }
        public override void SetOrigin()
        {
            this.Controls.OfType<TextBoxFWValidation>().ToList().ForEach(tbx => tbx.Originalstring = tbx.Text);
        }
        public override void ResumeToOrigin()
        {
            this.Controls.OfType<TextBoxFWValidation>().ToList().ForEach(tbx => tbx.Text = tbx.Originalstring);
            FormModified = false;
        }
        public override void AcceptData()
        {
            saveDataPhoto.FolderPhotoWorking = tbxFolderPhotoWorking.Text;
            saveDataPhoto.FolderPhoto = tbxFolderPhoto.Text;
            //saveDataPhoto.PhotoOralSpeed =
        }
        private void DatasChanged(object sender, EventArgs e)
        {
            FormModified = Controls.OfType<TextBoxFWValidation>().Any(n => n.isModified);
        }


        [Serializable()]
        public class CLSSaveDataPhoto : CLSSaveData
        {
            public string FolderPhotoWorking;
            public string FolderPhoto;
            public int PhotoOralSpeed;
            public int PhotoOralDiaphragm;
            public int PhotoFacialSpeed;
            public int PhotoFacialDiaphragm;
            public CLSSaveDataPhoto() { }
        }

    }
}
