namespace DOAN_QLNS
{
    partial class fmTheLoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTheLoaiSach));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gControl_TheLoaiSach = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gView_TheLoaiSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãthểloại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênthểloại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichú = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.btSuaNV = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gControl_TheLoaiSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_TheLoaiSach)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl3.Location = new System.Drawing.Point(203, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(163, 25);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "THỂ LOẠI SÁCH";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 100);
            this.panel1.TabIndex = 46;
            // 
            // gControl_TheLoaiSach
            // 
            this.gControl_TheLoaiSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gControl_TheLoaiSach.DataMember = "Query";
            this.gControl_TheLoaiSach.DataSource = this.sqlDataSource1;
            this.gControl_TheLoaiSach.Location = new System.Drawing.Point(0, 173);
            this.gControl_TheLoaiSach.MainView = this.gView_TheLoaiSach;
            this.gControl_TheLoaiSach.Name = "gControl_TheLoaiSach";
            this.gControl_TheLoaiSach.Size = new System.Drawing.Size(553, 300);
            this.gControl_TheLoaiSach.TabIndex = 48;
            this.gControl_TheLoaiSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gView_TheLoaiSach});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "TheLoaiSach";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select NhomTheLoai.NTL_id as [Mã thể loại], NhomTheLoai.NTL_name as [Tên thể loại" +
    "],\r\n       NhomTheLoai.NTL_note as [Ghi chú]\r\n  from \"dbo\".\"NhomTheLoai\" \"NhomTh" +
    "eLoai\"";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gView_TheLoaiSach
            // 
            this.gView_TheLoaiSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãthểloại,
            this.colTênthểloại,
            this.colGhichú});
            this.gView_TheLoaiSach.GridControl = this.gControl_TheLoaiSach;
            this.gView_TheLoaiSach.Name = "gView_TheLoaiSach";
            this.gView_TheLoaiSach.OptionsBehavior.Editable = false;
            this.gView_TheLoaiSach.OptionsBehavior.ReadOnly = true;
            this.gView_TheLoaiSach.OptionsFind.AlwaysVisible = true;
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
            this.btThemNV.Location = new System.Drawing.Point(156, 479);
            this.btThemNV.Name = "btThemNV";
            this.btThemNV.Size = new System.Drawing.Size(75, 62);
            this.btThemNV.TabIndex = 51;
            this.btThemNV.Text = "Thêm ";
            this.btThemNV.Click += new System.EventHandler(this.btThemNV_Click);
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
            this.btSuaNV.Location = new System.Drawing.Point(242, 479);
            this.btSuaNV.Name = "btSuaNV";
            this.btSuaNV.Size = new System.Drawing.Size(75, 62);
            this.btSuaNV.TabIndex = 50;
            this.btSuaNV.Text = "Sửa ";
            this.btSuaNV.Click += new System.EventHandler(this.btSuaNV_Click);
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
            this.btXoa.Location = new System.Drawing.Point(328, 479);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 62);
            this.btXoa.TabIndex = 49;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.Appearance.Options.UseForeColor = true;
            this.btnLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(449, 137);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(60, 30);
            this.btnLoad.TabIndex = 55;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(125, 146);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(252, 21);
            this.txtTimKiem.TabIndex = 54;
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.Appearance.Options.UseForeColor = true;
            this.btnTim.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(383, 137);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(60, 30);
            this.btnTim.TabIndex = 53;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl11.Location = new System.Drawing.Point(41, 150);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(78, 13);
            this.labelControl11.TabIndex = 52;
            this.labelControl11.Text = "Nhập từ khóa:";
            // 
            // fmTheLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 548);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.btThemNV);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSuaNV);
            this.Controls.Add(this.gControl_TheLoaiSach);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panel1);
            this.Name = "fmTheLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỂ LOẠI SÁCH";
            ((System.ComponentModel.ISupportInitialize)(this.gControl_TheLoaiSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_TheLoaiSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gControl_TheLoaiSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gView_TheLoaiSach;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãthểloại;
        private DevExpress.XtraGrid.Columns.GridColumn colTênthểloại;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichú;
        private DevExpress.XtraEditors.SimpleButton btThemNV;
        private DevExpress.XtraEditors.SimpleButton btSuaNV;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}