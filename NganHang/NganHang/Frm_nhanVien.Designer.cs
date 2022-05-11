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
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mANVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_nhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar_nhanVien = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_phucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ghi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_huy = new DevExpress.XtraBars.BarButtonItem();
            this.btn_chuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
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
            this.text_maCN = new DevExpress.XtraEditors.TextEdit();
            this.label_trangThaiXoa = new System.Windows.Forms.Label();
            this.text_soDT = new DevExpress.XtraEditors.TextEdit();
            this.cmb_phai = new System.Windows.Forms.ComboBox();
            this.text_diaChi = new DevExpress.XtraEditors.TextEdit();
            this.text_ten = new DevExpress.XtraEditors.TextEdit();
            this.text_ho = new DevExpress.XtraEditors.TextEdit();
            this.text_maNV = new DevExpress.XtraEditors.TextEdit();
            tENCNLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
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
            tENCNLabel.Location = new System.Drawing.Point(49, 47);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(62, 13);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Chi nhánh: ";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(287, 81);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(40, 13);
            mACNLabel.TabIndex = 15;
            mACNLabel.Text = "MACN:";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(285, 118);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(84, 13);
            trangThaiXoaLabel.TabIndex = 14;
            trangThaiXoaLabel.Text = "Trạng thái xoá: ";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(287, 43);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(38, 13);
            sODTLabel.TabIndex = 10;
            sODTLabel.Text = "SODT:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(65, 190);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(35, 13);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "PHAI:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(65, 154);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(47, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "DIACHI:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(65, 118);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(65, 81);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(65, 43);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(39, 13);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "MANV:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar_nhanVien,
            this.bar3});
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
            this.btn_chuyenChiNhanh});
            this.barManager1.MainMenu = this.bar_nhanVien;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_chuyenChiNhanh)});
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
            this.btn_chuyenChiNhanh.ImageOptions.Image = global::NganHang.Properties.Resources.allianceX;
            this.btn_chuyenChiNhanh.Name = "btn_chuyenChiNhanh";
            this.btn_chuyenChiNhanh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_chuyenChiNhanh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_chuyenChiNhanh_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1348, 58);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 536);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1348, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 58);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 478);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1348, 58);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 478);
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
            this.groupControl_chiNhanh.Location = new System.Drawing.Point(0, 58);
            this.groupControl_chiNhanh.Name = "groupControl_chiNhanh";
            this.groupControl_chiNhanh.Size = new System.Drawing.Size(1348, 88);
            this.groupControl_chiNhanh.TabIndex = 15;
            this.groupControl_chiNhanh.Text = "Chọn chi nhánh";
            // 
            // cmb_chiNhanh
            // 
            this.cmb_chiNhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DS_PHANMANHBindingSource, "TENCN", true));
            this.cmb_chiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chiNhanh.FormattingEnabled = true;
            this.cmb_chiNhanh.Location = new System.Drawing.Point(117, 44);
            this.cmb_chiNhanh.Name = "cmb_chiNhanh";
            this.cmb_chiNhanh.Size = new System.Drawing.Size(138, 21);
            this.cmb_chiNhanh.TabIndex = 2;
            this.cmb_chiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmb_chiNhanh_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.nhanVienGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 146);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1348, 185);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "Bảng nhân viên";
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.bds_nhanVien;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhanVienGridControl.Location = new System.Drawing.Point(2, 23);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(1344, 155);
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
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            // 
            // groupControl_nhanVien
            // 
            this.groupControl_nhanVien.Controls.Add(mACNLabel);
            this.groupControl_nhanVien.Controls.Add(this.text_maCN);
            this.groupControl_nhanVien.Controls.Add(trangThaiXoaLabel);
            this.groupControl_nhanVien.Controls.Add(this.label_trangThaiXoa);
            this.groupControl_nhanVien.Controls.Add(sODTLabel);
            this.groupControl_nhanVien.Controls.Add(this.text_soDT);
            this.groupControl_nhanVien.Controls.Add(pHAILabel);
            this.groupControl_nhanVien.Controls.Add(this.cmb_phai);
            this.groupControl_nhanVien.Controls.Add(dIACHILabel);
            this.groupControl_nhanVien.Controls.Add(this.text_diaChi);
            this.groupControl_nhanVien.Controls.Add(tENLabel);
            this.groupControl_nhanVien.Controls.Add(this.text_ten);
            this.groupControl_nhanVien.Controls.Add(hOLabel);
            this.groupControl_nhanVien.Controls.Add(this.text_ho);
            this.groupControl_nhanVien.Controls.Add(mANVLabel);
            this.groupControl_nhanVien.Controls.Add(this.text_maNV);
            this.groupControl_nhanVien.Location = new System.Drawing.Point(2, 317);
            this.groupControl_nhanVien.Name = "groupControl_nhanVien";
            this.groupControl_nhanVien.Size = new System.Drawing.Size(1344, 238);
            this.groupControl_nhanVien.TabIndex = 26;
            // 
            // text_maCN
            // 
            this.text_maCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "MACN", true));
            this.text_maCN.Enabled = false;
            this.text_maCN.Location = new System.Drawing.Point(333, 78);
            this.text_maCN.MenuManager = this.barManager1;
            this.text_maCN.Name = "text_maCN";
            this.text_maCN.Size = new System.Drawing.Size(132, 20);
            this.text_maCN.TabIndex = 16;
            // 
            // label_trangThaiXoa
            // 
            this.label_trangThaiXoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_nhanVien, "TrangThaiXoa", true));
            this.label_trangThaiXoa.Location = new System.Drawing.Point(374, 118);
            this.label_trangThaiXoa.Name = "label_trangThaiXoa";
            this.label_trangThaiXoa.Size = new System.Drawing.Size(100, 23);
            this.label_trangThaiXoa.TabIndex = 15;
            // 
            // text_soDT
            // 
            this.text_soDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "SODT", true));
            this.text_soDT.Location = new System.Drawing.Point(333, 40);
            this.text_soDT.MenuManager = this.barManager1;
            this.text_soDT.Name = "text_soDT";
            this.text_soDT.Size = new System.Drawing.Size(132, 20);
            this.text_soDT.TabIndex = 11;
            // 
            // cmb_phai
            // 
            this.cmb_phai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_nhanVien, "PHAI", true));
            this.cmb_phai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_phai.FormattingEnabled = true;
            this.cmb_phai.Location = new System.Drawing.Point(123, 187);
            this.cmb_phai.Name = "cmb_phai";
            this.cmb_phai.Size = new System.Drawing.Size(132, 21);
            this.cmb_phai.TabIndex = 9;
            // 
            // text_diaChi
            // 
            this.text_diaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "DIACHI", true));
            this.text_diaChi.Location = new System.Drawing.Point(123, 151);
            this.text_diaChi.MenuManager = this.barManager1;
            this.text_diaChi.Name = "text_diaChi";
            this.text_diaChi.Size = new System.Drawing.Size(342, 20);
            this.text_diaChi.TabIndex = 7;
            // 
            // text_ten
            // 
            this.text_ten.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "TEN", true));
            this.text_ten.Location = new System.Drawing.Point(123, 115);
            this.text_ten.MenuManager = this.barManager1;
            this.text_ten.Name = "text_ten";
            this.text_ten.Size = new System.Drawing.Size(132, 20);
            this.text_ten.TabIndex = 5;
            // 
            // text_ho
            // 
            this.text_ho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "HO", true));
            this.text_ho.Location = new System.Drawing.Point(123, 78);
            this.text_ho.MenuManager = this.barManager1;
            this.text_ho.Name = "text_ho";
            this.text_ho.Size = new System.Drawing.Size(132, 20);
            this.text_ho.TabIndex = 3;
            // 
            // text_maNV
            // 
            this.text_maNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "MANV", true));
            this.text_maNV.Location = new System.Drawing.Point(123, 43);
            this.text_maNV.MenuManager = this.barManager1;
            this.text_maNV.Name = "text_maNV";
            this.text_maNV.Size = new System.Drawing.Size(132, 20);
            this.text_maNV.TabIndex = 1;
            // 
            // Frm_nhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 556);
            this.Controls.Add(this.groupControl_nhanVien);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl_chiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_nhanVien";
            this.Text = "Nhân viên";
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
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar_nhanVien;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_sua;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraBars.BarButtonItem btn_phucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_ghi;
        private DevExpress.XtraBars.BarButtonItem btn_huy;
        private DevExpress.XtraBars.Bar bar3;
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
        private DevExpress.XtraEditors.TextEdit text_maCN;
        private System.Windows.Forms.Label label_trangThaiXoa;
        private DevExpress.XtraEditors.TextEdit text_soDT;
        private System.Windows.Forms.ComboBox cmb_phai;
        private DevExpress.XtraEditors.TextEdit text_diaChi;
        private DevExpress.XtraEditors.TextEdit text_ten;
        private DevExpress.XtraEditors.TextEdit text_ho;
        private DevExpress.XtraEditors.TextEdit text_maNV;
        private DevExpress.XtraBars.BarButtonItem btn_chuyenChiNhanh;
    }
}