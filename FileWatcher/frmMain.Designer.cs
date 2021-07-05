
namespace FileWatcher
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlV = new WindowsFormControlsLibrary.PanelValidation();
            this.tbxPathTarget = new WindowsFormControlsLibrary.TextBoxFWatermark();
            this.tbxPathOpponent = new WindowsFormControlsLibrary.TextBoxFWatermark();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseTarget = new System.Windows.Forms.Button();
            this.btnBrowseOpponent = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlV.SuspendLayout();
            this.cmsMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlV
            // 
            this.pnlV.Controls.Add(this.btnBrowseOpponent);
            this.pnlV.Controls.Add(this.btnBrowseTarget);
            this.pnlV.Controls.Add(this.label2);
            this.pnlV.Controls.Add(this.label1);
            this.pnlV.Controls.Add(this.tbxPathOpponent);
            this.pnlV.Controls.Add(this.tbxPathTarget);
            this.pnlV.isValidated = false;
            this.pnlV.Location = new System.Drawing.Point(12, 13);
            this.pnlV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlV.Name = "pnlV";
            this.pnlV.Size = new System.Drawing.Size(586, 228);
            this.pnlV.TabIndex = 0;
            // 
            // tbxPathTarget
            // 
            this.tbxPathTarget.CueBannerText = "ファイルのパスを入力してください";
            this.tbxPathTarget.Location = new System.Drawing.Point(114, 39);
            this.tbxPathTarget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPathTarget.Name = "tbxPathTarget";
            this.tbxPathTarget.Size = new System.Drawing.Size(364, 23);
            this.tbxPathTarget.TabIndex = 0;
            // 
            // tbxPathOpponent
            // 
            this.tbxPathOpponent.CueBannerText = "ファイルのパスを入力してください";
            this.tbxPathOpponent.Location = new System.Drawing.Point(114, 103);
            this.tbxPathOpponent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPathOpponent.Name = "tbxPathOpponent";
            this.tbxPathOpponent.Size = new System.Drawing.Size(364, 23);
            this.tbxPathOpponent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "移動先のファイル";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "監視するファイル";
            // 
            // btnBrowseTarget
            // 
            this.btnBrowseTarget.Location = new System.Drawing.Point(484, 39);
            this.btnBrowseTarget.Name = "btnBrowseTarget";
            this.btnBrowseTarget.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseTarget.TabIndex = 9;
            this.btnBrowseTarget.Text = "...";
            this.btnBrowseTarget.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseTarget.UseVisualStyleBackColor = true;
            // 
            // btnBrowseOpponent
            // 
            this.btnBrowseOpponent.Location = new System.Drawing.Point(484, 103);
            this.btnBrowseOpponent.Name = "btnBrowseOpponent";
            this.btnBrowseOpponent.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseOpponent.TabIndex = 10;
            this.btnBrowseOpponent.Text = "...";
            this.btnBrowseOpponent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseOpponent.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cmsMainMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // cmsMainMenu
            // 
            this.cmsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiQuit});
            this.cmsMainMenu.Name = "cmsMainMenu";
            this.cmsMainMenu.Size = new System.Drawing.Size(116, 48);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(115, 22);
            this.tsmiOpen.Text = "開く(&O)";
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(115, 22);
            this.tsmiQuit.Text = "終了(&Q)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 429);
            this.Controls.Add(this.pnlV);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlV.ResumeLayout(false);
            this.pnlV.PerformLayout();
            this.cmsMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormControlsLibrary.PanelValidation pnlV;
        private System.Windows.Forms.Button btnBrowseOpponent;
        private System.Windows.Forms.Button btnBrowseTarget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private WindowsFormControlsLibrary.TextBoxFWatermark tbxPathOpponent;
        private WindowsFormControlsLibrary.TextBoxFWatermark tbxPathTarget;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cmsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
    }
}

