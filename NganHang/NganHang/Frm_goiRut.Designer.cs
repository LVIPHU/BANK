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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label lOAIGDLabel;
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label nGAYGDLabel;
            System.Windows.Forms.Label tENCNLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_goiRut));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupControl_goiRut = new DevExpress.XtraEditors.GroupControl();
            this.textBox_traCuu = new System.Windows.Forms.TextBox();
            this.btn_traCuu = new DevExpress.XtraEditors.SimpleButton();
            this.text_soTien = new DevExpress.XtraEditors.SpinEdit();
            this.date_ngayGD = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_huyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.text_maNV = new DevExpress.XtraEditors.TextEdit();
            this.cmb_loaiGD = new System.Windows.Forms.ComboBox();
            this.text_soTK = new DevExpress.XtraEditors.TextEdit();
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
            mANVLabel = new System.Windows.Forms.Label();
            lOAIGDLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            nGAYGDLabel = new System.Windows.Forms.Label();
            tENCNLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GDGoiRut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_goiRut)).BeginInit();
            this.groupControl_goiRut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayGD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_maNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).BeginInit();
            this.groupControl_chiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(285, 104);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(39, 13);
            mANVLabel.TabIndex = 8;
            mANVLabel.Text = "MANV:";
            // 
            // lOAIGDLabel
            // 
            lOAIGDLabel.AutoSize = true;
            lOAIGDLabel.Location = new System.Drawing.Point(59, 63);
            lOAIGDLabel.Name = "lOAIGDLabel";
            lOAIGDLabel.Size = new System.Drawing.Size(49, 13);
            lOAIGDLabel.TabIndex = 3;
            lOAIGDLabel.Text = "LOAIGD:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(69, 104);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(37, 13);
            sOTKLabel.TabIndex = 2;
            sOTKLabel.Text = "SOTK:";
            // 
            // nGAYGDLabel
            // 
            nGAYGDLabel.AutoSize = true;
            nGAYGDLabel.Location = new System.Drawing.Point(56, 145);
            nGAYGDLabel.Name = "nGAYGDLabel";
            nGAYGDLabel.Size = new System.Drawing.Size(52, 13);
            nGAYGDLabel.TabIndex = 12;
            nGAYGDLabel.Text = "NGAYGD:";
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(49, 110);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(62, 13);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Chi nhánh: ";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Location = new System.Drawing.Point(276, 63);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(48, 13);
            sOTIENLabel.TabIndex = 13;
            sOTIENLabel.Text = "SOTIEN:";
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
            this.btn_xoa});
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 543);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1348, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 498);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1348, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 498);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.groupControl_goiRut);
            this.panel3.Location = new System.Drawing.Point(0, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1348, 255);
            this.panel3.TabIndex = 14;
            // 
            // groupControl_goiRut
            // 
            this.groupControl_goiRut.Controls.Add(this.textBox_traCuu);
            this.groupControl_goiRut.Controls.Add(this.btn_traCuu);
            this.groupControl_goiRut.Controls.Add(sOTIENLabel);
            this.groupControl_goiRut.Controls.Add(this.text_soTien);
            this.groupControl_goiRut.Controls.Add(nGAYGDLabel);
            this.groupControl_goiRut.Controls.Add(this.date_ngayGD);
            this.groupControl_goiRut.Controls.Add(this.label1);
            this.groupControl_goiRut.Controls.Add(this.btn_huyBo);
            this.groupControl_goiRut.Controls.Add(this.btn_xacNhan);
            this.groupControl_goiRut.Controls.Add(mANVLabel);
            this.groupControl_goiRut.Controls.Add(this.text_maNV);
            this.groupControl_goiRut.Controls.Add(lOAIGDLabel);
            this.groupControl_goiRut.Controls.Add(this.cmb_loaiGD);
            this.groupControl_goiRut.Controls.Add(sOTKLabel);
            this.groupControl_goiRut.Controls.Add(this.text_soTK);
            this.groupControl_goiRut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_goiRut.Location = new System.Drawing.Point(0, 0);
            this.groupControl_goiRut.Name = "groupControl_goiRut";
            this.groupControl_goiRut.Size = new System.Drawing.Size(1348, 255);
            this.groupControl_goiRut.TabIndex = 14;
            this.groupControl_goiRut.Text = "Thông tin giao dịch";
            // 
            // textBox_traCuu
            // 
            this.textBox_traCuu.Location = new System.Drawing.Point(697, 57);
            this.textBox_traCuu.Multiline = true;
            this.textBox_traCuu.Name = "textBox_traCuu";
            this.textBox_traCuu.Size = new System.Drawing.Size(280, 163);
            this.textBox_traCuu.TabIndex = 16;
            // 
            // btn_traCuu
            // 
            this.btn_traCuu.Location = new System.Drawing.Point(588, 57);
            this.btn_traCuu.Name = "btn_traCuu";
            this.btn_traCuu.Size = new System.Drawing.Size(75, 23);
            this.btn_traCuu.TabIndex = 15;
            this.btn_traCuu.Text = "Tra cứu Số TK";
            this.btn_traCuu.Click += new System.EventHandler(this.btn_traCuu_Click);
            // 
            // text_soTien
            // 
            this.text_soTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDGoiRut, "SOTIEN", true));
            this.text_soTien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.text_soTien.Location = new System.Drawing.Point(330, 60);
            this.text_soTien.MenuManager = this.barManager1;
            this.text_soTien.Name = "text_soTien";
            this.text_soTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text_soTien.Size = new System.Drawing.Size(121, 20);
            this.text_soTien.TabIndex = 14;
            // 
            // date_ngayGD
            // 
            this.date_ngayGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDGoiRut, "NGAYGD", true));
            this.date_ngayGD.EditValue = "";
            this.date_ngayGD.Location = new System.Drawing.Point(114, 142);
            this.date_ngayGD.MenuManager = this.barManager1;
            this.date_ngayGD.Name = "date_ngayGD";
            this.date_ngayGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ngayGD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ngayGD.Size = new System.Drawing.Size(121, 20);
            this.date_ngayGD.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "VND";
            // 
            // btn_huyBo
            // 
            this.btn_huyBo.Location = new System.Drawing.Point(330, 187);
            this.btn_huyBo.Name = "btn_huyBo";
            this.btn_huyBo.Size = new System.Drawing.Size(75, 23);
            this.btn_huyBo.TabIndex = 11;
            this.btn_huyBo.Text = "Huỷ bỏ";
            this.btn_huyBo.Click += new System.EventHandler(this.btn_huyBo_Click);
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.Location = new System.Drawing.Point(160, 187);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(75, 23);
            this.btn_xacNhan.TabIndex = 10;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // text_maNV
            // 
            this.text_maNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDGoiRut, "MANV", true));
            this.text_maNV.Location = new System.Drawing.Point(330, 101);
            this.text_maNV.MenuManager = this.barManager1;
            this.text_maNV.Name = "text_maNV";
            this.text_maNV.Size = new System.Drawing.Size(121, 20);
            this.text_maNV.TabIndex = 9;
            // 
            // cmb_loaiGD
            // 
            this.cmb_loaiGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_GDGoiRut, "LOAIGD", true));
            this.cmb_loaiGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_loaiGD.FormattingEnabled = true;
            this.cmb_loaiGD.Location = new System.Drawing.Point(114, 60);
            this.cmb_loaiGD.Name = "cmb_loaiGD";
            this.cmb_loaiGD.Size = new System.Drawing.Size(121, 21);
            this.cmb_loaiGD.TabIndex = 4;
            // 
            // text_soTK
            // 
            this.text_soTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GDGoiRut, "SOTK", true));
            this.text_soTK.Location = new System.Drawing.Point(114, 101);
            this.text_soTK.MenuManager = this.barManager1;
            this.text_soTK.Name = "text_soTK";
            this.text_soTK.Size = new System.Drawing.Size(121, 20);
            this.text_soTK.TabIndex = 3;
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
            this.groupControl_chiNhanh.Location = new System.Drawing.Point(1030, 46);
            this.groupControl_chiNhanh.Name = "groupControl_chiNhanh";
            this.groupControl_chiNhanh.Size = new System.Drawing.Size(318, 236);
            this.groupControl_chiNhanh.TabIndex = 20;
            this.groupControl_chiNhanh.Text = "Chi nhánh";
            // 
            // cmb_chiNhanh
            // 
            this.cmb_chiNhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DS_PHANMANHBindingSource, "TENCN", true));
            this.cmb_chiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chiNhanh.FormattingEnabled = true;
            this.cmb_chiNhanh.Location = new System.Drawing.Point(119, 107);
            this.cmb_chiNhanh.Name = "cmb_chiNhanh";
            this.cmb_chiNhanh.Size = new System.Drawing.Size(145, 21);
            this.cmb_chiNhanh.TabIndex = 1;
            this.cmb_chiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmb_chiNhanh_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gD_GOIRUTGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 46);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1024, 236);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "Bảng giao dịch gửi rút";
            // 
            // gD_GOIRUTGridControl
            // 
            this.gD_GOIRUTGridControl.DataSource = this.bds_GDGoiRut;
            this.gD_GOIRUTGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gD_GOIRUTGridControl.Location = new System.Drawing.Point(2, 23);
            this.gD_GOIRUTGridControl.MainView = this.gridView1;
            this.gD_GOIRUTGridControl.MenuManager = this.barManager1;
            this.gD_GOIRUTGridControl.Name = "gD_GOIRUTGridControl";
            this.gD_GOIRUTGridControl.Size = new System.Drawing.Size(1020, 213);
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
            this.gridView1.GridControl = this.gD_GOIRUTGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGD
            // 
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 1;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 2;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 3;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.DisplayFormat.FormatString = "N0";
            this.colSOTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 4;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 5;
            // 
            // Frm_goiRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 563);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl_chiNhanh);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_goiRut";
            this.Text = "Giao dịch gửi rút";
            this.Load += new System.EventHandler(this.Frm_goiRut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GDGoiRut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_goiRut)).EndInit();
            this.groupControl_goiRut.ResumeLayout(false);
            this.groupControl_goiRut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayGD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ngayGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_maNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).EndInit();
            this.groupControl_chiNhanh.ResumeLayout(false);
            this.groupControl_chiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).EndInit();
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
        private System.Windows.Forms.BindingSource bds_GDGoiRut;
        private DS dS;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_sua;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.GroupControl groupControl_goiRut;
        private DevExpress.XtraEditors.SimpleButton btn_huyBo;
        private DevExpress.XtraEditors.SimpleButton btn_xacNhan;
        private DevExpress.XtraEditors.TextEdit text_maNV;
        private System.Windows.Forms.ComboBox cmb_loaiGD;
        private DevExpress.XtraEditors.TextEdit text_soTK;
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
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit date_ngayGD;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private DevExpress.XtraEditors.SpinEdit text_soTien;
        private System.Windows.Forms.TextBox textBox_traCuu;
        private DevExpress.XtraEditors.SimpleButton btn_traCuu;
    }
}