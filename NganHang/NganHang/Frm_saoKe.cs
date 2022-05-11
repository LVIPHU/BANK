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
    public partial class Frm_saoKe : Form
    {
        public Frm_saoKe()
        {
            InitializeComponent();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            string ngay1, ngay2,soTK;
            ngay1 = date_BD.Text;
            ngay2 = date_KT.Text;
            soTK = text_soTK.Text;
            rptSaoKeGiaoDich rp = new rptSaoKeGiaoDich(soTK,ngay1, ngay2);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }
    }
}
