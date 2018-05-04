namespace DOAN_QLNS
{
    partial class fmCapNhatNgayLapPhieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCapNhatNgayLapPhieu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dati = new System.Windows.Forms.DateTimePicker();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btCapNhat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(137, 121);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Properties.Appearance.Options.UseFont = true;
            this.txtMa.Size = new System.Drawing.Size(150, 26);
            this.txtMa.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(11, 124);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 19);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Mã phiếu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(11, 172);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 19);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Ngày lập phiếu";
            // 
            // dati
            // 
            this.dati.CustomFormat = "dd/MM/yyyy";
            this.dati.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dati.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dati.Location = new System.Drawing.Point(137, 166);
            this.dati.Name = "dati";
            this.dati.Size = new System.Drawing.Size(150, 27);
            this.dati.TabIndex = 8;
            // 
            // btHuy
            // 
            this.btHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Appearance.Options.UseFont = true;
            this.btHuy.Location = new System.Drawing.Point(321, 166);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(102, 34);
            this.btHuy.TabIndex = 7;
            this.btHuy.Text = "Hủy";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.Appearance.Options.UseFont = true;
            this.btCapNhat.Location = new System.Drawing.Point(321, 116);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(102, 34);
            this.btCapNhat.TabIndex = 6;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // fmCapNhatNgayLapPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 224);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dati);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCapNhatNgayLapPhieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẬP NHẬT NGÀY LẬP PHIẾU";
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dati;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btCapNhat;
    }
}