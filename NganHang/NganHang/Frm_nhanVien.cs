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

namespace NganHang
{
    public partial class Frm_nhanVien : Form
    {

        string phai="";
        private Boolean isSua = false;
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
        }

        private void btn_ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (text_maNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã nhân viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                text_maNV.Focus();
                return;
            }
            if (text_ho.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ nhân viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                text_ho.Focus();
                return;
            }
            if (text_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên nhân viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                text_ten.Focus();
                return;
            }
            if (text_diaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa chỉ không được trống!", "Lỗi", MessageBoxButtons.OK);
                text_diaChi.Focus();
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

                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    cmb_phai.Text = phai;
                    bds_nhanVien.EndEdit();
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    groupControl_nhanVien.Enabled = false;
                    btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = true;
                    btn_ghi.Enabled = btn_huy.Enabled = false;
                    nhanVienGridControl.Enabled = true;
                    text_maNV.Enabled = true;
                    isSua = false;
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
                        bds_nhanVien.RemoveCurrent();
                        xoa_nhan_vien(maNV);
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
            text_maNV.Enabled = false;
            groupControl_nhanVien.Enabled = true;
            groupControl_chiNhanh.Enabled = false;
            nhanVienGridControl.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = false;
            btn_ghi.Enabled = btn_phucHoi.Enabled = btn_huy.Enabled = true;
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
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = true;
            btn_ghi.Enabled = btn_huy.Enabled = false;
            nhanVienGridControl.Enabled = true;
            text_maNV.Enabled = true;
            if (Program.mGroup == "NGANHANG")
            {
                groupControl_chiNhanh.Enabled = true;
            }
        }

        private void btn_chuyenChiNhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_chuyenChiNhanh pickCN = new Frm_chuyenChiNhanh();
            pickCN.ShowDialog();
        }
    }
}
