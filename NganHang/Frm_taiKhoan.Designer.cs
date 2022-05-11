namespace NganHang
{
    partial class Frm_taiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_taiKhoan));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_phucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ghi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_huy = new DevExpress.XtraBars.BarButtonItem();
            this.btn_reload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl_chiNhanh = new DevExpress.XtraEditors.GroupControl();
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPHANMANH = new NganHang.DS_DSPHANMANH();
            this.bds_taiKhoan = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new NganHang.DS();
            this.taiKhoanTableAdapter = new NganHang.DSTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            this.text_soTK = new DevExpress.XtraEditors.TextEdit();
            this.text_cmnd = new DevExpress.XtraEditors.TextEdit();
            this.text_maCN = new DevExpress.XtraEditors.TextEdit();
            this.groupControl_taiKhoan = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_soTK = new System.Windows.Forms.Label();
            this.lbl_soDu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_cmnd = new System.Windows.Forms.Label();
            this.btn_traCuu = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnl_soDu = new System.Windows.Forms.Panel();
            this.pnl_cmnd = new System.Windows.Forms.Panel();
            this.pnl_soTK = new System.Windows.Forms.Panel();
            this.text_soDu = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.date_ngayMoTK = new DevExpress.XtraEditors.DateEdit();
            this.v_DS_PHANMANHTableAdapter = new NganHang.DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new NganHang.DS_DSPHANMANHTableAdapters.TableAdapterManager();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.đi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsGR = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GOIRUTTableAdapter = new NganHang.DSTableAdapters.GD_GOIRUTTableAdapter();
            tENCNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).BeginInit();
            this.groupControl_chiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_taiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_cmnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_maCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_taiKhoan)).BeginInit();
            this.groupControl_taiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_soDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayMoTK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayMoTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGR)).BeginInit();
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
            this.btn_phucHoi,
            this.btn_ghi,
            this.btn_huy,
            this.btn_reload});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_them),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_phucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ghi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_huy),
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
            // btn_reload
            // 
            this.btn_reload.Caption = "Reload";
            this.btn_reload.Id = 6;
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
            // groupControl_chiNhanh
            // 
            this.groupControl_chiNhanh.Controls.Add(tENCNLabel);
            this.groupControl_chiNhanh.Controls.Add(this.cmb_chiNhanh);
            this.groupControl_chiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_chiNhanh.Location = new System.Drawing.Point(0, 30);
            this.groupControl_chiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl_chiNhanh.Name = "groupControl_chiNhanh";
            this.groupControl_chiNhanh.Size = new System.Drawing.Size(1882, 110);
            this.groupControl_chiNhanh.TabIndex = 4;
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
            this.cmb_chiNhanh.Size = new System.Drawing.Size(171, 24);
            this.cmb_chiNhanh.TabIndex = 1;
            this.cmb_chiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmb_chiNhanh_SelectedIndexChanged);
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
            // bds_taiKhoan
            // 
            this.bds_taiKhoan.DataMember = "TaiKhoan";
            this.bds_taiKhoan.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // text_soTK
            // 
            this.text_soTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_taiKhoan, "SOTK", true));
            this.text_soTK.Location = new System.Drawing.Point(50, 100);
            this.text_soTK.Margin = new System.Windows.Forms.Padding(4);
            this.text_soTK.MenuManager = this.barManager1;
            this.text_soTK.Name = "text_soTK";
            this.text_soTK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_soTK.Size = new System.Drawing.Size(200, 20);
            this.text_soTK.TabIndex = 1;
            this.text_soTK.Enter += new System.EventHandler(this.text_soTK_Enter);
            this.text_soTK.Leave += new System.EventHandler(this.text_soTK_Leave);
            // 
            // text_cmnd
            // 
            this.text_cmnd.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_taiKhoan, "CMND", true));
            this.text_cmnd.Location = new System.Drawing.Point(350, 100);
            this.text_cmnd.Margin = new System.Windows.Forms.Padding(4);
            this.text_cmnd.MenuManager = this.barManager1;
            this.text_cmnd.Name = "text_cmnd";
            this.text_cmnd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_cmnd.Size = new System.Drawing.Size(200, 20);
            this.text_cmnd.TabIndex = 2;
            this.text_cmnd.Enter += new System.EventHandler(this.text_cmnd_Enter);
            this.text_cmnd.Leave += new System.EventHandler(this.text_cmnd_Leave);
            // 
            // text_maCN
            // 
            this.text_maCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_taiKhoan, "MACN", true));
            this.text_maCN.Location = new System.Drawing.Point(350, 200);
            this.text_maCN.Margin = new System.Windows.Forms.Padding(4);
            this.text_maCN.MenuManager = this.barManager1;
            this.text_maCN.Name = "text_maCN";
            this.text_maCN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_maCN.Size = new System.Drawing.Size(200, 20);
            this.text_maCN.TabIndex = 2;
            // 
            // groupControl_taiKhoan
            // 
            this.groupControl_taiKhoan.Controls.Add(this.panel2);
            this.groupControl_taiKhoan.Controls.Add(this.panel1);
            this.groupControl_taiKhoan.Controls.Add(this.lbl_soTK);
            this.groupControl_taiKhoan.Controls.Add(this.lbl_soDu);
            this.groupControl_taiKhoan.Controls.Add(this.label4);
            this.groupControl_taiKhoan.Controls.Add(this.label3);
            this.groupControl_taiKhoan.Controls.Add(this.lbl_cmnd);
            this.groupControl_taiKhoan.Controls.Add(this.btn_traCuu);
            this.groupControl_taiKhoan.Controls.Add(this.pnl_soDu);
            this.groupControl_taiKhoan.Controls.Add(this.pnl_cmnd);
            this.groupControl_taiKhoan.Controls.Add(this.pnl_soTK);
            this.groupControl_taiKhoan.Controls.Add(this.text_soDu);
            this.groupControl_taiKhoan.Controls.Add(this.label1);
            this.groupControl_taiKhoan.Controls.Add(this.date_ngayMoTK);
            this.groupControl_taiKhoan.Controls.Add(this.text_maCN);
            this.groupControl_taiKhoan.Controls.Add(this.text_cmnd);
            this.groupControl_taiKhoan.Controls.Add(this.text_soTK);
            this.groupControl_taiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl_taiKhoan.Location = new System.Drawing.Point(0, 473);
            this.groupControl_taiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl_taiKhoan.Name = "groupControl_taiKhoan";
            this.groupControl_taiKhoan.Size = new System.Drawing.Size(1882, 280);
            this.groupControl_taiKhoan.TabIndex = 9;
            this.groupControl_taiKhoan.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(50, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(350, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 19;
            // 
            // lbl_soTK
            // 
            this.lbl_soTK.AutoSize = true;
            this.lbl_soTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_soTK.Location = new System.Drawing.Point(50, 75);
            this.lbl_soTK.Name = "lbl_soTK";
            this.lbl_soTK.Size = new System.Drawing.Size(91, 20);
            this.lbl_soTK.TabIndex = 30;
            this.lbl_soTK.Text = "Số tài khoản";
            this.lbl_soTK.Click += new System.EventHandler(this.lbl_soTK_Click);
            // 
            // lbl_soDu
            // 
            this.lbl_soDu.AutoSize = true;
            this.lbl_soDu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_soDu.Location = new System.Drawing.Point(650, 75);
            this.lbl_soDu.Name = "lbl_soDu";
            this.lbl_soDu.Size = new System.Drawing.Size(48, 20);
            this.lbl_soDu.TabIndex = 29;
            this.lbl_soDu.Text = "Số dư";
            this.lbl_soDu.Click += new System.EventHandler(this.lbl_soDu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(50, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ngày mở tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(350, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã chi nhánh";
            // 
            // lbl_cmnd
            // 
            this.lbl_cmnd.AutoSize = true;
            this.lbl_cmnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_cmnd.Location = new System.Drawing.Point(350, 75);
            this.lbl_cmnd.Name = "lbl_cmnd";
            this.lbl_cmnd.Size = new System.Drawing.Size(53, 20);
            this.lbl_cmnd.TabIndex = 26;
            this.lbl_cmnd.Text = "CMND";
            this.lbl_cmnd.Click += new System.EventHandler(this.lbl_cmnd_Click);
            // 
            // btn_traCuu
            // 
            this.btn_traCuu.AllowAnimations = true;
            this.btn_traCuu.AllowMouseEffects = true;
            this.btn_traCuu.AllowToggling = false;
            this.btn_traCuu.AnimationSpeed = 200;
            this.btn_traCuu.AutoGenerateColors = false;
            this.btn_traCuu.AutoRoundBorders = false;
            this.btn_traCuu.AutoSizeLeftIcon = true;
            this.btn_traCuu.AutoSizeRightIcon = true;
            this.btn_traCuu.BackColor = System.Drawing.Color.Transparent;
            this.btn_traCuu.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.btn_traCuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_traCuu.BackgroundImage")));
            this.btn_traCuu.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_traCuu.ButtonText = "TRA CỨU";
            this.btn_traCuu.ButtonTextMarginLeft = 0;
            this.btn_traCuu.ColorContrastOnClick = 45;
            this.btn_traCuu.ColorContrastOnHover = 45;
            this.btn_traCuu.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_traCuu.CustomizableEdges = borderEdges1;
            this.btn_traCuu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_traCuu.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_traCuu.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_traCuu.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_traCuu.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_traCuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_traCuu.ForeColor = System.Drawing.Color.White;
            this.btn_traCuu.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_traCuu.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_traCuu.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_traCuu.IconMarginLeft = 11;
            this.btn_traCuu.IconPadding = 10;
            this.btn_traCuu.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_traCuu.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_traCuu.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_traCuu.IconSize = 25;
            this.btn_traCuu.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.btn_traCuu.IdleBorderRadius = 40;
            this.btn_traCuu.IdleBorderThickness = 2;
            this.btn_traCuu.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.btn_traCuu.IdleIconLeftImage = null;
            this.btn_traCuu.IdleIconRightImage = null;
            this.btn_traCuu.IndicateFocus = false;
            this.btn_traCuu.Location = new System.Drawing.Point(650, 176);
            this.btn_traCuu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_traCuu.Name = "btn_traCuu";
            this.btn_traCuu.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_traCuu.OnDisabledState.BorderRadius = 40;
            this.btn_traCuu.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_traCuu.OnDisabledState.BorderThickness = 2;
            this.btn_traCuu.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_traCuu.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_traCuu.OnDisabledState.IconLeftImage = null;
            this.btn_traCuu.OnDisabledState.IconRightImage = null;
            this.btn_traCuu.onHoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_traCuu.onHoverState.BorderRadius = 40;
            this.btn_traCuu.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_traCuu.onHoverState.BorderThickness = 2;
            this.btn_traCuu.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_traCuu.onHoverState.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_traCuu.onHoverState.IconLeftImage = null;
            this.btn_traCuu.onHoverState.IconRightImage = null;
            this.btn_traCuu.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.btn_traCuu.OnIdleState.BorderRadius = 40;
            this.btn_traCuu.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_traCuu.OnIdleState.BorderThickness = 2;
            this.btn_traCuu.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.btn_traCuu.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_traCuu.OnIdleState.IconLeftImage = null;
            this.btn_traCuu.OnIdleState.IconRightImage = null;
            this.btn_traCuu.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_traCuu.OnPressedState.BorderRadius = 40;
            this.btn_traCuu.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_traCuu.OnPressedState.BorderThickness = 2;
            this.btn_traCuu.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btn_traCuu.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.btn_traCuu.OnPressedState.IconLeftImage = null;
            this.btn_traCuu.OnPressedState.IconRightImage = null;
            this.btn_traCuu.Size = new System.Drawing.Size(200, 48);
            this.btn_traCuu.TabIndex = 15;
            this.btn_traCuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_traCuu.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_traCuu.TextMarginLeft = 0;
            this.btn_traCuu.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_traCuu.UseDefaultRadiusAndThickness = true;
            this.btn_traCuu.Click += new System.EventHandler(this.btn_traCuu_Click);
            // 
            // pnl_soDu
            // 
            this.pnl_soDu.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_soDu.Location = new System.Drawing.Point(650, 122);
            this.pnl_soDu.Name = "pnl_soDu";
            this.pnl_soDu.Size = new System.Drawing.Size(200, 2);
            this.pnl_soDu.TabIndex = 19;
            // 
            // pnl_cmnd
            // 
            this.pnl_cmnd.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_cmnd.Location = new System.Drawing.Point(350, 122);
            this.pnl_cmnd.Name = "pnl_cmnd";
            this.pnl_cmnd.Size = new System.Drawing.Size(200, 2);
            this.pnl_cmnd.TabIndex = 18;
            // 
            // pnl_soTK
            // 
            this.pnl_soTK.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_soTK.Location = new System.Drawing.Point(50, 122);
            this.pnl_soTK.Name = "pnl_soTK";
            this.pnl_soTK.Size = new System.Drawing.Size(200, 2);
            this.pnl_soTK.TabIndex = 17;
            // 
            // text_soDu
            // 
            this.text_soDu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_taiKhoan, "SODU", true));
            this.text_soDu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.text_soDu.Location = new System.Drawing.Point(650, 100);
            this.text_soDu.Margin = new System.Windows.Forms.Padding(4);
            this.text_soDu.MenuManager = this.barManager1;
            this.text_soDu.Name = "text_soDu";
            this.text_soDu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_soDu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text_soDu.Properties.DisplayFormat.FormatString = "N0";
            this.text_soDu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.text_soDu.Size = new System.Drawing.Size(200, 22);
            this.text_soDu.TabIndex = 4;
            this.text_soDu.Enter += new System.EventHandler(this.text_soDu_Enter);
            this.text_soDu.Leave += new System.EventHandler(this.text_soDu_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(858, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "VND";
            // 
            // date_ngayMoTK
            // 
            this.date_ngayMoTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_taiKhoan, "NGAYMOTK", true));
            this.date_ngayMoTK.EditValue = null;
            this.date_ngayMoTK.Location = new System.Drawing.Point(50, 200);
            this.date_ngayMoTK.Margin = new System.Windows.Forms.Padding(4);
            this.date_ngayMoTK.MenuManager = this.barManager1;
            this.date_ngayMoTK.Name = "date_ngayMoTK";
            this.date_ngayMoTK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.date_ngayMoTK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ngayMoTK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ngayMoTK.Size = new System.Drawing.Size(200, 20);
            this.date_ngayMoTK.TabIndex = 1;
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
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.taiKhoanGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 140);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1882, 334);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "BẢNG TÀI KHOẢN";
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.bds_taiKhoan;
            this.taiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taiKhoanGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.taiKhoanGridControl.Location = new System.Drawing.Point(2, 28);
            this.taiKhoanGridControl.MainView = this.gridView1;
            this.taiKhoanGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.taiKhoanGridControl.MenuManager = this.barManager1;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(1878, 304);
            this.taiKhoanGridControl.TabIndex = 7;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.đi,
            this.colNGAYMOTK});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.taiKhoanGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 27;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 100;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 27;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 100;
            // 
            // colSODU
            // 
            this.colSODU.DisplayFormat.FormatString = "N0";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 27;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 100;
            // 
            // đi
            // 
            this.đi.FieldName = "MACN";
            this.đi.MinWidth = 27;
            this.đi.Name = "đi";
            this.đi.Visible = true;
            this.đi.VisibleIndex = 3;
            this.đi.Width = 100;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 27;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 100;
            // 
            // bdsGR
            // 
            this.bdsGR.DataMember = "FK_GD_GOIRUT_TaiKhoan";
            this.bdsGR.DataSource = this.bds_taiKhoan;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_taiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 753);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl_taiKhoan);
            this.Controls.Add(this.groupControl_chiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_taiKhoan";
            this.Text = "TÀI KHOẢN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_taiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).EndInit();
            this.groupControl_chiNhanh.ResumeLayout(false);
            this.groupControl_chiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_taiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_cmnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_maCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_taiKhoan)).EndInit();
            this.groupControl_taiKhoan.ResumeLayout(false);
            this.groupControl_taiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_soDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayMoTK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayMoTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGR)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_sua;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraBars.BarButtonItem btn_phucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_ghi;
        private DevExpress.XtraBars.BarButtonItem btn_huy;
        private System.Windows.Forms.BindingSource bds_taiKhoan;
        private DS dS;
        private DevExpress.XtraEditors.GroupControl groupControl_chiNhanh;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl_taiKhoan;
        private DevExpress.XtraEditors.DateEdit date_ngayMoTK;
        private DevExpress.XtraEditors.TextEdit text_maCN;
        private DevExpress.XtraEditors.TextEdit text_cmnd;
        private DevExpress.XtraEditors.TextEdit text_soTK;
        private DS_DSPHANMANH dS_DSPHANMANH;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPHANMANHTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn đi;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit text_soDu;
        private System.Windows.Forms.BindingSource bdsGR;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private System.Windows.Forms.Panel pnl_soDu;
        private System.Windows.Forms.Panel pnl_cmnd;
        private System.Windows.Forms.Panel pnl_soTK;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_traCuu;
        private DevExpress.XtraBars.BarButtonItem btn_reload;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_soTK;
        private System.Windows.Forms.Label lbl_soDu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_cmnd;
    }
}