using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NganHang
{
    public partial class rptDSKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDSKhachHang()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();

        }

    }
}
