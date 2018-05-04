namespace DOAN_QLNS
{
    partial class fmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmNhaCungCap));
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btSuaNV = new DevExpress.XtraEditors.SimpleButton();
            this.gCtrol_NCC = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gView_NCC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSốđiệnthoại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colĐịachỉ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichú = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrol_NCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_NCC)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl3.Location = new System.Drawing.Point(198, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(162, 25);
            this.labelControl3.TabIndex = 49;
            this.labelControl3.Text = "NHÀ CUNG CẤP";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 100);
            this.panel1.TabIndex = 48;
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
            this.btThemNV.Location = new System.Drawing.Point(139, 496);
            this.btThemNV.Name = "btThemNV";
            this.btThemNV.Size = new System.Drawing.Size(75, 62);
            this.btThemNV.TabIndex = 54;
            this.btThemNV.Text = "Thêm ";
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
            this.btXoa.Location = new System.Drawing.Point(311, 496);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 62);
            this.btXoa.TabIndex = 52;
            this.btXoa.Text = "Xóa";
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
            this.btSuaNV.Location = new System.Drawing.Point(225, 496);
            this.btSuaNV.Name = "btSuaNV";
            this.btSuaNV.Size = new System.Drawing.Size(75, 62);
            this.btSuaNV.TabIndex = 53;
            this.btSuaNV.Text = "Sửa ";
            this.btSuaNV.Click += new System.EventHandler(this.btSuaNV_Click);
            // 
            // gCtrol_NCC
            // 
            this.gCtrol_NCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCtrol_NCC.DataMember = "Query";
            this.gCtrol_NCC.DataSource = this.sqlDataSource1;
            this.gCtrol_NCC.Location = new System.Drawing.Point(0, 167);
            this.gCtrol_NCC.MainView = this.gView_NCC;
            this.gCtrol_NCC.Name = "gCtrol_NCC";
            this.gCtrol_NCC.Size = new System.Drawing.Size(553, 323);
            this.gCtrol_NCC.TabIndex = 55;
            this.gCtrol_NCC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gView_NCC});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "._QLNS_Connection";
            msSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows;
            msSqlConnectionParameters1.DatabaseName = "QLNS";
            msSqlConnectionParameters1.ServerName = ".";
            this.sqlDataSource1.ConnectionParameters = msSqlConnectionParameters1;
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gView_NCC
            // 
            this.gView_NCC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãNCC,
            this.colTênNCC,
            this.colSốđiệnthoại,
            this.colĐịachỉ,
            this.colGhichú});
            this.gView_NCC.GridControl = this.gCtrol_NCC;
            this.gView_NCC.Name = "gView_NCC";
            this.gView_NCC.OptionsBehavior.Editable = false;
            this.gView_NCC.OptionsBehavior.ReadOnly = true;
            // 
            // colMãNCC
            // 
            this.colMãNCC.FieldName = "Mã NCC";
            this.colMãNCC.Name = "colMãNCC";
            this.colMãNCC.Visible = true;
            this.colMãNCC.VisibleIndex = 0;
            // 
            // colTênNCC
            // 
            this.colTênNCC.FieldName = "Tên NCC";
            this.colTênNCC.Name = "colTênNCC";
            this.colTênNCC.Visible = true;
            this.colTênNCC.VisibleIndex = 1;
            // 
            // colSốđiệnthoại
            // 
            this.colSốđiệnthoại.FieldName = "Số điện thoại";
            this.colSốđiệnthoại.Name = "colSốđiệnthoại";
            this.colSốđiệnthoại.Visible = true;
            this.colSốđiệnthoại.VisibleIndex = 2;
            // 
            // colĐịachỉ
            // 
            this.colĐịachỉ.FieldName = "Địa chỉ";
            this.colĐịachỉ.Name = "colĐịachỉ";
            this.colĐịachỉ.Visible = true;
            this.colĐịachỉ.VisibleIndex = 3;
            // 
            // colGhichú
            // 
            this.colGhichú.FieldName = "Ghi chú";
            this.colGhichú.Name = "colGhichú";
            this.colGhichú.Visible = true;
            this.colGhichú.VisibleIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.Appearance.Options.UseForeColor = true;
            this.btnLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(436, 131);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(60, 30);
            this.btnLoad.TabIndex = 68;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(112, 140);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(252, 21);
            this.txtTimKiem.TabIndex = 67;
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.Appearance.Options.UseForeColor = true;
            this.btnTim.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(370, 131);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(60, 30);
            this.btnTim.TabIndex = 66;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(28, 144);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 65;
            this.labelControl2.Text = "Nhập từ khóa:";
            // 
            // fmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 570);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gCtrol_NCC);
            this.Controls.Add(this.btThemNV);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSuaNV);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panel1);
            this.Name = "fmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHÀ CUNG CẤP";
            ((System.ComponentModel.ISupportInitialize)(this.gCtrol_NCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_NCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btThemNV;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btSuaNV;
        private DevExpress.XtraGrid.GridControl gCtrol_NCC;
        private DevExpress.XtraGrid.Views.Grid.GridView gView_NCC;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTênNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colSốđiệnthoại;
        private DevExpress.XtraGrid.Columns.GridColumn colĐịachỉ;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichú;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}