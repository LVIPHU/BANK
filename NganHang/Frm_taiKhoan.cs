using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace NganHang
{
    public partial class Frm_taiKhoan : Form
    {

        public Frm_taiKhoan()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_taiKhoan.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Frm_taiKhoan_Load(object sender, EventArgs e)
        {

            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.

            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            // TODO: This line of code loads data into the 'dS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);

            cmb_chiNhanh.DataSource = Program.bds_dspm;
            cmb_chiNhanh.DisplayMember = "TENCN";
            cmb_chiNhanh.ValueMember = "TENSERVER";
            cmb_chiNhanh.SelectedIndex = Program.mCoso;

            if (Program.mGroup.Equals("CHINHANH"))
            {
                groupControl_chiNhanh.Enabled = false;
            }
            else
            {
                groupControl_chiNhanh.Enabled = true;
                btn_them.Enabled = false;
                btn_sua.Enabled = false;
                btn_ghi.Enabled = false;
                btn_huy.Enabled = false;
                btn_xoa.Enabled = false;
            }

            groupControl_taiKhoan.Enabled = false;
            btn_ghi.Enabled = btn_huy.Enabled = btn_phucHoi.Enabled = false;
            if (bds_taiKhoan.Count == 0)
            {
                btn_xoa.Enabled = false;
            }
            date_ngayMoTK.Enabled = false;
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupControl_chiNhanh.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_ghi.Enabled = true;
            btn_huy.Enabled = true;
            btn_xoa.Enabled = false;
            btn_reload.Enabled = false;
            text_maCN.Enabled = false;
            bds_taiKhoan.AddNew();

            if (cmb_chiNhanh.SelectedValue.ToString().Contains("SERVER1"))
            {
                text_maCN.Text = "BENTHANH";
            }
            else
            {
                text_maCN.Text = "TANDINH";
            }
            date_ngayMoTK.EditValue = DateTime.Today;
            groupControl_taiKhoan.Enabled = true;
            taiKhoanGridControl.Enabled = false;
            text_soTK.Focus();

/*            lbl_soTK.ForeColor = Color.DarkGray;
            lbl_soTK.Cursor = Cursors.IBeam;
            if (lbl_soTK.Location.Y == 75)
            lbl_soTK.Location = new Point(lbl_soTK.Location.X, lbl_soTK.Location.Y + 25);*/

            lbl_cmnd.ForeColor = Color.DarkGray;
            lbl_cmnd.Cursor = Cursors.IBeam;
            if (lbl_cmnd.Location.Y == 75)
                lbl_cmnd.Location = new Point(lbl_cmnd.Location.X, lbl_cmnd.Location.Y + 25);

            lbl_soDu.ForeColor = Color.DarkGray;
            lbl_soDu.Cursor = Cursors.IBeam;
            if (lbl_soDu.Location.Y == 75)
                lbl_soDu.Location = new Point(lbl_soDu.Location.X, lbl_soDu.Location.Y + 25);
        }

        private void btn_phucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (text_soTK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tài khoản không được trống!", "Lỗi", MessageBoxButtons.OK);
                text_soTK.Focus();
                return;
            }
            String stkPattern = "\\d";
            if (!Regex.IsMatch(text_soTK.Text.Trim(), stkPattern) || text_soTK.Text.Trim().Length > 9)
            {
                MessageBox.Show("Nhập sai định dạng số tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_soTK.Focus();
                return;
            }
            String cmndPattern = "\\d{9}";
            if (text_cmnd.Text.Trim().Length == 0)
            {
                MessageBox.Show("CMND không được trống!", "Lỗi", MessageBoxButtons.OK);
                text_cmnd.Focus();
                return;
            }
            if (!Regex.IsMatch(text_cmnd.Text.Trim(), cmndPattern))
            {
                MessageBox.Show("Nhập sai định dạng CMND!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_cmnd.Focus();
                return;
            }
            if (text_soDu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số dư không được trống!", "Lỗi", MessageBoxButtons.OK);
                text_soDu.Focus();
                return;
            }
            if (date_ngayMoTK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ngày mở tài khoản không được trống!", "Lỗi", MessageBoxButtons.OK);
                date_ngayMoTK.Focus();
                return;
            }
            if (text_soDu.Value < 0)
            {
                MessageBox.Show("Số dư không hợp lệ!", "Lỗi", MessageBoxButtons.OK);
                text_soDu.Focus();
                return;
            }
            if (!checkKH)
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin khách hàng!", "Thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                String soTK = text_soTK.Text.Trim();
                string strLenh = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CheckStkExists] " +
                               "@SOTK = " + text_soTK.Text.Trim() + " " +
                               "SELECT 'Return Value' = @return_value";

                SqlDataReader dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                // Đọc và lấy 
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();

                if (result == 1)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_soTK.Focus();
                    return;
                } 
                bds_taiKhoan.EndEdit();
                this.taiKhoanTableAdapter.Update(this.dS.TaiKhoan);
                this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);

                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bds_taiKhoan.Position = bds_taiKhoan.Find("SOTK", soTK);
                groupControl_taiKhoan.Enabled = false;
                btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btn_reload.Enabled = true;
                btn_ghi.Enabled = btn_huy.Enabled = false;
                taiKhoanGridControl.Enabled = true;
                checkKH = false;
                if (Program.mGroup.Equals("NGANHANG"))
                {
                    groupControl_chiNhanh.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi tài khoản!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_taiKhoan.RemoveCurrent();
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            groupControl_taiKhoan.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btn_reload.Enabled = true;
            btn_ghi.Enabled = btn_huy.Enabled = false;
            taiKhoanGridControl.Enabled = true;
            checkKH = false;
            if (Program.mGroup == "NGANHANG")
            {
                groupControl_chiNhanh.Enabled = true;
            }


            pnl_soTK.ForeColor = Color.DarkGray;
            lbl_soTK.ForeColor = Color.Black;
            lbl_soTK.Cursor = Cursors.Arrow;
            if (lbl_soTK.Location.Y == 100)
                lbl_soTK.Location = new Point(lbl_soTK.Location.X, lbl_soTK.Location.Y - 25);

            pnl_cmnd.ForeColor = Color.DarkGray;
            lbl_cmnd.ForeColor = Color.Black;
            lbl_cmnd.Cursor = Cursors.Arrow;
            if (lbl_cmnd.Location.Y == 100)
                lbl_cmnd.Location = new Point(lbl_cmnd.Location.X, lbl_cmnd.Location.Y - 25);

            pnl_soDu.ForeColor = Color.DarkGray;
            lbl_soDu.ForeColor = Color.Black;
            lbl_soDu.Cursor = Cursors.Arrow;
            if (lbl_soDu.Location.Y == 100)
                lbl_soDu.Location = new Point(lbl_soDu.Location.X, lbl_soDu.Location.Y - 25);

        }



        private void cmb_chiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_chiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmb_chiNhanh.SelectedValue.ToString();
            if (cmb_chiNhanh.SelectedIndex != Program.mCoso)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK);
            else
            {
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            }
        }

        public Boolean checkKH = false;
        private void btn_traCuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_cmnd.Text.Trim().Length == 0)
                {
                    MessageBox.Show("CMND không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_cmnd.Focus();
                    return;
                }
                String cmndPattern = "\\d{9}";
                if (!Regex.IsMatch(text_cmnd.Text.Trim(), cmndPattern) || text_cmnd.Text.Trim().Length > 10)
                {
                    MessageBox.Show("Nhập sai định dạng CMND!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_cmnd.Focus();
                    return;
                }
                string strLenh = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_TRACUUKH] " +
                               "@CMND = " + text_cmnd.Text.Trim() + " " +
                               "SELECT 'Return Value' = @return_value";
                SqlDataReader dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                // Đọc và lấy 
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                if (result == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng " + text_cmnd.Text.Trim(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("Thông tin khách hàng hợp lệ!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkKH = true;
                }
                dataReader.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tra cứu không thành công!\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi reload!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Event cho TextEdit

        private void lbl_soTK_Click(object sender, EventArgs e)
        {
            if (lbl_soTK.Location.Y == 100) // Vị trí hiện tại của label + 25
            {
                lbl_soTK.Font = new Font("Segoe UI", 8);
                lbl_soTK.Cursor = Cursors.Arrow;
                lbl_soTK.Location = new Point(lbl_soTK.Location.X, lbl_soTK.Location.Y - 25);
                text_soTK.Focus();
            }
        }

        private void text_soTK_Enter(object sender, EventArgs e)
        {
            pnl_soTK.BackColor = Color.Teal;
            lbl_soTK.ForeColor = Color.Teal;
            if (lbl_soTK.Location.Y != 75)
            {
                lbl_soTK.Font = new Font("Segoe UI", 8);
                lbl_soTK.Cursor = Cursors.Arrow;
                lbl_soTK.Location = new Point(lbl_soTK.Location.X, lbl_soTK.Location.Y - 25);
            }
        }

        private void text_soTK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_soTK.Text) && lbl_soTK.Location.Y == 75)
            {
                text_soTK.ResetText();
                pnl_soTK.BackColor = Color.DarkGray;
                lbl_soTK.ForeColor = Color.DarkGray;
                lbl_soTK.Font = new Font("Segoe UI", 9);
                lbl_soTK.Cursor = Cursors.IBeam;
                lbl_soTK.Location = new Point(lbl_soTK.Location.X, lbl_soTK.Location.Y + 25);
            }
        }

        // Event cho TextEdit

        private void lbl_cmnd_Click(object sender, EventArgs e)
        {
            if (lbl_cmnd.Location.Y == 100)
            {
                lbl_cmnd.Font = new Font("Segoe UI", 8);
                lbl_cmnd.Cursor = Cursors.Arrow;
                lbl_cmnd.Location = new Point(lbl_cmnd.Location.X, lbl_cmnd.Location.Y - 25);
                text_cmnd.Focus();
            }
        }

        private void text_cmnd_Enter(object sender, EventArgs e)
        {
            pnl_cmnd.BackColor = Color.Teal;
            lbl_cmnd.ForeColor = Color.Teal;
            if (lbl_cmnd.Location.Y != 75)
            {
                lbl_cmnd.Font = new Font("Segoe UI", 8);
                lbl_cmnd.Cursor = Cursors.Arrow;
                lbl_cmnd.Location = new Point(lbl_cmnd.Location.X, lbl_cmnd.Location.Y - 25);
            }
        }

        private void text_cmnd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_cmnd.Text) && lbl_cmnd.Location.Y == 75)
            {
                pnl_cmnd.BackColor = Color.DarkGray;
                lbl_cmnd.ForeColor = Color.DarkGray;
                text_cmnd.ResetText();
                lbl_cmnd.Font = new Font("Segoe UI", 9);
                lbl_cmnd.Cursor = Cursors.IBeam;
                lbl_cmnd.Location = new Point(lbl_cmnd.Location.X, lbl_cmnd.Location.Y + 25);
            }
        }

        // Event cho TextEdit

        private void lbl_soDu_Click(object sender, EventArgs e)
        {
            if (lbl_soDu.Location.Y == 100)
            {
                lbl_soDu.Font = new Font("Segoe UI", 8);
                lbl_soDu.Cursor = Cursors.Arrow;
                lbl_soDu.Location = new Point(lbl_soDu.Location.X, lbl_soDu.Location.Y - 25);
                text_soDu.Focus();
            }
        }

        private void text_soDu_Enter(object sender, EventArgs e)
        {
            pnl_soDu.BackColor = Color.Teal;
            lbl_soDu.ForeColor = Color.Teal;
            if (lbl_soDu.Location.Y != 75)
            {
                lbl_soDu.Font = new Font("Segoe UI", 8);
                lbl_soDu.Cursor = Cursors.Arrow;
                lbl_soDu.Location = new Point(lbl_soDu.Location.X, lbl_soDu.Location.Y - 25);
            }
        }

        private void text_soDu_Leave(object sender, EventArgs e)
        {
            if (text_soDu.Value == 0 && lbl_soDu.Location.Y == 75)
            {
                pnl_soDu.BackColor = Color.DarkGray;
                lbl_soDu.ForeColor = Color.DarkGray;
                text_soDu.ResetText();
                lbl_soDu.Font = new Font("Segoe UI", 9);
                lbl_soDu.Cursor = Cursors.IBeam;
                lbl_soDu.Location = new Point(lbl_soDu.Location.X, lbl_soDu.Location.Y + 25);
            }
        }
    }
}
