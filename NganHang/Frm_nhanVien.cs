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
using System.Collections;
using System.Text.RegularExpressions;

namespace NganHang
{
    public partial class Frm_nhanVien : Form
    {

        string phai="";
        private Boolean isSua = false;
        int position = 0;
        string NV_info = "";
        public Frm_nhanVien()
        {
            InitializeComponent();
        }

        private void Frm_nhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                dS.EnforceConstraints = false;
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

                cmb_chiNhanh.DataSource = Program.bds_dspm;
                cmb_chiNhanh.DisplayMember = "TENCN";
                cmb_chiNhanh.ValueMember = "TENSERVER";
                cmb_chiNhanh.SelectedIndex = Program.mCoso;

                cmb_phai.Items.Add("Nam");
                cmb_phai.Items.Add("Nữ");

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
                    btn_chuyenChiNhanh.Enabled = false;
                }
                groupControl_nhanVien.Enabled = false;
                btn_ghi.Enabled = btn_huy.Enabled = btn_phucHoi.Enabled = false;
                if (bds_nhanVien.Count == 0)
                {
                    btn_xoa.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tải dữ liệu không thành công!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            btn_chuyenChiNhanh.Enabled = false;
            bds_nhanVien.AddNew();
            if(cmb_chiNhanh.SelectedValue.ToString().Contains("SERVER1"))
            {
                text_maCN.Text = "BENTHANH";
            }
            else
            {
                text_maCN.Text = "TANDINH";
            }
            cmb_phai.SelectedIndex = 1;
            cmb_phai.SelectedIndex = 0;
            groupControl_nhanVien.Enabled = true;
            nhanVienGridControl.Enabled = false;
            label_trangThaiXoa.Text = "0";
            text_maNV.Focus();

/*            lbl_maNV.ForeColor = Color.DarkGray;
            lbl_maNV.Cursor = Cursors.IBeam;
            if (lbl_maNV.Location.Y == 75)
                lbl_maNV.Location = new Point(lbl_maNV.Location.X, lbl_maNV.Location.Y + 25);*/

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
        }

