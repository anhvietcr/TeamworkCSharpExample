using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnOpenFrmGV_Click(object sender, EventArgs e)
        {
            frmGiaoVien frm = new frmGiaoVien();
            frm.ShowDialog();
        }

        private void btnOpenFrmHV_Click(object sender, EventArgs e)
        {
            frmHocVien frm = new frmHocVien();
            frm.ShowDialog();
        }
    }
}
