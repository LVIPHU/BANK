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
    public partial class Frm_goiRut : Form
    {
        string loaiGD = "";
        string tenserver;
        public Frm_goiRut()
        {
            InitializeComponent();
        }

        private void gD_GOIRUTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_GDGoiRut.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Frm_goiRut_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);

            cmb_chiNhanh.DataSource = Program.bds_dspm;
            cmb_chiNhanh.DisplayMember = "TENCN";
            cmb_chiNhanh.ValueMember = "TENSERVER";
            cmb_chiNhanh.SelectedIndex = Program.mCoso;

            tenserver = Program.servername;

            if (Program.mGroup.Equals("CHINHANH"))
            {
                groupControl_chiNhanh.Enabled = false;
            }
            else
            {
                groupControl_chiNhanh.Enabled = true;
                btn_them.Enabled = false;
            }

            cmb_loaiGD.Items.Add("GT");
            cmb_loaiGD.Items.Add("RT");

            text_maNV.Enabled = false;
            date_ngayGD.Enabled = false;
            
            groupControl_goiRut.Enabled = false;
            

        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            btn_them.Enabled = false;
            bds_GDGoiRut.AddNew();
            cmb_loaiGD.SelectedIndex = 1;
            cmb_loaiGD.SelectedIndex = 0;
            date_ngayGD.EditValue = DateTime.Today;
            text_maNV.Text = Program.username.Trim();
            groupControl_goiRut.Enabled = true;
            groupControl_chiNhanh.Enabled = false;
            gD_GOIRUTGridControl.Enabled = false;
            text_soTK.Focus();
        }

        private void cmb_loaiGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaiGD = cmb_loaiGD.SelectedItem.ToString().Trim();
        }
        
        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            if (text_soTK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tài khoản không được trống!", "Lỗi", MessageBoxButtons.OK);
                text_soTK.Focus();
                return;
            }
            if (text_soTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tiền không được trống!", "Lỗi", MessageBoxButtons.OK);
                text_soTien.Focus();
                return;
            }
            
            try
            {
                string strLenh = "DECLARE @return_value int " +
                                "EXEC @return_value = [dbo].[SP_GDGOIRUT] " +
                                "@SOTIEN = " + text_soTien.Text.Trim() + "," +
                                 "@TYPE = " + cmb_loaiGD.Text.Trim() + "," +
                                 "@SOTK = " + text_soTK.Text.Trim() + " " +
                                "SELECT 'Return Value' = @return_value";

                SqlDataReader dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                // Đọc và lấy 
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();

                if (result == 0)
                {
                    MessageBox.Show("Giao dịch không thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (result == 1)
                {
                    MessageBox.Show("Giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_loaiGD.Text = loaiGD;
                    bds_GDGoiRut.EndEdit();
                    //this.gD_GOIRUTTableAdapter.Update(this.dS.GD_GOIRUT);
                    this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
                    groupControl_goiRut.Enabled = false;
                    btn_them.Enabled = true;
                    gD_GOIRUTGridControl.Enabled = true;
                    return;
                }

               if (Program.mGroup.Equals("NGANHANG"))
                {
                    groupControl_chiNhanh.Enabled = true;
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi phiên giao dịch\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);

            }
        }

        private void btn_huyBo_Click(object sender, EventArgs e)
        {
            bds_GDGoiRut.RemoveCurrent();
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
            groupControl_goiRut.Enabled = false;
            btn_them.Enabled = true;
            gD_GOIRUTGridControl.Enabled = true;
            if (Program.mGroup.Equals("NGANHANG"))
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
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
                if(tenserver != cmb_chiNhanh.SelectedValue.ToString())
                {
                    btn_them.Enabled = false;
                }
                else
                {
                    btn_them.Enabled = true;
                }
            }
        }

        private void btn_traCuu_Click(object sender, EventArgs e)
        {
            try
            {
                string strLenh = "EXEC SP_CheckStkExists '" + text_soTK.Text.Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                string traCuuSoTaiKhoan = Program.myReader.GetValue(0).ToString();
                Program.myReader.Close();
                Program.conn.Close();
                textBox_traCuu.Text = traCuuSoTaiKhoan;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
