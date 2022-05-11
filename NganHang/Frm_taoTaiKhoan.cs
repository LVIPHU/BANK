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
    public partial class Frm_taoTaiKhoan : Form
    {
        public Frm_taoTaiKhoan()
        {
            InitializeComponent();
        }

        private void Frm_taoTaiKhoan_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dS_DSPHANMANH.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPHANMANH.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dS_NHANVIEN.V_DS_NHANVIEN' table. You can move, or remove it, as needed.
            this.v_DS_NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_NHANVIENTableAdapter.Fill(this.dS_NHANVIEN.V_DS_NHANVIEN);

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

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            if (text_loginName.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_loginName.Focus();
                return;
            }
            if (text_password.Text.Trim() == "")
            {
                MessageBox.Show("Password không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_password.Focus();
                return;
            }
            if ((string)cmb_nhanVien.SelectedValue == "")
            {
                MessageBox.Show("Hiện không có nhân viên nào cần tạo tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_password.Focus();
                return;
            }

            String login = text_loginName.Text.Trim();
            String password = text_password.Text.Trim();
            String username = (string)cmb_nhanVien.SelectedValue;
            String role = "";

            if (Program.mGroup == "CHINHANH") role = "CHINHANH";
            else
            {
                role = "NGANHANG";
            }
            try
            {
                string strLenh = "DECLARE @return_value int " +
                            "EXEC @return_value = [dbo].[SP_TAOACCOUNT] " +
                            "@LGNAME= " + login + ", " +
                            "@PASS = " + password + ", " +
                            "@USERNAME = " + username + ", " +
                            "@ROLE = " + role + " " +
                            "SELECT 'Return Value' = @return_value";

                SqlDataReader dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                // Đọc và lấy 
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
                if (result == 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo",
                    MessageBoxButtons.OK);
                    cmb_nhanVien.Refresh();
                    return;
                }
                else if (result == 1)
                {
                    MessageBox.Show("Login name này đã có người sử dụng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_loginName.Focus();
                    return;
                }
                else if (result == 2)
                {
                    MessageBox.Show("Người này đã có tài khoản!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmb_nhanVien.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi tài khoản\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
