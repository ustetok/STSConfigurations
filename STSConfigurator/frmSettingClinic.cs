﻿using System;
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
            LoadFromDatabase();
        }
        private void frmSettingClinic_Shown(object sender, EventArgs e)
        {
            SetOrigin();
            foreach(var cnt in Controls.OfType<TextBoxFWValidation>())
            {
                cnt.isModified = false;
                cnt.TextChanged += DatasChanged;
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
            FormModified = Controls.OfType<TextBoxFWValidation>().Any(n => n.isModified);
        }
        private void LoadFromDatabase()
        {
            using (var conn = new SqlConnection(frmSettingDatabase.ConnectingString))
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM T_Configuration";
                try
                {
                    conn.Open();
                    using (var sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)    //一回だけ読む（複数登録を認めていない）
                        {
                            sdr.Read();

                            ClinicName = sdr["ClinicName"].ToString(); tbxClinicName.Text = ClinicName;
                            NameEnglish = sdr["ClinicNameEnglish"].ToString(); tbxClinicNameEnglish.Text = NameEnglish;
                            Tel = sdr["ClinicTel"].ToString(); tbxTel.Text = Tel;
                            Fax = sdr["ClinicFax"].ToString(); tbxFax.Text = Fax;
                            EMail = sdr["ClinicEMailAddress"].ToString(); tbxEmail.Text = EMail;
                            PostalCode = sdr["ClinicPostalCode"].ToString(); tbxPostalCode.Text = PostalCode;
                            Address = sdr["ClinicAddress"].ToString(); tbxAddress.Text = Address;
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString(), "データベースが開けません");
                    throw;
                }
            }
        }
        public override void SaveToDatabase()
        {
            bool isNew;
            using(var conn = new SqlConnection(frmSettingDatabase.ConnectingString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM T_Configuration";
                    try
                    {
                        conn.Open();
                        using (var sdr = cmd.ExecuteReader())
                        {
                            isNew = !sdr.HasRows;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "データベースが読み込めません");
                        throw;
                    }
                }
                using (var cmd = conn.CreateCommand())
                {
                    try
                    {
                        if (isNew)
                        {
                            cmd.CommandText = @"INSERT INTO T_Configuration (ClinicName, ClinicNameEnglish, ClinicTel, ClinicFax,ClinicEMailAddress,ClinicPostalCode,ClinicAddress) VALUES ('" + ClinicName + "','" + NameEnglish + "','" + Tel + "','" + Fax + "','" + EMail + "','" + PostalCode + "','" + Address + "')";
                        }
                        else
                        {
                            cmd.CommandText = @"UPDATE T_Configuration SET ClinicName = ''+'" + ClinicName + "' , ClinicNameEnglish = '" + NameEnglish + "' , ClinicTel = '" + Tel + "' , ClinicFax ='" + Fax + "' , ClinicEMailAddress = '" + EMail + "' , ClinicPostalCode = '" + PostalCode + "' , ClinicAddress = '" + Address + "'";
                        }
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString(), "データベースへの書き込みに失敗しました");
                        throw;
                    }
                }
            }
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
