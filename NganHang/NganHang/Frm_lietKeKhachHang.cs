using DevExpress.XtraReports.UI;
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
    public partial class Frm_lietKeKhachHang : Form
    {
        string maCN;
        public Frm_lietKeKhachHang()
        {
            InitializeComponent();

        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            
            rptDSKhachHang rp = new rptDSKhachHang();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

    }
}
