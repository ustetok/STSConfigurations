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
        private TreeNodeEx tnRoot = new TreeNodeEx("設定");
        public frmSettingsMain()
        {
            InitializeComponent();
        }
        private void SettingMain_Load(object sender, EventArgs e)
        {
            TreeNodeEx tn = new TreeNodeEx(new frmSettingDatabase(this));
            //tnRoot.Nodes.Add(new TreeNodeEx(new frmSettingDatabase()));
            tnRoot.Nodes.Add(tn);


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
            tnRoot.Expand();
        }
        private void frmSettingsMain_Shown(object sender, EventArgs e)
        {
            

        }
        public void ChangeTreeNodeBold(string treeNodeName, bool isBold)
        {
            FindTreeNode(treeNodeName).Bold = isBold;
        }
        private void Tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pnl.Controls.Clear();
            if (((TreeNodeEx)e.Node).FormSetting != null)
            {
                pnl.Controls.Add((frmSettingBase)((TreeNodeEx)e.Node).FormSetting);
                ((frmSettingBase)((TreeNodeEx)e.Node).FormSetting).Show();
            }
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
                fsb.SaveToXmlFile(fsb);
            }
        }

    }
}
