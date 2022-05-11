namespace NganHang
{
    partial class Frm_nhanVien
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
            System.Windows.Forms.Label tENCNLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_nhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar_nhanVien = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_phucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ghi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_huy = new DevExpress.XtraBars.BarButtonItem();
            this.btn_chuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_reload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPHANMANH = new NganHang.DS_DSPHANMANH();
            this.v_DS_PHANMANHTableAdapter = new NganHang.DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new NganHang.DS_DSPHANMANHTableAdapters.TableAdapterManager();
            this.dS = new NganHang.DS();
            this.bds_nhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new NganHang.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager1 = new NganHang.DSTableAdapters.TableAdapterManager();
            this.groupControl_chiNhanh = new DevExpress.XtraEditors.GroupControl();
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_nhanVien = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_soDT = new System.Windows.Forms.Label();
            this.lbl_diaChi = new System.Windows.Forms.Label();
            this.lbl_ho = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.lbl_maNV = new System.Windows.Forms.Label();
            this.pnl_maCN = new System.Windows.Forms.Panel();
            this.pnl_diaChi = new System.Windows.Forms.Panel();
            this.pnl_soDT = new System.Windows.Forms.Panel();
            this.pnl_ten = new System.Windows.Forms.Panel();
            this.pnl_ho = new System.Windows.Forms.Panel();
            this.pnl_maNV = new System.Windows.Forms.Panel();
            this.text_maCN = new DevExpress.XtraEditors.TextEdit();
            this.label_trangThaiXoa = new System.Windows.Forms.Label();
            this.text_soDT = new DevExpress.XtraEditors.TextEdit();
            this.cmb_phai = new System.Windows.Forms.ComboBox();
            this.text_diaChi = new DevExpress.XtraEditors.TextEdit();
            this.text_ten = new DevExpress.XtraEditors.TextEdit();
            this.text_ho = new DevExpress.XtraEditors.TextEdit();
            this.text_maNV = new DevExpress.XtraEditors.TextEdit();
            tENCNLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_nhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).BeginInit();
            this.groupControl_chiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_nhanVien)).BeginInit();
            this.groupControl_nhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_maCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_soDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_diaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_ho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_maNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(65, 60);
            tENCNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(70, 17);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Chi nhánh";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(1100, 100);
            trangThaiXoaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(106, 17);
            trangThaiXoaLabel.TabIndex = 29;
            trangThaiXoaLabel.Text = "Trạng thái xoá: ";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar_nhanVien});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_them,
            this.btn_sua,
            this.btn_xoa,
            this.btn_phucHoi,
            this.btn_ghi,
            this.btn_huy,
            this.btn_chuyenChiNhanh,
            this.btn_reload});
            this.barManager1.MainMenu = this.bar_nhanVien;
            this.barManager1.MaxItemId = 9;
            // 
            // bar_nhanVien
            // 
            this.bar_nhanVien.BarName = "Main menu";
            this.bar_nhanVien.DockCol = 0;
            this.bar_nhanVien.DockRow = 0;
            this.bar_nhanVien.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar_nhanVien.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_them),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_phucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ghi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_huy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_chuyenChiNhanh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_reload)});
            this.bar_nhanVien.OptionsBar.MultiLine = true;
            this.bar_nhanVien.OptionsBar.UseWholeRow = true;
            this.bar_nhanVien.Text = "Main menu";
            // 
            // btn_them
            // 
            this.btn_them.Caption = "Thêm";
            this.btn_them.Id = 0;
            this.btn_them.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_them.ImageOptions.SvgImage")));
            this.btn_them.Name = "btn_them";
            this.btn_them.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_them_ItemClick);
            // 
            // btn_sua
            // 
            this.btn_sua.Caption = "Sửa";
            this.btn_sua.Id = 1;
            this.btn_sua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sua.ImageOptions.SvgImage")));
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_sua_ItemClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Caption = "Xoá";
            this.btn_xoa.Id = 2;
            this.btn_xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_xoa.ImageOptions.SvgImage")));
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_xoa_ItemClick);
            // 
            // btn_phucHoi
            // 
            this.btn_phucHoi.Caption = "Phục hồi";
            this.btn_phucHoi.Id = 3;
            this.btn_phucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_phucHoi.ImageOptions.SvgImage")));
            this.btn_phucHoi.Name = "btn_phucHoi";
            this.btn_phucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_phucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_phucHoi_ItemClick);
            // 
            // btn_ghi
            // 
            this.btn_ghi.Caption = "Ghi";
            this.btn_ghi.Id = 4;
            this.btn_ghi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ghi.ImageOptions.SvgImage")));
            this.btn_ghi.Name = "btn_ghi";
            this.btn_ghi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_ghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ghi_ItemClick);
            // 
            // btn_huy
            // 
            this.btn_huy.Caption = "Huỷ";
            this.btn_huy.Id = 5;
            this.btn_huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_huy.ImageOptions.SvgImage")));
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_huy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_huy_ItemClick);
            // 
            // btn_chuyenChiNhanh
            // 
            this.btn_chuyenChiNhanh.Caption = "Chuyển chi nhánh";
            this.btn_chuyenChiNhanh.Id = 7;
            this.btn_chuyenChiNhanh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_chuyenChiNhanh.ImageOptions.SvgImage")));
            this.btn_chuyenChiNhanh.Name = "btn_chuyenChiNhanh";
            this.btn_chuyenChiNhanh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_chuyenChiNhanh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_chuyenChiNhanh_ItemClick);
            // 
            // btn_reload
            // 
            this.btn_reload.Caption = "Reload";
            this.btn_reload.Id = 8;
            this.btn_reload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_reload.ImageOptions.SvgImage")));
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_reload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_reload_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1882, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 753);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1882, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 723);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1882, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 723);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.dS_DSPHANMANH;
            // 
            // dS_DSPHANMANH
            // 
            this.dS_DSPHANMANH.DataSetName = "DS_DSPHANMANH";
            this.dS_DSPHANMANH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = NganHang.DS_DSPHANMANHTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_nhanVien
            // 
            this.bds_nhanVien.DataMember = "NhanVien";
            this.bds_nhanVien.DataSource = this.dS;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChiNhanhTableAdapter = null;
            this.tableAdapterManager1.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager1.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager1.KhachHangTableAdapter = null;
            this.tableAdapterManager1.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager1.TaiKhoanTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = NganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupControl_chiNhanh
            // 
            this.groupControl_chiNhanh.Controls.Add(this.cmb_chiNhanh);
            this.groupControl_chiNhanh.Controls.Add(tENCNLabel);
            this.groupControl_chiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_chiNhanh.Location = new System.Drawing.Point(0, 30);
            this.groupControl_chiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl_chiNhanh.Name = "groupControl_chiNhanh";
            this.groupControl_chiNhanh.Size = new System.Drawing.Size(1882, 110);
            this.groupControl_chiNhanh.TabIndex = 15;
            this.groupControl_chiNhanh.Text = "CHI NHÁNH";
            // 
            // cmb_chiNhanh
            // 
            this.cmb_chiNhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DS_PHANMANHBindingSource, "TENCN", true));
            this.cmb_chiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chiNhanh.FormattingEnabled = true;
            this.cmb_chiNhanh.Location = new System.Drawing.Point(145, 55);
            this.cmb_chiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_chiNhanh.Name = "cmb_chiNhanh";
            this.cmb_chiNhanh.Size = new System.Drawing.Size(183, 24);
            this.cmb_chiNhanh.TabIndex = 2;
            this.cmb_chiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmb_chiNhanh_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.nhanVienGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 140);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1882, 335);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "BẢNG NHÂN VIÊN";
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.bds_nhanVien;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanVienGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.nhanVienGridControl.Location = new System.Drawing.Point(2, 28);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(1878, 305);
            this.nhanVienGridControl.TabIndex = 20;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 27;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 100;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 27;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 100;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 27;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 100;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 27;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 100;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 27;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 100;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 27;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 5;
            this.colSODT.Width = 100;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 27;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            this.colMACN.Width = 100;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 27;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            this.colTrangThaiXoa.Width = 100;
            // 
            // groupControl_nhanVien
            // 
            this.groupControl_nhanVien.Controls.Add(this.label1);
            this.groupControl_nhanVien.Controls.Add(this.label7);
            this.groupControl_nhanVien.Controls.Add(this.lbl_soDT);
            this.groupControl_nhanVien.Controls.Add(this.lbl_diaChi);
            this.groupControl_nhanVien.Controls.Add(this.lbl_ho);
            this.groupControl_nhanVien.Controls.Add(this.lbl_ten);
            this.groupControl_nhanVien.Controls.Add(this.lbl_maNV);
            this.groupControl_nhanVien.Controls.Add(this.pnl_maCN);
            this.groupControl_nhanVien.Controls.Add(this.pnl_diaChi);
            this.groupControl_nhanVien.Controls.Add(this.pnl_soDT);
            this.groupControl_nhanVien.Controls.Add(this.pnl_ten);
            this.groupControl_nhanVien.Controls.Add(this.pnl_ho);
            this.groupControl_nhanVien.Controls.Add(this.pnl_maNV);
            this.groupControl_nhanVien.Controls.Add(this.text_maCN);
            this.groupControl_nhanVien.Controls.Add(trangThaiXoaLabel);
            this.groupControl_nhanVien.Controls.Add(this.label_trangThaiXoa);
            this.groupControl_nhanVien.Controls.Add(this.text_soDT);
            this.groupControl_nhanVien.Controls.Add(this.cmb_phai);
            this.groupControl_nhanVien.Controls.Add(this.text_diaChi);
            this.groupControl_nhanVien.Controls.Add(this.text_ten);
            this.groupControl_nhanVien.Controls.Add(this.text_ho);
            this.groupControl_nhanVien.Controls.Add(this.text_maNV);
            this.groupControl_nhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl_nhanVien.Location = new System.Drawing.Point(0, 473);
            this.groupControl_nhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl_nhanVien.Name = "groupControl_nhanVien";
            this.groupControl_nhanVien.Size = new System.Drawing.Size(1882, 280);
            this.groupControl_nhanVien.TabIndex = 26;
            this.groupControl_nhanVien.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(950, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Phái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(950, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Mã chi nhánh";
            // 
            // lbl_soDT
            // 
            this.lbl_soDT.AutoSize = true;
            this.lbl_soDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_soDT.Location = new System.Drawing.Point(50, 175);
            this.lbl_soDT.Name = "lbl_soDT";
            this.lbl_soDT.Size = new System.Drawing.Size(97, 20);
            this.lbl_soDT.TabIndex = 60;
            this.lbl_soDT.Text = "Số điện thoại";
            this.lbl_soDT.Click += new System.EventHandler(this.lbl_soDT_Click);
            // 
            // lbl_diaChi
            // 
            this.lbl_diaChi.AutoSize = true;
            this.lbl_diaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_diaChi.Location = new System.Drawing.Point(350, 175);
            this.lbl_diaChi.Name = "lbl_diaChi";
            this.lbl_diaChi.Size = new System.Drawing.Size(55, 20);
            this.lbl_diaChi.TabIndex = 59;
            this.lbl_diaChi.Text = "Địa chỉ";
            this.lbl_diaChi.Click += new System.EventHandler(this.lbl_diaChi_Click);
            // 
            // lbl_ho
            // 
            this.lbl_ho.AutoSize = true;
            this.lbl_ho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_ho.Location = new System.Drawing.Point(350, 75);
            this.lbl_ho.Name = "lbl_ho";
            this.lbl_ho.Size = new System.Drawing.Size(29, 20);
            this.lbl_ho.TabIndex = 57;
            this.lbl_ho.Text = "Họ";
            this.lbl_ho.Click += new System.EventHandler(this.lbl_ho_Click);
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_ten.Location = new System.Drawing.Point(650, 75);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(32, 20);
            this.lbl_ten.TabIndex = 56;
            this.lbl_ten.Text = "Tên";
            this.lbl_ten.Click += new System.EventHandler(this.lbl_ten_Click);
            // 
            // lbl_maNV
            // 
            this.lbl_maNV.AutoSize = true;
            this.lbl_maNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_maNV.Location = new System.Drawing.Point(50, 75);
            this.lbl_maNV.Name = "lbl_maNV";
            this.lbl_maNV.Size = new System.Drawing.Size(97, 20);
            this.lbl_maNV.TabIndex = 55;
            this.lbl_maNV.Text = "Mã nhân viên";
            this.lbl_maNV.Click += new System.EventHandler(this.lbl_maNV_Click);
            // 
            // pnl_maCN
            // 
            this.pnl_maCN.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_maCN.Location = new System.Drawing.Point(950, 220);
            this.pnl_maCN.Name = "pnl_maCN";
            this.pnl_maCN.Size = new System.Drawing.Size(200, 2);
            this.pnl_maCN.TabIndex = 52;
            // 
            // pnl_diaChi
            // 
            this.pnl_diaChi.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_diaChi.Location = new System.Drawing.Point(350, 220);
            this.pnl_diaChi.Name = "pnl_diaChi";
            this.pnl_diaChi.Size = new System.Drawing.Size(500, 2);
            this.pnl_diaChi.TabIndex = 51;
            // 
            // pnl_soDT
            // 
            this.pnl_soDT.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_soDT.Location = new System.Drawing.Point(50, 220);
            this.pnl_soDT.Name = "pnl_soDT";
            this.pnl_soDT.Size = new System.Drawing.Size(200, 2);
            this.pnl_soDT.TabIndex = 50;
            // 
            // pnl_ten
            // 
            this.pnl_ten.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_ten.Location = new System.Drawing.Point(650, 122);
            this.pnl_ten.Name = "pnl_ten";
            this.pnl_ten.Size = new System.Drawing.Size(200, 2);
            this.pnl_ten.TabIndex = 49;
            // 
            // pnl_ho
            // 
            this.pnl_ho.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_ho.Location = new System.Drawing.Point(350, 122);
            this.pnl_ho.Name = "pnl_ho";
            this.pnl_ho.Size = new System.Drawing.Size(200, 2);
            this.pnl_ho.TabIndex = 48;
            // 
            // pnl_maNV
            // 
            this.pnl_maNV.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_maNV.Location = new System.Drawing.Point(50, 122);
            this.pnl_maNV.Name = "pnl_maNV";
            this.pnl_maNV.Size = new System.Drawing.Size(200, 2);
            this.pnl_maNV.TabIndex = 47;
            // 
            // text_maCN
            // 
            this.text_maCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "MACN", true));
            this.text_maCN.Enabled = false;
            this.text_maCN.Location = new System.Drawing.Point(950, 200);
            this.text_maCN.Margin = new System.Windows.Forms.Padding(4);
            this.text_maCN.MenuManager = this.barManager1;
            this.text_maCN.Name = "text_maCN";
            this.text_maCN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_maCN.Size = new System.Drawing.Size(200, 20);
            this.text_maCN.TabIndex = 32;
            // 
            // label_trangThaiXoa
            // 
            this.label_trangThaiXoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_nhanVien, "TrangThaiXoa", true));
            this.label_trangThaiXoa.Location = new System.Drawing.Point(1226, 100);
            this.label_trangThaiXoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_trangThaiXoa.Name = "label_trangThaiXoa";
            this.label_trangThaiXoa.Size = new System.Drawing.Size(60, 30);
            this.label_trangThaiXoa.TabIndex = 31;
            // 
            // text_soDT
            // 
            this.text_soDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "SODT", true));
            this.text_soDT.Location = new System.Drawing.Point(50, 200);
            this.text_soDT.Margin = new System.Windows.Forms.Padding(4);
            this.text_soDT.MenuManager = this.barManager1;
            this.text_soDT.Name = "text_soDT";
            this.text_soDT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_soDT.Size = new System.Drawing.Size(200, 20);
            this.text_soDT.TabIndex = 28;
            this.text_soDT.Enter += new System.EventHandler(this.text_soDT_Enter);
            this.text_soDT.Leave += new System.EventHandler(this.text_soDT_Leave);
            // 
            // cmb_phai
            // 
            this.cmb_phai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_nhanVien, "PHAI", true));
            this.cmb_phai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_phai.FormattingEnabled = true;
            this.cmb_phai.Location = new System.Drawing.Point(950, 100);
            this.cmb_phai.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_phai.Name = "cmb_phai";
            this.cmb_phai.Size = new System.Drawing.Size(60, 24);
            this.cmb_phai.TabIndex = 26;
            // 
            // text_diaChi
            // 
            this.text_diaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "DIACHI", true));
            this.text_diaChi.Location = new System.Drawing.Point(350, 200);
            this.text_diaChi.Margin = new System.Windows.Forms.Padding(4);
            this.text_diaChi.MenuManager = this.barManager1;
            this.text_diaChi.Name = "text_diaChi";
            this.text_diaChi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_diaChi.Size = new System.Drawing.Size(500, 20);
            this.text_diaChi.TabIndex = 24;
            this.text_diaChi.Enter += new System.EventHandler(this.text_diaChi_Enter);
            this.text_diaChi.Leave += new System.EventHandler(this.text_diaChi_Leave);
            // 
            // text_ten
            // 
            this.text_ten.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "TEN", true));
            this.text_ten.Location = new System.Drawing.Point(650, 100);
            this.text_ten.Margin = new System.Windows.Forms.Padding(4);
            this.text_ten.MenuManager = this.barManager1;
            this.text_ten.Name = "text_ten";
            this.text_ten.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_ten.Size = new System.Drawing.Size(200, 20);
            this.text_ten.TabIndex = 22;
            this.text_ten.Enter += new System.EventHandler(this.text_ten_Enter);
            this.text_ten.Leave += new System.EventHandler(this.text_ten_Leave);
            // 
            // text_ho
            // 
            this.text_ho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "HO", true));
            this.text_ho.Location = new System.Drawing.Point(350, 100);
            this.text_ho.Margin = new System.Windows.Forms.Padding(4);
            this.text_ho.MenuManager = this.barManager1;
            this.text_ho.Name = "text_ho";
            this.text_ho.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_ho.Size = new System.Drawing.Size(200, 20);
            this.text_ho.TabIndex = 20;
            this.text_ho.Enter += new System.EventHandler(this.text_ho_Enter);
            this.text_ho.Leave += new System.EventHandler(this.text_ho_Leave);
            // 
            // text_maNV
            // 
            this.text_maNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "MANV", true));
            this.text_maNV.Location = new System.Drawing.Point(50, 100);
            this.text_maNV.Margin = new System.Windows.Forms.Padding(4);
            this.text_maNV.MenuManager = this.barManager1;
            this.text_maNV.Name = "text_maNV";
            this.text_maNV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_maNV.Size = new System.Drawing.Size(200, 20);
            this.text_maNV.TabIndex = 18;
            this.text_maNV.Enter += new System.EventHandler(this.text_maNV_Enter);
            this.text_maNV.Leave += new System.EventHandler(this.text_maNV_Leave);
            // 
            // Frm_nhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 753);
            this.Controls.Add(this.groupControl_nhanVien);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl_chiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_nhanVien";
            this.Text = "NHÂN VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_nhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_nhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).EndInit();
            this.groupControl_chiNhanh.ResumeLayout(false);
            this.groupControl_chiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_nhanVien)).EndInit();
            this.groupControl_nhanVien.ResumeLayout(false);
            this.groupControl_nhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_maCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_soDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_diaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_ho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_maNV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar_nhanVien;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_sua;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraBars.BarButtonItem btn_phucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_ghi;
        private DevExpress.XtraBars.BarButtonItem btn_huy;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_DSPHANMANH dS_DSPHANMANH;
        private DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPHANMANHTableAdapters.TableAdapterManager tableAdapterManager;
        private DS dS;
        private System.Windows.Forms.BindingSource bds_nhanVien;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraEditors.GroupControl groupControl_chiNhanh;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraEditors.GroupControl groupControl_nhanVien;
        private DevExpress.XtraBars.BarButtonItem btn_chuyenChiNhanh;
        private DevExpress.XtraBars.BarButtonItem btn_reload;
        private DevExpress.XtraEditors.TextEdit text_maCN;
        private System.Windows.Forms.Label label_trangThaiXoa;
        private DevExpress.XtraEditors.TextEdit text_soDT;
        private System.Windows.Forms.ComboBox cmb_phai;
        private DevExpress.XtraEditors.TextEdit text_diaChi;
        private DevExpress.XtraEditors.TextEdit text_ten;
        private DevExpress.XtraEditors.TextEdit text_ho;
        private DevExpress.XtraEditors.TextEdit text_maNV;
        private System.Windows.Forms.Panel pnl_maCN;
        private System.Windows.Forms.Panel pnl_diaChi;
        private System.Windows.Forms.Panel pnl_soDT;
        private System.Windows.Forms.Panel pnl_ten;
        private System.Windows.Forms.Panel pnl_ho;
        private System.Windows.Forms.Panel pnl_maNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_soDT;
        private System.Windows.Forms.Label lbl_diaChi;
        private System.Windows.Forms.Label lbl_ho;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.Label lbl_maNV;
    }
}