using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace NganHang
{
    public partial class rptSaoKeGiaoDich : DevExpress.XtraReports.UI.XtraReport
    {
        public rptSaoKeGiaoDich(string sotk, string ngay1, string ngay2)
        {
          try
            {
                InitializeComponent();
                this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
                this.sqlDataSource2.Queries[0].Parameters[0].Value = sotk;
                this.sqlDataSource2.Queries[0].Parameters[1].Value = ngay1;
                this.sqlDataSource2.Queries[0].Parameters[2].Value = ngay2;
                this.sqlDataSource2.Queries[1].Parameters[0].Value = sotk;
                this.sqlDataSource2.Fill();
                this.from.Text = ngay1;
                this.to.Text = ngay2;

                if (Program.mCoso == 0)
                    this.branch.Text = "Bến Thành";
                else if (Program.mCoso == 1)
                    this.branch.Text = "Tân Định";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đang tải dữ liệu vui lòng đợi trong giây lát!\n", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
