
namespace NganHang
{
    partial class Frm_chuyenChiNhanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_chuyenChiNhanh));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPHANMANH = new NganHang.DS_DSPHANMANH();
            this.btn_dangNhap = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.v_DS_PHANMANHTableAdapter = new NganHang.DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = global::NganHang.Properties.Resources.how_to_open_a_Swiss_bank_account_1024x683;
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.cmb_chiNhanh);
            this.bunifuGradientPanel1.Controls.Add(this.btn_dangNhap);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(193)))), ((int)(((byte)(149)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(359, 283);
            this.bunifuGradientPanel1.TabIndex = 8;
            // 
            // cmb_chiNhanh
            // 
            this.cmb_chiNhanh.DataSource = this.vDSPHANMANHBindingSource;
            this.cmb_chiNhanh.DisplayMember = "TENSERVER";
            this.cmb_chiNhanh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmb_chiNhanh.FormattingEnabled = true;
            this.cmb_chiNhanh.ItemHeight = 15;
            this.cmb_chiNhanh.Location = new System.Drawing.Point(83, 72);
            this.cmb_chiNhanh.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_chiNhanh.Name = "cmb_chiNhanh";
            this.cmb_chiNhanh.Size = new System.Drawing.Size(205, 23);
            this.cmb_chiNhanh.TabIndex = 15;
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
            this.btn_dangNhap.ButtonText = "CHUYỂN ";
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
            this.btn_dangNhap.Location = new System.Drawing.Point(110, 176);
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
            this.btn_dangNhap.Size = new System.Drawing.Size(150, 39);
            this.btn_dangNhap.TabIndex = 7;
            this.btn_dangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_dangNhap.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_dangNhap.TextMarginLeft = 0;
            this.btn_dangNhap.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_dangNhap.UseDefaultRadiusAndThickness = true;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_chuyenChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 283);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.IconOptions.Image = global::NganHang.Properties.Resources.company;
            this.Name = "Frm_chuyenChiNhanh";
            this.Text = "Chuyển chi nhánh";
            this.Load += new System.EventHandler(this.Frm_chuyenCN_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_dangNhap;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private DS_DSPHANMANH dS_DSPHANMANH;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
    }
}