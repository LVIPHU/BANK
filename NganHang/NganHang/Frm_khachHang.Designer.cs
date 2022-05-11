namespace NganHang
{
    partial class Frm_khachHang
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel1;
            System.Windows.Forms.Label tENCNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_khachHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_phucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ghi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_huy = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl_chiNhanh = new DevExpress.XtraEditors.GroupControl();
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPHANMANH = new NganHang.DS_DSPHANMANH();
            this.bds_khachHang = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new NganHang.DS();
            this.khachHangTableAdapter = new NganHang.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            this.groupControl_khachHang = new DevExpress.XtraEditors.GroupControl();
            this.text_maCN = new DevExpress.XtraEditors.TextEdit();
            this.text_soDT = new DevExpress.XtraEditors.TextEdit();
            this.date_ngayCap = new DevExpress.XtraEditors.DateEdit();
            this.cmb_phai = new System.Windows.Forms.ComboBox();
            this.text_diaChi = new DevExpress.XtraEditors.TextEdit();
            this.text_ten = new DevExpress.XtraEditors.TextEdit();
            this.text_ho = new DevExpress.XtraEditors.TextEdit();
            this.text_cmnd = new DevExpress.XtraEditors.TextEdit();
            this.v_DS_PHANMANHTableAdapter = new NganHang.DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new NganHang.DS_DSPHANMANHTableAdapters.TableAdapterManager();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.khachHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            cMNDLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel1 = new System.Windows.Forms.Label();
            tENCNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).BeginInit();
            this.groupControl_chiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_khachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_khachHang)).BeginInit();
            this.groupControl_khachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_maCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_soDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayCap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_diaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_ho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_cmnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(49, 47);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(40, 13);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(63, 79);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(59, 113);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(42, 143);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(47, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "DIACHI:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(54, 177);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(35, 13);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "PHAI:";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Location = new System.Drawing.Point(260, 45);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(58, 13);
            nGAYCAPLabel.TabIndex = 10;
            nGAYCAPLabel.Text = "NGAYCAP:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(280, 79);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(38, 13);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "SODT:";
            // 
            // mACNLabel1
            // 
            mACNLabel1.AutoSize = true;
            mACNLabel1.Location = new System.Drawing.Point(278, 111);
            mACNLabel1.Name = "mACNLabel1";
            mACNLabel1.Size = new System.Drawing.Size(40, 13);
            mACNLabel1.TabIndex = 14;
            mACNLabel1.Text = "MACN:";
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(29, 52);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(62, 13);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Chi nhánh: ";
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
            this.btn_sua,
            this.btn_xoa,
            this.btn_phucHoi,
            this.btn_ghi,
            this.btn_huy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_them),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_phucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ghi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_huy)});
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 537);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1348, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 492);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1348, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 492);
            // 
            // groupControl_chiNhanh
            // 
            this.groupControl_chiNhanh.Controls.Add(tENCNLabel);
            this.groupControl_chiNhanh.Controls.Add(this.cmb_chiNhanh);
            this.groupControl_chiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_chiNhanh.Location = new System.Drawing.Point(0, 45);
            this.groupControl_chiNhanh.Name = "groupControl_chiNhanh";
            this.groupControl_chiNhanh.Size = new System.Drawing.Size(1348, 100);
            this.groupControl_chiNhanh.TabIndex = 4;
            // 
            // cmb_chiNhanh
            // 
            this.cmb_chiNhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DS_PHANMANHBindingSource, "TENCN", true));
            this.cmb_chiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chiNhanh.FormattingEnabled = true;
            this.cmb_chiNhanh.Location = new System.Drawing.Point(95, 49);
            this.cmb_chiNhanh.Name = "cmb_chiNhanh";
            this.cmb_chiNhanh.Size = new System.Drawing.Size(131, 21);
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
            // bds_khachHang
            // 
            this.bds_khachHang.DataMember = "KhachHang";
            this.bds_khachHang.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupControl_khachHang
            // 
            this.groupControl_khachHang.Controls.Add(mACNLabel1);
            this.groupControl_khachHang.Controls.Add(this.text_maCN);
            this.groupControl_khachHang.Controls.Add(sODTLabel);
            this.groupControl_khachHang.Controls.Add(this.text_soDT);
            this.groupControl_khachHang.Controls.Add(nGAYCAPLabel);
            this.groupControl_khachHang.Controls.Add(this.date_ngayCap);
            this.groupControl_khachHang.Controls.Add(pHAILabel);
            this.groupControl_khachHang.Controls.Add(this.cmb_phai);
            this.groupControl_khachHang.Controls.Add(dIACHILabel);
            this.groupControl_khachHang.Controls.Add(this.text_diaChi);
            this.groupControl_khachHang.Controls.Add(tENLabel);
            this.groupControl_khachHang.Controls.Add(this.text_ten);
            this.groupControl_khachHang.Controls.Add(hOLabel);
            this.groupControl_khachHang.Controls.Add(this.text_ho);
            this.groupControl_khachHang.Controls.Add(cMNDLabel);
            this.groupControl_khachHang.Controls.Add(this.text_cmnd);
            this.groupControl_khachHang.Location = new System.Drawing.Point(2, 352);
            this.groupControl_khachHang.Name = "groupControl_khachHang";
            this.groupControl_khachHang.Size = new System.Drawing.Size(1356, 220);
            this.groupControl_khachHang.TabIndex = 10;
            // 
            // text_maCN
            // 
            this.text_maCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_khachHang, "MACN", true));
            this.text_maCN.Enabled = false;
            this.text_maCN.Location = new System.Drawing.Point(324, 108);
            this.text_maCN.MenuManager = this.barManager1;
            this.text_maCN.Name = "text_maCN";
            this.text_maCN.Size = new System.Drawing.Size(131, 20);
            this.text_maCN.TabIndex = 15;
            // 
            // text_soDT
            // 
            this.text_soDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_khachHang, "SODT", true));
            this.text_soDT.Location = new System.Drawing.Point(324, 76);
            this.text_soDT.MenuManager = this.barManager1;
            this.text_soDT.Name = "text_soDT";
            this.text_soDT.Size = new System.Drawing.Size(131, 20);
            this.text_soDT.TabIndex = 13;
            // 
            // date_ngayCap
            // 
            this.date_ngayCap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_khachHang, "NGAYCAP", true));
            this.date_ngayCap.EditValue = null;
            this.date_ngayCap.Location = new System.Drawing.Point(324, 42);
            this.date_ngayCap.MenuManager = this.barManager1;
            this.date_ngayCap.Name = "date_ngayCap";
            this.date_ngayCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ngayCap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ngayCap.Size = new System.Drawing.Size(131, 20);
            this.date_ngayCap.TabIndex = 11;
            // 
            // cmb_phai
            // 
            this.cmb_phai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_khachHang, "PHAI", true));
            this.cmb_phai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_phai.FormattingEnabled = true;
            this.cmb_phai.Location = new System.Drawing.Point(95, 174);
            this.cmb_phai.Name = "cmb_phai";
            this.cmb_phai.Size = new System.Drawing.Size(131, 21);
            this.cmb_phai.TabIndex = 9;
            this.cmb_phai.SelectedIndexChanged += new System.EventHandler(this.cmb_phai_SelectedIndexChanged);
            // 
            // text_diaChi
            // 
            this.text_diaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_khachHang, "DIACHI", true));
            this.text_diaChi.Location = new System.Drawing.Point(95, 141);
            this.text_diaChi.MenuManager = this.barManager1;
            this.text_diaChi.Name = "text_diaChi";
            this.text_diaChi.Size = new System.Drawing.Size(360, 20);
            this.text_diaChi.TabIndex = 7;
            // 
            // text_ten
            // 
            this.text_ten.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_khachHang, "TEN", true));
            this.text_ten.Location = new System.Drawing.Point(95, 110);
            this.text_ten.MenuManager = this.barManager1;
            this.text_ten.Name = "text_ten";
            this.text_ten.Size = new System.Drawing.Size(131, 20);
            this.text_ten.TabIndex = 5;
            // 
            // text_ho
            // 
            this.text_ho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_khachHang, "HO", true));
            this.text_ho.Location = new System.Drawing.Point(95, 76);
            this.text_ho.MenuManager = this.barManager1;
            this.text_ho.Name = "text_ho";
            this.text_ho.Size = new System.Drawing.Size(131, 20);
            this.text_ho.TabIndex = 3;
            // 
            // text_cmnd
            // 
            this.text_cmnd.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_khachHang, "CMND", true));
            this.text_cmnd.Location = new System.Drawing.Point(95, 44);
            this.text_cmnd.MenuManager = this.barManager1;
            this.text_cmnd.Name = "text_cmnd";
            this.text_cmnd.Size = new System.Drawing.Size(131, 20);
            this.text_cmnd.TabIndex = 1;
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
            this.groupControl1.Controls.Add(this.khachHangGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 151);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1348, 199);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Bảng khách hàng";
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.DataSource = this.bds_khachHang;
            this.khachHangGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.khachHangGridControl.Location = new System.Drawing.Point(2, 23);
            this.khachHangGridControl.MainView = this.gridView1;
            this.khachHangGridControl.MenuManager = this.barManager1;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(1344, 172);
            this.khachHangGridControl.TabIndex = 10;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN});
            this.gridView1.GridControl = this.khachHangGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
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
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            // 
            // Frm_khachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 557);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl_khachHang);
            this.Controls.Add(this.groupControl_chiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_khachHang";
            this.Text = "Khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_khachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).EndInit();
            this.groupControl_chiNhanh.ResumeLayout(false);
            this.groupControl_chiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_khachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_khachHang)).EndInit();
            this.groupControl_khachHang.ResumeLayout(false);
            this.groupControl_khachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_maCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_soDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayCap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_diaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_ho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_cmnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_sua;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraBars.BarButtonItem btn_phucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_ghi;
        private DevExpress.XtraBars.BarButtonItem btn_huy;
        private DevExpress.XtraEditors.GroupControl groupControl_chiNhanh;
        private System.Windows.Forms.BindingSource bds_khachHang;
        private DS dS;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl_khachHang;
        private DevExpress.XtraEditors.TextEdit text_soDT;
        private DevExpress.XtraEditors.DateEdit date_ngayCap;
        private System.Windows.Forms.ComboBox cmb_phai;
        private DevExpress.XtraEditors.TextEdit text_diaChi;
        private DevExpress.XtraEditors.TextEdit text_ten;
        private DevExpress.XtraEditors.TextEdit text_ho;
        private DevExpress.XtraEditors.TextEdit text_cmnd;
        private DevExpress.XtraEditors.TextEdit text_maCN;
        private DS_DSPHANMANH dS_DSPHANMANH;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPHANMANHTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl khachHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
    }
}