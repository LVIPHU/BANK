using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace NganHang
{
    public partial class Frm_khachHang : Form
    {
        private string phai = "";
        private Boolean isSua = false;
        Stack undolist = new Stack();
        string KH_info = "";
        public Frm_khachHang()
        {
            InitializeComponent();
        }

        private void Frm_khachHang_Load(object sender, EventArgs e)
        {

            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.dS.KhachHang);

            cmb_chiNhanh.DataSource = Program.bds_dspm;
            cmb_chiNhanh.DisplayMember = "TENCN";
            cmb_chiNhanh.ValueMember = "TENSERVER";
            cmb_chiNhanh.SelectedIndex = Program.mCoso;

            cmb_phai.Items.Add("Nam");
            cmb_phai.Items.Add("Nữ");
            if(cmb_phai.ValueMember == "Nam")
            {
                cmb_phai.DisplayMember = "true";
            } else cmb_phai.DisplayMember = "false";

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
            groupControl_khachHang.Enabled = false;
            btn_ghi.Enabled = btn_huy.Enabled = btn_phucHoi.Enabled = false;
            if (bds_khachHang.Count == 0)
            {
                btn_xoa.Enabled = false;
            }
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_khachHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

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
            bds_khachHang.AddNew();
            if (cmb_chiNhanh.SelectedValue.ToString().Contains("SERVER1"))
            {
                text_maCN.Text = "BENTHANH";
            }
            else
            {
                text_maCN.Text = "TANDINH";
            }
            text_cmnd.Enabled = true;
            cmb_phai.SelectedIndex = 1;
            cmb_phai.SelectedIndex = 0;
            groupControl_khachHang.Enabled = true;
            khachHangGridControl.Enabled = false;
            text_cmnd.Focus();

/*            lbl_cmnd.ForeColor = Color.DarkGray;
            lbl_cmnd.Cursor = Cursors.IBeam;
            if (lbl_cmnd.Location.Y == 75)
                lbl_cmnd.Location = new Point(lbl_cmnd.Location.X, lbl_cmnd.Location.Y + 25);*/

            lbl_ho.ForeColor = Color.DarkGray;
            lbl_ho.Cursor = Cursors.IBeam;
            if (lbl_ho.Location.Y == 75)
                lbl_ho.Location = new Point(lbl_ho.Location.X, lbl_ho.Location.Y + 25);

            lbl_ten.ForeColor = Color.DarkGray;
            lbl_ten.Cursor = Cursors.IBeam;
            if (lbl_ten.Location.Y == 75)
                lbl_ten.Location = new Point(lbl_ten.Location.X, lbl_ten.Location.Y + 25);

            lbl_soDT.ForeColor = Color.DarkGray;
            lbl_soDT.Cursor = Cursors.IBeam;
            if (lbl_soDT.Location.Y == 175)
                lbl_soDT.Location = new Point(lbl_soDT.Location.X, lbl_soDT.Location.Y + 25);

            lbl_diaChi.ForeColor = Color.DarkGray;
            lbl_diaChi.Cursor = Cursors.IBeam;
            if (lbl_diaChi.Location.Y == 175)
                lbl_diaChi.Location = new Point(lbl_diaChi.Location.X, lbl_diaChi.Location.Y + 25);

            lbl_ngayCap.ForeColor = Color.DarkGray;
            lbl_ngayCap.Cursor = Cursors.IBeam;
            if (lbl_ngayCap.Location.Y == 175)
                lbl_ngayCap.Location = new Point(lbl_ngayCap.Location.X, lbl_ngayCap.Location.Y + 25);
        }

        private void btn_ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String cmndPattern = "\\d{9}";
            if (text_cmnd.Text.Trim().Length == 0)
            {
                MessageBox.Show("CMND không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_cmnd.Focus();
                return;
            }

            if (!Regex.IsMatch(text_cmnd.Text.Trim(), cmndPattern) || text_cmnd.Text.Trim().Length < 9 || text_cmnd.Text.Trim().Length > 10)
            {
                MessageBox.Show("Nhập sai định dạng CMND!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_cmnd.Focus();
                return;
            }
            String hoten = "[a-zA-Z]";
            if (text_ho.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ khách hàng không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_ho.Focus();
                return;
            }
            if (!Regex.IsMatch(text_ho.Text.Trim(), hoten))
            {
                MessageBox.Show("Nhập sai định dạng họ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_ho.Focus();
                return;
            }
            if (text_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên khách hàng không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_ten.Focus();
                return;
            }
            if (!Regex.IsMatch(text_ten.Text.Trim(), hoten))
            {
                MessageBox.Show("Nhập sai định dạng tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_ten.Focus();
                return;
            }
            if (text_diaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa chỉ không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_diaChi.Focus();
                return;
            }
            if (date_ngayCap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ngày cấp không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                date_ngayCap.Focus();
                return;
            }
            String PhoneNumber = "0\\d{9,10}";
            if (text_soDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số điện thoại không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_soDT.Focus();
                return;
            }
            if (!Regex.IsMatch(text_soDT.Text.Trim(), PhoneNumber))
            {
                MessageBox.Show("Nhập sai định dạng SĐT!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_soDT.Focus();
                return;
            }
            try
            {
                String cmnd = text_cmnd.Text.Trim().ToString();
                if (!isSua)
                {
                    text_cmnd.Text = text_cmnd.Text.Trim();
                   
                    string strLenh = "DECLARE @return_value int " +
                                "EXEC @return_value = [dbo].[SP_CHECKKHEXISTS] " +
                                "@CMND=" + cmnd + " " +
                                "SELECT 'Return Value' = @return_value";

                    SqlDataReader dataReader = null;
                    dataReader = Program.ExecSqlDataReader(strLenh);
                    // Đọc và lấy 
                    dataReader.Read();
                    int result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();

                    if (result == 1)
                    {
                        MessageBox.Show("Khách hàng này đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        text_cmnd.Focus();
                        return;
                    }
                }

                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    if (!isSua)
                    {
                        btn_phucHoi.Enabled = true;
                        undolist.Push(cmnd);
                        undolist.Push("INSERT");
                    }
                    else
                    {
                        btn_phucHoi.Enabled = true;
                        undolist.Push(KH_info);
                        undolist.Push("EDIT");
                    }
                    cmb_phai.Text = phai;
                    bds_khachHang.EndEdit();
                    this.khachHangTableAdapter.Update(this.dS.KhachHang);
                    this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                    groupControl_khachHang.Enabled = false;
                    btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btn_reload.Enabled = true;
                    btn_ghi.Enabled = btn_huy.Enabled = false;
                    khachHangGridControl.Enabled = true;
                    isSua = false;
                    bds_khachHang.Position = bds_khachHang.Find("CMND", cmnd);
                }

                if (Program.mGroup.Equals("NGANHANG"))
                {
                    groupControl_chiNhanh.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi khách hàng\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string cmnd = text_cmnd.Text.ToString().Trim();
                string strLenh = "DECLARE @return_value int " +
                              "EXEC @return_value = [dbo].[SP_CHECKCUSHAVEACCOUNTS] " +
                              "@CMND=" + cmnd + " " +
                              "SELECT 'Return Value' = @return_value";

                SqlDataReader dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                // Đọc và lấy 
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();

                if (result == 1)
                {
                    MessageBox.Show("Không thể xóa người dùng!" + result, "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        cmnd = ((DataRowView)bds_khachHang[bds_khachHang.Position])["CMND"].ToString();
                        String info = text_cmnd.Text.Trim() + "#" + text_ho.Text.Trim() + "#" + text_ten.Text.Trim() + "#" +
                            text_diaChi.Text.Trim() + "#" + cmb_phai.SelectedItem.ToString() + "#" + date_ngayCap.Text + "#" + text_soDT.Text.Trim();

                        bds_khachHang.RemoveCurrent();
                        this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.khachHangTableAdapter.Update(this.dS.KhachHang);
                        btn_phucHoi.Enabled = true;
                        undolist.Push(info);
                        undolist.Push("DELETE");
                        this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa khách hàng. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                        bds_khachHang.Position = bds_khachHang.Find("CMND", cmnd);
                        return;
                    }
                }
                if (bds_khachHang.Count == 0)
                    btn_xoa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa khách hàng. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_khachHang.RemoveCurrent();
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.dS.KhachHang);
            groupControl_khachHang.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btn_reload.Enabled = true;
            btn_ghi.Enabled = btn_huy.Enabled = false;
            khachHangGridControl.Enabled = true;
            isSua = false;
            if (Program.mGroup == "NGANHANG")
            {
                groupControl_chiNhanh.Enabled = true;
            }

            pnl_cmnd.ForeColor = Color.DarkGray;
            lbl_cmnd.ForeColor = Color.Black;
            lbl_cmnd.Cursor = Cursors.Arrow;
            if (lbl_cmnd.Location.Y == 100)
                lbl_cmnd.Location = new Point(lbl_cmnd.Location.X, lbl_cmnd.Location.Y - 25);

            pnl_ho.ForeColor = Color.DarkGray;
            lbl_ho.ForeColor = Color.Black;
            lbl_ho.Cursor = Cursors.Arrow;
            lbl_ho.Font = new Font("Segoe UI", 9);
            if (lbl_ho.Location.Y == 100)
                lbl_ho.Location = new Point(lbl_ho.Location.X, lbl_ho.Location.Y - 25);

            pnl_ten.ForeColor = Color.DarkGray;
            lbl_ten.ForeColor = Color.Black;
            lbl_ten.Cursor = Cursors.Arrow;
            lbl_ten.Font = new Font("Segoe UI", 9);
            if (lbl_ten.Location.Y == 100)
                lbl_ten.Location = new Point(lbl_ten.Location.X, lbl_ten.Location.Y - 25);

            pnl_soDT.ForeColor = Color.DarkGray;
            lbl_soDT.ForeColor = Color.Black;
            lbl_soDT.Cursor = Cursors.Arrow;
            lbl_soDT.Font = new Font("Segoe UI", 9);
            if (lbl_soDT.Location.Y == 200)
                lbl_soDT.Location = new Point(lbl_soDT.Location.X, lbl_soDT.Location.Y - 25);

            pnl_diaChi.ForeColor = Color.DarkGray;
            lbl_diaChi.ForeColor = Color.Black;
            lbl_diaChi.Cursor = Cursors.Arrow;
            lbl_diaChi.Font = new Font("Segoe UI", 9);
            if (lbl_diaChi.Location.Y == 200)
                lbl_diaChi.Location = new Point(lbl_diaChi.Location.X, lbl_diaChi.Location.Y - 25);

            pnl_ngayCap.ForeColor = Color.DarkGray;
            lbl_ngayCap.ForeColor = Color.Black;
            lbl_ngayCap.Cursor = Cursors.Arrow;
            lbl_ngayCap.Font = new Font("Segoe UI", 9);
            if (lbl_ngayCap.Location.Y == 200)
                lbl_ngayCap.Location = new Point(lbl_ngayCap.Location.X, lbl_ngayCap.Location.Y - 25);
        }

        private void btn_sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isSua = true;
            text_cmnd.Enabled = false;
            groupControl_khachHang.Enabled = true;
            groupControl_chiNhanh.Enabled = false;
            khachHangGridControl.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btn_reload.Enabled = false;
            btn_ghi.Enabled = btn_huy.Enabled = true;
            KH_info = text_cmnd.Text.Trim() + "#" + text_ho.Text.Trim() + "#" + text_ten.Text.Trim() + "#" +
                  text_diaChi.Text.Trim() + "#" + cmb_phai.SelectedItem.ToString() + "#" + text_soDT.Text.Trim();

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

                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.dS.KhachHang);
            }
        }

        private void cmb_phai_SelectedIndexChanged(object sender, EventArgs e)
        {
            //phai = cmb_phai.SelectedItem.ToString();
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khachHangTableAdapter.Fill(this.dS.KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

        private void lbl_ho_Click(object sender, EventArgs e)
        {
            if (lbl_ho.Location.Y == 100)
            {
                lbl_ho.Font = new Font("Segoe UI", 8);
                lbl_ho.Cursor = Cursors.Arrow;
                lbl_ho.Location = new Point(lbl_ho.Location.X, lbl_ho.Location.Y - 25);
                text_ho.Focus();
            }
        }

        private void text_ho_Enter(object sender, EventArgs e)
        {
            pnl_ho.BackColor = Color.Teal;
            lbl_ho.ForeColor = Color.Teal;
            if (lbl_ho.Location.Y != 75)
            {
                lbl_ho.Font = new Font("Segoe UI", 8);
                lbl_ho.Cursor = Cursors.Arrow;
                lbl_ho.Location = new Point(lbl_ho.Location.X, lbl_ho.Location.Y - 25);
            }
        }

        private void text_ho_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_ho.Text) && lbl_ho.Location.Y == 75)
            {
                text_ho.ResetText();
                pnl_ho.BackColor = Color.DarkGray;
                lbl_ho.ForeColor = Color.DarkGray;
                lbl_ho.Font = new Font("Segoe UI", 9);
                lbl_ho.Cursor = Cursors.IBeam;
                lbl_ho.Location = new Point(lbl_ho.Location.X, lbl_ho.Location.Y + 25);
            }
        }

        // Event cho TextEdit

        private void lbl_ten_Click(object sender, EventArgs e)
        {
            if (lbl_ten.Location.Y == 100)
            {
                lbl_ten.Font = new Font("Segoe UI", 8);
                lbl_ten.Cursor = Cursors.Arrow;
                lbl_ten.Location = new Point(lbl_ten.Location.X, lbl_ten.Location.Y - 25);
                text_ten.Focus();
            }
        }

        private void text_ten_Enter(object sender, EventArgs e)
        {
            pnl_ten.BackColor = Color.Teal;
            lbl_ten.ForeColor = Color.Teal;
            if (lbl_ten.Location.Y != 75)
            {
                lbl_ten.Font = new Font("Segoe UI", 8);
                lbl_ten.Cursor = Cursors.Arrow;
                lbl_ten.Location = new Point(lbl_ten.Location.X, lbl_ten.Location.Y - 25);
            }
        }

        private void text_ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_ten.Text) && lbl_ten.Location.Y == 75)
            {
                pnl_ten.BackColor = Color.DarkGray;
                lbl_ten.ForeColor = Color.DarkGray;
                text_ten.ResetText();
                lbl_ten.Font = new Font("Segoe UI", 9);
                lbl_ten.Cursor = Cursors.IBeam;
                lbl_ten.Location = new Point(lbl_ten.Location.X, lbl_ten.Location.Y + 25);
            }
        }

        // Event cho TextEdit 

        private void lbl_soDT_Click(object sender, EventArgs e)
        {
            if (lbl_soDT.Location.Y == 200)
            {
                lbl_soDT.Font = new Font("Segoe UI", 8);
                lbl_soDT.Cursor = Cursors.Arrow;
                lbl_soDT.Location = new Point(lbl_soDT.Location.X, lbl_soDT.Location.Y - 25);
                text_soDT.Focus();
            }
        }

        private void text_soDT_Enter(object sender, EventArgs e)
        {
            pnl_soDT.BackColor = Color.Teal;
            lbl_soDT.ForeColor = Color.Teal;
            if (lbl_soDT.Location.Y != 175)
            {
                lbl_soDT.Font = new Font("Segoe UI", 8);
                lbl_soDT.Cursor = Cursors.Arrow;
                lbl_soDT.Location = new Point(lbl_soDT.Location.X, lbl_soDT.Location.Y - 25);
            }
        }

        private void text_soDT_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_soDT.Text) && lbl_soDT.Location.Y == 175)
            {
                text_soDT.ResetText();
                pnl_soDT.BackColor = Color.DarkGray;
                lbl_soDT.ForeColor = Color.DarkGray;
                lbl_soDT.Font = new Font("Segoe UI", 9);
                lbl_soDT.Cursor = Cursors.IBeam;
                lbl_soDT.Location = new Point(lbl_soDT.Location.X, lbl_soDT.Location.Y + 25);
            }
        }

        // Event cho TextEdit số tài khoản nhập

        private void lbl_diaChi_Click(object sender, EventArgs e)
        {
            if (lbl_diaChi.Location.Y == 200)
            {
                lbl_diaChi.Font = new Font("Segoe UI", 8);
                lbl_diaChi.Cursor = Cursors.Arrow;
                lbl_diaChi.Location = new Point(lbl_diaChi.Location.X, lbl_diaChi.Location.Y - 25);
                text_diaChi.Focus();
            }
        }

        private void text_diaChi_Enter(object sender, EventArgs e)
        {
            pnl_diaChi.BackColor = Color.Teal;
            lbl_diaChi.ForeColor = Color.Teal;
            if (lbl_diaChi.Location.Y != 175)
            {
                lbl_diaChi.Font = new Font("Segoe UI", 8);
                lbl_diaChi.Cursor = Cursors.Arrow;
                lbl_diaChi.Location = new Point(lbl_diaChi.Location.X, lbl_diaChi.Location.Y - 25);
            }
        }

        private void text_diaChi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_diaChi.Text) && lbl_diaChi.Location.Y == 175)
            {
                pnl_diaChi.BackColor = Color.DarkGray;
                lbl_diaChi.ForeColor = Color.DarkGray;
                text_diaChi.ResetText();
                lbl_diaChi.Font = new Font("Segoe UI", 9);
                lbl_diaChi.Cursor = Cursors.IBeam;
                lbl_diaChi.Location = new Point(lbl_diaChi.Location.X, lbl_diaChi.Location.Y + 25);
            }
        }

        // Event cho TextEdit 

        private void lbl_ngayCap_Click(object sender, EventArgs e)
        {
            if (lbl_ngayCap.Location.Y == 200)
            {
                lbl_ngayCap.Font = new Font("Segoe UI", 8);
                lbl_ngayCap.Cursor = Cursors.Arrow;
                lbl_ngayCap.Location = new Point(lbl_ngayCap.Location.X, lbl_ngayCap.Location.Y - 25);
                date_ngayCap.Focus();
            }
        }

        private void date_ngayCap_Enter(object sender, EventArgs e)
        {
            pnl_ngayCap.BackColor = Color.Teal;
            lbl_ngayCap.ForeColor = Color.Teal;
            if (lbl_ngayCap.Location.Y != 175)
            {
                lbl_ngayCap.Font = new Font("Segoe UI", 8);
                lbl_ngayCap.Cursor = Cursors.Arrow;
                lbl_ngayCap.Location = new Point(lbl_ngayCap.Location.X, lbl_ngayCap.Location.Y - 25);
            }
        }

        private void date_ngayCap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(date_ngayCap.Text) && lbl_ngayCap.Location.Y == 175)
            {
                pnl_ngayCap.BackColor = Color.DarkGray;
                lbl_ngayCap.ForeColor = Color.DarkGray;
                date_ngayCap.ResetText();
                lbl_ngayCap.Font = new Font("Segoe UI", 9);
                lbl_ngayCap.Cursor = Cursors.IBeam;
                lbl_ngayCap.Location = new Point(lbl_ngayCap.Location.X, lbl_ngayCap.Location.Y + 25);
            }
        }

        private void btn_phucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undolist.Count > 0)
            {
                String statement = undolist.Pop().ToString();
                if (statement.Equals("DELETE"))
                {
                    try
                    {
                        this.bds_khachHang.AddNew();
                        String TT = undolist.Pop().ToString();
                        String[] TT_NV = TT.Split('#');
                        text_cmnd.Text = TT_NV[0];
                        text_ho.Text = TT_NV[1];
                        text_ten.Text = TT_NV[2];
                        text_diaChi.Text = TT_NV[3];
                        cmb_phai.Text = TT_NV[4];
                        date_ngayCap.Text = TT_NV[5];
                        text_soDT.Text = TT_NV[6];
                        if (cmb_chiNhanh.SelectedValue.ToString().Contains("SERVER1"))
                        {
                            text_maCN.Text = "BENTHANH";
                        }
                        else
                        {
                            text_maCN.Text = "TANDINH";
                        }

                        this.bds_khachHang.EndEdit();
                        this.khachHangTableAdapter.Update(this.dS.KhachHang);
                        bds_khachHang.Position = bds_khachHang.Find("CMND", TT_NV[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (statement.Equals("EDIT"))
                {
                    try
                    {
                        String TT = undolist.Pop().ToString();
                        String[] TT_NV = TT.Split('#');

                        string lenh = "update[dbo].[KhachHang] set HO= '" + TT_NV[1] + "',TEN= '" + TT_NV[2] + "',DIACHI= '" + TT_NV[3] + "',PHAI= '"
                                        + TT_NV[4] + "',SODT= '" + TT_NV[5] + "',MACN= '" + text_maCN.Text.Trim() + "' where CMND = '" + TT_NV[0] + "'";

                        Program.ExecSqlNonQuery(lenh);
                        this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                        bds_khachHang.Position = bds_khachHang.Find("CMND", TT_NV[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else if (statement.Equals("INSERT"))
                {
                    String cmnd = undolist.Pop().ToString();
                    int vitri = bds_khachHang.Find("CMND", cmnd);
                    bds_khachHang.Position = vitri;
                    bds_khachHang.RemoveCurrent();
                }
                this.khachHangTableAdapter.Update(this.dS.KhachHang);
            }
            if (undolist.Count == 0) btn_phucHoi.Enabled = false;
        }
    }
}
