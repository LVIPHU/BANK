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
            
            btn_them.Enabled = btn_reload.Enabled = false;
            bds_GDGoiRut.AddNew();
            cmb_loaiGD.SelectedIndex = 1;
            cmb_loaiGD.SelectedIndex = 0;
            date_ngayGD.EditValue = DateTime.Today;
            text_maNV.Text = Program.username.Trim();
            groupControl_goiRut.Enabled = true;
            groupControl_chiNhanh.Enabled = false;
            gD_GOIRUTGridControl.Enabled = false;
            text_soTK.Focus();

/*            lbl_soTK.ForeColor = Color.DarkGray;
            lbl_soTK.Cursor = Cursors.IBeam;
            if (lbl_soTK.Location.Y == 75)
                lbl_soTK.Location = new Point(lbl_soTK.Location.X, lbl_soTK.Location.Y + 25);*/

            lbl_soTien.ForeColor = Color.DarkGray;
            lbl_soTien.Cursor = Cursors.IBeam;
            if (lbl_soTien.Location.Y == 75)
                lbl_soTien.Location = new Point(lbl_soTien.Location.X, lbl_soTien.Location.Y + 25);
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
            int sotien = int.Parse(text_soTien.Text);
            if (sotien < 100000)
            {
                MessageBox.Show("Số tiền giao dịch tối thiểu 100000!", "Lỗi", MessageBoxButtons.OK);
                text_soTien.Focus();
                return;
            }

            try
            {
                if (cmb_loaiGD.Text.Trim().Equals("RT"))
                {
                    SqlDataReader dataReader = null;
                    string strCheckSoDu = "DECLARE	@return_value int " +
                                          "EXEC @return_value = [dbo].[SP_CHECKSODU] " +
                                            "@SOTIEN = " + text_soTien.Text.Trim() + "," +
                                            "@SOTK = " + text_soTK.Text.Trim() + " " +
                                            "SELECT 'Return Value' = @return_value";
                    dataReader = Program.ExecSqlDataReader(strCheckSoDu);
                    // Đọc và lấy 
                    dataReader.Read();
                    int resultSodu = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();
                    if (resultSodu == 1)
                    {
                        MessageBox.Show("Tài khoản không tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        text_soTK.Focus();
                        return;
                    }
                    else if (resultSodu == 2)
                    {
                        MessageBox.Show("Số dư không hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        text_soTien.Focus();
                        return;
                    }
                }

                string strLenh = "DECLARE @return_value int " +
                                "EXEC @return_value = [dbo].[SP_GDGOIRUT] " +
                                "@SOTIEN = " + text_soTien.Text.Trim() + "," +
                                 "@TYPE = " + cmb_loaiGD.Text.Trim() + "," +
                                 "@SOTK = " + text_soTK.Text.Trim() + " " +
                                "SELECT 'Return Value' = @return_value";

                int result = Program.ExecSqlNonQuery(strLenh);

                if (result != 0)
                {
                    MessageBox.Show("Số tài khoản không tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (result == 0)
                {
                    MessageBox.Show("Giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_loaiGD.Text = loaiGD;
                    bds_GDGoiRut.EndEdit();
                    //this.gD_GOIRUTTableAdapter.Update(this.dS.GD_GOIRUT);
                    this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
                    groupControl_goiRut.Enabled = false;
                    btn_them.Enabled = btn_reload.Enabled = true;
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
            btn_them.Enabled = btn_reload.Enabled = true;
            gD_GOIRUTGridControl.Enabled = true;
            if (Program.mGroup.Equals("NGANHANG"))
            {
                groupControl_chiNhanh.Enabled = true;
            }

            pnl_soTK.ForeColor = Color.DarkGray;
            lbl_soTK.ForeColor = Color.Black;
            lbl_soTK.Cursor = Cursors.Arrow;
            lbl_soTK.Font = new Font("Segoe UI", 9);
            if (lbl_soTK.Location.Y == 100)
                lbl_soTK.Location = new Point(lbl_soTK.Location.X, lbl_soTK.Location.Y - 25);

            pnl_soTien.ForeColor = Color.DarkGray;
            lbl_soTien.ForeColor = Color.Black;
            lbl_soTien.Cursor = Cursors.Arrow;
            lbl_soTien.Font = new Font("Segoe UI", 9);
            if (lbl_soTien.Location.Y == 100)
                lbl_soTien.Location = new Point(lbl_soTien.Location.X, lbl_soTien.Location.Y - 25);
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK);
            else
            {
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
            }
        }

/*        private void btn_traCuu_Click(object sender, EventArgs e)
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
        }*/

        private void lbl_soTK_Click(object sender, EventArgs e)
        {
            if (lbl_soTK.Location.Y == 100)
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
                pnl_soTK.BackColor = Color.DarkGray;
                lbl_soTK.ForeColor = Color.DarkGray;
                text_soTK.ResetText();
                lbl_soTK.Font = new Font("Segoe UI", 9);
                lbl_soTK.Cursor = Cursors.IBeam;
                lbl_soTK.Location = new Point(lbl_soTK.Location.X, lbl_soTK.Location.Y + 25);
            }
        }

        /* Event cho TextEdit */

        private void lbl_soTien_Click(object sender, EventArgs e)
        {
            if (lbl_soTien.Location.Y == 100)
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
            if (lbl_soTien.Location.Y != 75)
            {
                lbl_soTien.Font = new Font("Segoe UI", 8);
                lbl_soTien.Cursor = Cursors.Arrow;
                lbl_soTien.Location = new Point(lbl_soTien.Location.X, lbl_soTien.Location.Y - 25);
            }
        }

        private void text_soTien_Leave(object sender, EventArgs e)
        {
            if (text_soTien.Value == 0 && lbl_soTien.Location.Y == 75)
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
