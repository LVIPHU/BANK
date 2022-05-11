namespace NganHang
{
    partial class Frm_saoKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_saoKe));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new NganHang.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.taiKhoanTableAdapter = new NganHang.DSTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_KT = new System.Windows.Forms.Label();
            this.lbl_BD = new System.Windows.Forms.Label();
            this.pnl_KT = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnl_BD = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_soTK = new System.Windows.Forms.Panel();
            this.btn_preview = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbl_soTK = new System.Windows.Forms.Label();
            this.text_soTK = new DevExpress.XtraEditors.TextEdit();
            this.date_KT = new DevExpress.XtraEditors.DateEdit();
            this.date_BD = new DevExpress.XtraEditors.DateEdit();
            this.fKGDGOIRUTTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GOIRUTTableAdapter = new NganHang.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.fKGDGOIRUTTaiKhoanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.pnl_KT.SuspendLayout();
            this.pnl_BD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGDGOIRUTTaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGDGOIRUTTaiKhoanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.taiKhoanGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1882, 410);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "BẢNG TÀI KHOẢN";
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.taiKhoanBindingSource;
            this.taiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taiKhoanGridControl.Location = new System.Drawing.Point(2, 28);
            this.taiKhoanGridControl.MainView = this.gridView1;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(1878, 380);
            this.taiKhoanGridControl.TabIndex = 0;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.taiKhoanGridControl;
            this.gridView1.Name = "gridView1";
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
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl2.Controls.Add(this.lbl_KT);
            this.groupControl2.Controls.Add(this.lbl_BD);
            this.groupControl2.Controls.Add(this.pnl_KT);
            this.groupControl2.Controls.Add(this.pnl_BD);
            this.groupControl2.Controls.Add(this.panel1);
            this.groupControl2.Controls.Add(this.pnl_soTK);
            this.groupControl2.Controls.Add(this.btn_preview);
            this.groupControl2.Controls.Add(this.lbl_soTK);
            this.groupControl2.Controls.Add(this.text_soTK);
            this.groupControl2.Controls.Add(this.date_KT);
            this.groupControl2.Controls.Add(this.date_BD);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 411);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1882, 352);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "THÔNG TIN";
            // 
            // lbl_KT
            // 
            this.lbl_KT.AutoSize = true;
            this.lbl_KT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KT.Location = new System.Drawing.Point(975, 175);
            this.lbl_KT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KT.Name = "lbl_KT";
            this.lbl_KT.Size = new System.Drawing.Size(100, 20);
            this.lbl_KT.TabIndex = 20;
            this.lbl_KT.Text = "Ngày kết thúc";
            this.lbl_KT.Click += new System.EventHandler(this.lbl_KT_Click);
            // 
            // lbl_BD
            // 
            this.lbl_BD.AutoSize = true;
            this.lbl_BD.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BD.Location = new System.Drawing.Point(675, 175);
            this.lbl_BD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BD.Name = "lbl_BD";
            this.lbl_BD.Size = new System.Drawing.Size(99, 20);
            this.lbl_BD.TabIndex = 19;
            this.lbl_BD.Text = "Ngày bắt đầu";
            this.lbl_BD.Click += new System.EventHandler(this.lbl_BD_Click);
            // 
            // pnl_KT
            // 
            this.pnl_KT.BackColor = System.Drawing.Color.Black;
            this.pnl_KT.Controls.Add(this.panel5);
            this.pnl_KT.Location = new System.Drawing.Point(975, 195);
            this.pnl_KT.Name = "pnl_KT";
            this.pnl_KT.Size = new System.Drawing.Size(200, 2);
            this.pnl_KT.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 2);
            this.panel5.TabIndex = 28;
            // 
            // pnl_BD
            // 
            this.pnl_BD.BackColor = System.Drawing.Color.Black;
            this.pnl_BD.Controls.Add(this.panel3);
            this.pnl_BD.Location = new System.Drawing.Point(675, 195);
            this.pnl_BD.Name = "pnl_BD";
            this.pnl_BD.Size = new System.Drawing.Size(200, 2);
            this.pnl_BD.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 28;
            // 
            // pnl_soTK
            // 
            this.pnl_soTK.BackColor = System.Drawing.Color.Blue;
            this.pnl_soTK.ForeColor = System.Drawing.Color.Transparent;
            this.pnl_soTK.Location = new System.Drawing.Point(675, 95);
            this.pnl_soTK.Name = "pnl_soTK";
            this.pnl_soTK.Size = new System.Drawing.Size(200, 2);
            this.pnl_soTK.TabIndex = 26;
            // 
            // btn_preview
            // 
            this.btn_preview.AllowAnimations = true;
            this.btn_preview.AllowMouseEffects = true;
            this.btn_preview.AllowToggling = false;
            this.btn_preview.AnimationSpeed = 200;
            this.btn_preview.AutoGenerateColors = false;
            this.btn_preview.AutoRoundBorders = false;
            this.btn_preview.AutoSizeLeftIcon = true;
            this.btn_preview.AutoSizeRightIcon = true;
            this.btn_preview.BackColor = System.Drawing.Color.Transparent;
            this.btn_preview.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.btn_preview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_preview.BackgroundImage")));
            this.btn_preview.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_preview.ButtonText = "PREVIEW";
            this.btn_preview.ButtonTextMarginLeft = 0;
            this.btn_preview.ColorContrastOnClick = 45;
            this.btn_preview.ColorContrastOnHover = 45;
            this.btn_preview.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_preview.CustomizableEdges = borderEdges2;
            this.btn_preview.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_preview.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_preview.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_preview.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_preview.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_preview.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_preview.ForeColor = System.Drawing.Color.White;
            this.btn_preview.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_preview.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_preview.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_preview.IconMarginLeft = 11;
            this.btn_preview.IconPadding = 10;
            this.btn_preview.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_preview.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_preview.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_preview.IconSize = 25;
            this.btn_preview.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.btn_preview.IdleBorderRadius = 40;
            this.btn_preview.IdleBorderThickness = 2;
            this.btn_preview.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.btn_preview.IdleIconLeftImage = null;
            this.btn_preview.IdleIconRightImage = null;
            this.btn_preview.IndicateFocus = false;
            this.btn_preview.Location = new System.Drawing.Point(824, 266);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(4);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_preview.OnDisabledState.BorderRadius = 40;
            this.btn_preview.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_preview.OnDisabledState.BorderThickness = 2;
            this.btn_preview.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_preview.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_preview.OnDisabledState.IconLeftImage = null;
            this.btn_preview.OnDisabledState.IconRightImage = null;
            this.btn_preview.onHoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_preview.onHoverState.BorderRadius = 40;
            this.btn_preview.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_preview.onHoverState.BorderThickness = 2;
            this.btn_preview.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_preview.onHoverState.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_preview.onHoverState.IconLeftImage = null;
            this.btn_preview.onHoverState.IconRightImage = null;
            this.btn_preview.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.btn_preview.OnIdleState.BorderRadius = 40;
            this.btn_preview.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_preview.OnIdleState.BorderThickness = 2;
            this.btn_preview.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.btn_preview.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_preview.OnIdleState.IconLeftImage = null;
            this.btn_preview.OnIdleState.IconRightImage = null;
            this.btn_preview.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_preview.OnPressedState.BorderRadius = 40;
            this.btn_preview.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_preview.OnPressedState.BorderThickness = 2;
            this.btn_preview.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btn_preview.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.btn_preview.OnPressedState.IconLeftImage = null;
            this.btn_preview.OnPressedState.IconRightImage = null;
            this.btn_preview.Size = new System.Drawing.Size(200, 48);
            this.btn_preview.TabIndex = 25;
            this.btn_preview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_preview.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_preview.TextMarginLeft = 0;
            this.btn_preview.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_preview.UseDefaultRadiusAndThickness = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // lbl_soTK
            // 
            this.lbl_soTK.AutoSize = true;
            this.lbl_soTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soTK.ForeColor = System.Drawing.Color.Blue;
            this.lbl_soTK.Location = new System.Drawing.Point(675, 50);
            this.lbl_soTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_soTK.Name = "lbl_soTK";
            this.lbl_soTK.Size = new System.Drawing.Size(91, 20);
            this.lbl_soTK.TabIndex = 23;
            this.lbl_soTK.Text = "Số tài khoản";
            this.lbl_soTK.Click += new System.EventHandler(this.lbl_soTK_Click);
            // 
            // text_soTK
            // 
            this.text_soTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBindingSource, "SOTK", true));
            this.text_soTK.Location = new System.Drawing.Point(675, 75);
            this.text_soTK.Margin = new System.Windows.Forms.Padding(4);
            this.text_soTK.Name = "text_soTK";
            this.text_soTK.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.text_soTK.Properties.Appearance.Options.UseBackColor = true;
            this.text_soTK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_soTK.Size = new System.Drawing.Size(200, 20);
            this.text_soTK.TabIndex = 24;
            this.text_soTK.Enter += new System.EventHandler(this.text_soTK_Enter);
            this.text_soTK.Leave += new System.EventHandler(this.text_soTK_Leave);
            // 
            // date_KT
            // 
            this.date_KT.EditValue = null;
            this.date_KT.Location = new System.Drawing.Point(975, 175);
            this.date_KT.Margin = new System.Windows.Forms.Padding(4);
            this.date_KT.Name = "date_KT";
            this.date_KT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.date_KT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_KT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_KT.Size = new System.Drawing.Size(200, 20);
            this.date_KT.TabIndex = 22;
            this.date_KT.Enter += new System.EventHandler(this.text_KT_Enter);
            this.date_KT.Leave += new System.EventHandler(this.text_KT_Leave);
            // 
            // date_BD
            // 
            this.date_BD.EditValue = null;
            this.date_BD.Location = new System.Drawing.Point(675, 175);
            this.date_BD.Margin = new System.Windows.Forms.Padding(4);
            this.date_BD.Name = "date_BD";
            this.date_BD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.date_BD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_BD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_BD.Size = new System.Drawing.Size(200, 20);
            this.date_BD.TabIndex = 21;
            this.date_BD.Enter += new System.EventHandler(this.text_BD_Enter);
            this.date_BD.Leave += new System.EventHandler(this.text_BD_Leave);
            // 
            // fKGDGOIRUTTaiKhoanBindingSource
            // 
            this.fKGDGOIRUTTaiKhoanBindingSource.DataMember = "FK_GD_GOIRUT_TaiKhoan";
            this.fKGDGOIRUTTaiKhoanBindingSource.DataSource = this.taiKhoanBindingSource;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // fKGDGOIRUTTaiKhoanBindingSource1
            // 
            this.fKGDGOIRUTTaiKhoanBindingSource1.DataMember = "FK_GD_GOIRUT_TaiKhoan";
            this.fKGDGOIRUTTaiKhoanBindingSource1.DataSource = this.taiKhoanBindingSource;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(675, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 26;
            // 
            // Frm_saoKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 763);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_saoKe";
            this.Text = "SAO KÊ";
            this.Load += new System.EventHandler(this.Frm_saoKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.pnl_KT.ResumeLayout(false);
            this.pnl_BD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.text_soTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGDGOIRUTTaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGDGOIRUTTaiKhoanBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DS dS;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_preview;
        private System.Windows.Forms.Label lbl_soTK;
        private DevExpress.XtraEditors.TextEdit text_soTK;
        private DevExpress.XtraEditors.DateEdit date_KT;
        private DevExpress.XtraEditors.DateEdit date_BD;
        private System.Windows.Forms.Label lbl_KT;
        private System.Windows.Forms.Label lbl_BD;
        private System.Windows.Forms.Panel pnl_KT;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnl_BD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_soTK;
        private System.Windows.Forms.BindingSource fKGDGOIRUTTaiKhoanBindingSource;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private System.Windows.Forms.BindingSource fKGDGOIRUTTaiKhoanBindingSource1;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
    }
}