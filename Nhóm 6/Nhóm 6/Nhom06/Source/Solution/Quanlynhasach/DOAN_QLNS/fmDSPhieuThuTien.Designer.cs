namespace DOAN_QLNS
{
    partial class fmDSPhieuThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDSPhieuThuTien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gCtrl_DSKH = new DevExpress.XtraGrid.GridControl();
            this.gView_DSKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gCtrl_DSPTT = new DevExpress.XtraGrid.GridControl();
            this.gView_DSPTT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_DSKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_DSPTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSPTT)).BeginInit();
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(501, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 33);
            this.labelControl2.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(501, 386);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 33);
            this.labelControl1.TabIndex = 12;
            // 
            // gCtrl_DSKH
            // 
            this.gCtrl_DSKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCtrl_DSKH.Location = new System.Drawing.Point(3, 19);
            this.gCtrl_DSKH.MainView = this.gView_DSKH;
            this.gCtrl_DSKH.Name = "gCtrl_DSKH";
            this.gCtrl_DSKH.Size = new System.Drawing.Size(426, 425);
            this.gCtrl_DSKH.TabIndex = 15;
            this.gCtrl_DSKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gView_DSKH});
            this.gCtrl_DSKH.DataSourceChanged += new System.EventHandler(this.gCtrl_DSKH_DataSourceChanged);
            // 
            // gView_DSKH
            // 
            this.gView_DSKH.GridControl = this.gCtrl_DSKH;
            this.gView_DSKH.Name = "gView_DSKH";
            this.gView_DSKH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gView_DSKH_RowClick);
            this.gView_DSKH.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gView_DSKH_CustomDrawRowIndicator);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gCtrl_DSKH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 447);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gCtrl_DSPTT);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(432, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 394);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Phiếu thu tiền ";
            // 
            // gCtrl_DSPTT
            // 
            this.gCtrl_DSPTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCtrl_DSPTT.Location = new System.Drawing.Point(3, 19);
            this.gCtrl_DSPTT.MainView = this.gView_DSPTT;
            this.gCtrl_DSPTT.Name = "gCtrl_DSPTT";
            this.gCtrl_DSPTT.Size = new System.Drawing.Size(446, 372);
            this.gCtrl_DSPTT.TabIndex = 0;
            this.gCtrl_DSPTT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gView_DSPTT});
            this.gCtrl_DSPTT.DataSourceChanged += new System.EventHandler(this.gCtrl_DSPTT_DataSourceChanged);
            // 
            // gView_DSPTT
            // 
            this.gView_DSPTT.GridControl = this.gCtrl_DSPTT;
            this.gView_DSPTT.Name = "gView_DSPTT";
            this.gView_DSPTT.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gView_DSPTT_CustomDrawRowIndicator);
            // 
            // btSua
            // 
            this.btSua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Appearance.Options.UseFont = true;
            this.btSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.Location = new System.Drawing.Point(768, 500);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(113, 35);
            this.btSua.TabIndex = 18;
            this.btSua.Text = "Sửa phiếu";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(646, 500);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(116, 35);
            this.btXoa.TabIndex = 19;
            this.btXoa.Text = "Xóa phiếu";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // fmDSPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 547);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel1);
            this.Name = "fmDSPhieuThuTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH PHIẾU THU TIỀN";
            this.Load += new System.EventHandler(this.fmDSPhieuThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_DSKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_DSPTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSPTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gCtrl_DSKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gView_DSKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gCtrl_DSPTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gView_DSPTT;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btXoa;
    }
}