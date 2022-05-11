namespace NganHang
{
    partial class Frm_goiRut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_goiRut));
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
            this.btn_sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.dS = new NganHang.DS();
            this.bds_GDGoiRut = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GOIRUTTableAdapter = new NganHang.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new NganHang.DSTableAdapters.TaiKhoanTableAdapter();
            this.dS_DSPHANMANH = new NganHang.DS_DSPHANMANH();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new NganHang.DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new NganHang.DS_DSPHANMANHTableAdapters.TableAdapterManager();
            this.groupControl_chiNhanh = new DevExpress.XtraEditors.GroupControl();
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gD_GOIRUTGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_goiRut = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_soTien = new System.Windows.Forms.Panel();
            this.pnl_soTK = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_soTK = new System.Windows.Forms.Label();
            this.lbl_soTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_loaiGD = new System.Windows.Forms.Label();
            this.btn_huyBo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_xacNhan = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.text_soTien = new DevExpress.XtraEditors.SpinEdit();
            this.date_ngayGD = new DevExpress.XtraEditors.DateEdit();
            this.text_maNV = new DevExpress.XtraEditors.TextEdit();
            this.cmb_loaiGD = new System.Windows.Forms.ComboBox();
            this.text_soTK = new DevExpress.XtraEditors.TextEdit();
            tENCNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GDGoiRut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).BeginInit();
            this.groupControl_chiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_goiRut)).BeginInit();
            this.groupControl_goiRut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayGD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_maNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(65, 60);
            tENCNLabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(70, 17);
            tENCNLabel.TabIndex = 0;
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
            this.btn_sua,
            this.btn_xoa,
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
            // btn_sua
            // 
            this.btn_sua.Caption = "Sửa";
            this.btn_sua.Id = 1;
            this.btn_sua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sua.ImageOptions.SvgImage")));
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Caption = "Xoá";
            this.btn_xoa.Id = 2;
            this.btn_xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_xoa.ImageOptions.SvgImage")));
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_GDGoiRut
            // 
            this.bds_GDGoiRut.DataMember = "GD_GOIRUT";
            this.bds_GDGoiRut.DataSource = this.dS;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.gD_GOIRUTTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.dS;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // dS_DSPHANMANH
            // 
            this.dS_DSPHANMANH.DataSetName = "DS_DSPHANMANH";
            this.dS_DSPHANMANH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.dS_DSPHANMANH;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = NganHang.DS_DSPHANMANHTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupControl_chiNhanh
            // 
            this.groupControl_chiNhanh.Controls.Add(tENCNLabel);
            this.groupControl_chiNhanh.Controls.Add(this.cmb_chiNhanh);
            this.groupControl_chiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_chiNhanh.Location = new System.Drawing.Point(0, 30);
            this.groupControl_chiNhanh.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.groupControl_chiNhanh.Name = "groupControl_chiNhanh";
            this.groupControl_chiNhanh.Size = new System.Drawing.Size(1882, 110);
            this.groupControl_chiNhanh.TabIndex = 20;
            this.groupControl_chiNhanh.Text = "CHỌN CHI NHÁNH";
            // 
            // cmb_chiNhanh
            // 
            this.cmb_chiNhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DS_PHANMANHBindingSource, "TENCN", true));
            this.cmb_chiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chiNhanh.FormattingEnabled = true;
            this.cmb_chiNhanh.Location = new System.Drawing.Point(145, 55);
            this.cmb_chiNhanh.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.cmb_chiNhanh.Name = "cmb_chiNhanh";
            this.cmb_chiNhanh.Size = new System.Drawing.Size(200, 24);
            this.cmb_chiNhanh.TabIndex = 1;
            this.cmb_chiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmb_chiNhanh_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gD_GOIRUTGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 143);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1882, 335);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "BẢNG GIAO DỊCH GỬI RÚT";
            // 
            // gD_GOIRUTGridControl
            // 
            this.gD_GOIRUTGridControl.DataSource = this.bds_GDGoiRut;
            this.gD_GOIRUTGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gD_GOIRUTGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.gD_GOIRUTGridControl.Location = new System.Drawing.Point(2, 28);
            this.gD_GOIRUTGridControl.MainView = this.gridView1;
            this.gD_GOIRUTGridControl.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.gD_GOIRUTGridControl.MenuManager = this.barManager1;
            this.gD_GOIRUTGridControl.Name = "gD_GOIRUTGridControl";
            this.gD_GOIRUTGridControl.Size = new System.Drawing.Size(1878, 305);
            this.gD_GOIRUTGridControl.TabIndex = 1;
            this.gD_GOIRUTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colSOTK,
            this.colLOAIGD,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colMANV});
            this.gridView1.DetailHeight = 1315;
            this.gridView1.GridControl = this.gD_GOIRUTGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGD
            // 
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.MinWidth = 81;
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            this.colMAGD.Width = 305;
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 81;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 1;
            this.colSOTK.Width = 305;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.MinWidth = 81;
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 2;
            this.colLOAIGD.Width = 305;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 81;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 3;
            this.colNGAYGD.Width = 305;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.DisplayFormat.FormatString = "N0";
            this.colSOTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 81;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 4;
            this.colSOTIEN.Width = 305;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 81;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 5;
            this.colMANV.Width = 305;
            // 
            // groupControl_goiRut
            // 
            this.groupControl_goiRut.Controls.Add(this.panel3);
            this.groupControl_goiRut.Controls.Add(this.panel2);
            this.groupControl_goiRut.Controls.Add(this.panel1);
            this.groupControl_goiRut.Controls.Add(this.pnl_soTien);
            this.groupControl_goiRut.Controls.Add(this.pnl_soTK);
            this.groupControl_goiRut.Controls.Add(this.label7);
            this.groupControl_goiRut.Controls.Add(this.lbl_soTK);
            this.groupControl_goiRut.Controls.Add(this.lbl_soTien);
            this.groupControl_goiRut.Controls.Add(this.label4);
            this.groupControl_goiRut.Controls.Add(this.label3);
            this.groupControl_goiRut.Controls.Add(this.lbl_loaiGD);
            this.groupControl_goiRut.Controls.Add(this.btn_huyBo);
            this.groupControl_goiRut.Controls.Add(this.btn_xacNhan);
            this.groupControl_goiRut.Controls.Add(this.text_soTien);
            this.groupControl_goiRut.Controls.Add(this.date_ngayGD);
            this.groupControl_goiRut.Controls.Add(this.text_maNV);
            this.groupControl_goiRut.Controls.Add(this.cmb_loaiGD);
            this.groupControl_goiRut.Controls.Add(this.text_soTK);
            this.groupControl_goiRut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl_goiRut.Location = new System.Drawing.Point(0, 473);
            this.groupControl_goiRut.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.groupControl_goiRut.Name = "groupControl_goiRut";
            this.groupControl_goiRut.Size = new System.Drawing.Size(1882, 280);
            this.groupControl_goiRut.TabIndex = 26;
            this.groupControl_goiRut.Text = "THÔNG TIN GIAO DỊCH";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(650, 122);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 113;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(350, 218);
            this.panel3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 114;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(50, 218);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 112;
            // 
            // pnl_soTien
            // 
            this.pnl_soTien.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_soTien.Location = new System.Drawing.Point(350, 122);
            this.pnl_soTien.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pnl_soTien.Name = "pnl_soTien";
            this.pnl_soTien.Size = new System.Drawing.Size(200, 2);
            this.pnl_soTien.TabIndex = 112;
            // 
            // pnl_soTK
            // 
            this.pnl_soTK.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_soTK.Location = new System.Drawing.Point(50, 122);
            this.pnl_soTK.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pnl_soTK.Name = "pnl_soTK";
            this.pnl_soTK.Size = new System.Drawing.Size(200, 2);
            this.pnl_soTK.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 110;
            this.label7.Text = "VND";
            // 
            // lbl_soTK
            // 
            this.lbl_soTK.AutoSize = true;
            this.lbl_soTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_soTK.Location = new System.Drawing.Point(50, 75);
            this.lbl_soTK.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbl_soTK.Name = "lbl_soTK";
            this.lbl_soTK.Size = new System.Drawing.Size(91, 20);
            this.lbl_soTK.TabIndex = 109;
            this.lbl_soTK.Text = "Số tài khoản";
            this.lbl_soTK.Click += new System.EventHandler(this.lbl_soTK_Click);
            // 
            // lbl_soTien
            // 
            this.lbl_soTien.AutoSize = true;
            this.lbl_soTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_soTien.Location = new System.Drawing.Point(350, 75);
            this.lbl_soTien.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbl_soTien.Name = "lbl_soTien";
            this.lbl_soTien.Size = new System.Drawing.Size(55, 20);
            this.lbl_soTien.TabIndex = 108;
            this.lbl_soTien.Text = "Số tiền";
            this.lbl_soTien.Click += new System.EventHandler(this.lbl_soTien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(350, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 107;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(50, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 106;
            this.label3.Text = "Ngày giao dịch";
            // 
            // lbl_loaiGD
            // 
            this.lbl_loaiGD.AutoSize = true;
            this.lbl_loaiGD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_loaiGD.Location = new System.Drawing.Point(650, 75);
            this.lbl_loaiGD.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbl_loaiGD.Name = "lbl_loaiGD";
            this.lbl_loaiGD.Size = new System.Drawing.Size(103, 20);
            this.lbl_loaiGD.TabIndex = 105;
            this.lbl_loaiGD.Text = "Loại giao dịch";
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
            this.btn_huyBo.Location = new System.Drawing.Point(950, 175);
            this.btn_huyBo.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
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
            this.btn_huyBo.TabIndex = 104;
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
            this.btn_xacNhan.Location = new System.Drawing.Point(650, 175);
            this.btn_xacNhan.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
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
            this.btn_xacNhan.TabIndex = 103;
            this.btn_xacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xacNhan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xacNhan.TextMarginLeft = 0;
            this.btn_xacNhan.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_xacNhan.UseDefaultRadiusAndThickness = true;
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // text_soTien
            // 
            this.text_soTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDGoiRut, "SOTIEN", true));
            this.text_soTien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.text_soTien.Location = new System.Drawing.Point(350, 100);
            this.text_soTien.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.text_soTien.MenuManager = this.barManager1;
            this.text_soTien.Name = "text_soTien";
            this.text_soTien.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_soTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text_soTien.Size = new System.Drawing.Size(200, 22);
            this.text_soTien.TabIndex = 2;
            this.text_soTien.Enter += new System.EventHandler(this.text_soTien_Enter);
            this.text_soTien.Leave += new System.EventHandler(this.text_soTien_Leave);
            // 
            // date_ngayGD
            // 
            this.date_ngayGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDGoiRut, "NGAYGD", true));
            this.date_ngayGD.EditValue = "";
            this.date_ngayGD.Location = new System.Drawing.Point(50, 200);
            this.date_ngayGD.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.date_ngayGD.MenuManager = this.barManager1;
            this.date_ngayGD.Name = "date_ngayGD";
            this.date_ngayGD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.date_ngayGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ngayGD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ngayGD.Size = new System.Drawing.Size(200, 20);
            this.date_ngayGD.TabIndex = 13;
            // 
            // text_maNV
            // 
            this.text_maNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDGoiRut, "MANV", true));
            this.text_maNV.Location = new System.Drawing.Point(350, 200);
            this.text_maNV.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.text_maNV.MenuManager = this.barManager1;
            this.text_maNV.Name = "text_maNV";
            this.text_maNV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_maNV.Size = new System.Drawing.Size(200, 20);
            this.text_maNV.TabIndex = 9;
            // 
            // cmb_loaiGD
            // 
            this.cmb_loaiGD.BackColor = System.Drawing.Color.White;
            this.cmb_loaiGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_GDGoiRut, "LOAIGD", true));
            this.cmb_loaiGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_loaiGD.FormattingEnabled = true;
            this.cmb_loaiGD.Location = new System.Drawing.Point(650, 100);
            this.cmb_loaiGD.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.cmb_loaiGD.Name = "cmb_loaiGD";
            this.cmb_loaiGD.Size = new System.Drawing.Size(200, 24);
            this.cmb_loaiGD.TabIndex = 3;
            // 
            // text_soTK
            // 
            this.text_soTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDGoiRut, "SOTK", true));
            this.text_soTK.Location = new System.Drawing.Point(50, 100);
            this.text_soTK.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.text_soTK.MenuManager = this.barManager1;
            this.text_soTK.Name = "text_soTK";
            this.text_soTK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_soTK.Size = new System.Drawing.Size(200, 20);
            this.text_soTK.TabIndex = 1;
            this.text_soTK.Enter += new System.EventHandler(this.text_soTK_Enter);
            this.text_soTK.Leave += new System.EventHandler(this.text_soTK_Leave);
            // 
            // Frm_goiRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 753);
            this.Controls.Add(this.groupControl_goiRut);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl_chiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_goiRut";
            this.Text = "GIAO DỊCH GỦI RÚT";
            this.Load += new System.EventHandler(this.Frm_goiRut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GDGoiRut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).EndInit();
            this.groupControl_chiNhanh.ResumeLayout(false);
            this.groupControl_chiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_goiRut)).EndInit();
            this.groupControl_goiRut.ResumeLayout(false);
            this.groupControl_goiRut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayGD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_maNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTK.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource bds_GDGoiRut;
        private DS dS;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_sua;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DS_DSPHANMANH dS_DSPHANMANH;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPHANMANHTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gD_GOIRUTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraEditors.GroupControl groupControl_chiNhanh;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private DevExpress.XtraEditors.GroupControl groupControl_goiRut;
        private DevExpress.XtraEditors.SpinEdit text_soTien;
        private DevExpress.XtraEditors.DateEdit date_ngayGD;
        private DevExpress.XtraEditors.TextEdit text_maNV;
        private System.Windows.Forms.ComboBox cmb_loaiGD;
        private DevExpress.XtraEditors.TextEdit text_soTK;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_xacNhan;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_huyBo;
        private System.Windows.Forms.Label lbl_soTK;
        private System.Windows.Forms.Label lbl_soTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_loaiGD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl_soTien;
        private System.Windows.Forms.Panel pnl_soTK;
        private DevExpress.XtraBars.BarButtonItem btn_reload;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}