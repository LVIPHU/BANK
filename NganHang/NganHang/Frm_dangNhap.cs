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
    public partial class Frm_dangNhap : Form
    {
        public Frm_main f_main;
        public Frm_dangNhap()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void Frm_dangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPHANMANH.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPHANMANH.V_DS_PHANMANH);
           
            string chuoiketnoi = "Data Source=DESKTOP-QJ10AES\\MSSQLSERVERMAIN;Initial Catalog=NGANHANG;Integrated Security=True";
            Program.conn.Close();
            Program.conn.ConnectionString = chuoiketnoi;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH");
            Program.bds_dspm.DataSource = dt;
            cmb_chiNhanh.DataSource = dt;
            cmb_chiNhanh.DisplayMember = "TENCN";
            cmb_chiNhanh.ValueMember = "TENSERVER";
            cmb_chiNhanh.SelectedIndex = 0;
           
        }

        private void cmb_chiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_chiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmb_chiNhanh.SelectedValue.ToString();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            if (text_userName.Text.Trim() == "" || text_passWord.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = text_userName.Text; Program.password = text_passWord.Text;
            if (Program.KetNoi() == 0) return;

            Program.mCoso = cmb_chiNhanh.SelectedIndex;

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();


            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            //Program.frmChinh.MANV.Text = "";
            MessageBox.Show("Nhân viên - Nhóm : " + Program.mHoten + " - " + Program.mGroup, "", MessageBoxButtons.OK);
            f_main.hienThongTinStatus();
            
        }
    }
}
