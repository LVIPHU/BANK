namespace NganHang
{
    partial class Frm_chuyenTien
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
            System.Windows.Forms.Label nGAYGDLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label sOTK_CHUYENLabel;
            System.Windows.Forms.Label sOTK_NHANLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_chuyenTien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gD_CHUYENTIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.bds_GDchuyenTien = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new NganHang.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_CHUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_NHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dS_DSPHANMANH = new NganHang.DS_DSPHANMANH();
            this.groupControl_chiNhanh = new DevExpress.XtraEditors.GroupControl();
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl_chuyenTien = new DevExpress.XtraEditors.GroupControl();
            this.btn_huyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.text_soTKNhan = new DevExpress.XtraEditors.TextEdit();
            this.text_soTKChuyen = new DevExpress.XtraEditors.TextEdit();
            this.text_maNV = new DevExpress.XtraEditors.TextEdit();
            this.text_soTien = new DevExpress.XtraEditors.SpinEdit();
            this.date_ngayGD = new DevExpress.XtraEditors.DateEdit();
            this.v_DS_PHANMANHTableAdapter = new NganHang.DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.gD_CHUYENTIENTableAdapter = new NganHang.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            tENCNLabel = new System.Windows.Forms.Label();
            nGAYGDLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            sOTK_CHUYENLabel = new System.Windows.Forms.Label();
            sOTK_NHANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GDchuyenTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).BeginInit();
            this.groupControl_chiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chuyenTien)).BeginInit();
            this.groupControl_chuyenTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTKNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTKChuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_maNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayGD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayGD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(79, 98);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(59, 13);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Chi nhánh:";
            // 
            // nGAYGDLabel
            // 
            nGAYGDLabel.AutoSize = true;
            nGAYGDLabel.Location = new System.Drawing.Point(55, 64);
            nGAYGDLabel.Name = "nGAYGDLabel";
            nGAYGDLabel.Size = new System.Drawing.Size(52, 13);
            nGAYGDLabel.TabIndex = 0;
            nGAYGDLabel.Text = "NGAYGD:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Location = new System.Drawing.Point(59, 149);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(48, 13);
            sOTIENLabel.TabIndex = 2;
            sOTIENLabel.Text = "SOTIEN:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(68, 106);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(39, 13);
            mANVLabel.TabIndex = 4;
            mANVLabel.Text = "MANV:";
            // 
            // sOTK_CHUYENLabel
            // 
            sOTK_CHUYENLabel.AutoSize = true;
            sOTK_CHUYENLabel.Location = new System.Drawing.Point(391, 83);
            sOTK_CHUYENLabel.Name = "sOTK_CHUYENLabel";
            sOTK_CHUYENLabel.Size = new System.Drawing.Size(80, 13);
            sOTK_CHUYENLabel.TabIndex = 6;
            sOTK_CHUYENLabel.Text = "SOTK CHUYEN:";
            // 
            // sOTK_NHANLabel
            // 
            sOTK_NHANLabel.AutoSize = true;
            sOTK_NHANLabel.Location = new System.Drawing.Point(590, 83);
            sOTK_NHANLabel.Name = "sOTK_NHANLabel";
            sOTK_NHANLabel.Size = new System.Drawing.Size(68, 13);
            sOTK_NHANLabel.TabIndex = 8;
            sOTK_NHANLabel.Text = "SOTK NHAN:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_them,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
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
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_them)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1348, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 557);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1348, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 512);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1348, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 512);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xoá";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gD_CHUYENTIENGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 47);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(937, 236);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Bảng GD chuyển tiền";
            // 
            // gD_CHUYENTIENGridControl
            // 
            this.gD_CHUYENTIENGridControl.DataSource = this.bds_GDchuyenTien;
            this.gD_CHUYENTIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gD_CHUYENTIENGridControl.Location = new System.Drawing.Point(2, 23);
            this.gD_CHUYENTIENGridControl.MainView = this.gridView1;
            this.gD_CHUYENTIENGridControl.MenuManager = this.barManager1;
            this.gD_CHUYENTIENGridControl.Name = "gD_CHUYENTIENGridControl";
            this.gD_CHUYENTIENGridControl.Size = new System.Drawing.Size(933, 211);
            this.gD_CHUYENTIENGridControl.TabIndex = 0;
            this.gD_CHUYENTIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bds_GDchuyenTien
            // 
            this.bds_GDchuyenTien.DataMember = "GD_CHUYENTIEN";
            this.bds_GDchuyenTien.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colSOTK_CHUYEN,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colSOTK_NHAN,
            this.colMANV});
            this.gridView1.GridControl = this.gD_CHUYENTIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGD
            // 
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            // 
            // colSOTK_CHUYEN
            // 
            this.colSOTK_CHUYEN.FieldName = "SOTK_CHUYEN";
            this.colSOTK_CHUYEN.Name = "colSOTK_CHUYEN";
            this.colSOTK_CHUYEN.Visible = true;
            this.colSOTK_CHUYEN.VisibleIndex = 1;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 2;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.DisplayFormat.FormatString = "N0";
            this.colSOTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 3;
            // 
            // colSOTK_NHAN
            // 
            this.colSOTK_NHAN.FieldName = "SOTK_NHAN";
            this.colSOTK_NHAN.Name = "colSOTK_NHAN";
            this.colSOTK_NHAN.Visible = true;
            this.colSOTK_NHAN.VisibleIndex = 4;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 5;
            // 
            // dS_DSPHANMANH
            // 
            this.dS_DSPHANMANH.DataSetName = "DS_DSPHANMANH";
            this.dS_DSPHANMANH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl_chiNhanh
            // 
            this.groupControl_chiNhanh.Controls.Add(tENCNLabel);
            this.groupControl_chiNhanh.Controls.Add(this.cmb_chiNhanh);
            this.groupControl_chiNhanh.Location = new System.Drawing.Point(943, 47);
            this.groupControl_chiNhanh.Name = "groupControl_chiNhanh";
            this.groupControl_chiNhanh.Size = new System.Drawing.Size(405, 236);
            this.groupControl_chiNhanh.TabIndex = 5;
            this.groupControl_chiNhanh.Text = "Chi nhánh";
            // 
            // cmb_chiNhanh
            // 
            this.cmb_chiNhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DS_PHANMANHBindingSource, "TENCN", true));
            this.cmb_chiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chiNhanh.FormattingEnabled = true;
            this.cmb_chiNhanh.Location = new System.Drawing.Point(144, 95);
            this.cmb_chiNhanh.Name = "cmb_chiNhanh";
            this.cmb_chiNhanh.Size = new System.Drawing.Size(121, 21);
            this.cmb_chiNhanh.TabIndex = 1;
            this.cmb_chiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmb_chiNhanh_SelectedIndexChanged);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.dS_DSPHANMANH;
            // 
            // groupControl_chuyenTien
            // 
            this.groupControl_chuyenTien.Controls.Add(this.btn_huyBo);
            this.groupControl_chuyenTien.Controls.Add(this.btn_xacNhan);
            this.groupControl_chuyenTien.Controls.Add(sOTK_NHANLabel);
            this.groupControl_chuyenTien.Controls.Add(this.text_soTKNhan);
            this.groupControl_chuyenTien.Controls.Add(sOTK_CHUYENLabel);
            this.groupControl_chuyenTien.Controls.Add(this.text_soTKChuyen);
            this.groupControl_chuyenTien.Controls.Add(mANVLabel);
            this.groupControl_chuyenTien.Controls.Add(this.text_maNV);
            this.groupControl_chuyenTien.Controls.Add(sOTIENLabel);
            this.groupControl_chuyenTien.Controls.Add(this.text_soTien);
            this.groupControl_chuyenTien.Controls.Add(nGAYGDLabel);
            this.groupControl_chuyenTien.Controls.Add(this.date_ngayGD);
            this.groupControl_chuyenTien.Location = new System.Drawing.Point(0, 289);
            this.groupControl_chuyenTien.Name = "groupControl_chuyenTien";
            this.groupControl_chuyenTien.Size = new System.Drawing.Size(1348, 268);
            this.groupControl_chuyenTien.TabIndex = 6;
            this.groupControl_chuyenTien.Text = "Thông tin chuyển tiền";
            // 
            // btn_huyBo
            // 
            this.btn_huyBo.Location = new System.Drawing.Point(560, 149);
            this.btn_huyBo.Name = "btn_huyBo";
            this.btn_huyBo.Size = new System.Drawing.Size(75, 23);
            this.btn_huyBo.TabIndex = 11;
            this.btn_huyBo.Text = "Huỷ bỏ";
            this.btn_huyBo.Click += new System.EventHandler(this.btn_huyBo_Click);
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.Location = new System.Drawing.Point(425, 149);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(75, 23);
            this.btn_xacNhan.TabIndex = 10;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // text_soTKNhan
            // 
            this.text_soTKNhan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDchuyenTien, "SOTK_NHAN", true));
            this.text_soTKNhan.Location = new System.Drawing.Point(572, 99);
            this.text_soTKNhan.MenuManager = this.barManager1;
            this.text_soTKNhan.Name = "text_soTKNhan";
            this.text_soTKNhan.Size = new System.Drawing.Size(100, 20);
            this.text_soTKNhan.TabIndex = 9;
            // 
            // text_soTKChuyen
            // 
            this.text_soTKChuyen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDchuyenTien, "SOTK_CHUYEN", true));
            this.text_soTKChuyen.Location = new System.Drawing.Point(382, 99);
            this.text_soTKChuyen.MenuManager = this.barManager1;
            this.text_soTKChuyen.Name = "text_soTKChuyen";
            this.text_soTKChuyen.Size = new System.Drawing.Size(100, 20);
            this.text_soTKChuyen.TabIndex = 7;
            // 
            // text_maNV
            // 
            this.text_maNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDchuyenTien, "MANV", true));
            this.text_maNV.Location = new System.Drawing.Point(113, 103);
            this.text_maNV.MenuManager = this.barManager1;
            this.text_maNV.Name = "text_maNV";
            this.text_maNV.Size = new System.Drawing.Size(100, 20);
            this.text_maNV.TabIndex = 5;
            // 
            // text_soTien
            // 
            this.text_soTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDchuyenTien, "SOTIEN", true));
            this.text_soTien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.text_soTien.Location = new System.Drawing.Point(113, 146);
            this.text_soTien.MenuManager = this.barManager1;
            this.text_soTien.Name = "text_soTien";
            this.text_soTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text_soTien.Properties.DisplayFormat.FormatString = "N0";
            this.text_soTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.text_soTien.Size = new System.Drawing.Size(100, 20);
            this.text_soTien.TabIndex = 3;
            // 
            // date_ngayGD
            // 
            this.date_ngayGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDchuyenTien, "NGAYGD", true));
            this.date_ngayGD.EditValue = null;
            this.date_ngayGD.Location = new System.Drawing.Point(113, 61);
            this.date_ngayGD.MenuManager = this.barManager1;
            this.date_ngayGD.Name = "date_ngayGD";
            this.date_ngayGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ngayGD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ngayGD.Size = new System.Drawing.Size(100, 20);
            this.date_ngayGD.TabIndex = 1;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = this.gD_CHUYENTIENTableAdapter;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Frm_chuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 577);
            this.Controls.Add(this.groupControl_chuyenTien);
            this.Controls.Add(this.groupControl_chiNhanh);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_chuyenTien";
            this.Text = "Giao dịch chuyển tiền";
            this.Load += new System.EventHandler(this.Frm_chuyenTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GDchuyenTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).EndInit();
            this.groupControl_chiNhanh.ResumeLayout(false);
            this.groupControl_chiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chuyenTien)).EndInit();
            this.groupControl_chuyenTien.ResumeLayout(false);
            this.groupControl_chuyenTien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTKNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTKChuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_maNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayGD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayGD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl_chuyenTien;
        private DevExpress.XtraEditors.GroupControl groupControl_chiNhanh;
        private DS dS;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DS_DSPHANMANH dS_DSPHANMANH;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private System.Windows.Forms.BindingSource bds_GDchuyenTien;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton btn_huyBo;
        private DevExpress.XtraEditors.SimpleButton btn_xacNhan;
        private DevExpress.XtraEditors.TextEdit text_soTKNhan;
        private DevExpress.XtraEditors.TextEdit text_soTKChuyen;
        private DevExpress.XtraEditors.TextEdit text_maNV;
        private DevExpress.XtraEditors.SpinEdit text_soTien;
        private DevExpress.XtraEditors.DateEdit date_ngayGD;
        private DevExpress.XtraGrid.GridControl gD_CHUYENTIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_CHUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_NHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
    }
}