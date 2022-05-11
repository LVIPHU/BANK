using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            bds_GDchuyenTien.AddNew();
            date_ngayGD.EditValue = DateTime.Today;
            text_maNV.Text = Program.username.Trim();
            groupControl_chuyenTien.Enabled = true;
            groupControl_chiNhanh.Enabled = false;
            gD_CHUYENTIENGridControl.Enabled = false;
            text_soTien.Focus();
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


            try
            {
                //if (isThem)
                //{
                //    recovery.PushStack_ThemNV(text_maNV.Text);
                //    isThem = false;
                //}
                //else if (isSua)
                //{
                //    recovery.PushStack_SuaNV(text_maNV.Text);
                //    isSua = false;
                //}
                int result;
                string sql = "exec [dbo].[SP_GDCHUYENTIEN] '" + text_soTKChuyen.Text.Trim() + "' , '" + text_soTien.Value + "' , '" +   text_soTKNhan.Text.Trim() + "'";
                result = Program.ExecSqlNonQuery(sql);
                if (result != 0)
                {
                    MessageBox.Show("Giao dịch không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    bds_GDchuyenTien.RemoveCurrent();
                    this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
                    groupControl_chuyenTien.Enabled = false;
                    btn_them.Enabled = true;
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
            btn_them.Enabled = true;
            gD_CHUYENTIENGridControl.Enabled = true;
            if (Program.mGroup.Equals("NGANHANG"))
            {
                groupControl_chiNhanh.Enabled = true;
            }
        }
    }
}
