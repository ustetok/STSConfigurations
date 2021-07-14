
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
            this.cbxServer = new System.Windows.Forms.ComboBox();
            this.cbxDatabase = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(8, 6);
            this.lblTitle.Text = "データベース接続";
            // 
            // cbxServer
            // 
            this.cbxServer.FormattingEnabled = true;
            this.cbxServer.Location = new System.Drawing.Point(29, 98);
            this.cbxServer.Name = "cbxServer";
            this.cbxServer.Size = new System.Drawing.Size(279, 26);
            this.cbxServer.TabIndex = 2;
            this.cbxServer.DropDown += new System.EventHandler(this.cbxServer_DropDown);
            // 
            // cbxDatabase
            // 
            this.cbxDatabase.FormattingEnabled = true;
            this.cbxDatabase.Location = new System.Drawing.Point(29, 203);
            this.cbxDatabase.Name = "cbxDatabase";
            this.cbxDatabase.Size = new System.Drawing.Size(279, 26);
            this.cbxDatabase.TabIndex = 3;
            this.cbxDatabase.DropDown += new System.EventHandler(this.cbxDatabase_DropDown);
            // 
            // frmSettingDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 682);
            this.Controls.Add(this.cbxDatabase);
            this.Controls.Add(this.cbxServer);
            this.Name = "frmSettingDatabase";
            this.Text = "frmSettingDatabase";
            this.Title = "データベース接続";
            this.Load += new System.EventHandler(this.frmSettingDatabase_Load);
            this.Shown += new System.EventHandler(this.frmSettingDatabase_Shown);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.cbxServer, 0);
            this.Controls.SetChildIndex(this.cbxDatabase, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxServer;
        private System.Windows.Forms.ComboBox cbxDatabase;
    }
}