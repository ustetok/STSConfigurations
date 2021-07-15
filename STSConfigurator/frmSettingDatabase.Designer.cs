
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // frmSettingDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 682);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowsFormControlsLibrary.ComboBoxModified cbxMServer;
        private WindowsFormControlsLibrary.ComboBoxModified cbxMDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}