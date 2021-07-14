
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
            this.cbxMServer = new WindowsFormControlsLibrary.ComboBoxModified();
            this.cbxMDatabase = new WindowsFormControlsLibrary.ComboBoxModified();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(8, 6);
            this.lblTitle.Text = "データベース接続";
            // 
            // cbxMServer
            // 
            this.cbxMServer.FormattingEnabled = true;
            this.cbxMServer.Location = new System.Drawing.Point(29, 140);
            this.cbxMServer.Name = "cbxMServer";
            this.cbxMServer.Original = null;
            this.cbxMServer.Size = new System.Drawing.Size(279, 26);
            this.cbxMServer.TabIndex = 4;
            this.cbxMServer.DropDown += new System.EventHandler(this.cbxServer_DropDown);
            // 
            // cbxMDatabase
            // 
            this.cbxMDatabase.FormattingEnabled = true;
            this.cbxMDatabase.Location = new System.Drawing.Point(29, 247);
            this.cbxMDatabase.Name = "cbxMDatabase";
            this.cbxMDatabase.Original = null;
            this.cbxMDatabase.Size = new System.Drawing.Size(279, 26);
            this.cbxMDatabase.TabIndex = 5;
            this.cbxMDatabase.DropDown += new System.EventHandler(this.cbxDatabase_DropDown);
            // 
            // frmSettingDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 682);
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
            this.ResumeLayout(false);

        }

        #endregion
        private WindowsFormControlsLibrary.ComboBoxModified cbxMServer;
        private WindowsFormControlsLibrary.ComboBoxModified cbxMDatabase;
    }
}