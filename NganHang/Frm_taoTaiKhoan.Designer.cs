
namespace NganHang
{
    partial class Frm_taoTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_taoTaiKhoan));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_nhanVien = new System.Windows.Forms.ComboBox();
            this.v_DS_NHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_NHANVIEN = new NganHang.DS_NHANVIEN();
            this.btn_dangNhap = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.text_password = new Bunifu.UI.WinForms.BunifuTextBox();
            this.text_loginName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPHANMANH = new NganHang.DS_DSPHANMANH();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dSDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new NganHang.DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.v_DS_NHANVIENTableAdapter = new NganHang.DS_NHANVIENTableAdapters.V_DS_NHANVIENTableAdapter();
            this.tableAdapterManager = new NganHang.DS_NHANVIENTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_NHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_NHANVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDSPHANMANHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_nhanVien);
            this.panel1.Controls.Add(this.btn_dangNhap);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.text_password);
            this.panel1.Controls.Add(this.text_loginName);
            this.panel1.Controls.Add(this.cmb_chiNhanh);
            this.panel1.Location = new System.Drawing.Point(883, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 621);
            this.panel1.TabIndex = 20;
            // 
            // cmb_nhanVien
            // 
            this.cmb_nhanVien.DataSource = this.v_DS_NHANVIENBindingSource;
            this.cmb_nhanVien.DisplayMember = "HOTEN";
            this.cmb_nhanVien.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cmb_nhanVien.FormattingEnabled = true;
            this.cmb_nhanVien.Location = new System.Drawing.Point(242, 242);
            this.cmb_nhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_nhanVien.Name = "cmb_nhanVien";
            this.cmb_nhanVien.Size = new System.Drawing.Size(261, 28);
            this.cmb_nhanVien.TabIndex = 19;
            this.cmb_nhanVien.ValueMember = "MANV";
            // 
            // v_DS_NHANVIENBindingSource
            // 
            this.v_DS_NHANVIENBindingSource.DataMember = "V_DS_NHANVIEN";
            this.v_DS_NHANVIENBindingSource.DataSource = this.dS_NHANVIEN;
            // 
            // dS_NHANVIEN
            // 
            this.dS_NHANVIEN.DataSetName = "DS_NHANVIEN";
            this.dS_NHANVIEN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.AllowAnimations = true;
            this.btn_dangNhap.AllowMouseEffects = true;
            this.btn_dangNhap.AllowToggling = false;
            this.btn_dangNhap.AnimationSpeed = 200;
            this.btn_dangNhap.AutoGenerateColors = false;
            this.btn_dangNhap.AutoRoundBorders = false;
            this.btn_dangNhap.AutoSizeLeftIcon = true;
            this.btn_dangNhap.AutoSizeRightIcon = true;
            this.btn_dangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_dangNhap.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_dangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dangNhap.BackgroundImage")));
            this.btn_dangNhap.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dangNhap.ButtonText = "SIGN UP";
            this.btn_dangNhap.ButtonTextMarginLeft = 0;
            this.btn_dangNhap.ColorContrastOnClick = 45;
            this.btn_dangNhap.ColorContrastOnHover = 45;
            this.btn_dangNhap.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_dangNhap.CustomizableEdges = borderEdges1;
            this.btn_dangNhap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_dangNhap.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_dangNhap.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_dangNhap.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_dangNhap.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_dangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_dangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_dangNhap.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangNhap.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_dangNhap.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_dangNhap.IconMarginLeft = 11;
            this.btn_dangNhap.IconPadding = 10;
            this.btn_dangNhap.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dangNhap.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_dangNhap.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_dangNhap.IconSize = 25;
            this.btn_dangNhap.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_dangNhap.IdleBorderRadius = 30;
            this.btn_dangNhap.IdleBorderThickness = 2;
            this.btn_dangNhap.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_dangNhap.IdleIconLeftImage = null;
            this.btn_dangNhap.IdleIconRightImage = null;
            this.btn_dangNhap.IndicateFocus = false;
            this.btn_dangNhap.Location = new System.Drawing.Point(304, 507);
            this.btn_dangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_dangNhap.OnDisabledState.BorderRadius = 30;
            this.btn_dangNhap.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dangNhap.OnDisabledState.BorderThickness = 2;
            this.btn_dangNhap.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_dangNhap.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_dangNhap.OnDisabledState.IconLeftImage = null;
            this.btn_dangNhap.OnDisabledState.IconRightImage = null;
            this.btn_dangNhap.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btn_dangNhap.onHoverState.BorderRadius = 30;
            this.btn_dangNhap.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dangNhap.onHoverState.BorderThickness = 2;
            this.btn_dangNhap.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_dangNhap.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btn_dangNhap.onHoverState.IconLeftImage = null;
            this.btn_dangNhap.onHoverState.IconRightImage = null;
            this.btn_dangNhap.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_dangNhap.OnIdleState.BorderRadius = 30;
            this.btn_dangNhap.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dangNhap.OnIdleState.BorderThickness = 2;
            this.btn_dangNhap.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_dangNhap.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_dangNhap.OnIdleState.IconLeftImage = null;
            this.btn_dangNhap.OnIdleState.IconRightImage = null;
            this.btn_dangNhap.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_dangNhap.OnPressedState.BorderRadius = 30;
            this.btn_dangNhap.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dangNhap.OnPressedState.BorderThickness = 2;
            this.btn_dangNhap.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btn_dangNhap.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_dangNhap.OnPressedState.IconLeftImage = null;
            this.btn_dangNhap.OnPressedState.IconRightImage = null;
            this.btn_dangNhap.Size = new System.Drawing.Size(200, 48);
            this.btn_dangNhap.TabIndex = 3;
            this.btn_dangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_dangNhap.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_dangNhap.TextMarginLeft = 0;
            this.btn_dangNhap.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_dangNhap.UseDefaultRadiusAndThickness = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(168)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(152, 112);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(292, 28);
            this.bunifuSeparator1.TabIndex = 17;
            // 
            // text_password
            // 
            this.text_password.AcceptsReturn = false;
            this.text_password.AcceptsTab = false;
            this.text_password.AnimationSpeed = 200;
            this.text_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.text_password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.text_password.BackColor = System.Drawing.Color.Transparent;
            this.text_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("text_password.BackgroundImage")));
            this.text_password.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.text_password.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.text_password.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.text_password.BorderColorIdle = System.Drawing.Color.Silver;
            this.text_password.BorderRadius = 1;
            this.text_password.BorderThickness = 1;
            this.text_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.text_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_password.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.text_password.DefaultText = "";
            this.text_password.FillColor = System.Drawing.Color.White;
            this.text_password.HideSelection = true;
            this.text_password.IconLeft = global::NganHang.Properties.Resources._lock;
            this.text_password.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.text_password.IconPadding = 9;
            this.text_password.IconRight = null;
            this.text_password.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.text_password.Lines = new string[0];
            this.text_password.Location = new System.Drawing.Point(242, 401);
            this.text_password.Margin = new System.Windows.Forms.Padding(4);
            this.text_password.MaxLength = 32767;
            this.text_password.MinimumSize = new System.Drawing.Size(1, 1);
            this.text_password.Modified = false;
            this.text_password.Multiline = false;
            this.text_password.Name = "text_password";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.text_password.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.text_password.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.text_password.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.text_password.OnIdleState = stateProperties4;
            this.text_password.Padding = new System.Windows.Forms.Padding(4);
            this.text_password.PasswordChar = '●';
            this.text_password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.text_password.PlaceholderText = "Password";
            this.text_password.ReadOnly = false;
            this.text_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_password.SelectedText = "";
            this.text_password.SelectionLength = 0;
            this.text_password.SelectionStart = 0;
            this.text_password.ShortcutsEnabled = true;
            this.text_password.Size = new System.Drawing.Size(262, 38);
            this.text_password.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.text_password.TabIndex = 12;
            this.text_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_password.TextMarginBottom = 0;
            this.text_password.TextMarginLeft = 7;
            this.text_password.TextMarginTop = 1;
            this.text_password.TextPlaceholder = "Password";
            this.text_password.UseSystemPasswordChar = true;
            this.text_password.WordWrap = true;
            // 
            // text_loginName
            // 
            this.text_loginName.AcceptsReturn = false;
            this.text_loginName.AcceptsTab = false;
            this.text_loginName.AnimationSpeed = 200;
            this.text_loginName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.text_loginName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.text_loginName.BackColor = System.Drawing.Color.Transparent;
            this.text_loginName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("text_loginName.BackgroundImage")));
            this.text_loginName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.text_loginName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.text_loginName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.text_loginName.BorderColorIdle = System.Drawing.Color.Silver;
            this.text_loginName.BorderRadius = 1;
            this.text_loginName.BorderThickness = 1;
            this.text_loginName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.text_loginName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_loginName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.text_loginName.DefaultText = "";
            this.text_loginName.FillColor = System.Drawing.Color.White;
            this.text_loginName.HideSelection = true;
            this.text_loginName.IconLeft = global::NganHang.Properties.Resources.user;
            this.text_loginName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.text_loginName.IconPadding = 9;
            this.text_loginName.IconRight = null;
            this.text_loginName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.text_loginName.Lines = new string[0];
            this.text_loginName.Location = new System.Drawing.Point(242, 315);
            this.text_loginName.Margin = new System.Windows.Forms.Padding(4);
            this.text_loginName.MaxLength = 32767;
            this.text_loginName.MinimumSize = new System.Drawing.Size(1, 1);
            this.text_loginName.Modified = false;
            this.text_loginName.Multiline = false;
            this.text_loginName.Name = "text_loginName";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.text_loginName.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.text_loginName.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.text_loginName.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.text_loginName.OnIdleState = stateProperties8;
            this.text_loginName.Padding = new System.Windows.Forms.Padding(4);
            this.text_loginName.PasswordChar = '\0';
            this.text_loginName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.text_loginName.PlaceholderText = "Enter Name";
            this.text_loginName.ReadOnly = false;
            this.text_loginName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_loginName.SelectedText = "";
            this.text_loginName.SelectionLength = 0;
            this.text_loginName.SelectionStart = 0;
            this.text_loginName.ShortcutsEnabled = true;
            this.text_loginName.Size = new System.Drawing.Size(262, 38);
            this.text_loginName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.text_loginName.TabIndex = 13;
            this.text_loginName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_loginName.TextMarginBottom = 0;
            this.text_loginName.TextMarginLeft = 7;
            this.text_loginName.TextMarginTop = 1;
            this.text_loginName.TextPlaceholder = "Enter Name";
            this.text_loginName.UseSystemPasswordChar = false;
            this.text_loginName.WordWrap = true;
            // 
            // cmb_chiNhanh
            // 
            this.cmb_chiNhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vDSPHANMANHBindingSource, "TENCN", true));
            this.cmb_chiNhanh.DataSource = this.vDSPHANMANHBindingSource;
            this.cmb_chiNhanh.DisplayMember = "TENSERVER";
            this.cmb_chiNhanh.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cmb_chiNhanh.FormattingEnabled = true;
            this.cmb_chiNhanh.ItemHeight = 20;
            this.cmb_chiNhanh.Location = new System.Drawing.Point(242, 166);
            this.cmb_chiNhanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_chiNhanh.Name = "cmb_chiNhanh";
            this.cmb_chiNhanh.Size = new System.Drawing.Size(261, 28);
            this.cmb_chiNhanh.TabIndex = 14;
            this.cmb_chiNhanh.ValueMember = "TENSERVER";
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.dS_DSPHANMANH;
            // 
            // dS_DSPHANMANH
            // 
            this.dS_DSPHANMANH.DataSetName = "DS_DSPHANMANH";
            this.dS_DSPHANMANH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(193)))), ((int)(((byte)(149)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(535, 767);
            this.bunifuGradientPanel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 250);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dSDSPHANMANHBindingSource
            // 
            this.dSDSPHANMANHBindingSource.DataSource = this.dS_DSPHANMANH;
            this.dSDSPHANMANHBindingSource.Position = 0;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // v_DS_NHANVIENTableAdapter
            // 
            this.v_DS_NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = NganHang.DS_NHANVIENTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(212, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 61);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sign up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(110, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Chi nhánh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(110, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(110, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Login name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(110, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 26;
            this.label5.Text = "Password";
            // 
            // Frm_taoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 767);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_taoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo tài khoản";
            this.Load += new System.EventHandler(this.Frm_taoTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_NHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_NHANVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDSPHANMANHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_dangNhap;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuTextBox text_password;
        private Bunifu.UI.WinForms.BunifuTextBox text_loginName;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private System.Windows.Forms.ComboBox cmb_nhanVien;
        private System.Windows.Forms.BindingSource dSDSPHANMANHBindingSource;
        private DS_DSPHANMANH dS_DSPHANMANH;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_NHANVIEN dS_NHANVIEN;
        private System.Windows.Forms.BindingSource v_DS_NHANVIENBindingSource;
        private DS_NHANVIENTableAdapters.V_DS_NHANVIENTableAdapter v_DS_NHANVIENTableAdapter;
        private DS_NHANVIENTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}