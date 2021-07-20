using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace STSConfigurator
{
    public partial class frmSettingClinic : frmSettingBase
    {
        private CLSSaveDataClinic classSaveDataClinic;
        public override CLSSaveData ClassSaveData { get { return classSaveDataClinic; } }
        public frmSettingClinic()
        {
            InitializeComponent();
            classSaveDataClinic = new CLSSaveDataClinic();
            HeadingForm = true;
        }
        public frmSettingClinic(frmSettingsMain ownerForm, string title):this()
        {
            SetOwnerForm(ownerForm);
            Title = title;
        }
    }
    [Serializable()]
    public class CLSSaveDataClinic : frmSettingBase.CLSSaveData
    {
        public CLSSaveDataClinic() { }
    }

}
