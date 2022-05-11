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

namespace NganHang
{
    public partial class Frm_khachHang : Form
    {
        private string phai = "";
        private Boolean isSua=false;
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
        }

        private void btn_ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (text_cmnd.Text.Trim().Length == 0)
            {
                MessageBox.Show("CMND không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_cmnd.Focus();
                return;
            }
            Regex regCmnd = new Regex(@"\d");
            if (text_cmnd.Text.Trim().Length > 10)
            {
                MessageBox.Show("Nhập sai định dạng CMND!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_cmnd.Focus();
                return;
            }
            if (text_ho.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ nhân viên không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_ho.Focus();
                return;
            }
            if (text_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên nhân viên không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            try
            {
                if (!isSua)
                {
                    string strLenh = "DECLARE @return_value int " +
                                "EXEC @return_value = [dbo].[SP_CHECKCMNDEXISTS] " +
                                "@CMND = " + text_cmnd.Text.Trim() + " " +
                                "SELECT 'Return Value' = @return_value";

                    SqlDataReader dataReader = null;
                    dataReader = Program.ExecSqlDataReader(strLenh);
                    // Đọc và lấy 
                    dataReader.Read();
                    int result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();

                    MessageBox.Show("Khách hàng này đã tồn tại! '" + result + "'", "Thông báo", MessageBoxButtons.OK);

                    if (result == 1)
                    {
                        MessageBox.Show("Khách hàng này đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        text_cmnd.Focus();
                        return;
                    }
                }

                cmb_phai.Text = phai;
                bds_khachHang.EndEdit();
                this.khachHangTableAdapter.Update(this.dS.KhachHang);
                this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                groupControl_khachHang.Enabled = false;
                btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = true;
                btn_ghi.Enabled = btn_huy.Enabled = false;
                khachHangGridControl.Enabled = true;
                isSua = false;
                if (Program.mGroup.Equals("NGANHANG"))
                {
                    groupControl_chiNhanh.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi khách hàng\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {   
                string cmnd="";
                string strLenh = "DECLARE @return_value int " +
                              "EXEC @return_value = [dbo].[SP_CHECKCUSHAVEACCOUNTS] " +
                              "@CMND = " + text_cmnd.Text.Trim() + " " +
                              "SELECT 'Return Value' = @return_value";

                SqlDataReader dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                // Đọc và lấy 
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();

                if (result == 1)
                {
                    MessageBox.Show("Không thể xóa người dùng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        cmnd = ((DataRowView)bds_khachHang[bds_khachHang.Position])["CMND"].ToString();

                        bds_khachHang.RemoveCurrent();
                        this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.khachHangTableAdapter.Update(this.dS.KhachHang);
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
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = true;
            btn_ghi.Enabled = btn_huy.Enabled = false;
            khachHangGridControl.Enabled = true;
            isSua = false;
            if (Program.mGroup == "NGANHANG")
            {
                groupControl_chiNhanh.Enabled = true;
            }
        }

        private void btn_sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isSua = true;
            text_cmnd.Enabled = false;
            groupControl_khachHang.Enabled = true;
            groupControl_chiNhanh.Enabled = false;
            khachHangGridControl.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = false;
            btn_ghi.Enabled = btn_phucHoi.Enabled = btn_huy.Enabled = true;
            
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
    }
}
