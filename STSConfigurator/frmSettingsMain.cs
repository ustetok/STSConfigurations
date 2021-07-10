using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STSConfigurator
{
    public partial class frmSettingsMain : Form
    {
        private readonly TreeNodeEx tnRoot = new TreeNodeEx(new frmSettingBase());
        public frmSettingsMain()
        {
            InitializeComponent();
        }
        private void SettingMain_Load(object sender, EventArgs e)
        {
            tnRoot.Nodes.Add(new TreeNodeEx(new frmSettingDatabase()));



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

        private void Tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pnl.Controls.Clear();
            if (((TreeNodeEx)e.Node).FormSetting != null)
            {
                pnl.Controls.Add((frmSettingBase)((TreeNodeEx)e.Node).FormSetting);
                ((frmSettingBase)((TreeNodeEx)e.Node).FormSetting).Show();
                ((frmSettingBase)((TreeNodeEx)e.Node).FormSetting).lblTitle.Text = ((TreeNodeEx)e.Node).Text;
            }

        }
    }
}
