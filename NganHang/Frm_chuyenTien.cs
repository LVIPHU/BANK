using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang
{
    public partial class Frm_chuyenTien : Form
    {
        string tenserver;
        public Frm_chuyenTien()
        {
            InitializeComponent();
        }

        private void gD_CHUYENTIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_GDchuyenTien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Frm_chuyenTien_Load(object sender, EventArgs e)
        {
            try
            {
                dS.EnforceConstraints = false;
                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
                this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);


                cmb_chiNhanh.DataSource = Program.bds_dspm;
                cmb_chiNhanh.DisplayMember = "TENCN";
                cmb_chiNhanh.ValueMember = "TENSERVER";
                cmb_chiNhanh.SelectedIndex = Program.mCoso;

                tenserver = Program.servername;

                if (Program.mGroup.Equals("CHINHANH"))
                {
                    groupControl_chiNhanh.Enabled = false;
                    btn_them.Enabled = true;
                }
                else
                {
                    groupControl_chiNhanh.Enabled = true;
                    btn_them.Enabled = false;
                }

                text_maNV.Enabled = false;
                date_ngayGD.Enabled = false;

                groupControl_chuyenTien.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tải dữ liệu không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
                if (tenserver != cmb_chiNhanh.SelectedValue.ToString())
                {
                    btn_them.Enabled = false;
                }
                else
                {
                    btn_them.Enabled = true;
                }
            }
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_them.Enabled = false;
            btn_reload.Enabled = false;
            bds_GDchuyenTien.AddNew();
            date_ngayGD.EditValue = DateTime.Today;
            text_maNV.Text = Program.username.Trim();
            groupControl_chuyenTien.Enabled = true;
            groupControl_chiNhanh.Enabled = false;
            gD_CHUYENTIENGridControl.Enabled = false;
            text_soTKChuyen.Focus();

            /*            lbl_soTKChuyen.ForeColor = Color.DarkGray;
                        lbl_soTKChuyen.Cursor = Cursors.IBeam;
                        if (lbl_soTKChuyen.Location.Y == 75)
                        lbl_soTKChuyen.Location = new Point(lbl_soTKChuyen.Location.X, lbl_soTKChuyen.Location.Y + 25);*/

            lbl_soTKNhan.ForeColor = Color.DarkGray;
            lbl_soTKNhan.Cursor = Cursors.IBeam;
            if (lbl_soTKNhan.Location.Y == 75)
                lbl_soTKNhan.Location = new Point(lbl_soTKNhan.Location.X, lbl_soTKNhan.Location.Y + 25);

            lbl_soTien.ForeColor = Color.DarkGray;
            lbl_soTien.Cursor = Cursors.IBeam;
            if (lbl_soTien.Location.Y == 175)
                lbl_soTien.Location = new Point(lbl_soTien.Location.X, lbl_soTien.Location.Y + 25);
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            if (text_soTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tiền không được trống!", "Lỗi", MessageBoxButtons.OK);
                text_soTien.Focus();
                return;
            }
           
            if (text_soTKChuyen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tài khoản chuyển không được trống!", "Lỗi", MessageBoxButtons.OK);
                text_soTKChuyen.Focus();
                return;
            }
            if (text_soTKNhan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tài khoản nhận không được trống!", "Lỗi", MessageBoxButtons.OK);
                text_soTKNhan.Focus();
                return;
            }
            String stkPattern = "\\d";
            if (!Regex.IsMatch(text_soTKChuyen.Text.Trim(), stkPattern) || text_soTKChuyen.Text.Trim().Length > 9)
            {
                MessageBox.Show("Nhập sai định dạng số tài khoản chuyển!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_soTKChuyen.Focus();
                return;
            }
            if (!Regex.IsMatch(text_soTKNhan.Text.Trim(), stkPattern) || text_soTKNhan.Text.Trim().Length > 9)
            {
                MessageBox.Show("Nhập sai định dạng số tài khoản nhận!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_soTKNhan.Focus();
                return;
            }

            try
            {
                int result;
                string sql = "exec [dbo].[SP_GDCHUYENTIEN] '" + text_soTKChuyen.Text.Trim() + "' , '" + text_soTien.Value + "' , '" + text_soTKNhan.Text.Trim() + "'";
                result = Program.ExecSqlNonQuery(sql);
                if (result == 1)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin tài khoản chuyển và nhận!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bds_GDchuyenTien.RemoveCurrent();
                    this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
                    groupControl_chuyenTien.Enabled = false;
                    btn_them.Enabled = btn_reload.Enabled = true;
                    gD_CHUYENTIENGridControl.Enabled = true;
                    if (Program.mGroup.Equals("NGANHANG"))
                    {
                        groupControl_chiNhanh.Enabled = true;
                    }
                    return;
                }
                MessageBox.Show("Giao dịch thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bds_GDchuyenTien.EndEdit();
                //this.gD_CHUYENTIENTableAdapter.Update(this.dS.GD_CHUYENTIEN);
                this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
                groupControl_chuyenTien.Enabled = false;
                btn_them.Enabled = true;
                gD_CHUYENTIENGridControl.Enabled = true;
                if (Program.mGroup.Equals("NGANHANG"))
                {
                    groupControl_chiNhanh.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giao dịch không thành công!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_huyBo_Click(object sender, EventArgs e)
        {
            bds_GDchuyenTien.RemoveCurrent();
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
            groupControl_chuyenTien.Enabled = false;
            btn_them.Enabled = btn_reload.Enabled = true;
            gD_CHUYENTIENGridControl.Enabled = true;
            if (Program.mGroup.Equals("NGANHANG"))
            {
                groupControl_chiNhanh.Enabled = true;
            }

            pnl_soTKChuyen.ForeColor = Color.DarkGray;
            lbl_soTKChuyen.ForeColor = Color.Black;
            lbl_soTKChuyen.Cursor = Cursors.Arrow;
            lbl_soTKChuyen.Font = new Font("Segoe UI", 9);
            if (lbl_soTKChuyen.Location.Y == 100)
                lbl_soTKChuyen.Location = new Point(lbl_soTKChuyen.Location.X, lbl_soTKChuyen.Location.Y - 25);

            pnl_soTKNhan.ForeColor = Color.DarkGray;
            lbl_soTKNhan.ForeColor = Color.Black;
            lbl_soTKNhan.Cursor = Cursors.Arrow;
            lbl_soTKNhan.Font = new Font("Segoe UI", 9);
            if (lbl_soTKNhan.Location.Y == 100)
                lbl_soTKNhan.Location = new Point(lbl_soTKNhan.Location.X, lbl_soTKNhan.Location.Y - 25);

            pnl_soTien.ForeColor = Color.DarkGray;
            lbl_soTien.ForeColor = Color.Black;
            lbl_soTien.Cursor = Cursors.Arrow;
            lbl_soTien.Font = new Font("Segoe UI", 9);
            if (lbl_soTien.Location.Y == 200)
                lbl_soTien.Location = new Point(lbl_soTien.Location.X, lbl_soTien.Location.Y - 25);
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /* Event cho TextEdit  */

        private void lbl_soTKChuyen_Click(object sender, EventArgs e)
        {
            if (lbl_soTKChuyen.Location.Y == 100)
            {
                lbl_soTKChuyen.Font = new Font("Segoe UI", 8);
                lbl_soTKChuyen.Cursor = Cursors.Arrow;
                lbl_soTKChuyen.Location = new Point(lbl_soTKChuyen.Location.X, lbl_soTKChuyen.Location.Y - 25);
                text_soTKChuyen.Focus();
            }
        }

        private void text_soTKChuyen_Enter(object sender, EventArgs e)
        {
            pnl_soTKChuyen.BackColor = Color.Teal;
            lbl_soTKChuyen.ForeColor = Color.Teal;
            if (lbl_soTKChuyen.Location.Y != 75)
            {
                lbl_soTKChuyen.Font = new Font("Segoe UI", 8);
                lbl_soTKChuyen.Cursor = Cursors.Arrow;
                lbl_soTKChuyen.Location = new Point(lbl_soTKChuyen.Location.X, lbl_soTKChuyen.Location.Y - 25);
            }
        }

        private void text_soTKChuyen_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_soTKChuyen.Text) && lbl_soTKChuyen.Location.Y == 75)
            {
                text_soTKChuyen.ResetText();
                pnl_soTKChuyen.BackColor = Color.DarkGray;
                lbl_soTKChuyen.ForeColor = Color.DarkGray;
                lbl_soTKChuyen.Font = new Font("Segoe UI", 9);
                lbl_soTKChuyen.Cursor = Cursors.IBeam;
                lbl_soTKChuyen.Location = new Point(lbl_soTKChuyen.Location.X, lbl_soTKChuyen.Location.Y + 25);
            }
        }

        /* Event cho TextEdit số tài khoản nhập */

        private void lbl_soTKNhan_Click(object sender, EventArgs e)
        {
            if (lbl_soTKNhan.Location.Y == 100)
            {
                lbl_soTKNhan.Font = new Font("Segoe UI", 8);
                lbl_soTKNhan.Cursor = Cursors.Arrow;
                lbl_soTKNhan.Location = new Point(lbl_soTKNhan.Location.X, lbl_soTKNhan.Location.Y - 25);
                text_soTKNhan.Focus();
            }
        }

        private void text_soTKNhan_Enter(object sender, EventArgs e)
        {
            pnl_soTKNhan.BackColor = Color.Teal;
            lbl_soTKNhan.ForeColor = Color.Teal;
            if (lbl_soTKNhan.Location.Y != 75)
            {
                lbl_soTKNhan.Font = new Font("Segoe UI", 8);
                lbl_soTKNhan.Cursor = Cursors.Arrow;
                lbl_soTKNhan.Location = new Point(lbl_soTKNhan.Location.X, lbl_soTKNhan.Location.Y - 25);
            }
        }

        private void text_soTKNhan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_soTKNhan.Text) && lbl_soTKNhan.Location.Y == 75)
            {
                pnl_soTKNhan.BackColor = Color.DarkGray;
                lbl_soTKNhan.ForeColor = Color.DarkGray;
                text_soTKNhan.ResetText();
                lbl_soTKNhan.Font = new Font("Segoe UI", 9);
                lbl_soTKNhan.Cursor = Cursors.IBeam;
                lbl_soTKNhan.Location = new Point(lbl_soTKNhan.Location.X, lbl_soTKNhan.Location.Y + 25);
            }
        }

        /* Event cho TextEdit */

        private void lbl_soTien_Click(object sender, EventArgs e)
        {
            if (lbl_soTien.Location.Y == 200)
            {
                lbl_soTien.Font = new Font("Segoe UI", 8);
                lbl_soTien.Cursor = Cursors.Arrow;
                lbl_soTien.Location = new Point(lbl_soTien.Location.X, lbl_soTien.Location.Y - 25);
                text_soTien.Focus();
            }
        }

        private void text_soTien_Enter(object sender, EventArgs e)
        {
            pnl_soTien.BackColor = Color.Teal;
            lbl_soTien.ForeColor = Color.Teal;
            if (lbl_soTien.Location.Y != 175)
            {
                lbl_soTien.Font = new Font("Segoe UI", 8);
                lbl_soTien.Cursor = Cursors.Arrow;
                lbl_soTien.Location = new Point(lbl_soTien.Location.X, lbl_soTien.Location.Y - 25);
            }
        }

        private void text_soTien_Leave(object sender, EventArgs e)
        {
            if (text_soTien.Value == 0 && lbl_soTien.Location.Y == 175)
            {
                pnl_soTien.BackColor = Color.DarkGray;
                lbl_soTien.ForeColor = Color.DarkGray;
                text_soTien.ResetText();
                lbl_soTien.Font = new Font("Segoe UI", 9);
                lbl_soTien.Cursor = Cursors.IBeam;
                lbl_soTien.Location = new Point(lbl_soTien.Location.X, lbl_soTien.Location.Y + 25);
            }
        }

    }
}
