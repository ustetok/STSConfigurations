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
        private TreeNode currentNode = null;
        private TreeNodeEx tnRoot = new TreeNodeEx("設定");
        public frmSettingsMain()
        {
            InitializeComponent();
        }
        private void SettingMain_Load(object sender, EventArgs e)
        {
            TreeNodeEx tn0 = new TreeNodeEx(new frmSettingDatabase(this));
            tnRoot.Nodes.Add(tn0);
            TreeNodeEx tn1 = new TreeNodeEx("共通設定");
            tnRoot.Nodes.Add(tn1);
            TreeNodeEx tn2 = new TreeNodeEx("個別設定");
            tnRoot.Nodes.Add(tn2);
            TreeNodeEx tn11 = new TreeNodeEx(new frmSettingClinic(this));
            tn1.Nodes.Add(tn11);
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
        }
        public void ModifiedChanged(string treeNodeName, bool isModified)
        {
            btnConfirm.Enabled = isModified;
            FindTreeNode(treeNodeName).Bold = isModified;
        }
        private void tv_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (currentNode != null)
            {
                frmSettingBase frm = ((TreeNodeEx)currentNode).FormSetting;
                if (frm != null && frm.FormModified)
                {
                    DialogResult dr = MessageBox.Show("保存しますか？", "設定が変更されていますが...", MessageBoxButtons.YesNoCancel);
                    switch (dr)
                    {
                        case DialogResult.Yes: btnConfirm_Click(null, null); break;
                        case DialogResult.No: frm.ResumeToOrigin(); break;
                        case DialogResult.Cancel:e.Cancel = true;break;
                    }
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
            if(pnl.Controls.Count>0)
            {
                var fsb = pnl.Controls[0] as frmSettingBase;
                fsb.AcceptData();
                fsb.SetOrigin();
                fsb.SaveToXmlFile(fsb);
                fsb.FormModified = false;
            }
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
