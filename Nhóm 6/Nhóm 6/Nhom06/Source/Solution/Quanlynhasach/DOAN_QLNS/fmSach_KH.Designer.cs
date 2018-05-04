namespace DOAN_QLNS
{
    partial class fmSach_KH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSach_KH));
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.label2 = new System.Windows.Forms.Label();
            this.picSach = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlSach = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView_DSSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãsách = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênsách = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThểloại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTácgiả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNămxuấtbản = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiábán = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNộidung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhàxuấtbản = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(235, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 33);
            this.label2.TabIndex = 35;
            this.label2.Text = "HỆ THỐNG SÁCH";
            // 
            // picSach
            // 
            this.picSach.BackColor = System.Drawing.Color.Silver;
            this.picSach.Location = new System.Drawing.Point(10, 179);
            this.picSach.Name = "picSach";
            this.picSach.Size = new System.Drawing.Size(169, 245);
            this.picSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSach.TabIndex = 34;
            this.picSach.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 107);
            this.panel1.TabIndex = 33;
            // 
            // gridControlSach
            // 
            this.gridControlSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSach.DataMember = "Query";
            this.gridControlSach.DataSource = this.sqlDataSource1;
            this.gridControlSach.Location = new System.Drawing.Point(185, 179);
            this.gridControlSach.MainView = this.gridView_DSSach;
            this.gridControlSach.Name = "gridControlSach";
            this.gridControlSach.Size = new System.Drawing.Size(504, 245);
            this.gridControlSach.TabIndex = 36;
            this.gridControlSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DSSach});
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
            // gridView_DSSach
            // 
            this.gridView_DSSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãsách,
            this.colTênsách,
            this.colThểloại,
            this.colTácgiả,
            this.colNămxuấtbản,
            this.colGiábán,
            this.colNộidung,
            this.colNhàxuấtbản});
            this.gridView_DSSach.GridControl = this.gridControlSach;
            this.gridView_DSSach.Name = "gridView_DSSach";
            this.gridView_DSSach.OptionsBehavior.Editable = false;
            this.gridView_DSSach.OptionsBehavior.ReadOnly = true;
            this.gridView_DSSach.OptionsFind.AlwaysVisible = true;
            this.gridView_DSSach.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DSSach_RowClick);
            // 
            // colMãsách
            // 
            this.colMãsách.FieldName = "Mã sách";
            this.colMãsách.Name = "colMãsách";
            this.colMãsách.Visible = true;
            this.colMãsách.VisibleIndex = 0;
            // 
            // colTênsách
            // 
            this.colTênsách.FieldName = "Tên sách";
            this.colTênsách.Name = "colTênsách";
            this.colTênsách.Visible = true;
            this.colTênsách.VisibleIndex = 1;
            // 
            // colThểloại
            // 
            this.colThểloại.FieldName = "Thể loại";
            this.colThểloại.Name = "colThểloại";
            this.colThểloại.Visible = true;
            this.colThểloại.VisibleIndex = 2;
            // 
            // colTácgiả
            // 
            this.colTácgiả.FieldName = "Tác giả";
            this.colTácgiả.Name = "colTácgiả";
            this.colTácgiả.Visible = true;
            this.colTácgiả.VisibleIndex = 3;
            // 
            // colNămxuấtbản
            // 
            this.colNămxuấtbản.FieldName = "Năm xuất bản";
            this.colNămxuấtbản.Name = "colNămxuấtbản";
            this.colNămxuấtbản.Visible = true;
            this.colNămxuấtbản.VisibleIndex = 4;
            // 
            // colGiábán
            // 
            this.colGiábán.FieldName = "Giá bán";
            this.colGiábán.Name = "colGiábán";
            this.colGiábán.Visible = true;
            this.colGiábán.VisibleIndex = 5;
            // 
            // colNộidung
            // 
            this.colNộidung.FieldName = "Nội dung";
            this.colNộidung.Name = "colNộidung";
            this.colNộidung.Visible = true;
            this.colNộidung.VisibleIndex = 6;
            // 
            // colNhàxuấtbản
            // 
            this.colNhàxuấtbản.FieldName = "Nhà xuất bản";
            this.colNhàxuấtbản.Name = "colNhàxuấtbản";
            this.colNhàxuấtbản.Visible = true;
            this.colNhàxuấtbản.VisibleIndex = 7;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(269, 152);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(252, 21);
            this.txtTimKiem.TabIndex = 39;
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.Appearance.Options.UseForeColor = true;
            this.btnTim.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(527, 140);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(60, 33);
            this.btnTim.TabIndex = 38;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(185, 156);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "Nhập từ khóa:";
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.Appearance.Options.UseForeColor = true;
            this.btnLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(593, 140);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(70, 33);
            this.btnLoad.TabIndex = 38;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // fmSach_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 436);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridControlSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picSach);
            this.Controls.Add(this.panel1);
            this.Name = "fmSach_KH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRA CỨU SÁCH";
            this.Load += new System.EventHandler(this.fmSach_KH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picSach;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlSach;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DSSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMãsách;
        private DevExpress.XtraGrid.Columns.GridColumn colTênsách;
        private DevExpress.XtraGrid.Columns.GridColumn colThểloại;
        private DevExpress.XtraGrid.Columns.GridColumn colTácgiả;
        private DevExpress.XtraGrid.Columns.GridColumn colNămxuấtbản;
        private DevExpress.XtraGrid.Columns.GridColumn colGiábán;
        private DevExpress.XtraGrid.Columns.GridColumn colNộidung;
        private DevExpress.XtraGrid.Columns.GridColumn colNhàxuấtbản;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
    }
}