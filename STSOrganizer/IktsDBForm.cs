using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STSOrganizer
{
    public interface IktsDBForm
    {
        string ConnectingString { get; }
        bool AllowSaveSetting { get; set; }
        void Form_Load(object sender, EventArgs e);
        void Form_Closed(object sender, FormClosedEventArgs e);
    }
}
