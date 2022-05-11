namespace NganHang
{
    partial class Frm_lietKeTaiKhoan
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
            System.Windows.Forms.Label lbl_maCN;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_lietKeTaiKhoan));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pnl_KT = new System.Windows.Forms.Panel();
            this.pnl_BD = new System.Windows.Forms.Panel();
            this.btn_preview = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cmb_maCN = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPHANMANH = new NganHang.DS_DSPHANMANH();
            this.lbl_KT = new System.Windows.Forms.Label();
            this.lbl_BD = new System.Windows.Forms.Label();
            this.date_KT = new DevExpress.XtraEditors.DateEdit();
            this.date_BD = new DevExpress.XtraEditors.DateEdit();
            this.v_DS_PHANMANHTableAdapter = new NganHang.DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new NganHang.DS_DSPHANMANHTableAdapters.TableAdapterManager();
            lbl_maCN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_maCN
            // 
            lbl_maCN.AutoSize = true;
            lbl_maCN.BackColor = System.Drawing.Color.Transparent;
            lbl_maCN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lbl_maCN.ForeColor = System.Drawing.Color.Black;
            lbl_maCN.Location = new System.Drawing.Point(230, 275);
            lbl_maCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_maCN.Name = "lbl_maCN";
            lbl_maCN.Size = new System.Drawing.Size(89, 23);
            lbl_maCN.TabIndex = 29;
            lbl_maCN.Text = "Chi nhánh";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pnl_KT);
            this.groupControl1.Controls.Add(this.pnl_BD);
            this.groupControl1.Controls.Add(this.btn_preview);
            this.groupControl1.Controls.Add(lbl_maCN);
            this.groupControl1.Controls.Add(this.cmb_maCN);
            this.groupControl1.Controls.Add(this.lbl_KT);
            this.groupControl1.Controls.Add(this.lbl_BD);
            this.groupControl1.Controls.Add(this.date_KT);
            this.groupControl1.Controls.Add(this.date_BD);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(622, 522);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Liệt kê các tài khoản mở trong 1 khoảng thời gian của chi nhánh, của tất cả các c" +
    "hi nhánh.";
            // 
            // pnl_KT
            // 
            this.pnl_KT.BackColor = System.Drawing.Color.Black;
            this.pnl_KT.Location = new System.Drawing.Point(230, 222);
            this.pnl_KT.Name = "pnl_KT";
            this.pnl_KT.Size = new System.Drawing.Size(200, 2);
            this.pnl_KT.TabIndex = 33;
            // 
            // pnl_BD
            // 
            this.pnl_BD.BackColor = System.Drawing.Color.Black;
            this.pnl_BD.Location = new System.Drawing.Point(230, 122);
            this.pnl_BD.Name = "pnl_BD";
            this.pnl_BD.Size = new System.Drawing.Size(200, 2);
            this.pnl_BD.TabIndex = 32;
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
            this.btn_preview.BackColor1 = System.Drawing.Color.Blue;
            this.btn_preview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_preview.BackgroundImage")));
            this.btn_preview.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_preview.ButtonText = "PREVIEW";
            this.btn_preview.ButtonTextMarginLeft = 0;
            this.btn_preview.ColorContrastOnClick = 45;
            this.btn_preview.ColorContrastOnHover = 45;
            this.btn_preview.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_preview.CustomizableEdges = borderEdges1;
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
            this.btn_preview.IdleFillColor = System.Drawing.Color.Blue;
            this.btn_preview.IdleIconLeftImage = null;
            this.btn_preview.IdleIconRightImage = null;
            this.btn_preview.IndicateFocus = false;
            this.btn_preview.Location = new System.Drawing.Point(231, 438);
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
            this.btn_preview.OnIdleState.FillColor = System.Drawing.Color.Blue;
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
            this.btn_preview.TabIndex = 4;
            this.btn_preview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_preview.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_preview.TextMarginLeft = 0;
            this.btn_preview.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_preview.UseDefaultRadiusAndThickness = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // cmb_maCN
            // 
            this.cmb_maCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DS_PHANMANHBindingSource, "TENCN", true));
            this.cmb_maCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_maCN.FormattingEnabled = true;
            this.cmb_maCN.Location = new System.Drawing.Point(230, 300);
            this.cmb_maCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_maCN.Name = "cmb_maCN";
            this.cmb_maCN.Size = new System.Drawing.Size(200, 24);
            this.cmb_maCN.TabIndex = 3;
            this.cmb_maCN.SelectedIndexChanged += new System.EventHandler(this.cmb_maCN_SelectedIndexChanged);
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
            // lbl_KT
            // 
            this.lbl_KT.AutoSize = true;
            this.lbl_KT.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_KT.ForeColor = System.Drawing.Color.Black;
            this.lbl_KT.Location = new System.Drawing.Point(230, 200);
            this.lbl_KT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KT.Name = "lbl_KT";
            this.lbl_KT.Size = new System.Drawing.Size(117, 23);
            this.lbl_KT.TabIndex = 28;
            this.lbl_KT.Text = "Ngày kết thúc";
            this.lbl_KT.Click += new System.EventHandler(this.lbl_KT_Click);
            // 
            // lbl_BD
            // 
            this.lbl_BD.AutoSize = true;
            this.lbl_BD.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_BD.ForeColor = System.Drawing.Color.Black;
            this.lbl_BD.Location = new System.Drawing.Point(230, 100);
            this.lbl_BD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BD.Name = "lbl_BD";
            this.lbl_BD.Size = new System.Drawing.Size(114, 23);
            this.lbl_BD.TabIndex = 1;
            this.lbl_BD.Text = "Ngày bắt đầu";
            this.lbl_BD.Click += new System.EventHandler(this.lbl_BD_Click);
            // 
            // date_KT
            // 
            this.date_KT.EditValue = null;
            this.date_KT.Location = new System.Drawing.Point(230, 200);
            this.date_KT.Margin = new System.Windows.Forms.Padding(4);
            this.date_KT.Name = "date_KT";
            this.date_KT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.date_KT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_KT.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.date_KT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_KT.Size = new System.Drawing.Size(200, 20);
            this.date_KT.TabIndex = 2;
            this.date_KT.Enter += new System.EventHandler(this.text_KT_Enter);
            this.date_KT.Leave += new System.EventHandler(this.text_KT_Leave);
            // 
            // date_BD
            // 
            this.date_BD.EditValue = null;
            this.date_BD.Location = new System.Drawing.Point(230, 100);
            this.date_BD.Margin = new System.Windows.Forms.Padding(4);
            this.date_BD.Name = "date_BD";
            this.date_BD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.date_BD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_BD.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.date_BD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_BD.Size = new System.Drawing.Size(200, 20);
            this.date_BD.TabIndex = 1;
            this.date_BD.Enter += new System.EventHandler(this.text_BD_Enter);
            this.date_BD.Leave += new System.EventHandler(this.text_BD_Leave);
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
            // Frm_lietKeTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 522);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_lietKeTaiKhoan";
            this.Text = "Liệt Kê Tài Khoản";
            this.Load += new System.EventHandler(this.Frm_lietKeTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DS_DSPHANMANH dS_DSPHANMANH;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPHANMANHTableAdapters.TableAdapterManager tableAdapterManager;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_preview;
        private System.Windows.Forms.ComboBox cmb_maCN;
        private System.Windows.Forms.Label lbl_KT;
        private System.Windows.Forms.Label lbl_BD;
        private DevExpress.XtraEditors.DateEdit date_KT;
        private DevExpress.XtraEditors.DateEdit date_BD;
        private System.Windows.Forms.Panel pnl_KT;
        private System.Windows.Forms.Panel pnl_BD;
    }
}