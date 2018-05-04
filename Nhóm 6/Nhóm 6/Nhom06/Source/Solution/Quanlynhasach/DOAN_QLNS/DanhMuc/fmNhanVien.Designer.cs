namespace DOAN_QLNS
{
    partial class fmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmNhanVien));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gCtrl_DSNV = new DevExpress.XtraGrid.GridControl();
            this.gView_DSNV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btSuaNV = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_DSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl1.Location = new System.Drawing.Point(210, 108);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(252, 25);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 100);
            this.panel1.TabIndex = 14;
            // 
            // gCtrl_DSNV
            // 
            this.gCtrl_DSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCtrl_DSNV.DataMember = "Query";
            this.gCtrl_DSNV.Location = new System.Drawing.Point(0, 180);
            this.gCtrl_DSNV.MainView = this.gView_DSNV;
            this.gCtrl_DSNV.Name = "gCtrl_DSNV";
            this.gCtrl_DSNV.Size = new System.Drawing.Size(632, 429);
            this.gCtrl_DSNV.TabIndex = 17;
            this.gCtrl_DSNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gView_DSNV});
            // 
            // gView_DSNV
            // 
            this.gView_DSNV.GridControl = this.gCtrl_DSNV;
            this.gView_DSNV.Name = "gView_DSNV";
            this.gView_DSNV.OptionsBehavior.Editable = false;
            this.gView_DSNV.OptionsBehavior.ReadOnly = true;
            this.gView_DSNV.OptionsFind.AlwaysVisible = true;
            // 
            // btThemNV
            // 
            this.btThemNV.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNV.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThemNV.Appearance.Options.UseFont = true;
            this.btThemNV.Appearance.Options.UseForeColor = true;
            this.btThemNV.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btThemNV.Image")));
            this.btThemNV.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btThemNV.Location = new System.Drawing.Point(163, 615);
            this.btThemNV.Name = "btThemNV";
            this.btThemNV.Size = new System.Drawing.Size(110, 62);
            this.btThemNV.TabIndex = 20;
            this.btThemNV.Text = "Thêm NV";
            this.btThemNV.Click += new System.EventHandler(this.btThemNV_Click);
            // 
            // btXoa
            // 
            this.btXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Appearance.Options.UseForeColor = true;
            this.btXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btXoa.Location = new System.Drawing.Point(405, 615);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(110, 62);
            this.btXoa.TabIndex = 18;
            this.btXoa.Text = "Xóa NV";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSuaNV
            // 
            this.btSuaNV.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaNV.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSuaNV.Appearance.Options.UseFont = true;
            this.btSuaNV.Appearance.Options.UseForeColor = true;
            this.btSuaNV.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btSuaNV.Image = ((System.Drawing.Image)(resources.GetObject("btSuaNV.Image")));
            this.btSuaNV.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btSuaNV.Location = new System.Drawing.Point(284, 615);
            this.btSuaNV.Name = "btSuaNV";
            this.btSuaNV.Size = new System.Drawing.Size(110, 62);
            this.btSuaNV.TabIndex = 19;
            this.btSuaNV.Text = "Sửa thông tin NV";
            this.btSuaNV.Click += new System.EventHandler(this.btSuaNV_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(126, 144);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Nhập từ khóa:";
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.Appearance.Options.UseForeColor = true;
            this.btnTim.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(468, 131);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(60, 30);
            this.btnTim.TabIndex = 23;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(210, 140);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(252, 21);
            this.txtTimKiem.TabIndex = 25;
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.Appearance.Options.UseForeColor = true;
            this.btnLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(534, 131);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(60, 30);
            this.btnLoad.TabIndex = 39;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // fmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 691);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btThemNV);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSuaNV);
            this.Controls.Add(this.gCtrl_DSNV);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel1);
            this.Name = "fmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHÂN VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_DSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gCtrl_DSNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gView_DSNV;
        private DevExpress.XtraEditors.SimpleButton btThemNV;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btSuaNV;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
    }
}