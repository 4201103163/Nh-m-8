namespace DOAN_QLNS
{
    partial class fmNhaXuatBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmNhaXuatBan));
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl_NXB = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView_NXB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãNhàxuấtbản = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênnhàxuấtbản = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSốđiệnthoại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colĐịachỉ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichú = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btSuaNV = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_NXB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.Appearance.Options.UseForeColor = true;
            this.btnLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(524, 128);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(60, 30);
            this.btnLoad.TabIndex = 45;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(200, 137);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(252, 21);
            this.txtTimKiem.TabIndex = 44;
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.Appearance.Options.UseForeColor = true;
            this.btnTim.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(458, 128);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(60, 30);
            this.btnTim.TabIndex = 43;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(116, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 42;
            this.labelControl2.Text = "Nhập từ khóa:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl1.Location = new System.Drawing.Point(249, 106);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(159, 25);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "NHÀ XUẤT BẢN";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 100);
            this.panel1.TabIndex = 40;
            // 
            // gridControl_NXB
            // 
            this.gridControl_NXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_NXB.DataMember = "Query";
            this.gridControl_NXB.DataSource = this.sqlDataSource1;
            this.gridControl_NXB.Location = new System.Drawing.Point(0, 167);
            this.gridControl_NXB.MainView = this.gridView_NXB;
            this.gridControl_NXB.Name = "gridControl_NXB";
            this.gridControl_NXB.Size = new System.Drawing.Size(632, 431);
            this.gridControl_NXB.TabIndex = 46;
            this.gridControl_NXB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_NXB});
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
            // gridView_NXB
            // 
            this.gridView_NXB.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãNhàxuấtbản,
            this.colTênnhàxuấtbản,
            this.colSốđiệnthoại,
            this.colĐịachỉ,
            this.colGhichú});
            this.gridView_NXB.GridControl = this.gridControl_NXB;
            this.gridView_NXB.Name = "gridView_NXB";
            this.gridView_NXB.OptionsBehavior.Editable = false;
            this.gridView_NXB.OptionsBehavior.ReadOnly = true;
            this.gridView_NXB.OptionsFind.AlwaysVisible = true;
            // 
            // colMãNhàxuấtbản
            // 
            this.colMãNhàxuấtbản.FieldName = "Mã Nhà xuất bản";
            this.colMãNhàxuấtbản.Name = "colMãNhàxuấtbản";
            this.colMãNhàxuấtbản.Visible = true;
            this.colMãNhàxuấtbản.VisibleIndex = 0;
            // 
            // colTênnhàxuấtbản
            // 
            this.colTênnhàxuấtbản.FieldName = "Tên nhà xuất bản";
            this.colTênnhàxuấtbản.Name = "colTênnhàxuấtbản";
            this.colTênnhàxuấtbản.Visible = true;
            this.colTênnhàxuấtbản.VisibleIndex = 1;
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
            // btThemNV
            // 
            this.btThemNV.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNV.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThemNV.Appearance.Options.UseFont = true;
            this.btThemNV.Appearance.Options.UseForeColor = true;
            this.btThemNV.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btThemNV.Image")));
            this.btThemNV.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btThemNV.Location = new System.Drawing.Point(166, 604);
            this.btThemNV.Name = "btThemNV";
            this.btThemNV.Size = new System.Drawing.Size(110, 62);
            this.btThemNV.TabIndex = 49;
            this.btThemNV.Text = "Thêm";
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
            this.btXoa.Location = new System.Drawing.Point(408, 604);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(110, 62);
            this.btXoa.TabIndex = 47;
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
            this.btSuaNV.Location = new System.Drawing.Point(287, 604);
            this.btSuaNV.Name = "btSuaNV";
            this.btSuaNV.Size = new System.Drawing.Size(110, 62);
            this.btSuaNV.TabIndex = 48;
            this.btSuaNV.Text = "Sửa";
            this.btSuaNV.Click += new System.EventHandler(this.btSuaNV_Click);
            // 
            // fmNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 681);
            this.Controls.Add(this.btThemNV);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSuaNV);
            this.Controls.Add(this.gridControl_NXB);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel1);
            this.Name = "fmNhaXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHÀ XUẤT BẢN";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_NXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl_NXB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_NXB;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãNhàxuấtbản;
        private DevExpress.XtraGrid.Columns.GridColumn colTênnhàxuấtbản;
        private DevExpress.XtraGrid.Columns.GridColumn colSốđiệnthoại;
        private DevExpress.XtraGrid.Columns.GridColumn colĐịachỉ;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichú;
        private DevExpress.XtraEditors.SimpleButton btThemNV;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btSuaNV;
    }
}