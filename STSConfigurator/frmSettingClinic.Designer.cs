
namespace STSConfigurator
{
    partial class frmSettingClinic
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxClinicName = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.tbxClinicNameEnglish = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.tbxTel = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.tbxFax = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.tbxEmail = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPostalCode = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxAddress = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "医院情報";
            // 
            // tbxClinicName
            // 
            this.tbxClinicName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxClinicName.CueBannerText = "医院名を入力してください（必須）";
            this.tbxClinicName.Enable = true;
            this.tbxClinicName.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tbxClinicName.isModified = false;
            this.tbxClinicName.isValidated = false;
            this.tbxClinicName.Location = new System.Drawing.Point(114, 72);
            this.tbxClinicName.Name = "tbxClinicName";
            this.tbxClinicName.Originalstring = null;
            this.tbxClinicName.Size = new System.Drawing.Size(730, 25);
            this.tbxClinicName.TabIndex = 2;
            // 
            // tbxClinicNameEnglish
            // 
            this.tbxClinicNameEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxClinicNameEnglish.CueBannerText = "英語表記で入力してください";
            this.tbxClinicNameEnglish.Enable = true;
            this.tbxClinicNameEnglish.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxClinicNameEnglish.isModified = false;
            this.tbxClinicNameEnglish.isValidated = false;
            this.tbxClinicNameEnglish.Location = new System.Drawing.Point(114, 116);
            this.tbxClinicNameEnglish.Name = "tbxClinicNameEnglish";
            this.tbxClinicNameEnglish.Originalstring = null;
            this.tbxClinicNameEnglish.Size = new System.Drawing.Size(730, 25);
            this.tbxClinicNameEnglish.TabIndex = 3;
            // 
            // tbxTel
            // 
            this.tbxTel.CueBannerText = "ハイフンなどは入れないでください";
            this.tbxTel.Enable = true;
            this.tbxTel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxTel.isModified = false;
            this.tbxTel.isValidated = false;
            this.tbxTel.Location = new System.Drawing.Point(114, 160);
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.NumericMode = true;
            this.tbxTel.Originalstring = null;
            this.tbxTel.Size = new System.Drawing.Size(203, 25);
            this.tbxTel.TabIndex = 4;
            // 
            // tbxFax
            // 
            this.tbxFax.CueBannerText = "ハイフンなどは入れないでください";
            this.tbxFax.Enable = true;
            this.tbxFax.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxFax.isModified = false;
            this.tbxFax.isValidated = false;
            this.tbxFax.Location = new System.Drawing.Point(114, 204);
            this.tbxFax.Name = "tbxFax";
            this.tbxFax.Originalstring = null;
            this.tbxFax.Size = new System.Drawing.Size(203, 25);
            this.tbxFax.TabIndex = 5;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxEmail.CueBannerText = "E-Mailアドレスを入力してください";
            this.tbxEmail.Enable = true;
            this.tbxEmail.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxEmail.isModified = false;
            this.tbxEmail.isValidated = false;
            this.tbxEmail.Location = new System.Drawing.Point(114, 248);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Originalstring = null;
            this.tbxEmail.Size = new System.Drawing.Size(730, 25);
            this.tbxEmail.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "医院名 *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "医院名(英語)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "電話番号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fax番号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-Mailアドレス";
            // 
            // tbxPostalCode
            // 
            this.tbxPostalCode.CueBannerText = "ハイフンなどは入れないでください";
            this.tbxPostalCode.Enable = true;
            this.tbxPostalCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxPostalCode.isModified = false;
            this.tbxPostalCode.isValidated = false;
            this.tbxPostalCode.Location = new System.Drawing.Point(114, 292);
            this.tbxPostalCode.Name = "tbxPostalCode";
            this.tbxPostalCode.NumericMode = true;
            this.tbxPostalCode.Originalstring = null;
            this.tbxPostalCode.Size = new System.Drawing.Size(203, 25);
            this.tbxPostalCode.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "郵便番号";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAddress.CueBannerText = "医院の住所を入力してください";
            this.tbxAddress.Enable = true;
            this.tbxAddress.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tbxAddress.isModified = false;
            this.tbxAddress.isValidated = false;
            this.tbxAddress.Location = new System.Drawing.Point(115, 336);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Originalstring = null;
            this.tbxAddress.Size = new System.Drawing.Size(729, 25);
            this.tbxAddress.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "所在地";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "データはデータベースに保存されます";
            // 
            // frmSettingClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(856, 606);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxPostalCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxFax);
            this.Controls.Add(this.tbxTel);
            this.Controls.Add(this.tbxClinicNameEnglish);
            this.Controls.Add(this.tbxClinicName);
            this.Name = "frmSettingClinic";
            this.Title = "医院情報";
            this.Load += new System.EventHandler(this.frmSettingClinic_Load);
            this.Shown += new System.EventHandler(this.frmSettingClinic_Shown);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.tbxClinicName, 0);
            this.Controls.SetChildIndex(this.tbxClinicNameEnglish, 0);
            this.Controls.SetChildIndex(this.tbxTel, 0);
            this.Controls.SetChildIndex(this.tbxFax, 0);
            this.Controls.SetChildIndex(this.tbxEmail, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbxPostalCode, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tbxAddress, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormControlsLibrary.TextBoxFWValidation tbxClinicName;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxClinicNameEnglish;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxTel;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxFax;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxPostalCode;
        private System.Windows.Forms.Label label7;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
