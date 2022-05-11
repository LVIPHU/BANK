using DevExpress.XtraEditors;
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
    public partial class Frm_chuyenChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        public Frm_chuyenChiNhanh()
        {
            InitializeComponent();
        }

        private void Frm_chuyenCN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPHANMANH.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPHANMANH.V_DS_PHANMANH);

        }
    }
}