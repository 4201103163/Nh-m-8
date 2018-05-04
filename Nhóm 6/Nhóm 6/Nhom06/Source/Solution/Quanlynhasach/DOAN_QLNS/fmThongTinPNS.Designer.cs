namespace DOAN_QLNS
{
    partial class fmThongTinPNS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmThongTinPNS));
            this.btEditMa = new DevExpress.XtraEditors.ButtonEdit();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btLapPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.dati = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btEditMa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btEditMa
            // 
            this.btEditMa.Location = new System.Drawing.Point(139, 154);
            this.btEditMa.Name = "btEditMa";
            this.btEditMa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditMa.Properties.Appearance.Options.UseFont = true;
            this.btEditMa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo)});
            this.btEditMa.Size = new System.Drawing.Size(161, 26);
            this.btEditMa.TabIndex = 11;
            this.btEditMa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btEditMa_ButtonClick);
            // 
            // btHuy
            // 
            this.btHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btHuy.Appearance.Options.UseFont = true;
            this.btHuy.Appearance.Options.UseForeColor = true;
            this.btHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btHuy.Image = ((System.Drawing.Image)(resources.GetObject("btHuy.Image")));
            this.btHuy.Location = new System.Drawing.Point(316, 199);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(116, 35);
            this.btHuy.TabIndex = 9;
            this.btHuy.Text = "Hủy";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btLapPhieu
            // 
            this.btLapPhieu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLapPhieu.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btLapPhieu.Appearance.Options.UseFont = true;
            this.btLapPhieu.Appearance.Options.UseForeColor = true;
            this.btLapPhieu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btLapPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btLapPhieu.Image")));
            this.btLapPhieu.Location = new System.Drawing.Point(184, 199);
            this.btLapPhieu.Name = "btLapPhieu";
            this.btLapPhieu.Size = new System.Drawing.Size(116, 35);
            this.btLapPhieu.TabIndex = 10;
            this.btLapPhieu.Text = "Lập phiếu";
            this.btLapPhieu.Click += new System.EventHandler(this.btLapPhieu_Click);
            // 
            // dati
            // 
            this.dati.CustomFormat = "dd/MM/yyyy";
            this.dati.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dati.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dati.Location = new System.Drawing.Point(437, 153);
            this.dati.Name = "dati";
            this.dati.Size = new System.Drawing.Size(131, 27);
            this.dati.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(316, 157);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(106, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Ngày lập phiếu";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(150, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(314, 35);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Thông tin phiếu nhập";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(29, 157);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 19);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Mã phiếu nhập";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 100);
            this.panel1.TabIndex = 12;
            // 
            // fmThongTinPNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btEditMa);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btLapPhieu);
            this.Controls.Add(this.dati);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Name = "fmThongTinPNS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN PHIẾU NHẬP SÁCH";
            this.Load += new System.EventHandler(this.fmThongTinPNS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btEditMa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit btEditMa;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btLapPhieu;
        private System.Windows.Forms.DateTimePicker dati;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
    }
}