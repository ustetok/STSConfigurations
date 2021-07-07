using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileWatcher
{
    public partial class frmMain : Form
    {
        private bool settingChangedFlag = false;
        private FileAttribute FATarget, FAOpponent;
        public frmMain()
        {
            InitializeComponent();

            tbxPathTarget.Text = Properties.Settings.Default.TargetFile;
            tbxPathOpponent.Text = Properties.Settings.Default.OpponentFile;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (settingChangedFlag && pnlV.isValidated) //変更がありすべて埋められているなら保存する
            {
                Properties.Settings.Default.TargetFile =  tbxPathTarget.Text;
                //Properties.Settings.Default.WatchInterval = Convert.ToInt32(nudTime.Value);
                Properties.Settings.Default.OpponentFile = tbxPathOpponent.Text;
                Properties.Settings.Default.Save();
            }
        }
        private void pnlV_Validation(WindowsFormControlsLibrary.IktsValidation obj)
        {
            btnVerify.Enabled = pnlV.isValidated;
        }
        private void btnVerify_Click(object sender, EventArgs e)
        {
            string msg = "";
            FATarget = new FileAttribute(tbxPathTarget.Text);
            FAOpponent = new FileAttribute(tbxPathOpponent.Text);

            if (FATarget.Error) msg += "手元のファイルが存在しないか拡張子の異常が見られます\r\n";
            if (FAOpponent.Error) msg += "相手ファイルが存在しないか拡張子の異常が見られます\r\n";
            if (FATarget.Extension != FAOpponent.Extension) msg += "双方の拡張子が異なります\r\n";
            if (msg == "")
            {
                msg = "それぞれのファイルに異常はありません\r\n";
                if (FATarget.LastWriteTime == FAOpponent.LastWriteTime)
                {
                    msg += "が、最終更新日が同じです";
                }
                else if (FATarget.FileName != FAOpponent.FileName)
                {
                    msg += "が、双方のファイル名が異なります";
                }
                else
                {
                    msg += "手元のファイルの最終更新日は　\t\t" + FATarget.LastWriteTime.ToString() + "\r\n";
                    msg += "相手ファイルの最終更新日は　　\t\t" + FAOpponent.LastWriteTime.ToString() + "\r\n";

                    btnSynchronize.Enabled = true;
                }
            }
            lblReport.Text = msg;
        }
        private void btnsBrows_Click(object sender, EventArgs e)
        {
            TextBox tb;
            if (((Button)sender) == btnBrowseTarget)
                tb = tbxPathTarget;
            else
                tb = tbxPathOpponent;
            if (Directory.Exists(tb.Text))
            {
                ofd.InitialDirectory = Path.GetDirectoryName(tb.Text);
            }
            else
            {
                ofd.InitialDirectory = "c:\\";
            }
            if(ofd.ShowDialog()== DialogResult.OK)
            {
                tb.Text = ofd.FileName;
            }

        }
        private void tbxs_TextChanged(object sender, EventArgs e)
        {
            btnSynchronize.Enabled = false;
            settingChangedFlag = true;
        }

        private void btnSynchronize_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("最新のファイルをコピーしますか？", "確認", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                string targetPath = FATarget.LastWriteTime > FAOpponent.LastWriteTime ? tbxPathTarget.Text : tbxPathOpponent.Text;
                string movetoPath = FATarget.LastWriteTime < FAOpponent.LastWriteTime ? tbxPathTarget.Text : tbxPathOpponent.Text;
                try
                {
                    File.Copy(targetPath, movetoPath, true);
                }
                catch(Exception ee)
                {
                    MessageBox.Show(ee.Message, "ERROR");
                }
                finally
                {
                    MessageBox.Show("プログラムを終了します", "コピー完了しました");
                    Application.Exit();
                }
            }
        }
    }
    public class FileAttribute
    {
        public bool Error { get; set; } = false;
        public bool Exist { get; set; }             //存在しない場合 false
        public string FileName { get; set; }
        public string Extension { get; set; }       //存在しない場合 ""
        public DateTime LastWriteTime { get; set; }
        public FileAttribute(string fileName)
        {
            Exist = File.Exists(fileName);
            FileName = Path.GetFileName(fileName);
            Extension = Path.GetExtension(fileName);
            LastWriteTime = File.GetLastWriteTime(fileName);

            if (!Exist || Extension == "") Error = true;
        }
    }
}
