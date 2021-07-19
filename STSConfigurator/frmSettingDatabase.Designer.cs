
namespace STSConfigurator
{
    partial class frmSettingDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbxMServer = new WindowsFormControlsLibrary.ComboBoxModified();
            this.cbxMDatabase = new WindowsFormControlsLibrary.ComboBoxModified();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDirectoryWorking = new WindowsFormControlsLibrary.TextBoxFWValidation();
            this.cmsFolderWorkingDefault = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.FBDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cmsFolderWorkingDefault.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(8, 6);
            this.lblTitle.Size = new System.Drawing.Size(1186, 26);
            this.lblTitle.Text = "データベース接続";
            // 
            // cbxMServer
            // 
            this.cbxMServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMServer.FormattingEnabled = true;
            this.cbxMServer.Location = new System.Drawing.Point(29, 112);
            this.cbxMServer.Name = "cbxMServer";
            this.cbxMServer.Original = null;
            this.cbxMServer.Size = new System.Drawing.Size(765, 26);
            this.cbxMServer.TabIndex = 4;
            this.cbxMServer.DropDown += new System.EventHandler(this.cbxServer_DropDown);
            // 
            // cbxMDatabase
            // 
            this.cbxMDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMDatabase.FormattingEnabled = true;
            this.cbxMDatabase.Location = new System.Drawing.Point(29, 178);
            this.cbxMDatabase.Name = "cbxMDatabase";
            this.cbxMDatabase.Original = null;
            this.cbxMDatabase.Size = new System.Drawing.Size(765, 26);
            this.cbxMDatabase.TabIndex = 5;
            this.cbxMDatabase.DropDown += new System.EventHandler(this.cbxDatabase_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "サーバー名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "データベース名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(33, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "データは各デバイスの設定ファイルに保存されます";
            // 
            // tbxDirectoryWorking
            // 
            this.tbxDirectoryWorking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDirectoryWorking.ContextMenuStrip = this.cmsFolderWorkingDefault;
            this.tbxDirectoryWorking.CueBannerText = "デフォルト推奨  右クリックでデフォルト値選択可能";
            this.tbxDirectoryWorking.Enable = true;
            this.tbxDirectoryWorking.isValidated = false;
            this.tbxDirectoryWorking.Location = new System.Drawing.Point(29, 286);
            this.tbxDirectoryWorking.Name = "tbxDirectoryWorking";
            this.tbxDirectoryWorking.Size = new System.Drawing.Size(723, 25);
            this.tbxDirectoryWorking.TabIndex = 9;
            this.tbxDirectoryWorking.Validating += new System.ComponentModel.CancelEventHandler(this.tbxDirectoryWorking_Validating);
            // 
            // cmsFolderWorkingDefault
            // 
            this.cmsFolderWorkingDefault.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDefault});
            this.cmsFolderWorkingDefault.Name = "cmsFolderWorkingDefault";
            this.cmsFolderWorkingDefault.Size = new System.Drawing.Size(161, 26);
            // 
            // tsmiDefault
            // 
            this.tsmiDefault.Name = "tsmiDefault";
            this.tsmiDefault.Size = new System.Drawing.Size(160, 22);
            this.tsmiDefault.Text = "デフォルト値に戻す";
            this.tsmiDefault.Click += new System.EventHandler(this.tsmiDefault_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(29, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(765, 2);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "作業フォルダー";
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDialog.Location = new System.Drawing.Point(758, 286);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(36, 25);
            this.btnOpenDialog.TabIndex = 12;
            this.btnOpenDialog.Text = "...";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // frmSettingDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 682);
            this.Controls.Add(this.btnOpenDialog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxDirectoryWorking);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxMDatabase);
            this.Controls.Add(this.cbxMServer);
            this.Name = "frmSettingDatabase";
            this.Text = "frmSettingDatabase";
            this.Title = "データベース接続";
            this.Load += new System.EventHandler(this.frmSettingDatabase_Load);
            this.Shown += new System.EventHandler(this.frmSettingDatabase_Shown);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.cbxMServer, 0);
            this.Controls.SetChildIndex(this.cbxMDatabase, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbxDirectoryWorking, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnOpenDialog, 0);
            this.cmsFolderWorkingDefault.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowsFormControlsLibrary.ComboBoxModified cbxMServer;
        private WindowsFormControlsLibrary.ComboBoxModified cbxMDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private WindowsFormControlsLibrary.TextBoxFWValidation tbxDirectoryWorking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.FolderBrowserDialog FBDialog;
        private System.Windows.Forms.ContextMenuStrip cmsFolderWorkingDefault;
        private System.Windows.Forms.ToolStripMenuItem tsmiDefault;
    }
}