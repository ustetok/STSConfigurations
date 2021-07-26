using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STSOrganizer
{
    public partial class Form1 : formDB
    {
        public Form1()
        {
            InitializeComponent();
            AllowSaveSetting = true;
        }
    }
}
