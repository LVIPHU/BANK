
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
            System.Windows.Forms.Label lbl_maCN;
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPHANMANH = new NganHang.DS_DSPHANMANH();
            this.v_DS_PHANMANHTableAdapter = new NganHang.DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.btn_chuyen = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            lbl_maCN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(lbl_maCN);
            this.bunifuPanel1.Controls.Add(this.cmb_chiNhanh);
            this.bunifuPanel1.Controls.Add(this.btn_chuyen);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(419, 348);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // cmb_chiNhanh
            // 
            this.cmb_chiNhanh.DataSource = this.vDSPHANMANHBindingSource;
            this.cmb_chiNhanh.DisplayMember = "TENSERVER";
            this.cmb_chiNhanh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmb_chiNhanh.FormattingEnabled = true;
            this.cmb_chiNhanh.ItemHeight = 20;
            this.cmb_chiNhanh.Location = new System.Drawing.Point(90, 86);
            this.cmb_chiNhanh.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_chiNhanh.Name = "cmb_chiNhanh";
            this.cmb_chiNhanh.Size = new System.Drawing.Size(238, 28);
            this.cmb_chiNhanh.TabIndex = 17;
            this.cmb_chiNhanh.ValueMember = "TENSERVER";
            // 
            // btn_chuyen
            // 
            this.btn_chuyen.AllowAnimations = true;
            this.btn_chuyen.AllowMouseEffects = true;
            this.btn_chuyen.AllowToggling = false;
            this.btn_chuyen.AnimationSpeed = 200;
            this.btn_chuyen.AutoGenerateColors = false;
            this.btn_chuyen.AutoRoundBorders = false;
            this.btn_chuyen.AutoSizeLeftIcon = true;
            this.btn_chuyen.AutoSizeRightIcon = true;
            this.btn_chuyen.BackColor = System.Drawing.Color.Transparent;
            this.btn_chuyen.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_chuyen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_chuyen.BackgroundImage")));
            this.btn_chuyen.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_chuyen.ButtonText = "CHUYỂN ";
            this.btn_chuyen.ButtonTextMarginLeft = 0;
            this.btn_chuyen.ColorContrastOnClick = 45;
            this.btn_chuyen.ColorContrastOnHover = 45;
            this.btn_chuyen.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_chuyen.CustomizableEdges = borderEdges1;
            this.btn_chuyen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_chuyen.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_chuyen.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_chuyen.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_chuyen.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_chuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_chuyen.ForeColor = System.Drawing.Color.White;
            this.btn_chuyen.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chuyen.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_chuyen.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_chuyen.IconMarginLeft = 11;
            this.btn_chuyen.IconPadding = 10;
            this.btn_chuyen.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_chuyen.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_chuyen.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_chuyen.IconSize = 25;
            this.btn_chuyen.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_chuyen.IdleBorderRadius = 40;
            this.btn_chuyen.IdleBorderThickness = 2;
            this.btn_chuyen.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_chuyen.IdleIconLeftImage = null;
            this.btn_chuyen.IdleIconRightImage = null;
            this.btn_chuyen.IndicateFocus = false;
            this.btn_chuyen.Location = new System.Drawing.Point(121, 214);
            this.btn_chuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_chuyen.Name = "btn_chuyen";
            this.btn_chuyen.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_chuyen.OnDisabledState.BorderRadius = 40;
            this.btn_chuyen.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_chuyen.OnDisabledState.BorderThickness = 2;
            this.btn_chuyen.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_chuyen.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_chuyen.OnDisabledState.IconLeftImage = null;
            this.btn_chuyen.OnDisabledState.IconRightImage = null;
            this.btn_chuyen.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btn_chuyen.onHoverState.BorderRadius = 40;
            this.btn_chuyen.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_chuyen.onHoverState.BorderThickness = 2;
            this.btn_chuyen.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_chuyen.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btn_chuyen.onHoverState.IconLeftImage = null;
            this.btn_chuyen.onHoverState.IconRightImage = null;
            this.btn_chuyen.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_chuyen.OnIdleState.BorderRadius = 40;
            this.btn_chuyen.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_chuyen.OnIdleState.BorderThickness = 2;
            this.btn_chuyen.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_chuyen.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_chuyen.OnIdleState.IconLeftImage = null;
            this.btn_chuyen.OnIdleState.IconRightImage = null;
            this.btn_chuyen.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_chuyen.OnPressedState.BorderRadius = 40;
            this.btn_chuyen.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_chuyen.OnPressedState.BorderThickness = 2;
            this.btn_chuyen.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btn_chuyen.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btn_chuyen.OnPressedState.IconLeftImage = null;
            this.btn_chuyen.OnPressedState.IconRightImage = null;
            this.btn_chuyen.Size = new System.Drawing.Size(175, 48);
            this.btn_chuyen.TabIndex = 16;
            this.btn_chuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_chuyen.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_chuyen.TextMarginLeft = 0;
            this.btn_chuyen.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_chuyen.UseDefaultRadiusAndThickness = true;
            this.btn_chuyen.Click += new System.EventHandler(this.btn_chuyen_Click);
            // 
            // lbl_maCN
            // 
            lbl_maCN.AutoSize = true;
            lbl_maCN.BackColor = System.Drawing.Color.Transparent;
            lbl_maCN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lbl_maCN.ForeColor = System.Drawing.Color.Black;
            lbl_maCN.Location = new System.Drawing.Point(86, 61);
            lbl_maCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_maCN.Name = "lbl_maCN";
            lbl_maCN.Size = new System.Drawing.Size(89, 23);
            lbl_maCN.TabIndex = 30;
            lbl_maCN.Text = "Chi nhánh";
            // 
            // Frm_chuyenChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 348);
            this.Controls.Add(this.bunifuPanel1);
            this.IconOptions.Image = global::NganHang.Properties.Resources.company;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_chuyenChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển chi nhánh";
            this.Load += new System.EventHandler(this.Frm_chuyenCN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DS_DSPHANMANH dS_DSPHANMANH;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_chuyen;
    }
}