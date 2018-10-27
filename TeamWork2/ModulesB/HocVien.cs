using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModulesB
{
    public partial class frmHocVien : Form
    {
        public frmHocVien()
        {
            InitializeComponent();
            DataProvider.HOCVIEN hv = new DataProvider.HOCVIEN();

            dataGridView1.DataSource = hv.SelectAll();

        }
    }
}
