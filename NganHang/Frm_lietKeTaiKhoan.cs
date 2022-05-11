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

            if (ngay1.Length == 0 || ngay2.Length == 0)
            {
                MessageBox.Show("Không được để trống ngày chọn liệt kê\n Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parsedDate1 = DateTime.Parse(ngay1);
            var parsedDate2 = DateTime.Parse(ngay2);

            int result = DateTime.Compare(parsedDate1, parsedDate2);

            if (result > 0)
            {
                MessageBox.Show("Ngày không hợp lệ!\n Vui lòng chọn lại ngày!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            rptDSTaiKhoan rp = new rptDSTaiKhoan(cn, ngay1, ngay2);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void Frm_lietKeTaiKhoan_Load(object sender, EventArgs e)
        {
            cmb_maCN.DataSource = Program.bds_dspm;
            cmb_maCN.DisplayMember = "TENCN";
            cmb_maCN.ValueMember = "TENSERVER";
            cmb_maCN.SelectedIndex = Program.mCoso;
            if (cmb_maCN.SelectedValue.ToString().Contains("SERVER1"))
            {
                cn = "BENTHANH";
            }
            else
            {
                cn = "TANDINH";
            }
        }

        private void cmb_maCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_maCN.SelectedValue.ToString().Contains("SERVER1"))
            {
                cn = "BENTHANH";
            } else {
                cn = "TANDINH";
            }
        }

        /* Event cho TextEdit  */

        private void lbl_BD_Click(object sender, EventArgs e)
        {
            if (lbl_BD.Location.Y == 100)
            {
                lbl_BD.Font = new Font("Segoe UI", 8);
                lbl_BD.Cursor = Cursors.Arrow;
                lbl_BD.Location = new Point(lbl_BD.Location.X, lbl_BD.Location.Y - 25);
                date_BD.Focus();
            }
        }

        private void text_BD_Enter(object sender, EventArgs e)
        {
            pnl_BD.BackColor = Color.Blue;
            lbl_BD.ForeColor = Color.Blue;
            if (lbl_BD.Location.Y != 75)
            {
                lbl_BD.Font = new Font("Segoe UI", 8);
                lbl_BD.Cursor = Cursors.Arrow;
                lbl_BD.Location = new Point(lbl_BD.Location.X, lbl_BD.Location.Y - 25);
            }
        }

        private void text_BD_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(date_BD.Text) && lbl_BD.Location.Y == 75)
            {
                date_BD.ResetText();
                pnl_BD.BackColor = Color.Black;
                lbl_BD.ForeColor = Color.Black;
                lbl_BD.Font = new Font("Segoe UI", 9);
                lbl_BD.Cursor = Cursors.IBeam;
                lbl_BD.Location = new Point(lbl_BD.Location.X, lbl_BD.Location.Y + 25);
            }
        }

        /* Event cho TextEdit số tài khoản nhập */

        private void lbl_KT_Click(object sender, EventArgs e)
        {
            if (lbl_KT.Location.Y == 200)
            {
                lbl_KT.Font = new Font("Segoe UI", 8);
                lbl_KT.Cursor = Cursors.Arrow;
                lbl_KT.Location = new Point(lbl_KT.Location.X, lbl_KT.Location.Y - 25);
                date_KT.Focus();
            }
        }

        private void text_KT_Enter(object sender, EventArgs e)
        {
            pnl_KT.BackColor = Color.Blue;
            lbl_KT.ForeColor = Color.Blue;
            if (lbl_KT.Location.Y != 175)
            {
                lbl_KT.Font = new Font("Segoe UI", 8);
                lbl_KT.Cursor = Cursors.Arrow;
                lbl_KT.Location = new Point(lbl_KT.Location.X, lbl_KT.Location.Y - 25);
            }
        }

        private void text_KT_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(date_KT.Text) && lbl_KT.Location.Y == 175)
            {
                pnl_KT.BackColor = Color.Black;
                lbl_KT.ForeColor = Color.Black;
                date_KT.ResetText();
                lbl_KT.Font = new Font("Segoe UI", 9);
                lbl_KT.Cursor = Cursors.IBeam;
                lbl_KT.Location = new Point(lbl_KT.Location.X, lbl_KT.Location.Y + 25);
            }
        }

 
    }
}
