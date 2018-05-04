namespace DOAN_QLNS
{
    partial class fmSach_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSach_User));
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.cbNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbTacGia = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtND = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtNamXuatBan = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gCtrlDSSach = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gViewDSSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãsách = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênsách = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThểloại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTácgiả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNămxuấtbản = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiánhập = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiábán = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSốlượng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNộidung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhàxuấtbản = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrlDSSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewDSSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 100);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl13);
            this.groupBox1.Controls.Add(this.labelControl12);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btUpdate);
            this.groupBox1.Controls.Add(this.cbNhaXuatBan);
            this.groupBox1.Controls.Add(this.cbTheLoai);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.cbTacGia);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.txtND);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.labelControl14);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.txtNamXuatBan);
            this.groupBox1.Controls.Add(this.txtTheLoai);
            this.groupBox1.Controls.Add(this.txtNhaXB);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Sách";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(310, 91);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(124, 18);
            this.labelControl13.TabIndex = 11;
            this.labelControl13.Text = "Mã Nhà xuất bản";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(12, 91);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(76, 18);
            this.labelControl12.TabIndex = 10;
            this.labelControl12.Text = "Mã tác giả";
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(882, 59);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 35);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(882, 101);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 35);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Appearance.Options.UseForeColor = true;
            this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(882, 143);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 35);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Hủy";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btUpdate.Appearance.Options.UseFont = true;
            this.btUpdate.Appearance.Options.UseForeColor = true;
            this.btUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btUpdate.Image")));
            this.btUpdate.Location = new System.Drawing.Point(882, 17);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(93, 35);
            this.btUpdate.TabIndex = 9;
            this.btUpdate.Text = "Cập nhật";
            this.btUpdate.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbNhaXuatBan
            // 
            this.cbNhaXuatBan.FormattingEnabled = true;
            this.cbNhaXuatBan.Location = new System.Drawing.Point(447, 87);
            this.cbNhaXuatBan.Name = "cbNhaXuatBan";
            this.cbNhaXuatBan.Size = new System.Drawing.Size(167, 21);
            this.cbNhaXuatBan.TabIndex = 6;
            this.cbNhaXuatBan.SelectedIndexChanged += new System.EventHandler(this.cbNhaXuatBan_SelectedIndexChanged);
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(447, 18);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(167, 21);
            this.cbTheLoai.TabIndex = 4;
            this.cbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbTheLoai_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(659, 21);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 18);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Số lượng";
            // 
            // cbTacGia
            // 
            this.cbTacGia.FormattingEnabled = true;
            this.cbTacGia.Location = new System.Drawing.Point(99, 87);
            this.cbTacGia.Name = "cbTacGia";
            this.cbTacGia.Size = new System.Drawing.Size(188, 21);
            this.cbTacGia.TabIndex = 2;
            this.cbTacGia.SelectedIndexChanged += new System.EventHandler(this.cbTacGia_SelectedIndexChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(730, 17);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(146, 21);
            this.txtSoLuong.TabIndex = 8;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(730, 84);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(146, 21);
            this.txtGiaBan.TabIndex = 10;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(730, 51);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(146, 21);
            this.txtGiaNhap.TabIndex = 9;
            // 
            // txtND
            // 
            this.txtND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtND.Location = new System.Drawing.Point(99, 161);
            this.txtND.Multiline = true;
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(747, 121);
            this.txtND.TabIndex = 1;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Enabled = false;
            this.txtTacGia.Location = new System.Drawing.Point(99, 123);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(188, 21);
            this.txtTacGia.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(99, 53);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(188, 21);
            this.txtTen.TabIndex = 1;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(347, 54);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(87, 18);
            this.labelControl14.TabIndex = 0;
            this.labelControl14.Text = "Tên thể loại";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(305, 126);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(129, 18);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Tên Nhà xuất bản";
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Location = new System.Drawing.Point(730, 123);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Size = new System.Drawing.Size(146, 21);
            this.txtNamXuatBan.TabIndex = 11;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Enabled = false;
            this.txtTheLoai.Location = new System.Drawing.Point(447, 51);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(167, 21);
            this.txtTheLoai.TabIndex = 5;
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.Enabled = false;
            this.txtNhaXB.Location = new System.Drawing.Point(447, 123);
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(167, 21);
            this.txtNhaXB.TabIndex = 7;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(99, 18);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(188, 21);
            this.txtMa.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(668, 91);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 18);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Giá bán";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(659, 56);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 18);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Giá nhập";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(622, 126);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(102, 18);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Năm xuất bản";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(7, 126);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Tên tác giả";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(6, 160);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(66, 18);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Nội dung";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(375, 21);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Thể loại";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(23, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên sách";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(28, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã sách";
            // 
            // gCtrlDSSach
            // 
            this.gCtrlDSSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCtrlDSSach.DataMember = "Query";
            this.gCtrlDSSach.DataSource = this.sqlDataSource1;
            this.gCtrlDSSach.Location = new System.Drawing.Point(0, 456);
            this.gCtrlDSSach.MainView = this.gViewDSSach;
            this.gCtrlDSSach.Name = "gCtrlDSSach";
            this.gCtrlDSSach.Size = new System.Drawing.Size(983, 277);
            this.gCtrlDSSach.TabIndex = 2;
            this.gCtrlDSSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewDSSach});
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
            // gViewDSSach
            // 
            this.gViewDSSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãsách,
            this.colTênsách,
            this.colThểloại,
            this.colTácgiả,
            this.colNămxuấtbản,
            this.colGiánhập,
            this.colGiábán,
            this.colSốlượng,
            this.colNộidung,
            this.colNhàxuấtbản});
            this.gViewDSSach.GridControl = this.gCtrlDSSach;
            this.gViewDSSach.Name = "gViewDSSach";
            this.gViewDSSach.OptionsBehavior.Editable = false;
            this.gViewDSSach.OptionsBehavior.ReadOnly = true;
            this.gViewDSSach.OptionsFind.AlwaysVisible = true;
            this.gViewDSSach.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gViewDSSach_RowClick);
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
            // colGiánhập
            // 
            this.colGiánhập.FieldName = "Giá nhập";
            this.colGiánhập.Name = "colGiánhập";
            this.colGiánhập.Visible = true;
            this.colGiánhập.VisibleIndex = 5;
            // 
            // colGiábán
            // 
            this.colGiábán.FieldName = "Giá bán";
            this.colGiábán.Name = "colGiábán";
            this.colGiábán.Visible = true;
            this.colGiábán.VisibleIndex = 6;
            // 
            // colSốlượng
            // 
            this.colSốlượng.FieldName = "Số lượng";
            this.colSốlượng.Name = "colSốlượng";
            this.colSốlượng.Visible = true;
            this.colSốlượng.VisibleIndex = 7;
            // 
            // colNộidung
            // 
            this.colNộidung.FieldName = "Nội dung";
            this.colNộidung.Name = "colNộidung";
            this.colNộidung.Visible = true;
            this.colNộidung.VisibleIndex = 8;
            // 
            // colNhàxuấtbản
            // 
            this.colNhàxuấtbản.FieldName = "Nhà xuất bản";
            this.colNhàxuấtbản.Name = "colNhàxuấtbản";
            this.colNhàxuấtbản.Visible = true;
            this.colNhàxuấtbản.VisibleIndex = 9;
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.Appearance.Options.UseForeColor = true;
            this.btnLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(660, 412);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(60, 30);
            this.btnLoad.TabIndex = 43;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(336, 421);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(252, 21);
            this.txtTimKiem.TabIndex = 42;
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.Appearance.Options.UseForeColor = true;
            this.btnTim.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(594, 412);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(60, 30);
            this.btnTim.TabIndex = 41;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl11.Location = new System.Drawing.Point(252, 425);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(78, 13);
            this.labelControl11.TabIndex = 40;
            this.labelControl11.Text = "Nhập từ khóa:";
            // 
            // fmSach_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 733);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.gCtrlDSSach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmSach_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SÁCH";
            this.Load += new System.EventHandler(this.fmSach_User_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrlDSSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewDSSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbNhaXuatBan;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.ComboBox cbTacGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.TextBox txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.TextBox txtMa;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gCtrlDSSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewDSSach;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btUpdate;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãsách;
        private DevExpress.XtraGrid.Columns.GridColumn colTênsách;
        private DevExpress.XtraGrid.Columns.GridColumn colThểloại;
        private DevExpress.XtraGrid.Columns.GridColumn colTácgiả;
        private DevExpress.XtraGrid.Columns.GridColumn colNămxuấtbản;
        private DevExpress.XtraGrid.Columns.GridColumn colGiánhập;
        private DevExpress.XtraGrid.Columns.GridColumn colGiábán;
        private DevExpress.XtraGrid.Columns.GridColumn colSốlượng;
        private DevExpress.XtraGrid.Columns.GridColumn colNộidung;
        private DevExpress.XtraGrid.Columns.GridColumn colNhàxuấtbản;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtNamXuatBan;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.TextBox txtTheLoai;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
    }
}