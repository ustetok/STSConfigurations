using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'patients2DataSet.T_Patient' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.t_PatientTableAdapter.Fill(this.patients2DataSet.T_Patient);

        }
    }
}
