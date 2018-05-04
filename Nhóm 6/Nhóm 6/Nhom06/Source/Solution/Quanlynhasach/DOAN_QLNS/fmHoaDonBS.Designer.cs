namespace DOAN_QLNS
{
    partial class fmHoaDonBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmHoaDonBS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datiNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btReport = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btMua = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSLM = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblMaHD = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblText = new System.Windows.Forms.Label();
            this.gCtrl_DSSach = new DevExpress.XtraGrid.GridControl();
            this.gView_DSSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gCtrl_HDBS = new DevExpress.XtraGrid.GridControl();
            this.gView_HDBS = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLM.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_DSSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_HDBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_HDBS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 100);
            this.panel1.TabIndex = 0;
            // 
            // datiNgayLap
            // 
            this.datiNgayLap.CustomFormat = "dd/MM/yyyy";
            this.datiNgayLap.Enabled = false;
            this.datiNgayLap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datiNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datiNgayLap.Location = new System.Drawing.Point(746, 154);
            this.datiNgayLap.Name = "datiNgayLap";
            this.datiNgayLap.Size = new System.Drawing.Size(121, 27);
            this.datiNgayLap.TabIndex = 25;
            // 
            // btReport
            // 
            this.btReport.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReport.Appearance.Options.UseFont = true;
            this.btReport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btReport.Image = ((System.Drawing.Image)(resources.GetObject("btReport.Image")));
            this.btReport.Location = new System.Drawing.Point(280, 396);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(131, 43);
            this.btReport.TabIndex = 22;
            this.btReport.Text = "Xuất report";
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // btXoa
            // 
            this.btXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(161, 396);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(113, 43);
            this.btXoa.TabIndex = 23;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btMua
            // 
            this.btMua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMua.Appearance.Options.UseFont = true;
            this.btMua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btMua.Image = ((System.Drawing.Image)(resources.GetObject("btMua.Image")));
            this.btMua.Location = new System.Drawing.Point(262, 396);
            this.btMua.Name = "btMua";
            this.btMua.Size = new System.Drawing.Size(95, 47);
            this.btMua.TabIndex = 24;
            this.btMua.Text = "Mua";
            this.btMua.Click += new System.EventHandler(this.btMua_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(103, 49);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Properties.Appearance.Options.UseFont = true;
            this.txtTenKH.Properties.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(149, 26);
            this.txtTenKH.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(667, 160);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 19);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Ngày lập";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 19);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Họ tên KH";
            // 
            // txtSLM
            // 
            this.txtSLM.Location = new System.Drawing.Point(145, 417);
            this.txtSLM.Name = "txtSLM";
            this.txtSLM.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLM.Properties.Appearance.Options.UseFont = true;
            this.txtSLM.Size = new System.Drawing.Size(100, 26);
            this.txtSLM.TabIndex = 21;
            this.txtSLM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLM_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(27, 420);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 19);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Số lượng mua";
            // 
            // lblMaHD
            // 
            this.lblMaHD.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(12, 22);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(70, 25);
            this.lblMaHD.TabIndex = 15;
            this.lblMaHD.Text = "Mã HD";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(6, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 33);
            this.labelControl2.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblText);
            this.groupBox1.Controls.Add(this.gCtrl_DSSach);
            this.groupBox1.Controls.Add(this.btMua);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtSLM);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 449);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH SÁCH";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(24, 380);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(267, 13);
            this.lblText.TabIndex = 25;
            this.lblText.Text = "LƯU Ý: Đầu sách có số lượng tồn sau khi bán là";
            // 
            // gCtrl_DSSach
            // 
            this.gCtrl_DSSach.Location = new System.Drawing.Point(3, 22);
            this.gCtrl_DSSach.MainView = this.gView_DSSach;
            this.gCtrl_DSSach.Name = "gCtrl_DSSach";
            this.gCtrl_DSSach.Size = new System.Drawing.Size(400, 337);
            this.gCtrl_DSSach.TabIndex = 25;
            this.gCtrl_DSSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gView_DSSach});
            // 
            // gView_DSSach
            // 
            this.gView_DSSach.GridControl = this.gCtrl_DSSach;
            this.gView_DSSach.Name = "gView_DSSach";
            this.gView_DSSach.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gView_DSSach_CustomDrawRowIndicator);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gCtrl_HDBS);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.btReport);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.lblMaHD);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(409, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 449);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn bán sách";
            // 
            // gCtrl_HDBS
            // 
            this.gCtrl_HDBS.Location = new System.Drawing.Point(0, 81);
            this.gCtrl_HDBS.MainView = this.gView_HDBS;
            this.gCtrl_HDBS.Name = "gCtrl_HDBS";
            this.gCtrl_HDBS.Size = new System.Drawing.Size(475, 286);
            this.gCtrl_HDBS.TabIndex = 24;
            this.gCtrl_HDBS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gView_HDBS});
            this.gCtrl_HDBS.DataSourceChanged += new System.EventHandler(this.gCtrl_HDBS_DataSourceChanged);
            // 
            // gView_HDBS
            // 
            this.gView_HDBS.GridControl = this.gCtrl_HDBS;
            this.gView_HDBS.Name = "gView_HDBS";
            this.gView_HDBS.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gView_HDBS_CustomDrawRowIndicator);
            // 
            // fmHoaDonBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 586);
            this.Controls.Add(this.datiNgayLap);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmHoaDonBS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmHoaDonBS";
            this.Load += new System.EventHandler(this.fmHoaDonBS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLM.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_DSSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_HDBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_HDBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker datiNgayLap;
        private DevExpress.XtraEditors.SimpleButton btReport;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btMua;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSLM;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblMaHD;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gCtrl_DSSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gView_DSSach;
        private DevExpress.XtraGrid.GridControl gCtrl_HDBS;
        private DevExpress.XtraGrid.Views.Grid.GridView gView_HDBS;
        private System.Windows.Forms.Label lblText;
    }
}