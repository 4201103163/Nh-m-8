namespace DOAN_QLNS
{
    partial class fmTacGia_KH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTacGia_KH));
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.label2 = new System.Windows.Forms.Label();
            this.picTG = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlTG = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãtácgiả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTêntácgiả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichú = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(279, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 33);
            this.label2.TabIndex = 32;
            this.label2.Text = "TÁC GIẢ";
            // 
            // picTG
            // 
            this.picTG.BackColor = System.Drawing.Color.Silver;
            this.picTG.Location = new System.Drawing.Point(10, 193);
            this.picTG.Name = "picTG";
            this.picTG.Size = new System.Drawing.Size(169, 202);
            this.picTG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTG.TabIndex = 31;
            this.picTG.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 111);
            this.panel1.TabIndex = 30;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(242, 156);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(252, 21);
            this.txtTimKiem.TabIndex = 43;
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.Appearance.Options.UseForeColor = true;
            this.btnLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(566, 144);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(70, 33);
            this.btnLoad.TabIndex = 41;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.Appearance.Options.UseForeColor = true;
            this.btnTim.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(500, 144);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(60, 33);
            this.btnTim.TabIndex = 42;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(158, 160);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Nhập từ khóa:";
            // 
            // gridControlTG
            // 
            this.gridControlTG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlTG.DataMember = "Query";
            this.gridControlTG.DataSource = this.sqlDataSource1;
            this.gridControlTG.Location = new System.Drawing.Point(186, 193);
            this.gridControlTG.MainView = this.gridView1;
            this.gridControlTG.Name = "gridControlTG";
            this.gridControlTG.Size = new System.Drawing.Size(462, 401);
            this.gridControlTG.TabIndex = 44;
            this.gridControlTG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            customSqlQuery1.Sql = "select NhomTacGia.NTG_id as [Mã tác giả], NhomTacGia.NTG_name as [Tên tác giả],\r\n" +
    "       NhomTacGia.NTG_note as [Ghi chú]\r\n  from \"dbo\".\"NhomTacGia\" \"NhomTacGia\"";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãtácgiả,
            this.colTêntácgiả,
            this.colGhichú});
            this.gridView1.GridControl = this.gridControlTG;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
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
            // fmTacGia_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 606);
            this.Controls.Add(this.gridControlTG);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picTG);
            this.Controls.Add(this.panel1);
            this.Name = "fmTacGia_KH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÁC GIẢ";
            this.Load += new System.EventHandler(this.fmTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picTG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControlTG;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãtácgiả;
        private DevExpress.XtraGrid.Columns.GridColumn colTêntácgiả;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichú;
    }
}