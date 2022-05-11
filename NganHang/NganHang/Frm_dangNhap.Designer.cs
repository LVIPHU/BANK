namespace NganHang
{
    partial class Frm_dangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_dangNhap));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPHANMANH = new NganHang.DS_DSPHANMANH();
            this.v_DS_PHANMANHTableAdapter = new NganHang.DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new NganHang.DS_DSPHANMANHTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dangNhap = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.text_passWord = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.text_userName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 248);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(535, 732);
            this.bunifuGradientPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn_dangNhap);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.text_passWord);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.text_userName);
            this.panel1.Controls.Add(this.bunifuLabel6);
            this.panel1.Controls.Add(this.cmb_chiNhanh);
            this.panel1.Location = new System.Drawing.Point(848, 117);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 484);
            this.panel1.TabIndex = 19;
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
            this.btn_dangNhap.ButtonText = "SIGN IN";
            this.btn_dangNhap.ButtonTextMarginLeft = 0;
            this.btn_dangNhap.ColorContrastOnClick = 45;
            this.btn_dangNhap.ColorContrastOnHover = 45;
            this.btn_dangNhap.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_dangNhap.CustomizableEdges = borderEdges3;
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
            this.btn_dangNhap.Location = new System.Drawing.Point(319, 382);
            this.btn_dangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(292, 28);
            this.bunifuSeparator1.TabIndex = 17;
            // 
            // text_passWord
            // 
            this.text_passWord.AcceptsReturn = false;
            this.text_passWord.AcceptsTab = false;
            this.text_passWord.AnimationSpeed = 200;
            this.text_passWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.text_passWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.text_passWord.BackColor = System.Drawing.Color.Transparent;
            this.text_passWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("text_passWord.BackgroundImage")));
            this.text_passWord.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.text_passWord.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.text_passWord.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.text_passWord.BorderColorIdle = System.Drawing.Color.Silver;
            this.text_passWord.BorderRadius = 1;
            this.text_passWord.BorderThickness = 1;
            this.text_passWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.text_passWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_passWord.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.text_passWord.DefaultText = "";
            this.text_passWord.FillColor = System.Drawing.Color.White;
            this.text_passWord.HideSelection = true;
            this.text_passWord.IconLeft = global::NganHang.Properties.Resources._lock;
            this.text_passWord.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.text_passWord.IconPadding = 9;
            this.text_passWord.IconRight = null;
            this.text_passWord.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.text_passWord.Lines = new string[0];
            this.text_passWord.Location = new System.Drawing.Point(101, 303);
            this.text_passWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_passWord.MaxLength = 32767;
            this.text_passWord.MinimumSize = new System.Drawing.Size(1, 1);
            this.text_passWord.Modified = false;
            this.text_passWord.Multiline = false;
            this.text_passWord.Name = "text_passWord";
            stateProperties17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.text_passWord.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.text_passWord.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.text_passWord.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.text_passWord.OnIdleState = stateProperties20;
            this.text_passWord.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_passWord.PasswordChar = '●';
            this.text_passWord.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.text_passWord.PlaceholderText = "Password";
            this.text_passWord.ReadOnly = false;
            this.text_passWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_passWord.SelectedText = "";
            this.text_passWord.SelectionLength = 0;
            this.text_passWord.SelectionStart = 0;
            this.text_passWord.ShortcutsEnabled = true;
            this.text_passWord.Size = new System.Drawing.Size(389, 38);
            this.text_passWord.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.text_passWord.TabIndex = 12;
            this.text_passWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_passWord.TextMarginBottom = 0;
            this.text_passWord.TextMarginLeft = 7;
            this.text_passWord.TextMarginTop = 1;
            this.text_passWord.TextPlaceholder = "Password";
            this.text_passWord.UseSystemPasswordChar = true;
            this.text_passWord.WordWrap = true;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(217, 27);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(141, 61);
            this.bunifuLabel1.TabIndex = 16;
            this.bunifuLabel1.Text = "Sign In";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // text_userName
            // 
            this.text_userName.AcceptsReturn = false;
            this.text_userName.AcceptsTab = false;
            this.text_userName.AnimationSpeed = 200;
            this.text_userName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.text_userName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.text_userName.BackColor = System.Drawing.Color.Transparent;
            this.text_userName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("text_userName.BackgroundImage")));
            this.text_userName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.text_userName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.text_userName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.text_userName.BorderColorIdle = System.Drawing.Color.Silver;
            this.text_userName.BorderRadius = 1;
            this.text_userName.BorderThickness = 1;
            this.text_userName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.text_userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_userName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.text_userName.DefaultText = "";
            this.text_userName.FillColor = System.Drawing.Color.White;
            this.text_userName.HideSelection = true;
            this.text_userName.IconLeft = global::NganHang.Properties.Resources.user;
            this.text_userName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.text_userName.IconPadding = 9;
            this.text_userName.IconRight = null;
            this.text_userName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.text_userName.Lines = new string[0];
            this.text_userName.Location = new System.Drawing.Point(101, 230);
            this.text_userName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_userName.MaxLength = 32767;
            this.text_userName.MinimumSize = new System.Drawing.Size(1, 1);
            this.text_userName.Modified = false;
            this.text_userName.Multiline = false;
            this.text_userName.Name = "text_userName";
            stateProperties21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.text_userName.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.text_userName.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.text_userName.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.text_userName.OnIdleState = stateProperties24;
            this.text_userName.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_userName.PasswordChar = '\0';
            this.text_userName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.text_userName.PlaceholderText = "Enter Name";
            this.text_userName.ReadOnly = false;
            this.text_userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_userName.SelectedText = "";
            this.text_userName.SelectionLength = 0;
            this.text_userName.SelectionStart = 0;
            this.text_userName.ShortcutsEnabled = true;
            this.text_userName.Size = new System.Drawing.Size(389, 38);
            this.text_userName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.text_userName.TabIndex = 13;
            this.text_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_userName.TextMarginBottom = 0;
            this.text_userName.TextMarginLeft = 7;
            this.text_userName.TextMarginTop = 1;
            this.text_userName.TextPlaceholder = "Enter Name";
            this.text_userName.UseSystemPasswordChar = false;
            this.text_userName.WordWrap = true;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuLabel6.Location = new System.Drawing.Point(101, 166);
            this.bunifuLabel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(87, 28);
            this.bunifuLabel6.TabIndex = 15;
            this.bunifuLabel6.Text = "Chi nhánh";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cmb_chiNhanh
            // 
            this.cmb_chiNhanh.DataSource = this.v_DS_PHANMANHBindingSource;
            this.cmb_chiNhanh.DisplayMember = "TENSERVER";
            this.cmb_chiNhanh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmb_chiNhanh.FormattingEnabled = true;
            this.cmb_chiNhanh.ItemHeight = 20;
            this.cmb_chiNhanh.Location = new System.Drawing.Point(217, 166);
            this.cmb_chiNhanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_chiNhanh.Name = "cmb_chiNhanh";
            this.cmb_chiNhanh.Size = new System.Drawing.Size(272, 28);
            this.cmb_chiNhanh.TabIndex = 14;
            this.cmb_chiNhanh.ValueMember = "TENSERVER";
            this.cmb_chiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmb_chiNhanh_SelectedIndexChanged);
            // 
            // Frm_dangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_dangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_dangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DS_DSPHANMANH dS_DSPHANMANH;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPHANMANHTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_dangNhap;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuTextBox text_passWord;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox text_userName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
    }
}