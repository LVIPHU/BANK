using DevExpress.XtraReports.UI;
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
    public partial class Frm_lietKeKhachHang : Form
    {
        string cn;
        public Frm_lietKeKhachHang()
        {
            InitializeComponent();

        }

        private void Frm_lietKeKhachHang_Load(object sender, EventArgs e)
        {
            cmb_chiNhanh.DataSource = Program.bds_dspm;
            cmb_chiNhanh.DisplayMember = "TENCN";
            cmb_chiNhanh.ValueMember = "TENSERVER";
            cmb_chiNhanh.SelectedIndex = Program.mCoso;
            if (Program.mGroup.Equals("CHINHANH"))
            {
                cmb_chiNhanh.Enabled = false;
            }
            else
            {
                cmb_chiNhanh.Enabled = true;
            }
        }

        private void cmb_chiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_chiNhanh.SelectedValue.ToString().Contains("SERVER1"))
            {
                cn = "BENTHANH";
            } else {
                cn = "TANDINH";
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            rptDSKhachHang rp = new rptDSKhachHang(cn);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }
    }
}
