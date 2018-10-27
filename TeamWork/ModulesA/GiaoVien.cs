using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModulesA
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
            DataProvider.GIAOVIEN gv = new DataProvider.GIAOVIEN();

            dataGridView1.DataSource = gv.SelectAll();
        }
    }
}
