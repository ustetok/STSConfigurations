﻿
namespace STSConfigurator
{
    partial class frmSettingsMain
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
            this.pnl = new System.Windows.Forms.Panel();
            this.tv = new System.Windows.Forms.TreeView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReturnToOriginal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl.Location = new System.Drawing.Point(269, 12);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(566, 505);
            this.pnl.TabIndex = 1;
            this.pnl.SizeChanged += new System.EventHandler(this.pnl_SizeChanged);
            // 
            // tv
            // 
            this.tv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tv.Location = new System.Drawing.Point(12, 12);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(251, 546);
            this.tv.TabIndex = 2;
            this.tv.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tv_BeforeSelect);
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tv_AfterSelect);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(709, 533);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(126, 25);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "O K";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReturnToOriginal
            // 
            this.btnReturnToOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToOriginal.Enabled = false;
            this.btnReturnToOriginal.Location = new System.Drawing.Point(500, 533);
            this.btnReturnToOriginal.Name = "btnReturnToOriginal";
            this.btnReturnToOriginal.Size = new System.Drawing.Size(91, 24);
            this.btnReturnToOriginal.TabIndex = 4;
            this.btnReturnToOriginal.Text = "変更前に戻す";
            this.btnReturnToOriginal.UseVisualStyleBackColor = true;
            this.btnReturnToOriginal.Click += new System.EventHandler(this.btnReturnToOriginal_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "* 必須項目";
            // 
            // frmSettingsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnToOriginal);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.pnl);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettingsMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SettingMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.Button btnReturnToOriginal;
        public System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
    }
}

