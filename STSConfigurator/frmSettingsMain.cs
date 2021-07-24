using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace STSConfigurator
{
    public partial class frmSettingsMain : Form
    {
        public const string CONFIG_DB_NAME = "● データベース接続および初期設定";
        private TreeNode currentNode = null;
        private bool isFirstTime = true;
        private TreeNodeEx tnRoot;// = new TreeNodeEx("設定");
        private frmSettingBase formTarget { get { return ((TreeNodeEx)currentNode).FormSetting; } }
        public frmSettingsMain()
        {
            InitializeComponent();
        }
        private void SettingMain_Load(object sender, EventArgs e)
        {

            tnRoot = new TreeNodeEx(new frmSettingBase("設定", true));
                TreeNodeEx tn1 = new TreeNodeEx(new frmSettingDatabase(this, CONFIG_DB_NAME));
                tnRoot.Nodes.Add(tn1);
            TreeNodeEx tn2 = new TreeNodeEx(new frmSettingBase("院内共通設定", true));
            tnRoot.Nodes.Add(tn2);
                TreeNodeEx tn21 = new TreeNodeEx(new frmSettingClinic(this, "● 医院情報"));
                tn2.Nodes.Add(tn21);
                TreeNodeEx tn22 = new TreeNodeEx(new frmSettingPhoto(this, "● 写真及びレントゲンの設定"));
                tn2.Nodes.Add(tn22);
            TreeNodeEx tn3 = new TreeNodeEx(new frmSettingBase("各デバイスごとの設定", true));
            tnRoot.Nodes.Add(tn3);
            //TreeNodeEx tn0 = new TreeNodeEx(new frmSettingDatabase(this));
            //tnRoot.Nodes.Add(tn0);
            //TreeNodeEx tn1 = new TreeNodeEx("共通設定");
            //tnRoot.Nodes.Add(tn1);
            //TreeNodeEx tn2 = new TreeNodeEx("個別設定");
            //tnRoot.Nodes.Add(tn2);
            //TreeNodeEx tn11 = new TreeNodeEx(new frmSettingClinic(this));
            //tn1.Nodes.Add(tn11);
            //tnRoot.Nodes.Add(new TreeNodeEx(new frmSettingDatabase()));
            //tnRoot.Nodes.Add(tn);


            //tnRoot.Nodes.Add(new TreeNodeEx(new SetConnectDB("データベース接続", new frmConnectDB())));
            //tnRoot.Nodes.Add(new TreeNodeEx(new SetPostalCode("郵便番号設定", new frmPostalCode())));
            //tnRoot.Nodes.Add(new TreeNodeEx(new SetDirectries("フォルダーの設定", new frmDirectories())));
            //tnRoot.Nodes.Add(new TreeNodeEx(new SetCamera("カメラの設定", new frmCamera())));
            //tnRoot.Nodes.Add(new TreeNodeEx(new SetPrinters("プリンターの設定", new frmPrinters())));
            //tnRoot.Nodes.Add(new TreeNodeEx(new SetOrganizerMain("OrganizerMain", new frmOrganizer())));
            //tnRoot.Nodes[4].Nodes.Add(new TreeNodeEx(new SetOrganizerTepra("テプラの設定", new frmOrganizerTepra())));

            //tnRoot.Nodes.Add(new TreeNodeEx("カルテ"));
            //tnRoot.Nodes["カルテ"].Nodes.Add(new TreeNodeEx(new SetCartePhotoOrder("写真の登録順", new frmCartePhotoOrder())));

            tv.Nodes.Add(tnRoot);
            tnRoot.ExpandAll();
            checkInitialSetting();
        }
        private void checkInitialSetting()
        {
            if (!File.Exists(frmSettingBase.FilePath + CONFIG_DB_NAME + ".config"))
            {
                List<TreeNode> tns = getChildNodes(tnRoot);
                foreach (TreeNode tn in tns)
                {
                    tn.ForeColor = SystemColors.GrayText;
                }
                tns.Find(tn => tn.Name == CONFIG_DB_NAME).ForeColor = SystemColors.WindowText;
            }
            else isFirstTime = false;

            List<TreeNode> getChildNodes(TreeNode parent)   //再帰処理
            {
                var treeNodes = new List<TreeNode>();
                foreach (TreeNode tn in parent.Nodes)
                {
                    treeNodes.Add(tn);
                    treeNodes.AddRange(getChildNodes(tn));
                }
                return treeNodes;
            }
        }
        public void ModifiedChanged(string treeNodeName, bool isModified)
        {
            btnConfirm.Enabled = isModified && formTarget.IsValidated;
            btnReturnToOriginal.Enabled = isModified;
            FindTreeNode(treeNodeName).Bold = isModified;
        }
        private void btnReturnToOriginal_Click(object sender, EventArgs e)
        {
            formTarget.ResumeToOrigin();
        }
        private void tv_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (isFirstTime) //データベース接続ファイルが作成されていない場合
            {
                foreach (var tn in tnRoot.Nodes.OfType<TreeNodeEx>())
                {
                    if (e.Node.Name != CONFIG_DB_NAME)
                    {
                        e.Cancel = true;
                        tv.SelectedNode = currentNode;
                        return;
                    }
                }
            }
            if (currentNode != null)
            {
                var node = tnRoot.Nodes.Find(e.Node.Name, true);

                if (formTarget.FormModified)                                  //変更があるなら
                {
                    DialogResult dr = MessageBox.Show("保存しますか？", "設定が変更されていますが...", MessageBoxButtons.YesNoCancel);
                    switch (dr)
                    {
                        case DialogResult.Yes: btnConfirm_Click(null, null); break;
                        case DialogResult.No: formTarget.ResumeToOrigin(); break;
                        case DialogResult.Cancel: e.Cancel = true; break;
                    }
                    return;
                }
                
                if (node.Count<TreeNode>() == 0)                            //tnRootなら
                {
                    e.Cancel = true;
                    return;
                }
                else if (((TreeNodeEx)node[0]).FormSetting.HeadingForm)     //見出しの場合
                {
                    tv.SelectedNode = node[0].NextNode;
                }
            }
        }
        
        private void Tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pnl.Controls.Clear();
            currentNode = e.Node;
            if (((TreeNodeEx)e.Node).FormSetting != null)
            {
                frmSettingBase form = adjustFormSize((frmSettingBase)((TreeNodeEx)e.Node).FormSetting);
                pnl.Controls.Add(form);
                form.Show();
            }
        }
        private frmSettingBase adjustFormSize(frmSettingBase f)
        {
            f.Size = new Size(pnl.Width, pnl.Height);
            return f;
        }
        private TreeNodeEx FindTreeNode(string treeNodeName)
        {
            TreeNode[] ns = tnRoot.Nodes.Find(treeNodeName, true);
            if (ns.Count<TreeNode>() > 0)
                return ns[0] as TreeNodeEx;
            else
                return null;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            formTarget.AcceptData();
            formTarget.SetOrigin();
            if (formTarget.SaveModeXML)
                formTarget.SaveToXmlFile(formTarget);
            else
                formTarget.SaveToDatabase(formTarget.ClassSaveData);
            formTarget.FormModified = false;
        }
        private void pnl_SizeChanged(object sender, EventArgs e)
        {
            if(pnl.Controls.OfType<frmSettingBase>().Count<frmSettingBase>() >0)
            {
                frmSettingBase frm = adjustFormSize(pnl.Controls.OfType<frmSettingBase>().First<frmSettingBase>());
                frm.Show();
            }
        }

    }
}