        private void btn_ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (text_maNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã nhân viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                text_maNV.Focus();
                return;
            }
            String mnvPattern = "\\w";
            if (!Regex.IsMatch(text_maNV.Text.Trim(), mnvPattern) || text_maNV.Text.Trim().Length > 10)
            {
                MessageBox.Show("Nhập sai định dạng Mã nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_maNV.Focus();
                return;
            }
            String hoten = "[a-zA-Z]";
            if (text_ho.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ nhân viên không được trống!", "Lỗi", MessageBoxButtons.OK);
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
                MessageBox.Show("Tên nhân viên không được trống!", "Lỗi", MessageBoxButtons.OK);
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
                MessageBox.Show("Địa chỉ không được trống!", "Lỗi", MessageBoxButtons.OK);
                text_diaChi.Focus();
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
                if (!isSua)
                {
                    string strLenh = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CHECKNVEXISTS] " +
                               "@MANV = " + text_maNV.Text.Trim() + " " +
                               "SELECT 'Return Value' = @return_value";

                    SqlDataReader dataReader = null;
                    dataReader = Program.ExecSqlDataReader(strLenh);
                    // Đọc và lấy 
                    dataReader.Read();
                    int result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();

                    if (result == 1)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        text_maNV.Focus();
                        return;
                    }
                }
                String maNV = text_maNV.Text.Trim();
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    if (!isSua)
                    {
                        btn_phucHoi.Enabled = true;
                        undolist.Push(maNV);
                        undolist.Push("INSERT");
                    } else
                    {
                        btn_phucHoi.Enabled = true;
                        undolist.Push(NV_info);
                        undolist.Push("EDIT");
                    }
                    cmb_phai.Text = phai;
                    bds_nhanVien.EndEdit();
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    groupControl_nhanVien.Enabled = false;
                    btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btn_reload.Enabled  = btn_chuyenChiNhanh.Enabled = true;
                    btn_ghi.Enabled = btn_huy.Enabled = false;
                    nhanVienGridControl.Enabled = true;
                    text_maNV.Enabled = true;
                    isSua = false;
                    MessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bds_nhanVien.Position = bds_nhanVien.Find("MANV", maNV);
                }

                if (Program.mGroup.Equals("NGANHANG"))
                {
                    groupControl_chiNhanh.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu không thành công vui lòng kiểm tra thông tin nhân viên!\n"+ ex.Message, 
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        

        private void cmb_chiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void xoa_nhan_vien(string maNV)
        {
            try
            {
                string lenh = "update[dbo].[NhanVien] set TrangThaiXoa = 1 where MANV = '" + maNV + "'";
                Program.ExecSqlNonQuery(lenh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa nhân viên thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maNV = "";

            String trangThaiXoa;
            trangThaiXoa = ((DataRowView)bds_nhanVien[bds_nhanVien.Position])["TrangThaiXoa"].ToString();

            if (trangThaiXoa == "1")
            {
                MessageBox.Show("Nhân viên đã bị xoá!", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            if (bds_nhanVien.Count == 0)
            {
                MessageBox.Show("Không có nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK);
                btn_xoa.Enabled = false;
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        maNV = ((DataRowView)bds_nhanVien[bds_nhanVien.Position])["MANV"].ToString();
                        String NV_info = text_maNV.Text.Trim() + "#" + text_ho.Text.Trim() + "#" + text_ten.Text.Trim() + "#" +
                           text_diaChi.Text.Trim() + "#" + cmb_phai.SelectedItem.ToString() + "#" + text_soDT.Text.Trim();
                        bds_nhanVien.RemoveCurrent();
                        xoa_nhan_vien(maNV);
                        btn_phucHoi.Enabled = true;
                        undolist.Push(NV_info);
                        undolist.Push("DELETE");
                        this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa nhân viên. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                        bds_nhanVien.Position = bds_nhanVien.Find("MANV", maNV);
                        return;
                    }
                }
            }
        }

        private void btn_sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isSua = true;
            String trangThaiXoa;
            trangThaiXoa = ((DataRowView)bds_nhanVien[bds_nhanVien.Position])["TrangThaiXoa"].ToString();
            
            if (trangThaiXoa == "1")
            {
                MessageBox.Show("Nhân viên đã bị xoá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            NV_info = text_maNV.Text.Trim() + "#" + text_ho.Text.Trim() + "#" + text_ten.Text.Trim() + "#" +
               text_diaChi.Text.Trim() + "#" + cmb_phai.SelectedItem.ToString() + "#" + text_soDT.Text.Trim();
            text_maNV.Enabled = false;
            groupControl_nhanVien.Enabled = true;
            groupControl_chiNhanh.Enabled = false;
            nhanVienGridControl.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btn_reload.Enabled = btn_chuyenChiNhanh.Enabled = false;
            btn_ghi.Enabled = btn_huy.Enabled = true;
        }

        private void cmb_phai_SelectedIndexChanged(object sender, EventArgs e)
        { 
            phai = cmb_phai.SelectedItem.ToString();
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_nhanVien.RemoveCurrent();
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            groupControl_nhanVien.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btn_reload.Enabled = btn_chuyenChiNhanh.Enabled = true;
            btn_ghi.Enabled = btn_huy.Enabled = false;
            nhanVienGridControl.Enabled = true;
            text_maNV.Enabled = true;
            if (Program.mGroup == "NGANHANG")
            {
                groupControl_chiNhanh.Enabled = true;
            }

            pnl_maNV.ForeColor = Color.DarkGray;
            lbl_maNV.ForeColor = Color.Black;
            lbl_maNV.Cursor = Cursors.Arrow;
            if (lbl_maNV.Location.Y == 100)
                lbl_maNV.Location = new Point(lbl_maNV.Location.X, lbl_maNV.Location.Y - 25);

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
        }

        String cnChuyen;
        Stack undolist = new Stack();
        public void GETVALUE(String index)
        {
            cnChuyen = index;
          
            if (cnChuyen != Program.servername)
            {
                String maCN = "";
                if (cnChuyen.Contains("2")) maCN = "TANDINH";
                else if (cnChuyen.Contains("1")) maCN = "BENTHANH";

                String maNV = ((DataRowView)bds_nhanVien[bds_nhanVien.Position])["MANV"].ToString();
                try
                {
                    string strLenh = "DECLARE @return_value int " +
                              "EXEC @return_value = [dbo].[SP_CHUYENCHINHANH_NV] " +
                              "@MANV = " + maNV + "," +
                               "@MACN = " + maCN + " " +
                              "SELECT 'Return Value' = @return_value";

                    SqlDataReader dataReader = null;
                    dataReader = Program.ExecSqlDataReader(strLenh);
                    // Đọc và lấy 
                    dataReader.Read();
                    int result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();
                    MessageBox.Show("Chuyển nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    undolist.Push(maNV + "#" + cnChuyen);
                    undolist.Push("CHUYENCN");
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    btn_phucHoi.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else MessageBox.Show("Vui lòng chọn CN khác chi nhánh hiện tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_chuyenChiNhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int trangThaiXoa = int.Parse(((DataRowView)bds_nhanVien[bds_nhanVien.Position])["TrangThaiXoa"].ToString());
                if (trangThaiXoa == 0)
                {
                    Frm_chuyenChiNhanh pickCN = new Frm_chuyenChiNhanh();
                    pickCN.mydata = new Frm_chuyenChiNhanh.GETDATA(GETVALUE);
                    pickCN.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nhân viên hiện không có ở chi nhánh này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chuyển nhân viên thất bại!\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                this.nhanVienTableAdapter.Update(this.dS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Event cho TextEdit

        private void lbl_maNV_Click(object sender, EventArgs e)
        {
            if (lbl_maNV.Location.Y == 100)
            {
                lbl_maNV.Font = new Font("Segoe UI", 8);
                lbl_maNV.Cursor = Cursors.Arrow;
                lbl_maNV.Location = new Point(lbl_maNV.Location.X, lbl_maNV.Location.Y - 25);
                text_maNV.Focus();
            }
        }

        private void text_maNV_Enter(object sender, EventArgs e)
        {
            pnl_maNV.BackColor = Color.Teal;
            lbl_maNV.ForeColor = Color.Teal;
            if (lbl_maNV.Location.Y != 75)
            {
                lbl_maNV.Font = new Font("Segoe UI", 8);
                lbl_maNV.Cursor = Cursors.Arrow;
                lbl_maNV.Location = new Point(lbl_maNV.Location.X, lbl_maNV.Location.Y - 25);
            }
        }

        private void text_maNV_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_maNV.Text) && lbl_maNV.Location.Y == 75)
            {
                pnl_maNV.BackColor = Color.DarkGray;
                lbl_maNV.ForeColor = Color.DarkGray;
                text_maNV.ResetText();
                lbl_maNV.Font = new Font("Segoe UI", 9);
                lbl_maNV.Cursor = Cursors.IBeam;
                lbl_maNV.Location = new Point(lbl_maNV.Location.X, lbl_maNV.Location.Y + 25);
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

        private void btn_phucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undolist.Count > 0)
            {
                String statement = undolist.Pop().ToString();
                if (statement.Equals("DELETE"))
                {
                    String TT = undolist.Pop().ToString();
                    String[] TT_NV = TT.Split('#');
                   
                    try
                    {
                        string lenh = "update[dbo].[NhanVien] set TrangThaiXoa = 0 where MANV = '" + TT_NV[0] + "'";
                        Program.ExecSqlNonQuery(lenh);
                        this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                        bds_nhanVien.Position = bds_nhanVien.Find("MANV", TT_NV[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (statement.Equals("EDIT"))
                {
                   try
                    {
                        String TT = undolist.Pop().ToString();
                        String[] TT_NV = TT.Split('#');

                        string lenh = "update[dbo].[NhanVien] set HO= '" + TT_NV[1] + "',TEN= '" + TT_NV[2] + "',DIACHI= '" + TT_NV[3] + "',PHAI= '"
                                        + TT_NV[4] + "',SODT= '" + TT_NV[5] + "',MACN= '" + text_maCN.Text.Trim() + "',TrangThaiXoa = 0 where MANV = '" + TT_NV[0] + "'";
                        
                        Program.ExecSqlNonQuery(lenh);
                        this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                        bds_nhanVien.Position = bds_nhanVien.Find("MANV", TT_NV[0]);
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    } 
                    
                }
                else if (statement.Equals("INSERT"))
                {
                    String maNV = undolist.Pop().ToString();
                    int vitri = bds_nhanVien.Find("MANV", maNV);
                    bds_nhanVien.Position = vitri;
                    bds_nhanVien.RemoveCurrent();
                }
                else if (statement.Equals("CHUYENCN"))
                {
                    String info = undolist.Pop().ToString();
                    String[] info_CN = info.Split('#');
                    Console.WriteLine(info_CN[0] + " " + info_CN[1]);
                    String servername_temp = Program.servername;

                    Program.servername = info_CN[1].ToString();

                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;

                    if (Program.KetNoi() == 0)
                        MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                    String maNV = info_CN[0].ToString();
                    String maCN = "";
                    if (info_CN[1].ToString().Contains("2")) maCN = "BENTHANH";
                    else if (info_CN[1].ToString().Contains("1")) maCN = "TANDINH";

                    Program.conn = new SqlConnection(Program.connstr);
                    Program.conn.Open();

                    string strLenh = "DECLARE @return_value int " +
                              "EXEC @return_value = [dbo].[SP_CHUYENCHINHANH_NV] " +
                              "@MANV = " + maNV + "," +
                               "@MACN = " + maCN + " " +
                              "SELECT 'Return Value' = @return_value";

                    SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
                    sqlcmd.CommandType = CommandType.Text;
                    SqlDataReader myReader = null;
                    try
                    {
                        myReader = sqlcmd.ExecuteReader();
                        MessageBox.Show("Chuyển nhân viên trở về thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    finally
                    {
                        if (Program.servername != servername_temp)
                        {
                            Program.servername = servername_temp;
                            Program.mlogin = Program.mloginDN;
                            Program.password = Program.passwordDN;
                            if (Program.KetNoi() == 0)
                                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                        }

                    }

                }
                this.nhanVienTableAdapter.Update(this.dS.NhanVien);
            }
            if (undolist.Count == 0) btn_phucHoi.Enabled = false;
        }


    }
}
