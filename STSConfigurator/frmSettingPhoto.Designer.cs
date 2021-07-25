
namespace STSConfigurator
{
    partial class frmSettingPhoto
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFolderPhotoWorking = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFolderPhoto = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxOSpeed = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxODiaphragm = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.tbxFSpeed = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.tbxFDiaphragm = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pbxO = new System.Windows.Forms.PictureBox();
            this.pbxF = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxOIso = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.tbxFIso = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonLink1 = new WindowsFormControlsLibrary.ButtonLink();
            this.buttonLink2 = new WindowsFormControlsLibrary.ButtonLink();
            ((System.ComponentModel.ISupportInitialize)(this.pbxO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxF)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "写真およびレントゲンの設定";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "データはデータベースに保存されます";
            // 
            // tbxFolderPhotoWorking
            // 
            this.tbxFolderPhotoWorking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFolderPhotoWorking.Enable = true;
            this.tbxFolderPhotoWorking.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxFolderPhotoWorking.isModified = false;
            this.tbxFolderPhotoWorking.isValidated = false;
            this.tbxFolderPhotoWorking.Location = new System.Drawing.Point(185, 80);
            this.tbxFolderPhotoWorking.Name = "tbxFolderPhotoWorking";
            this.tbxFolderPhotoWorking.Originalstring = null;
            this.tbxFolderPhotoWorking.Size = new System.Drawing.Size(620, 25);
            this.tbxFolderPhotoWorking.TabIndex = 0;
            this.tbxFolderPhotoWorking.Validating += new System.ComponentModel.CancelEventHandler(this.tbxFolders_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "各写真の作業フォルダー *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "各写真の保存フォルダー *";
            // 
            // tbxFolderPhoto
            // 
            this.tbxFolderPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFolderPhoto.Enable = true;
            this.tbxFolderPhoto.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxFolderPhoto.isModified = false;
            this.tbxFolderPhoto.isValidated = false;
            this.tbxFolderPhoto.Location = new System.Drawing.Point(185, 130);
            this.tbxFolderPhoto.Name = "tbxFolderPhoto";
            this.tbxFolderPhoto.Originalstring = null;
            this.tbxFolderPhoto.Size = new System.Drawing.Size(620, 25);
            this.tbxFolderPhoto.TabIndex = 1;
            this.tbxFolderPhoto.Validating += new System.ComponentModel.CancelEventHandler(this.tbxFolders_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "フォルダーの設定";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(832, 2);
            this.label6.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(15, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "写真の設定";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "口腔内写真";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "顔貌写真";
            // 
            // tbxOSpeed
            // 
            this.tbxOSpeed.Enable = true;
            this.tbxOSpeed.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxOSpeed.isModified = false;
            this.tbxOSpeed.isValidated = false;
            this.tbxOSpeed.Location = new System.Drawing.Point(152, 258);
            this.tbxOSpeed.Name = "tbxOSpeed";
            this.tbxOSpeed.NumericMode = true;
            this.tbxOSpeed.Originalstring = null;
            this.tbxOSpeed.Size = new System.Drawing.Size(45, 25);
            this.tbxOSpeed.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "シャッタースピード *";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "絞り *";
            // 
            // tbxODiaphragm
            // 
            this.tbxODiaphragm.Enable = true;
            this.tbxODiaphragm.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxODiaphragm.isModified = false;
            this.tbxODiaphragm.isValidated = false;
            this.tbxODiaphragm.Location = new System.Drawing.Point(245, 258);
            this.tbxODiaphragm.Name = "tbxODiaphragm";
            this.tbxODiaphragm.NumericMode = true;
            this.tbxODiaphragm.Originalstring = null;
            this.tbxODiaphragm.Size = new System.Drawing.Size(45, 25);
            this.tbxODiaphragm.TabIndex = 3;
            // 
            // tbxFSpeed
            // 
            this.tbxFSpeed.Enable = true;
            this.tbxFSpeed.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxFSpeed.isModified = false;
            this.tbxFSpeed.isValidated = false;
            this.tbxFSpeed.Location = new System.Drawing.Point(152, 388);
            this.tbxFSpeed.Name = "tbxFSpeed";
            this.tbxFSpeed.NumericMode = true;
            this.tbxFSpeed.Originalstring = null;
            this.tbxFSpeed.Size = new System.Drawing.Size(45, 25);
            this.tbxFSpeed.TabIndex = 5;
            // 
            // tbxFDiaphragm
            // 
            this.tbxFDiaphragm.Enable = true;
            this.tbxFDiaphragm.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxFDiaphragm.isModified = false;
            this.tbxFDiaphragm.isValidated = false;
            this.tbxFDiaphragm.Location = new System.Drawing.Point(245, 388);
            this.tbxFDiaphragm.Name = "tbxFDiaphragm";
            this.tbxFDiaphragm.NumericMode = true;
            this.tbxFDiaphragm.Originalstring = null;
            this.tbxFDiaphragm.Size = new System.Drawing.Size(45, 25);
            this.tbxFDiaphragm.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(132, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "1/";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(132, 391);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "1/";
            // 
            // pbxO
            // 
            this.pbxO.BackColor = System.Drawing.Color.White;
            this.pbxO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxO.Location = new System.Drawing.Point(418, 230);
            this.pbxO.Name = "pbxO";
            this.pbxO.Size = new System.Drawing.Size(120, 90);
            this.pbxO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxO.TabIndex = 22;
            this.pbxO.TabStop = false;
            this.pbxO.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.pbxO.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            // 
            // pbxF
            // 
            this.pbxF.BackColor = System.Drawing.Color.White;
            this.pbxF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxF.Location = new System.Drawing.Point(432, 336);
            this.pbxF.Name = "pbxF";
            this.pbxF.Size = new System.Drawing.Size(90, 120);
            this.pbxF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxF.TabIndex = 23;
            this.pbxF.TabStop = false;
            this.pbxF.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.pbxF.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(331, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 18);
            this.label14.TabIndex = 24;
            this.label14.Text = "ISO感度 *";
            // 
            // tbxOIso
            // 
            this.tbxOIso.Enable = true;
            this.tbxOIso.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxOIso.isModified = false;
            this.tbxOIso.isValidated = false;
            this.tbxOIso.Location = new System.Drawing.Point(337, 258);
            this.tbxOIso.Name = "tbxOIso";
            this.tbxOIso.NumericMode = true;
            this.tbxOIso.Originalstring = null;
            this.tbxOIso.Size = new System.Drawing.Size(45, 25);
            this.tbxOIso.TabIndex = 4;
            // 
            // tbxFIso
            // 
            this.tbxFIso.Enable = true;
            this.tbxFIso.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxFIso.isModified = false;
            this.tbxFIso.isValidated = false;
            this.tbxFIso.Location = new System.Drawing.Point(337, 388);
            this.tbxFIso.Name = "tbxFIso";
            this.tbxFIso.NumericMode = true;
            this.tbxFIso.Originalstring = null;
            this.tbxFIso.Size = new System.Drawing.Size(45, 25);
            this.tbxFIso.TabIndex = 7;
            // 
            // buttonLink1
            // 
            this.buttonLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLink1.Location = new System.Drawing.Point(811, 80);
            this.buttonLink1.Name = "buttonLink1";
            this.buttonLink1.ParentControl = this.tbxFolderPhotoWorking;
            this.buttonLink1.Size = new System.Drawing.Size(33, 26);
            this.buttonLink1.TabIndex = 25;
            this.buttonLink1.Text = "...";
            this.buttonLink1.UseVisualStyleBackColor = true;
            this.buttonLink1.Click += new System.EventHandler(this.fbdOpen);
            // 
            // buttonLink2
            // 
            this.buttonLink2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLink2.Location = new System.Drawing.Point(811, 130);
            this.buttonLink2.Name = "buttonLink2";
            this.buttonLink2.ParentControl = this.tbxFolderPhoto;
            this.buttonLink2.Size = new System.Drawing.Size(33, 25);
            this.buttonLink2.TabIndex = 26;
            this.buttonLink2.Text = "...";
            this.buttonLink2.UseVisualStyleBackColor = true;
            this.buttonLink2.Click += new System.EventHandler(this.fbdOpen);
            // 
            // frmSettingPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(856, 509);
            this.Controls.Add(this.buttonLink2);
            this.Controls.Add(this.buttonLink1);
            this.Controls.Add(this.tbxFIso);
            this.Controls.Add(this.tbxOIso);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pbxF);
            this.Controls.Add(this.pbxO);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxFDiaphragm);
            this.Controls.Add(this.tbxFSpeed);
            this.Controls.Add(this.tbxODiaphragm);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxOSpeed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxFolderPhoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxFolderPhotoWorking);
            this.Controls.Add(this.label2);
            this.Name = "frmSettingPhoto";
            this.Title = "写真およびレントゲンの設定";
            this.Load += new System.EventHandler(this.frmSettingPhoto_Load);
            this.Shown += new System.EventHandler(this.frmSettingPhoto_Shown);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbxFolderPhotoWorking, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbxFolderPhoto, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.tbxOSpeed, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.tbxODiaphragm, 0);
            this.Controls.SetChildIndex(this.tbxFSpeed, 0);
            this.Controls.SetChildIndex(this.tbxFDiaphragm, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.pbxO, 0);
            this.Controls.SetChildIndex(this.pbxF, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.tbxOIso, 0);
            this.Controls.SetChildIndex(this.tbxFIso, 0);
            this.Controls.SetChildIndex(this.buttonLink1, 0);
            this.Controls.SetChildIndex(this.buttonLink2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbxO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxFolderPhotoWorking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxFolderPhoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxOSpeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxODiaphragm;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxFSpeed;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxFDiaphragm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbxO;
        private System.Windows.Forms.PictureBox pbxF;
        private System.Windows.Forms.Label label14;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxOIso;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxFIso;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private WindowsFormControlsLibrary.ButtonLink buttonLink1;
        private WindowsFormControlsLibrary.ButtonLink buttonLink2;
    }
}
