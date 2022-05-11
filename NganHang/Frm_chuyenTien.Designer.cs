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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_chuyenTien));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_reload = new DevExpress.XtraBars.BarButtonItem();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_soTKChuyen = new System.Windows.Forms.Label();
            this.lbl_soTien = new System.Windows.Forms.Label();
            this.lbl_soTKNhan = new System.Windows.Forms.Label();
            this.lbl_ngayGD = new System.Windows.Forms.Label();
            this.pnl_soTien = new System.Windows.Forms.Panel();
            this.btn_huyBo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_xacNhan = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnl_soTKNhan = new System.Windows.Forms.Panel();
            this.pnl_soTKChuyen = new System.Windows.Forms.Panel();
            this.text_soTKNhan = new DevExpress.XtraEditors.TextEdit();
            this.text_soTKChuyen = new DevExpress.XtraEditors.TextEdit();
            this.text_maNV = new DevExpress.XtraEditors.TextEdit();
            this.text_soTien = new DevExpress.XtraEditors.SpinEdit();
            this.date_ngayGD = new DevExpress.XtraEditors.DateEdit();
            this.v_DS_PHANMANHTableAdapter = new NganHang.DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.gD_CHUYENTIENTableAdapter = new NganHang.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            tENCNLabel = new System.Windows.Forms.Label();
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
            tENCNLabel.Location = new System.Drawing.Point(65, 60);
            tENCNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(70, 17);
            tENCNLabel.TabIndex = 2;
            tENCNLabel.Text = "Chi nhánh";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_them,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btn_reload});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_them),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_reload)});
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
            // btn_reload
            // 
            this.btn_reload.Caption = "Reload";
            this.btn_reload.Id = 3;
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
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gD_CHUYENTIENGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 140);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1882, 336);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "BẢNG GIAO DỊCH CHUYỂN TIỀN";
            // 
            // gD_CHUYENTIENGridControl
            // 
            this.gD_CHUYENTIENGridControl.DataSource = this.bds_GDchuyenTien;
            this.gD_CHUYENTIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gD_CHUYENTIENGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gD_CHUYENTIENGridControl.Location = new System.Drawing.Point(2, 28);
            this.gD_CHUYENTIENGridControl.MainView = this.gridView1;
            this.gD_CHUYENTIENGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.gD_CHUYENTIENGridControl.MenuManager = this.barManager1;
            this.gD_CHUYENTIENGridControl.Name = "gD_CHUYENTIENGridControl";
            this.gD_CHUYENTIENGridControl.Size = new System.Drawing.Size(1878, 306);
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
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gD_CHUYENTIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGD
            // 
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.MinWidth = 27;
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            this.colMAGD.Width = 100;
            // 
            // colSOTK_CHUYEN
            // 
            this.colSOTK_CHUYEN.FieldName = "SOTK_CHUYEN";
            this.colSOTK_CHUYEN.MinWidth = 27;
            this.colSOTK_CHUYEN.Name = "colSOTK_CHUYEN";
            this.colSOTK_CHUYEN.Visible = true;
            this.colSOTK_CHUYEN.VisibleIndex = 1;
            this.colSOTK_CHUYEN.Width = 100;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 27;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 2;
            this.colNGAYGD.Width = 100;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.DisplayFormat.FormatString = "N0";
            this.colSOTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 27;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 3;
            this.colSOTIEN.Width = 100;
            // 
            // colSOTK_NHAN
            // 
            this.colSOTK_NHAN.FieldName = "SOTK_NHAN";
            this.colSOTK_NHAN.MinWidth = 27;
            this.colSOTK_NHAN.Name = "colSOTK_NHAN";
            this.colSOTK_NHAN.Visible = true;
            this.colSOTK_NHAN.VisibleIndex = 4;
            this.colSOTK_NHAN.Width = 100;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 27;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 5;
            this.colMANV.Width = 100;
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
            this.groupControl_chiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_chiNhanh.Location = new System.Drawing.Point(0, 30);
            this.groupControl_chiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl_chiNhanh.Name = "groupControl_chiNhanh";
            this.groupControl_chiNhanh.Size = new System.Drawing.Size(1882, 110);
            this.groupControl_chiNhanh.TabIndex = 5;
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
            this.cmb_chiNhanh.Size = new System.Drawing.Size(200, 24);
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
            this.groupControl_chuyenTien.Controls.Add(this.panel2);
            this.groupControl_chuyenTien.Controls.Add(this.panel1);
            this.groupControl_chuyenTien.Controls.Add(this.label5);
            this.groupControl_chuyenTien.Controls.Add(this.lbl_soTKChuyen);
            this.groupControl_chuyenTien.Controls.Add(this.lbl_soTien);
            this.groupControl_chuyenTien.Controls.Add(this.lbl_soTKNhan);
            this.groupControl_chuyenTien.Controls.Add(this.lbl_ngayGD);
            this.groupControl_chuyenTien.Controls.Add(this.pnl_soTien);
            this.groupControl_chuyenTien.Controls.Add(this.btn_huyBo);
            this.groupControl_chuyenTien.Controls.Add(this.btn_xacNhan);
            this.groupControl_chuyenTien.Controls.Add(this.pnl_soTKNhan);
            this.groupControl_chuyenTien.Controls.Add(this.pnl_soTKChuyen);
            this.groupControl_chuyenTien.Controls.Add(this.text_soTKNhan);
            this.groupControl_chuyenTien.Controls.Add(this.text_soTKChuyen);
            this.groupControl_chuyenTien.Controls.Add(this.text_maNV);
            this.groupControl_chuyenTien.Controls.Add(this.text_soTien);
            this.groupControl_chuyenTien.Controls.Add(this.date_ngayGD);
            this.groupControl_chuyenTien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl_chuyenTien.Location = new System.Drawing.Point(0, 473);
            this.groupControl_chuyenTien.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl_chuyenTien.Name = "groupControl_chuyenTien";
            this.groupControl_chuyenTien.Size = new System.Drawing.Size(1882, 280);
            this.groupControl_chuyenTien.TabIndex = 6;
            this.groupControl_chuyenTien.Text = "THÔNG TIN GIAO DỊCH";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(50, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 102;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(50, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(50, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 110;
            this.label5.Text = "Mã nhân viên";
            // 
            // lbl_soTKChuyen
            // 
            this.lbl_soTKChuyen.AutoSize = true;
            this.lbl_soTKChuyen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_soTKChuyen.Location = new System.Drawing.Point(350, 75);
            this.lbl_soTKChuyen.Name = "lbl_soTKChuyen";
            this.lbl_soTKChuyen.Size = new System.Drawing.Size(141, 20);
            this.lbl_soTKChuyen.TabIndex = 109;
            this.lbl_soTKChuyen.Text = "Số tài khoản chuyển";
            this.lbl_soTKChuyen.Click += new System.EventHandler(this.lbl_soTKChuyen_Click);
            // 
            // lbl_soTien
            // 
            this.lbl_soTien.AutoSize = true;
            this.lbl_soTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_soTien.Location = new System.Drawing.Point(350, 175);
            this.lbl_soTien.Name = "lbl_soTien";
            this.lbl_soTien.Size = new System.Drawing.Size(55, 20);
            this.lbl_soTien.TabIndex = 108;
            this.lbl_soTien.Text = "Số tiền";
            this.lbl_soTien.Click += new System.EventHandler(this.lbl_soTien_Click);
            // 
            // lbl_soTKNhan
            // 
            this.lbl_soTKNhan.AutoSize = true;
            this.lbl_soTKNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_soTKNhan.Location = new System.Drawing.Point(650, 75);
            this.lbl_soTKNhan.Name = "lbl_soTKNhan";
            this.lbl_soTKNhan.Size = new System.Drawing.Size(127, 20);
            this.lbl_soTKNhan.TabIndex = 107;
            this.lbl_soTKNhan.Text = "Số tài khoản nhận";
            this.lbl_soTKNhan.Click += new System.EventHandler(this.lbl_soTKNhan_Click);
            // 
            // lbl_ngayGD
            // 
            this.lbl_ngayGD.AutoSize = true;
            this.lbl_ngayGD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_ngayGD.Location = new System.Drawing.Point(50, 75);
            this.lbl_ngayGD.Name = "lbl_ngayGD";
            this.lbl_ngayGD.Size = new System.Drawing.Size(110, 20);
            this.lbl_ngayGD.TabIndex = 106;
            this.lbl_ngayGD.Text = "Ngày giao dịch";
            // 
            // pnl_soTien
            // 
            this.pnl_soTien.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_soTien.Location = new System.Drawing.Point(350, 225);
            this.pnl_soTien.Name = "pnl_soTien";
            this.pnl_soTien.Size = new System.Drawing.Size(200, 2);
            this.pnl_soTien.TabIndex = 102;
            // 
            // btn_huyBo
            // 
            this.btn_huyBo.AllowAnimations = true;
            this.btn_huyBo.AllowMouseEffects = true;
            this.btn_huyBo.AllowToggling = false;
            this.btn_huyBo.AnimationSpeed = 200;
            this.btn_huyBo.AutoGenerateColors = false;
            this.btn_huyBo.AutoRoundBorders = false;
            this.btn_huyBo.AutoSizeLeftIcon = true;
            this.btn_huyBo.AutoSizeRightIcon = true;
            this.btn_huyBo.BackColor = System.Drawing.Color.Transparent;
            this.btn_huyBo.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(103)))));
            this.btn_huyBo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_huyBo.BackgroundImage")));
            this.btn_huyBo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_huyBo.ButtonText = "HỦY BỎ";
            this.btn_huyBo.ButtonTextMarginLeft = 0;
            this.btn_huyBo.ColorContrastOnClick = 45;
            this.btn_huyBo.ColorContrastOnHover = 45;
            this.btn_huyBo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_huyBo.CustomizableEdges = borderEdges1;
            this.btn_huyBo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_huyBo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_huyBo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_huyBo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_huyBo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_huyBo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_huyBo.ForeColor = System.Drawing.Color.White;
            this.btn_huyBo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huyBo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_huyBo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_huyBo.IconMarginLeft = 11;
            this.btn_huyBo.IconPadding = 10;
            this.btn_huyBo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_huyBo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_huyBo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_huyBo.IconSize = 25;
            this.btn_huyBo.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(103)))));
            this.btn_huyBo.IdleBorderRadius = 40;
            this.btn_huyBo.IdleBorderThickness = 2;
            this.btn_huyBo.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(103)))));
            this.btn_huyBo.IdleIconLeftImage = null;
            this.btn_huyBo.IdleIconRightImage = null;
            this.btn_huyBo.IndicateFocus = false;
            this.btn_huyBo.Location = new System.Drawing.Point(950, 176);
            this.btn_huyBo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huyBo.Name = "btn_huyBo";
            this.btn_huyBo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_huyBo.OnDisabledState.BorderRadius = 40;
            this.btn_huyBo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_huyBo.OnDisabledState.BorderThickness = 2;
            this.btn_huyBo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_huyBo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_huyBo.OnDisabledState.IconLeftImage = null;
            this.btn_huyBo.OnDisabledState.IconRightImage = null;
            this.btn_huyBo.onHoverState.BorderColor = System.Drawing.Color.DeepPink;
            this.btn_huyBo.onHoverState.BorderRadius = 40;
            this.btn_huyBo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_huyBo.onHoverState.BorderThickness = 2;
            this.btn_huyBo.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_huyBo.onHoverState.ForeColor = System.Drawing.Color.DeepPink;
            this.btn_huyBo.onHoverState.IconLeftImage = null;
            this.btn_huyBo.onHoverState.IconRightImage = null;
            this.btn_huyBo.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(103)))));
            this.btn_huyBo.OnIdleState.BorderRadius = 40;
            this.btn_huyBo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_huyBo.OnIdleState.BorderThickness = 2;
            this.btn_huyBo.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(103)))));
            this.btn_huyBo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_huyBo.OnIdleState.IconLeftImage = null;
            this.btn_huyBo.OnIdleState.IconRightImage = null;
            this.btn_huyBo.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_huyBo.OnPressedState.BorderRadius = 40;
            this.btn_huyBo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_huyBo.OnPressedState.BorderThickness = 2;
            this.btn_huyBo.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btn_huyBo.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(103)))));
            this.btn_huyBo.OnPressedState.IconLeftImage = null;
            this.btn_huyBo.OnPressedState.IconRightImage = null;
            this.btn_huyBo.Size = new System.Drawing.Size(200, 48);
            this.btn_huyBo.TabIndex = 103;
            this.btn_huyBo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_huyBo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_huyBo.TextMarginLeft = 0;
            this.btn_huyBo.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_huyBo.UseDefaultRadiusAndThickness = true;
            this.btn_huyBo.Click += new System.EventHandler(this.btn_huyBo_Click);
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.AllowAnimations = true;
            this.btn_xacNhan.AllowMouseEffects = true;
            this.btn_xacNhan.AllowToggling = false;
            this.btn_xacNhan.AnimationSpeed = 200;
            this.btn_xacNhan.AutoGenerateColors = false;
            this.btn_xacNhan.AutoRoundBorders = false;
            this.btn_xacNhan.AutoSizeLeftIcon = true;
            this.btn_xacNhan.AutoSizeRightIcon = true;
            this.btn_xacNhan.BackColor = System.Drawing.Color.Transparent;
            this.btn_xacNhan.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_xacNhan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_xacNhan.BackgroundImage")));
            this.btn_xacNhan.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_xacNhan.ButtonText = "XÁC NHẬN";
            this.btn_xacNhan.ButtonTextMarginLeft = 0;
            this.btn_xacNhan.ColorContrastOnClick = 45;
            this.btn_xacNhan.ColorContrastOnHover = 45;
            this.btn_xacNhan.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_xacNhan.CustomizableEdges = borderEdges2;
            this.btn_xacNhan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xacNhan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_xacNhan.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_xacNhan.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_xacNhan.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_xacNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_xacNhan.ForeColor = System.Drawing.Color.White;
            this.btn_xacNhan.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xacNhan.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_xacNhan.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_xacNhan.IconMarginLeft = 11;
            this.btn_xacNhan.IconPadding = 10;
            this.btn_xacNhan.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xacNhan.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_xacNhan.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_xacNhan.IconSize = 25;
            this.btn_xacNhan.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_xacNhan.IdleBorderRadius = 40;
            this.btn_xacNhan.IdleBorderThickness = 2;
            this.btn_xacNhan.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_xacNhan.IdleIconLeftImage = null;
            this.btn_xacNhan.IdleIconRightImage = null;
            this.btn_xacNhan.IndicateFocus = false;
            this.btn_xacNhan.Location = new System.Drawing.Point(650, 176);
            this.btn_xacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_xacNhan.OnDisabledState.BorderRadius = 40;
            this.btn_xacNhan.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_xacNhan.OnDisabledState.BorderThickness = 2;
            this.btn_xacNhan.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_xacNhan.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_xacNhan.OnDisabledState.IconLeftImage = null;
            this.btn_xacNhan.OnDisabledState.IconRightImage = null;
            this.btn_xacNhan.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btn_xacNhan.onHoverState.BorderRadius = 40;
            this.btn_xacNhan.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_xacNhan.onHoverState.BorderThickness = 2;
            this.btn_xacNhan.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_xacNhan.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btn_xacNhan.onHoverState.IconLeftImage = null;
            this.btn_xacNhan.onHoverState.IconRightImage = null;
            this.btn_xacNhan.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_xacNhan.OnIdleState.BorderRadius = 40;
            this.btn_xacNhan.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_xacNhan.OnIdleState.BorderThickness = 2;
            this.btn_xacNhan.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_xacNhan.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_xacNhan.OnIdleState.IconLeftImage = null;
            this.btn_xacNhan.OnIdleState.IconRightImage = null;
            this.btn_xacNhan.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_xacNhan.OnPressedState.BorderRadius = 40;
            this.btn_xacNhan.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_xacNhan.OnPressedState.BorderThickness = 2;
            this.btn_xacNhan.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btn_xacNhan.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_xacNhan.OnPressedState.IconLeftImage = null;
            this.btn_xacNhan.OnPressedState.IconRightImage = null;
            this.btn_xacNhan.Size = new System.Drawing.Size(200, 48);
            this.btn_xacNhan.TabIndex = 102;
            this.btn_xacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xacNhan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xacNhan.TextMarginLeft = 0;
            this.btn_xacNhan.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_xacNhan.UseDefaultRadiusAndThickness = true;
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // pnl_soTKNhan
            // 
            this.pnl_soTKNhan.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_soTKNhan.Location = new System.Drawing.Point(650, 122);
            this.pnl_soTKNhan.Name = "pnl_soTKNhan";
            this.pnl_soTKNhan.Size = new System.Drawing.Size(200, 2);
            this.pnl_soTKNhan.TabIndex = 101;
            // 
            // pnl_soTKChuyen
            // 
            this.pnl_soTKChuyen.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_soTKChuyen.Location = new System.Drawing.Point(350, 122);
            this.pnl_soTKChuyen.Name = "pnl_soTKChuyen";
            this.pnl_soTKChuyen.Size = new System.Drawing.Size(200, 2);
            this.pnl_soTKChuyen.TabIndex = 100;
            // 
            // text_soTKNhan
            // 
            this.text_soTKNhan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDchuyenTien, "SOTK_NHAN", true));
            this.text_soTKNhan.Location = new System.Drawing.Point(650, 100);
            this.text_soTKNhan.Margin = new System.Windows.Forms.Padding(4);
            this.text_soTKNhan.MenuManager = this.barManager1;
            this.text_soTKNhan.Name = "text_soTKNhan";
            this.text_soTKNhan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_soTKNhan.Size = new System.Drawing.Size(200, 20);
            this.text_soTKNhan.TabIndex = 1;
            this.text_soTKNhan.Enter += new System.EventHandler(this.text_soTKNhan_Enter);
            this.text_soTKNhan.Leave += new System.EventHandler(this.text_soTKNhan_Leave);
            // 
            // text_soTKChuyen
            // 
            this.text_soTKChuyen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDchuyenTien, "SOTK_CHUYEN", true));
            this.text_soTKChuyen.Location = new System.Drawing.Point(350, 100);
            this.text_soTKChuyen.Margin = new System.Windows.Forms.Padding(4);
            this.text_soTKChuyen.MenuManager = this.barManager1;
            this.text_soTKChuyen.Name = "text_soTKChuyen";
            this.text_soTKChuyen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_soTKChuyen.Size = new System.Drawing.Size(200, 20);
            this.text_soTKChuyen.TabIndex = 0;
            this.text_soTKChuyen.Enter += new System.EventHandler(this.text_soTKChuyen_Enter);
            this.text_soTKChuyen.Leave += new System.EventHandler(this.text_soTKChuyen_Leave);
            // 
            // text_maNV
            // 
            this.text_maNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDchuyenTien, "MANV", true));
            this.text_maNV.Location = new System.Drawing.Point(50, 200);
            this.text_maNV.Margin = new System.Windows.Forms.Padding(4);
            this.text_maNV.MenuManager = this.barManager1;
            this.text_maNV.Name = "text_maNV";
            this.text_maNV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_maNV.Size = new System.Drawing.Size(200, 20);
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
            this.text_soTien.Location = new System.Drawing.Point(350, 200);
            this.text_soTien.Margin = new System.Windows.Forms.Padding(4);
            this.text_soTien.MenuManager = this.barManager1;
            this.text_soTien.Name = "text_soTien";
            this.text_soTien.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_soTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text_soTien.Properties.DisplayFormat.FormatString = "N0";
            this.text_soTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.text_soTien.Size = new System.Drawing.Size(200, 22);
            this.text_soTien.TabIndex = 2;
            this.text_soTien.Enter += new System.EventHandler(this.text_soTien_Enter);
            this.text_soTien.Leave += new System.EventHandler(this.text_soTien_Leave);
            // 
            // date_ngayGD
            // 
            this.date_ngayGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDchuyenTien, "NGAYGD", true));
            this.date_ngayGD.EditValue = null;
            this.date_ngayGD.Location = new System.Drawing.Point(50, 100);
            this.date_ngayGD.Margin = new System.Windows.Forms.Padding(4);
            this.date_ngayGD.MenuManager = this.barManager1;
            this.date_ngayGD.Name = "date_ngayGD";
            this.date_ngayGD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.date_ngayGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ngayGD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ngayGD.Size = new System.Drawing.Size(200, 20);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 753);
            this.Controls.Add(this.groupControl_chuyenTien);
            this.Controls.Add(this.groupControl_chiNhanh);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_chuyenTien";
            this.Text = "GIAO DỊCH CHUYỂN TIỀN";
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
        private DevExpress.XtraBars.Bar bar2;
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
        private DevExpress.XtraGrid.GridControl gD_CHUYENTIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_CHUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_NHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.Panel pnl_soTKNhan;
        private System.Windows.Forms.Panel pnl_soTKChuyen;
        private DevExpress.XtraEditors.TextEdit text_soTKNhan;
        private DevExpress.XtraEditors.TextEdit text_soTKChuyen;
        private DevExpress.XtraEditors.TextEdit text_maNV;
        private DevExpress.XtraEditors.SpinEdit text_soTien;
        private DevExpress.XtraEditors.DateEdit date_ngayGD;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_huyBo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_xacNhan;
        private System.Windows.Forms.Panel pnl_soTien;
        private DevExpress.XtraBars.BarButtonItem btn_reload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_soTKChuyen;
        private System.Windows.Forms.Label lbl_soTien;
        private System.Windows.Forms.Label lbl_soTKNhan;
        private System.Windows.Forms.Label lbl_ngayGD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}