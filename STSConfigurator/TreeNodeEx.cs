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
        public TreeNodeEx(string txt) : base(txt)
        {
            FormSetting = null;
            this.Name = txt;
        }
        public TreeNodeEx(frmSettingBase b) : base(b.Title)
        {
            FormSetting = b;
        }
    }
}
