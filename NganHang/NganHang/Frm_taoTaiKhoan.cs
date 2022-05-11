using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang
{
    public partial class Frm_taoTaiKhoan : Form
    {
        public Frm_taoTaiKhoan()
        {
            InitializeComponent();
        }

        private void Frm_taoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPHANMANH.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPHANMANH.V_DS_PHANMANH);

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
