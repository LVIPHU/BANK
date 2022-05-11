using DevExpress.XtraEditors;
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
    public partial class Frm_chuyenChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        public Frm_chuyenChiNhanh()
        {
            InitializeComponent();
        }

        private void Frm_chuyenCN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPHANMANH.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPHANMANH.V_DS_PHANMANH);
            cmb_chiNhanh.DisplayMember = "TENCN";
            cmb_chiNhanh.ValueMember = "TENSERVER";
            cmb_chiNhanh.SelectedIndex = Program.mCoso;

            if (cmb_chiNhanh.SelectedValue.ToString().Contains("SERVER1"))
            {
                cmb_chiNhanh.Text = "BENTHANH";
            }
            else
            {
                cmb_chiNhanh.Text = "TANDINH";
            }
        }

        public delegate void GETDATA(String index);
        public GETDATA mydata;
        private void btn_chuyen_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_chiNhanh.Text.Trim().Equals(""))
                {
                    cmb_chiNhanh.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Quá trình chuyển nhanh viên đang diễn ra vui lòng chờ trông giây lát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mydata(cmb_chiNhanh.SelectedValue.ToString());
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "" + "", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}