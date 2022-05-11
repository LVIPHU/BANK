using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NganHang
{
    public partial class rptDSTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDSTaiKhoan(string ngay1, string ngay2, string cn)
        {
            InitializeComponent();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource2.Queries[0].Parameters[0].Value = ngay1;
            this.sqlDataSource2.Queries[0].Parameters[1].Value = ngay2;
            this.sqlDataSource2.Queries[0].Parameters[2].Value = cn;
            this.sqlDataSource2.Fill();
        }

    }
}
