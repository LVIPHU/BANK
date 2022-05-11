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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.text_soTK = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_BD = new DevExpress.XtraEditors.DateEdit();
            this.date_KT = new DevExpress.XtraEditors.DateEdit();
            this.btn_preview = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_preview);
            this.groupControl1.Controls.Add(this.date_KT);
            this.groupControl1.Controls.Add(this.date_BD);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.text_soTK);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(421, 303);
            this.groupControl1.TabIndex = 0;
            // 
            // text_soTK
            // 
            this.text_soTK.Location = new System.Drawing.Point(169, 78);
            this.text_soTK.Name = "text_soTK";
            this.text_soTK.Size = new System.Drawing.Size(113, 20);
            this.text_soTK.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số TK:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày BD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày KT:";
            // 
            // date_BD
            // 
            this.date_BD.EditValue = null;
            this.date_BD.Location = new System.Drawing.Point(169, 121);
            this.date_BD.Name = "date_BD";
            this.date_BD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_BD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_BD.Size = new System.Drawing.Size(113, 20);
            this.date_BD.TabIndex = 6;
            // 
            // date_KT
            // 
            this.date_KT.EditValue = null;
            this.date_KT.Location = new System.Drawing.Point(169, 165);
            this.date_KT.Name = "date_KT";
            this.date_KT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_KT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_KT.Size = new System.Drawing.Size(113, 20);
            this.date_KT.TabIndex = 7;
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(169, 220);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_preview.TabIndex = 8;
            this.btn_preview.Text = "Preview";
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // Frm_saoKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 303);
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_saoKe";
            this.Text = "Frm_saoKe";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_soTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_KT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_preview;
        private DevExpress.XtraEditors.DateEdit date_KT;
        private DevExpress.XtraEditors.DateEdit date_BD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit text_soTK;
    }
}