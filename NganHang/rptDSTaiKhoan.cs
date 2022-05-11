using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace NganHang
{
    public partial class rptDSTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {

            public rptDSTaiKhoan(string cn, string ngay1, string ngay2)
            {
                InitializeComponent();
                try
                {
                    this.sqlDataSource4.Connection.ConnectionString = Program.connstr;
                    this.sqlDataSource4.Queries[0].Parameters[0].Value = cn;
                    this.sqlDataSource4.Queries[0].Parameters[1].Value = ngay1;
                    this.sqlDataSource4.Queries[0].Parameters[2].Value = ngay2;
                    this.sqlDataSource4.Fill();

                    this.from.Text = ngay1;
                    this.to.Text = ngay2;
                    this.branch.Text = cn;
                    if (Program.mCoso == 0)
                        this.branch.Text = "Bến Thành";
                    else if (Program.mCoso == 1)
                        this.branch.Text = "Tân Định";
                } catch (Exception ex) {
                    MessageBox.Show("Tải báo cáo không thành công. Vui lòng kiểm tra lại thông tin!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
       

    }
}
