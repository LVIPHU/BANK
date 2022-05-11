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
    public partial class Frm_lietKeTaiKhoan : Form
    {
        string cn;
        public Frm_lietKeTaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            string ngay1, ngay2;
            ngay1 = date_BD.Text;
            ngay2 = date_KT.Text;

            rptDSTaiKhoan rp = new rptDSTaiKhoan(ngay1, ngay2,cn);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();

        }

        private void Frm_lietKeTaiKhoan_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dS_DSPHANMANH.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            cmb_maCN.DataSource = Program.bds_dspm;
            cmb_maCN.DisplayMember = "TENCN";
            cmb_maCN.ValueMember = "TENSERVER";
            cmb_maCN.SelectedIndex = Program.mCoso;

        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_maCN.SelectedValue.ToString().Contains("SERVER1"))
            {
                cn = "BENTHANH";
            }
            else
            {
                cn = "TANDINH";
            }
        }
    }
}
