namespace DOAN_QLNS
{
    partial class fmDanhSachPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDanhSachPhieuNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSuaSachPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.btSuaNgayPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.btXoaPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.btTim = new DevExpress.XtraEditors.SimpleButton();
            this.cbTimTheo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.datiToi = new System.Windows.Forms.DateTimePicker();
            this.lblToi = new DevExpress.XtraEditors.LabelControl();
            this.datiTu = new System.Windows.Forms.DateTimePicker();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblTu = new DevExpress.XtraEditors.LabelControl();
            this.datiPNS = new System.Windows.Forms.DateTimePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.gView_PNS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gView_DSPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtMaPhieu = new DevExpress.XtraEditors.TextEdit();
            this.label = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gCtrl_PhieuNS = new DevExpress.XtraGrid.GridControl();
            this.gView_PhieuNS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gCtrl_DSachPN = new DevExpress.XtraGrid.GridControl();
            this.gView_DSachPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimTheo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_PNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_PhieuNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_PhieuNS)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_DSachPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSachPN)).BeginInit();
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
            // btSuaSachPhieu
            // 
            this.btSuaSachPhieu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaSachPhieu.Appearance.Options.UseFont = true;
            this.btSuaSachPhieu.Enabled = false;
            this.btSuaSachPhieu.Location = new System.Drawing.Point(116, 416);
            this.btSuaSachPhieu.Name = "btSuaSachPhieu";
            this.btSuaSachPhieu.Size = new System.Drawing.Size(230, 34);
            this.btSuaSachPhieu.TabIndex = 25;
            this.btSuaSachPhieu.Text = "Sửa sách nhập của phiếu";
            this.btSuaSachPhieu.Click += new System.EventHandler(this.btSuaSachPhieu_Click);
            // 
            // btSuaNgayPhieu
            // 
            this.btSuaNgayPhieu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaNgayPhieu.Appearance.Options.UseFont = true;
            this.btSuaNgayPhieu.Enabled = false;
            this.btSuaNgayPhieu.Location = new System.Drawing.Point(193, 416);
            this.btSuaNgayPhieu.Name = "btSuaNgayPhieu";
            this.btSuaNgayPhieu.Size = new System.Drawing.Size(166, 34);
            this.btSuaNgayPhieu.TabIndex = 26;
            this.btSuaNgayPhieu.Text = "Sửa ngày lập phiếu";
            this.btSuaNgayPhieu.Click += new System.EventHandler(this.btSuaNgayPhieu_Click);
            // 
            // btXoaPhieu
            // 
            this.btXoaPhieu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaPhieu.Appearance.Options.UseFont = true;
            this.btXoaPhieu.Enabled = false;
            this.btXoaPhieu.Location = new System.Drawing.Point(44, 416);
            this.btXoaPhieu.Name = "btXoaPhieu";
            this.btXoaPhieu.Size = new System.Drawing.Size(115, 34);
            this.btXoaPhieu.TabIndex = 27;
            this.btXoaPhieu.Text = "Xóa phiếu";
            this.btXoaPhieu.Click += new System.EventHandler(this.btXoaPhieu_Click);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(304, 56);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 28;
            this.btTim.Text = "Tìm";
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // cbTimTheo
            // 
            this.cbTimTheo.Location = new System.Drawing.Point(61, 134);
            this.cbTimTheo.Name = "cbTimTheo";
            this.cbTimTheo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.cbTimTheo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTimTheo.Properties.Items.AddRange(new object[] {
            "All",
            "Khoảng ngày"});
            this.cbTimTheo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTimTheo.Size = new System.Drawing.Size(102, 20);
            this.cbTimTheo.TabIndex = 24;
            this.cbTimTheo.SelectedIndexChanged += new System.EventHandler(this.cbTimTheo_SelectedIndexChanged);
            // 
            // datiToi
            // 
            this.datiToi.CustomFormat = "dd/MM/yyyy";
            this.datiToi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datiToi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datiToi.Location = new System.Drawing.Point(193, 55);
            this.datiToi.Name = "datiToi";
            this.datiToi.Size = new System.Drawing.Size(102, 23);
            this.datiToi.TabIndex = 21;
            // 
            // lblToi
            // 
            this.lblToi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToi.Location = new System.Drawing.Point(169, 60);
            this.lblToi.Name = "lblToi";
            this.lblToi.Size = new System.Drawing.Size(18, 16);
            this.lblToi.TabIndex = 15;
            this.lblToi.Text = "Tới";
            // 
            // datiTu
            // 
            this.datiTu.CustomFormat = "dd/MM/yyyy";
            this.datiTu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datiTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datiTu.Location = new System.Drawing.Point(57, 56);
            this.datiTu.Name = "datiTu";
            this.datiTu.Size = new System.Drawing.Size(102, 23);
            this.datiTu.TabIndex = 22;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(3, 135);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 16);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Tìm theo";
            // 
            // lblTu
            // 
            this.lblTu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTu.Location = new System.Drawing.Point(35, 63);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(16, 16);
            this.lblTu.TabIndex = 17;
            this.lblTu.Text = "Từ";
            // 
            // datiPNS
            // 
            this.datiPNS.CalendarForeColor = System.Drawing.Color.Black;
            this.datiPNS.CustomFormat = "dd/MM/yyyy";
            this.datiPNS.Enabled = false;
            this.datiPNS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datiPNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datiPNS.Location = new System.Drawing.Point(68, 34);
            this.datiPNS.Name = "datiPNS";
            this.datiPNS.Size = new System.Drawing.Size(130, 23);
            this.datiPNS.TabIndex = 23;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(4, 39);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 16);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Ngày lập";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(224, 38);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(52, 16);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "Mã phiếu";
            // 
            // gView_PNS
            // 
            this.gView_PNS.Name = "gView_PNS";
            this.gView_PNS.OptionsBehavior.Editable = false;
            this.gView_PNS.OptionsBehavior.ReadOnly = true;
            this.gView_PNS.OptionsFind.AlwaysVisible = true;
            this.gView_PNS.OptionsView.ShowGroupPanel = false;
            // 
            // gView_DSPN
            // 
            this.gView_DSPN.Name = "gView_DSPN";
            this.gView_DSPN.OptionsBehavior.Editable = false;
            this.gView_DSPN.OptionsBehavior.ReadOnly = true;
            this.gView_DSPN.OptionsFind.AlwaysVisible = true;
            this.gView_DSPN.OptionsView.ShowGroupPanel = false;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Enabled = false;
            this.txtMaPhieu.Location = new System.Drawing.Point(282, 35);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Properties.Appearance.Options.UseFont = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(130, 22);
            this.txtMaPhieu.TabIndex = 20;
            // 
            // label
            // 
            this.label.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(514, 146);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 29);
            this.label.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(50, 106);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 29);
            this.labelControl1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTim);
            this.groupBox1.Controls.Add(this.gCtrl_PhieuNS);
            this.groupBox1.Controls.Add(this.datiToi);
            this.groupBox1.Controls.Add(this.btSuaNgayPhieu);
            this.groupBox1.Controls.Add(this.lblToi);
            this.groupBox1.Controls.Add(this.btXoaPhieu);
            this.groupBox1.Controls.Add(this.datiTu);
            this.groupBox1.Controls.Add(this.lblTu);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 463);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Phiếu nhập";
            // 
            // gCtrl_PhieuNS
            // 
            this.gCtrl_PhieuNS.Location = new System.Drawing.Point(0, 85);
            this.gCtrl_PhieuNS.MainView = this.gView_PhieuNS;
            this.gCtrl_PhieuNS.Name = "gCtrl_PhieuNS";
            this.gCtrl_PhieuNS.Size = new System.Drawing.Size(389, 325);
            this.gCtrl_PhieuNS.TabIndex = 28;
            this.gCtrl_PhieuNS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gView_PhieuNS});
            this.gCtrl_PhieuNS.DataSourceChanged += new System.EventHandler(this.gCtrl_PhieuNS_DataSourceChanged);
            // 
            // gView_PhieuNS
            // 
            this.gView_PhieuNS.GridControl = this.gCtrl_PhieuNS;
            this.gView_PhieuNS.Name = "gView_PhieuNS";
            this.gView_PhieuNS.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gView_PhieuNS_RowClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gCtrl_DSachPN);
            this.groupBox2.Controls.Add(this.btSuaSachPhieu);
            this.groupBox2.Controls.Add(this.txtMaPhieu);
            this.groupBox2.Controls.Add(this.labelControl10);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.datiPNS);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(398, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 463);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Phiếu nhập";
            // 
            // gCtrl_DSachPN
            // 
            this.gCtrl_DSachPN.Location = new System.Drawing.Point(6, 63);
            this.gCtrl_DSachPN.MainView = this.gView_DSachPN;
            this.gCtrl_DSachPN.Name = "gCtrl_DSachPN";
            this.gCtrl_DSachPN.Size = new System.Drawing.Size(480, 347);
            this.gCtrl_DSachPN.TabIndex = 26;
            this.gCtrl_DSachPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gView_DSachPN});
            // 
            // gView_DSachPN
            // 
            this.gView_DSachPN.GridControl = this.gCtrl_DSachPN;
            this.gView_DSachPN.Name = "gView_DSachPN";
            // 
            // fmDanhSachPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 570);
            this.Controls.Add(this.cbTimTheo);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmDanhSachPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phiếu nhập";
            ((System.ComponentModel.ISupportInitialize)(this.cbTimTheo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_PNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_PhieuNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_PhieuNS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_DSachPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSachPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btSuaSachPhieu;
        private DevExpress.XtraEditors.SimpleButton btSuaNgayPhieu;
        private DevExpress.XtraEditors.SimpleButton btXoaPhieu;
        private DevExpress.XtraEditors.SimpleButton btTim;
        private DevExpress.XtraEditors.ComboBoxEdit cbTimTheo;
        private System.Windows.Forms.DateTimePicker datiToi;
        private DevExpress.XtraEditors.LabelControl lblToi;
        private System.Windows.Forms.DateTimePicker datiTu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblTu;
        private System.Windows.Forms.DateTimePicker datiPNS;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraGrid.Views.Grid.GridView gView_PNS;
        private DevExpress.XtraGrid.Views.Grid.GridView gView_DSPN;
        private DevExpress.XtraEditors.TextEdit txtMaPhieu;
        private DevExpress.XtraEditors.LabelControl label;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gCtrl_PhieuNS;
        private DevExpress.XtraGrid.Views.Grid.GridView gView_PhieuNS;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gCtrl_DSachPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gView_DSachPN;
    }
}