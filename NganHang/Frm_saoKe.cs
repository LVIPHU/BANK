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
    public partial class Frm_saoKe : Form
    {
        public Frm_saoKe()
        {
            InitializeComponent();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            string ngay1, ngay2,soTK;
            ngay1 = date_BD.Text;
            ngay2 = date_KT.Text;

            if (ngay1.Length == 0 || ngay2.Length == 0) {
                MessageBox.Show("Không được để trống ngày sao kê\n Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            soTK = text_soTK.Text.Trim();
            int checkMaNV;
            checkMaNV = taiKhoanBindingSource.Find("SOTK", soTK);
            
            if (checkMaNV == -1)
            {
                MessageBox.Show("Không tồn tại tài khoản cần sao kê vui lòng kiểm tra lại thông tin!\n" + checkMaNV, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rptSaoKeGiaoDich rp = new rptSaoKeGiaoDich(soTK,ngay1, ngay2);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Frm_saoKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.

            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            text_soTK.Focus();
        }

        private void lbl_soTK_Click(object sender, EventArgs e)
        {
            if (lbl_soTK.Location.Y == 75) // Vị trí hiện tại của label + 25
            {
                lbl_soTK.Font = new Font("Segoe UI", 8);
                lbl_soTK.Cursor = Cursors.Arrow;
                lbl_soTK.Location = new Point(lbl_soTK.Location.X, lbl_soTK.Location.Y - 25);
                text_soTK.Focus();
            }
        }

        private void text_soTK_Enter(object sender, EventArgs e)
        {
            pnl_soTK.BackColor = Color.Blue;
            lbl_soTK.ForeColor = Color.Blue;
            if (lbl_soTK.Location.Y != 50)
            {
                lbl_soTK.Font = new Font("Segoe UI", 8);
                lbl_soTK.Cursor = Cursors.Arrow;
                lbl_soTK.Location = new Point(lbl_soTK.Location.X, lbl_soTK.Location.Y - 25);
            }
        }

        private void text_soTK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_soTK.Text) && lbl_soTK.Location.Y == 50)
            {
                text_soTK.ResetText();
                pnl_soTK.BackColor = Color.Black;
                lbl_soTK.ForeColor = Color.Black;
                lbl_soTK.Font = new Font("Segoe UI", 9);
                lbl_soTK.Cursor = Cursors.IBeam;
                lbl_soTK.Location = new Point(lbl_soTK.Location.X, lbl_soTK.Location.Y + 25);
            }
        }

        /* Event cho TextEdit  */

        private void lbl_BD_Click(object sender, EventArgs e)
        {
            if (lbl_BD.Location.Y == 175)
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
            if (lbl_BD.Location.Y != 150)
            {
                lbl_BD.Font = new Font("Segoe UI", 8);
                lbl_BD.Cursor = Cursors.Arrow;
                lbl_BD.Location = new Point(lbl_BD.Location.X, lbl_BD.Location.Y - 25);
            }
        }

        private void text_BD_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(date_BD.Text) && lbl_BD.Location.Y == 150)
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
            if (lbl_KT.Location.Y == 175)
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
            if (lbl_KT.Location.Y != 150)
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
