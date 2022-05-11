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
            System.Windows.Forms.Label tENCNLabel;
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_preview = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_KT = new DevExpress.XtraEditors.DateEdit();
            this.date_BD = new DevExpress.XtraEditors.DateEdit();
            this.dS_DSPHANMANH = new NganHang.DS_DSPHANMANH();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new NganHang.DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new NganHang.DS_DSPHANMANHTableAdapters.TableAdapterManager();
            this.cmb_maCN = new System.Windows.Forms.ComboBox();
            tENCNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(tENCNLabel);
            this.groupControl1.Controls.Add(this.cmb_maCN);
            this.groupControl1.Controls.Add(this.btn_preview);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.date_KT);
            this.groupControl1.Controls.Add(this.date_BD);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(383, 336);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Liệt kê các tài khoản mở trong 1 khoảng thời gian của chi nhánh, của tất cả các c" +
    "hi nhánh.";
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(142, 232);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_preview.TabIndex = 4;
            this.btn_preview.Text = "Preview";
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày kết thúc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày bắt đầu:";
            // 
            // date_KT
            // 
            this.date_KT.EditValue = null;
            this.date_KT.Location = new System.Drawing.Point(151, 82);
            this.date_KT.Name = "date_KT";
            this.date_KT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_KT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_KT.Size = new System.Drawing.Size(121, 20);
            this.date_KT.TabIndex = 1;
            // 
            // date_BD
            // 
            this.date_BD.EditValue = null;
            this.date_BD.Location = new System.Drawing.Point(151, 43);
            this.date_BD.Name = "date_BD";
            this.date_BD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_BD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_BD.Size = new System.Drawing.Size(121, 20);
            this.date_BD.TabIndex = 0;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = NganHang.DS_DSPHANMANHTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(84, 134);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(62, 13);
            tENCNLabel.TabIndex = 5;
            tENCNLabel.Text = "Chi nhánh: ";
            // 
            // cmb_maCN
            // 
            this.cmb_maCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DS_PHANMANHBindingSource, "TENCN", true));
            this.cmb_maCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_maCN.FormattingEnabled = true;
            this.cmb_maCN.Location = new System.Drawing.Point(151, 131);
            this.cmb_maCN.Name = "cmb_maCN";
            this.cmb_maCN.Size = new System.Drawing.Size(121, 21);
            this.cmb_maCN.TabIndex = 6;
            this.cmb_maCN.SelectedIndexChanged += new System.EventHandler(this.tENCNComboBox_SelectedIndexChanged);
            // 
            // Frm_lietKeTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 336);
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_lietKeTaiKhoan";
            this.Text = "Liệt Kê Tài Khoản";
            this.Load += new System.EventHandler(this.Frm_lietKeTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPHANMANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_preview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit date_KT;
        private DevExpress.XtraEditors.DateEdit date_BD;
        private DS_DSPHANMANH dS_DSPHANMANH;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_DSPHANMANHTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPHANMANHTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmb_maCN;
    }
}