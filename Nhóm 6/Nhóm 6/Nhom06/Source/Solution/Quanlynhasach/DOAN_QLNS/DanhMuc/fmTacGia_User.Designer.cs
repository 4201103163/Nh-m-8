namespace DOAN_QLNS
{
    partial class fmTacGia_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTacGia_User));
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btSuaNV = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_TG = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView_TG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãtácgiả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTêntácgiả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichú = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_TG)).BeginInit();
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
            this.btnLoad.Location = new System.Drawing.Point(518, 135);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(60, 30);
            this.btnLoad.TabIndex = 45;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(194, 144);
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
            this.btnTim.Location = new System.Drawing.Point(452, 135);
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
            this.labelControl2.Location = new System.Drawing.Point(110, 148);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 42;
            this.labelControl2.Text = "Nhập từ khóa:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl1.Location = new System.Drawing.Point(194, 106);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(218, 25);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "DANH SÁCH TÁC GIẢ";
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
            // btThemNV
            // 
            this.btThemNV.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNV.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThemNV.Appearance.Options.UseFont = true;
            this.btThemNV.Appearance.Options.UseForeColor = true;
            this.btThemNV.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btThemNV.Image")));
            this.btThemNV.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btThemNV.Location = new System.Drawing.Point(199, 617);
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
            this.btXoa.Location = new System.Drawing.Point(371, 617);
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
            this.btSuaNV.Location = new System.Drawing.Point(285, 617);
            this.btSuaNV.Name = "btSuaNV";
            this.btSuaNV.Size = new System.Drawing.Size(75, 62);
            this.btSuaNV.TabIndex = 53;
            this.btSuaNV.Text = "Sửa ";
            this.btSuaNV.Click += new System.EventHandler(this.btSuaNV_Click);
            // 
            // gridControl_TG
            // 
            this.gridControl_TG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_TG.DataMember = "Query";
            this.gridControl_TG.DataSource = this.sqlDataSource1;
            this.gridControl_TG.Location = new System.Drawing.Point(0, 171);
            this.gridControl_TG.MainView = this.gridView_TG;
            this.gridControl_TG.Name = "gridControl_TG";
            this.gridControl_TG.Size = new System.Drawing.Size(632, 440);
            this.gridControl_TG.TabIndex = 55;
            this.gridControl_TG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_TG});
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
            customSqlQuery1.Sql = "select NhomTacGia.NTG_id AS [Mã tác giả], NhomTacGia.NTG_name AS [Tên tác giả],\r\n" +
    "       NhomTacGia.NTG_note AS [Ghi chú]\r\n  from \"dbo\".\"NhomTacGia\" \"NhomTacGia\"";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView_TG
            // 
            this.gridView_TG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãtácgiả,
            this.colTêntácgiả,
            this.colGhichú});
            this.gridView_TG.GridControl = this.gridControl_TG;
            this.gridView_TG.Name = "gridView_TG";
            this.gridView_TG.OptionsBehavior.Editable = false;
            this.gridView_TG.OptionsBehavior.ReadOnly = true;
            this.gridView_TG.OptionsFind.AlwaysVisible = true;
            // 
            // colMãtácgiả
            // 
            this.colMãtácgiả.FieldName = "Mã tác giả";
            this.colMãtácgiả.Name = "colMãtácgiả";
            this.colMãtácgiả.Visible = true;
            this.colMãtácgiả.VisibleIndex = 0;
            // 
            // colTêntácgiả
            // 
            this.colTêntácgiả.FieldName = "Tên tác giả";
            this.colTêntácgiả.Name = "colTêntácgiả";
            this.colTêntácgiả.Visible = true;
            this.colTêntácgiả.VisibleIndex = 1;
            // 
            // colGhichú
            // 
            this.colGhichú.FieldName = "Ghi chú";
            this.colGhichú.Name = "colGhichú";
            this.colGhichú.Visible = true;
            this.colGhichú.VisibleIndex = 2;
            // 
            // fmTacGia_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 691);
            this.Controls.Add(this.gridControl_TG);
            this.Controls.Add(this.btThemNV);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSuaNV);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel1);
            this.Name = "fmTacGia_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÁC GIẢ";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_TG)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btThemNV;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btSuaNV;
        private DevExpress.XtraGrid.GridControl gridControl_TG;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_TG;
        private DevExpress.XtraGrid.Columns.GridColumn colMãtácgiả;
        private DevExpress.XtraGrid.Columns.GridColumn colTêntácgiả;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichú;
    }
}