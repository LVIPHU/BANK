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
            if (text_cmnd.Text.Trim().Length == 0)
            {
                MessageBox.Show("CMND không được trống!", "Lỗi", MessageBoxButtons.OK);
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
            try
            {
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
                groupControl_taiKhoan.Enabled = false;
                btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = true;
                btn_ghi.Enabled = btn_huy.Enabled = false;
                taiKhoanGridControl.Enabled = true;
                if (Program.mGroup.Equals("NGANHANG"))
                {
                    groupControl_chiNhanh.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi ghi nhân viên\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);

            }
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_taiKhoan.RemoveCurrent();
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            groupControl_taiKhoan.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = true;
            btn_ghi.Enabled = btn_huy.Enabled = false;
            taiKhoanGridControl.Enabled = true;
            if (Program.mGroup == "NGANHANG")
            {
                groupControl_chiNhanh.Enabled = true;
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
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK);
            else
            {
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            }
        }

        private void btn_traCuu_Click(object sender, EventArgs e)
        {
            string strLenh = "EXEC SP_TraCuuKhachHang '" + text_cmnd.Text.Trim() + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            string traCuuKhachHang = Program.myReader.GetString(0);
            Program.myReader.Close();
            Program.conn.Close();
            textBox_traCuu.Text = traCuuKhachHang;
        }

        private void textBox_traCuu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
