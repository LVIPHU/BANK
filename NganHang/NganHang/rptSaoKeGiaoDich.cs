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
            InitializeComponent();
            try
            {
                this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
                this.sqlDataSource2.Queries[0].Parameters[0].Value = sotk;
                this.sqlDataSource2.Queries[0].Parameters[1].Value = ngay1;
                this.sqlDataSource2.Queries[0].Parameters[2].Value = ngay2;
                this.sqlDataSource2.Fill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tải báo cáo không thành công. Vui lòng kiểm tra lại thông tin!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

    }
}
