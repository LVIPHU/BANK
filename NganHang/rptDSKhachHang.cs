using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace NganHang
{
    public partial class rptDSKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDSKhachHang(string cn)
        {
            InitializeComponent();
            try
            {
                this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
                this.sqlDataSource1.Queries[0].Parameters[0].Value = cn;

                if (Program.mCoso == 0)
                    this.branch.Text = "Bến Thành";
                else if (Program.mCoso == 1)
                    this.branch.Text = "Tân Định";
                this.sqlDataSource1.Fill();
            } catch (Exception ex)
            {
                MessageBox.Show("Tải báo cáo không thành công. Vui lòng kiểm tra lại thông tin!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
