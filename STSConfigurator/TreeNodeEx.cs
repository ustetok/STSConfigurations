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
    [Serializable()]
    public partial class TreeNodeEx : TreeNode
    {
        public frmSettingBase FormSetting { get; set; }
        public bool Bold
        {
            get { return this.NodeFont.Bold; }
            set
            {
                Font font = this.NodeFont;
                Font newFont = new Font(font.FontFamily, font.Size, value ? FontStyle.Bold : FontStyle.Regular);
                this.NodeFont = newFont;
            }
        }
        public TreeNodeEx(string txt) : base(txt)
        {
            FormSetting = null;
            this.Name = txt;

            Font f = new Font("メイリオ", 9.0f);
            this.NodeFont = f;
        }
        public TreeNodeEx(frmSettingBase b) : base(b.Title)
        {
            FormSetting = b;
            this.Name = b.lblTitle.Text;

            Font f = new Font("メイリオ", 9.0f);
            this.NodeFont = f;
        }
    }
}
