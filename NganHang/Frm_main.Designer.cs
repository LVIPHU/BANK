namespace NganHang
{
    partial class Frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem_dangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_dangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_khachHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_nhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_GDGuiRut = new DevExpress.XtraBars.BarButtonItem();
            this.btn_saoKe = new DevExpress.XtraBars.BarButtonItem();
            this.btn_lietKeTK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_GDChuyenTien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_lietKeKH = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage_login = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_login = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_chucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_khacHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_thongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_thongKe = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_ma = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_ten = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_nhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem_taoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem_dangNhap,
            this.barButtonItem_dangXuat,
            this.barButtonItem_khachHang,
            this.barButtonItem_nhanVien,
            this.barButtonItem_GDGuiRut,
            this.btn_saoKe,
            this.btn_lietKeTK,
            this.barButtonItem_GDChuyenTien,
            this.btn_lietKeKH,
            this.barButtonItem_taoTaiKhoan});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_login,
            this.ribbonPage_chucNang,
            this.ribbonPage_thongKe});
            this.ribbonControl1.Size = new System.Drawing.Size(1332, 158);
            // 
            // barButtonItem_dangNhap
            // 
            this.barButtonItem_dangNhap.Caption = "Đăng nhập";
            this.barButtonItem_dangNhap.Id = 1;
            this.barButtonItem_dangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_dangNhap.ImageOptions.SvgImage")));
            this.barButtonItem_dangNhap.Name = "barButtonItem_dangNhap";
            this.barButtonItem_dangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_dangNhap_ItemClick);
            // 
            // barButtonItem_dangXuat
            // 
            this.barButtonItem_dangXuat.Caption = "Đăng xuất";
            this.barButtonItem_dangXuat.Id = 2;
            this.barButtonItem_dangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_dangXuat.ImageOptions.SvgImage")));
            this.barButtonItem_dangXuat.Name = "barButtonItem_dangXuat";
            this.barButtonItem_dangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_dangXuat_ItemClick);
            // 
            // barButtonItem_khachHang
            // 
            this.barButtonItem_khachHang.Caption = "Khách hàng";
            this.barButtonItem_khachHang.Id = 3;
            this.barButtonItem_khachHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_khachHang.ImageOptions.SvgImage")));
            this.barButtonItem_khachHang.Name = "barButtonItem_khachHang";
            this.barButtonItem_khachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_khachHang_ItemClick);
            // 
            // barButtonItem_nhanVien
            // 
            this.barButtonItem_nhanVien.Caption = "Nhân viên";
            this.barButtonItem_nhanVien.Id = 6;
            this.barButtonItem_nhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_nhanVien.ImageOptions.SvgImage")));
            this.barButtonItem_nhanVien.Name = "barButtonItem_nhanVien";
            this.barButtonItem_nhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_nhanVien_ItemClick);
            // 
            // barButtonItem_GDGuiRut
            // 
            this.barButtonItem_GDGuiRut.Caption = "GD Gửi Rút";
            this.barButtonItem_GDGuiRut.Id = 7;
            this.barButtonItem_GDGuiRut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_GDGuiRut.ImageOptions.SvgImage")));
            this.barButtonItem_GDGuiRut.Name = "barButtonItem_GDGuiRut";
            this.barButtonItem_GDGuiRut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_GDGuiRut_ItemClick);
            // 
            // btn_saoKe
            // 
            this.btn_saoKe.Caption = "Sao kê GD";
            this.btn_saoKe.Id = 8;
            this.btn_saoKe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_saoKe.ImageOptions.SvgImage")));
            this.btn_saoKe.Name = "btn_saoKe";
            this.btn_saoKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_saoKe_ItemClick);
            // 
            // btn_lietKeTK
            // 
            this.btn_lietKeTK.Caption = "Liệt kê TK";
            this.btn_lietKeTK.Id = 9;
            this.btn_lietKeTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_lietKeTK.ImageOptions.SvgImage")));
            this.btn_lietKeTK.Name = "btn_lietKeTK";
            this.btn_lietKeTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_lietKeTK_ItemClick);
            // 
            // barButtonItem_GDChuyenTien
            // 
            this.barButtonItem_GDChuyenTien.Caption = "GD Chuyển tiền";
            this.barButtonItem_GDChuyenTien.Id = 10;
            this.barButtonItem_GDChuyenTien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_GDChuyenTien.ImageOptions.SvgImage")));
            this.barButtonItem_GDChuyenTien.Name = "barButtonItem_GDChuyenTien";
            this.barButtonItem_GDChuyenTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_GDChuyenTien_ItemClick);
            // 
            // btn_lietKeKH
            // 
            this.btn_lietKeKH.Caption = "Liệt kê KH";
            this.btn_lietKeKH.Id = 11;
            this.btn_lietKeKH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_lietKeKH.ImageOptions.SvgImage")));
            this.btn_lietKeKH.Name = "btn_lietKeKH";
            this.btn_lietKeKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_lietKeKH_ItemClick);
            // 
            // ribbonPage_login
            // 
            this.ribbonPage_login.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_login});
            this.ribbonPage_login.Name = "ribbonPage_login";
            this.ribbonPage_login.Text = "Login";
            // 
            // ribbonPageGroup_login
            // 
            this.ribbonPageGroup_login.ItemLinks.Add(this.barButtonItem_dangNhap);
            this.ribbonPageGroup_login.ItemLinks.Add(this.barButtonItem_taoTaiKhoan);
            this.ribbonPageGroup_login.ItemLinks.Add(this.barButtonItem_dangXuat);
            this.ribbonPageGroup_login.Name = "ribbonPageGroup_login";
            // 
            // ribbonPage_chucNang
            // 
            this.ribbonPage_chucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_khacHang});
            this.ribbonPage_chucNang.Name = "ribbonPage_chucNang";
            this.ribbonPage_chucNang.Text = "Chức năng";
            // 
            // ribbonPageGroup_khacHang
            // 
            this.ribbonPageGroup_khacHang.ItemLinks.Add(this.barButtonItem_khachHang);
            this.ribbonPageGroup_khacHang.ItemLinks.Add(this.barButtonItem_nhanVien);
            this.ribbonPageGroup_khacHang.ItemLinks.Add(this.barButtonItem_GDGuiRut);
            this.ribbonPageGroup_khacHang.ItemLinks.Add(this.barButtonItem_GDChuyenTien);
            this.ribbonPageGroup_khacHang.Name = "ribbonPageGroup_khacHang";
            // 
            // ribbonPage_thongKe
            // 
            this.ribbonPage_thongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_thongKe});
            this.ribbonPage_thongKe.Name = "ribbonPage_thongKe";
            this.ribbonPage_thongKe.Text = "Thống kê";
            // 
            // ribbonPageGroup_thongKe
            // 
            this.ribbonPageGroup_thongKe.ItemLinks.Add(this.btn_saoKe);
            this.ribbonPageGroup_thongKe.ItemLinks.Add(this.btn_lietKeTK);
            this.ribbonPageGroup_thongKe.ItemLinks.Add(this.btn_lietKeKH);
            this.ribbonPageGroup_thongKe.Name = "ribbonPageGroup_thongKe";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_ma,
            this.status_ten,
            this.status_nhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 695);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1332, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_ma
            // 
            this.status_ma.Name = "status_ma";
            this.status_ma.Size = new System.Drawing.Size(46, 17);
            this.status_ma.Text = "MaNV: ";
            // 
            // status_ten
            // 
            this.status_ten.Name = "status_ten";
            this.status_ten.Size = new System.Drawing.Size(47, 17);
            this.status_ten.Text = "TenNV: ";
            // 
            // status_nhom
            // 
            this.status_nhom.Name = "status_nhom";
            this.status_nhom.Size = new System.Drawing.Size(47, 17);
            this.status_nhom.Text = "Nhom: ";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem_taoTaiKhoan
            // 
            this.barButtonItem_taoTaiKhoan.Caption = "Thêm tài khoản";
            this.barButtonItem_taoTaiKhoan.Id = 12;
            this.barButtonItem_taoTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_taoTaiKhoan.ImageOptions.SvgImage")));
            this.barButtonItem_taoTaiKhoan.Name = "barButtonItem_taoTaiKhoan";
            this.barButtonItem_taoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_taoTaiKhoan_ItemClick);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 717);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Frm_main";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý ngân hàng";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_login;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_login;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_dangNhap;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_dangXuat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_ma;
        private System.Windows.Forms.ToolStripStatusLabel status_ten;
        private System.Windows.Forms.ToolStripStatusLabel status_nhom;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_chucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_khacHang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_khachHang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_nhanVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_GDGuiRut;
        private DevExpress.XtraBars.BarButtonItem btn_saoKe;
        private DevExpress.XtraBars.BarButtonItem btn_lietKeTK;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_thongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_thongKe;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_GDChuyenTien;
        private DevExpress.XtraBars.BarButtonItem btn_lietKeKH;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_taoTaiKhoan;
    }
}

