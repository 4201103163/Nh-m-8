namespace DOAN_QLNS
{
    partial class fmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmKhachHang));
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gView_TheLoaiSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãthểloại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênthểloại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichú = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.gControl_DSKH = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gView_DSKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãkháchhàng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênkháchhàng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSốđiệnthoại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSốtiềnnợ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichú1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btSuaKH = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gView_TheLoaiSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl_DSKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSKH)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl3.Location = new System.Drawing.Point(213, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(143, 25);
            this.labelControl3.TabIndex = 54;
            this.labelControl3.Text = "KHÁCH HÀNG";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 100);
            this.panel1.TabIndex = 53;
            // 
            // gView_TheLoaiSach
            // 
            this.gView_TheLoaiSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãthểloại,
            this.colTênthểloại,
            this.colGhichú});
            this.gView_TheLoaiSach.Name = "gView_TheLoaiSach";
            // 
            // colMãthểloại
            // 
            this.colMãthểloại.FieldName = "Mã thể loại";
            this.colMãthểloại.Name = "colMãthểloại";
            this.colMãthểloại.Visible = true;
            this.colMãthểloại.VisibleIndex = 0;
            // 
            // colTênthểloại
            // 
            this.colTênthểloại.FieldName = "Tên thể loại";
            this.colTênthểloại.Name = "colTênthểloại";
            this.colTênthểloại.Visible = true;
            this.colTênthểloại.VisibleIndex = 1;
            // 
            // colGhichú
            // 
            this.colGhichú.FieldName = "Ghi chú";
            this.colGhichú.Name = "colGhichú";
            this.colGhichú.Visible = true;
            this.colGhichú.VisibleIndex = 2;
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
            this.btThemNV.Location = new System.Drawing.Point(200, 529);
            this.btThemNV.Name = "btThemNV";
            this.btThemNV.Size = new System.Drawing.Size(75, 62);
            this.btThemNV.TabIndex = 57;
            this.btThemNV.Text = "Thêm ";
            this.btThemNV.Click += new System.EventHandler(this.btThemNV_Click);
            // 
            // gControl_DSKH
            // 
            this.gControl_DSKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gControl_DSKH.DataMember = "Query";
            this.gControl_DSKH.DataSource = this.sqlDataSource1;
            this.gControl_DSKH.Location = new System.Drawing.Point(0, 171);
            this.gControl_DSKH.MainView = this.gView_DSKH;
            this.gControl_DSKH.Name = "gControl_DSKH";
            this.gControl_DSKH.Size = new System.Drawing.Size(553, 346);
            this.gControl_DSKH.TabIndex = 59;
            this.gControl_DSKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gView_DSKH});
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
            // gView_DSKH
            // 
            this.gView_DSKH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãkháchhàng,
            this.colTênkháchhàng,
            this.colSốđiệnthoại,
            this.colEmail,
            this.colSốtiềnnợ,
            this.colGhichú1});
            this.gView_DSKH.GridControl = this.gControl_DSKH;
            this.gView_DSKH.Name = "gView_DSKH";
            this.gView_DSKH.OptionsBehavior.Editable = false;
            this.gView_DSKH.OptionsBehavior.ReadOnly = true;
            this.gView_DSKH.OptionsFind.AlwaysVisible = true;
            // 
            // colMãkháchhàng
            // 
            this.colMãkháchhàng.FieldName = "Mã khách hàng";
            this.colMãkháchhàng.Name = "colMãkháchhàng";
            this.colMãkháchhàng.Visible = true;
            this.colMãkháchhàng.VisibleIndex = 0;
            // 
            // colTênkháchhàng
            // 
            this.colTênkháchhàng.FieldName = "Tên khách hàng";
            this.colTênkháchhàng.Name = "colTênkháchhàng";
            this.colTênkháchhàng.Visible = true;
            this.colTênkháchhàng.VisibleIndex = 1;
            // 
            // colSốđiệnthoại
            // 
            this.colSốđiệnthoại.FieldName = "Số điện thoại";
            this.colSốđiệnthoại.Name = "colSốđiệnthoại";
            this.colSốđiệnthoại.Visible = true;
            this.colSốđiệnthoại.VisibleIndex = 2;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // colSốtiềnnợ
            // 
            this.colSốtiềnnợ.FieldName = "Số tiền nợ";
            this.colSốtiềnnợ.Name = "colSốtiềnnợ";
            this.colSốtiềnnợ.Visible = true;
            this.colSốtiềnnợ.VisibleIndex = 4;
            // 
            // colGhichú1
            // 
            this.colGhichú1.FieldName = "Ghi chú";
            this.colGhichú1.Name = "colGhichú1";
            this.colGhichú1.Visible = true;
            this.colGhichú1.VisibleIndex = 5;
            // 
            // btSuaKH
            // 
            this.btSuaKH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaKH.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSuaKH.Appearance.Options.UseFont = true;
            this.btSuaKH.Appearance.Options.UseForeColor = true;
            this.btSuaKH.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btSuaKH.Image = ((System.Drawing.Image)(resources.GetObject("btSuaKH.Image")));
            this.btSuaKH.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btSuaKH.Location = new System.Drawing.Point(281, 529);
            this.btSuaKH.Name = "btSuaKH";
            this.btSuaKH.Size = new System.Drawing.Size(75, 62);
            this.btSuaKH.TabIndex = 60;
            this.btSuaKH.Text = "Sửa ";
            this.btSuaKH.Click += new System.EventHandler(this.btSuaKH_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.Appearance.Options.UseForeColor = true;
            this.btnLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(433, 135);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(60, 30);
            this.btnLoad.TabIndex = 64;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(109, 144);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(252, 21);
            this.txtTimKiem.TabIndex = 63;
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.Appearance.Options.UseForeColor = true;
            this.btnTim.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(367, 135);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(60, 30);
            this.btnTim.TabIndex = 62;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(25, 148);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 61;
            this.labelControl2.Text = "Nhập từ khóa:";
            // 
            // fmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 603);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btSuaKH);
            this.Controls.Add(this.gControl_DSKH);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btThemNV);
            this.Name = "fmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÁCH HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.gView_TheLoaiSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl_DSKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gView_TheLoaiSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMãthểloại;
        private DevExpress.XtraGrid.Columns.GridColumn colTênthểloại;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichú;
        private DevExpress.XtraEditors.SimpleButton btThemNV;
        private DevExpress.XtraGrid.GridControl gControl_DSKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gView_DSKH;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãkháchhàng;
        private DevExpress.XtraGrid.Columns.GridColumn colTênkháchhàng;
        private DevExpress.XtraGrid.Columns.GridColumn colSốđiệnthoại;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSốtiềnnợ;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichú1;
        private DevExpress.XtraEditors.SimpleButton btSuaKH;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}