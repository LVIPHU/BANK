using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NganHang
{
    public partial class Frm_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Frm_dangNhap f_dangNhap;
        private Frm_taoTaiKhoan f_taoTaikhoan;
        private Frm_nhanVien f_nhanVien;
        private Frm_khachHang f_khachHang;
        private Frm_taiKhoan f_taiKhoan;
        private Frm_goiRut f_goiRut;
        private Frm_chuyenTien f_chuyenTien;
        private Frm_lietKeTaiKhoan f_lietKeTaiKhoan;
        private Frm_lietKeKhachHang f_lietKeKhachHang;
        private Frm_saoKe f_saoKe;
        public Frm_main()
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

        private void barButtonItem_dangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup != "")
            {
                MessageBox.Show("Bạn chưa đăng xuất!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_taoTaiKhoan = this.CheckExists(typeof(Frm_taoTaiKhoan));
            if (frm_taoTaiKhoan != null)
                frm_taoTaiKhoan.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_lietKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_lietKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();

            Form frm = this.CheckExists(typeof(Frm_dangNhap));
            if (frm != null) frm.Activate();
            else
            {
                f_dangNhap = new Frm_dangNhap();
                f_dangNhap.MdiParent = this;
                f_dangNhap.f_main = this;
                f_dangNhap.Show();
            }
        }
        public void hienThongTinStatus()
        {
            status_ma.Text = "MaNV: " + Program.username;
            status_ten.Text = "TenNV: " + Program.mHoten;
            status_nhom.Text = "Nhom: " + Program.mGroup;

            Form frm_dangNhap = this.CheckExists(typeof(Frm_dangNhap));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
        }

        private void barButtonItem_dangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mHoten.Trim().Length == 0 || Program.mGroup.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa đăng nhập!", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_taoTaiKhoan = this.CheckExists(typeof(Frm_taoTaiKhoan));
            if (frm_taoTaiKhoan != null)
                frm_taoTaiKhoan.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_lietKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_lietKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();

            Program.myReader = null;
            Program.username = "";
            Program.mlogin = "";
            Program.password = "";
            Program.mloginDN = "";
            Program.passwordDN = "";
            Program.mGroup = "";
            Program.mHoten = "";
            Program.mCoso = 0;
            Frm_main f1 = new Frm_main();
            f1.hienThongTinStatus();
            status_ma.Text = "MaNV: ";
            status_ten.Text = "TenNV: ";
            status_nhom.Text = "Nhom: ";
            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK);
            return;
        }

        private void barButtonItem_nhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_dangNhap));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_taoTaiKhoan = this.CheckExists(typeof(Frm_taoTaiKhoan));
            if (frm_taoTaiKhoan != null)
                frm_taoTaiKhoan.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_lietKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_lietKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();

            Form frm = this.CheckExists(typeof(Frm_nhanVien));
            if (frm != null) frm.Activate();
            else
            {
                f_nhanVien = new Frm_nhanVien();
                f_nhanVien.MdiParent = this;
                f_nhanVien.Show();
            }
        }

        private void barButtonItem_khachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_dangNhap));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_taoTaiKhoan = this.CheckExists(typeof(Frm_taoTaiKhoan));
            if (frm_taoTaiKhoan != null)
                frm_taoTaiKhoan.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_lietKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_lietKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();

            Form frm = this.CheckExists(typeof(Frm_khachHang));
            Form frm2 = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                f_khachHang = new Frm_khachHang();
                f_khachHang.MdiParent = this;
                f_khachHang.Show();
            }
            if (frm2 != null) frm2.Activate();
            else
            {
                f_taiKhoan = new Frm_taiKhoan();
                f_taiKhoan.MdiParent = this;
                f_taiKhoan.Show();
            }
        }

        private void barButtonItem_GDGuiRut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_dangNhap));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_taoTaiKhoan = this.CheckExists(typeof(Frm_taoTaiKhoan));
            if (frm_taoTaiKhoan != null)
                frm_taoTaiKhoan.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_lietKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_lietKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();

            Form frm = this.CheckExists(typeof(Frm_goiRut));
            if (frm != null) frm.Activate();
            else
            {
                f_goiRut = new Frm_goiRut();
                f_goiRut.MdiParent = this;
                f_goiRut.Show();
            }
        }

        private void barButtonItem_GDChuyenTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_dangNhap));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_taoTaiKhoan = this.CheckExists(typeof(Frm_taoTaiKhoan));
            if (frm_taoTaiKhoan != null)
                frm_taoTaiKhoan.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_lietKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_lietKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();

            Form frm = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm != null) frm.Activate();
            else
            {
                f_chuyenTien = new Frm_chuyenTien();
                f_chuyenTien.MdiParent = this;
                f_chuyenTien.Show();
            }
        }

        private void btn_lietKeKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_dangNhap = this.CheckExists(typeof(Frm_dangNhap));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_taoTaiKhoan = this.CheckExists(typeof(Frm_taoTaiKhoan));
            if (frm_taoTaiKhoan != null)
                frm_taoTaiKhoan.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_lietKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();

            rptDSKhachHang rp = new rptDSKhachHang();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void btn_lietKeTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_dangNhap));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_taoTaiKhoan = this.CheckExists(typeof(Frm_taoTaiKhoan));
            if (frm_taoTaiKhoan != null)
                frm_taoTaiKhoan.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_lietKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();

            Form frm = this.CheckExists(typeof(Frm_lietKeTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                f_lietKeTaiKhoan = new Frm_lietKeTaiKhoan();
                f_lietKeTaiKhoan.MdiParent = this;
                f_lietKeTaiKhoan.Show();
            }
        }

        private void btn_saoKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_dangNhap));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_taoTaiKhoan = this.CheckExists(typeof(Frm_taoTaiKhoan));
            if (frm_taoTaiKhoan != null)
                frm_taoTaiKhoan.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_lietKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_lietKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();

            Form frm = this.CheckExists(typeof(Frm_saoKe));
            if (frm != null) frm.Activate();
            else
            {
                f_saoKe = new Frm_saoKe();
                f_saoKe.MdiParent = this;
                f_saoKe.Show();
            }
        }

        private void barButtonItem_taoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }

            Form frm_dangNhap = this.CheckExists(typeof(Frm_dangNhap));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_lietKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_lietKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();

            Form frm = this.CheckExists(typeof(Frm_taoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                f_taoTaikhoan = new Frm_taoTaiKhoan();
                f_taoTaikhoan.MdiParent = this;
                f_taoTaikhoan.Show();
            }

        }
    }
}
