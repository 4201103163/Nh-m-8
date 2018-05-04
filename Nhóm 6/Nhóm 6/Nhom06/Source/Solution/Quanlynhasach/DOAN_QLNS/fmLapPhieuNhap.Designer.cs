namespace DOAN_QLNS
{
    partial class fmLapPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLapPhieuNhap));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPNS = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btEditTen = new DevExpress.XtraEditors.ButtonEdit();
            this.btEditMa = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSLT = new DevExpress.XtraEditors.TextEdit();
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.txtSLN = new DevExpress.XtraEditors.TextEdit();
            this.txtTG = new DevExpress.XtraEditors.TextEdit();
            this.txtTL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaPhieu = new DevExpress.XtraEditors.TextEdit();
            this.dati = new System.Windows.Forms.DateTimePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btReloadDSPN = new DevExpress.XtraEditors.SimpleButton();
            this.gCtrl_DSPN = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gView_DSPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãphiếunhập = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãsách = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênsách = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThểloại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTácgiả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSốlượngnhập = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnKetthuc = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTonTruocNhap = new DevExpress.XtraEditors.LabelControl();
            this.lblNhaptt = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btEditTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEditMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_DSPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSPN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btXoa
            // 
            this.btXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btXoa.Enabled = false;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(427, 505);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(107, 37);
            this.btXoa.TabIndex = 18;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Appearance.Options.UseFont = true;
            this.btSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btSua.Enabled = false;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.Location = new System.Drawing.Point(540, 506);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(105, 37);
            this.btSua.TabIndex = 19;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 103);
            this.panel1.TabIndex = 14;
            // 
            // lblPNS
            // 
            this.lblPNS.AutoSize = true;
            this.lblPNS.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNS.ForeColor = System.Drawing.Color.Red;
            this.lblPNS.Location = new System.Drawing.Point(509, 112);
            this.lblPNS.Name = "lblPNS";
            this.lblPNS.Size = new System.Drawing.Size(247, 29);
            this.lblPNS.TabIndex = 13;
            this.lblPNS.Text = " PHIẾU NHẬP SÁCH";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btEditTen);
            this.groupControl1.Controls.Add(this.btEditMa);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtSLT);
            this.groupControl1.Controls.Add(this.txtGia);
            this.groupControl1.Controls.Add(this.txtSLN);
            this.groupControl1.Controls.Add(this.txtTG);
            this.groupControl1.Controls.Add(this.txtTL);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(18, 192);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(366, 305);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "Thông tin Nhập";
            // 
            // btEditTen
            // 
            this.btEditTen.Location = new System.Drawing.Point(129, 68);
            this.btEditTen.Name = "btEditTen";
            this.btEditTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditTen.Properties.Appearance.Options.UseFont = true;
            this.btEditTen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.btEditTen.Size = new System.Drawing.Size(221, 26);
            this.btEditTen.TabIndex = 2;
            this.btEditTen.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btEditTen_ButtonClick);
            // 
            // btEditMa
            // 
            this.btEditMa.Location = new System.Drawing.Point(129, 33);
            this.btEditMa.Name = "btEditMa";
            this.btEditMa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditMa.Properties.Appearance.Options.UseFont = true;
            this.btEditMa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.Default, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btEditMa.Size = new System.Drawing.Size(221, 26);
            this.btEditMa.TabIndex = 2;
            this.btEditMa.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btEditMa_ButtonPressed);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(15, 211);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(92, 19);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Số lượng tồn";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(15, 176);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 19);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Giá";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(15, 246);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(104, 19);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Số lượng nhập";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(15, 141);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Tác giả";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(15, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Thể loại";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(15, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên sách";
            // 
            // txtSLT
            // 
            this.txtSLT.Location = new System.Drawing.Point(129, 208);
            this.txtSLT.Name = "txtSLT";
            this.txtSLT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLT.Properties.Appearance.Options.UseFont = true;
            this.txtSLT.Size = new System.Drawing.Size(220, 26);
            this.txtSLT.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(129, 173);
            this.txtGia.Name = "txtGia";
            this.txtGia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Properties.Appearance.Options.UseFont = true;
            this.txtGia.Size = new System.Drawing.Size(221, 26);
            this.txtGia.TabIndex = 1;
            // 
            // txtSLN
            // 
            this.txtSLN.Location = new System.Drawing.Point(129, 243);
            this.txtSLN.Name = "txtSLN";
            this.txtSLN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLN.Properties.Appearance.Options.UseFont = true;
            this.txtSLN.Size = new System.Drawing.Size(221, 26);
            this.txtSLN.TabIndex = 1;
            // 
            // txtTG
            // 
            this.txtTG.Location = new System.Drawing.Point(129, 138);
            this.txtTG.Name = "txtTG";
            this.txtTG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTG.Properties.Appearance.Options.UseFont = true;
            this.txtTG.Size = new System.Drawing.Size(221, 26);
            this.txtTG.TabIndex = 1;
            // 
            // txtTL
            // 
            this.txtTL.Location = new System.Drawing.Point(129, 103);
            this.txtTL.Name = "txtTL";
            this.txtTL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTL.Properties.Appearance.Options.UseFont = true;
            this.txtTL.Size = new System.Drawing.Size(221, 26);
            this.txtTL.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(15, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã sách";
            // 
            // btThem
            // 
            this.btThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Appearance.Options.UseFont = true;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.Location = new System.Drawing.Point(150, 506);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(107, 34);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(665, 163);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(64, 19);
            this.labelControl10.TabIndex = 23;
            this.labelControl10.Text = "Mã phiếu";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(737, 160);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Properties.Appearance.Options.UseFont = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(130, 26);
            this.txtMaPhieu.TabIndex = 24;
            // 
            // dati
            // 
            this.dati.CustomFormat = "dd/MM/yyyy";
            this.dati.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dati.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dati.Location = new System.Drawing.Point(518, 159);
            this.dati.Name = "dati";
            this.dati.Size = new System.Drawing.Size(130, 27);
            this.dati.TabIndex = 26;
            this.dati.ValueChanged += new System.EventHandler(this.dati_ValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(396, 165);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(111, 19);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "Ngày lập phiếu ";
            // 
            // btReloadDSPN
            // 
            this.btReloadDSPN.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btReloadDSPN.Image = ((System.Drawing.Image)(resources.GetObject("btReloadDSPN.Image")));
            this.btReloadDSPN.Location = new System.Drawing.Point(651, 506);
            this.btReloadDSPN.Name = "btReloadDSPN";
            this.btReloadDSPN.Size = new System.Drawing.Size(105, 36);
            this.btReloadDSPN.TabIndex = 27;
            this.btReloadDSPN.Text = "Tải lại DS";
            this.btReloadDSPN.Click += new System.EventHandler(this.btReloadDSPN_Click);
            // 
            // gCtrl_DSPN
            // 
            this.gCtrl_DSPN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCtrl_DSPN.DataMember = "Query";
            this.gCtrl_DSPN.DataSource = this.sqlDataSource1;
            this.gCtrl_DSPN.Location = new System.Drawing.Point(390, 192);
            this.gCtrl_DSPN.MainView = this.gView_DSPN;
            this.gCtrl_DSPN.Name = "gCtrl_DSPN";
            this.gCtrl_DSPN.Size = new System.Drawing.Size(503, 305);
            this.gCtrl_DSPN.TabIndex = 28;
            this.gCtrl_DSPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gView_DSPN});
            this.gCtrl_DSPN.DataSourceChanged += new System.EventHandler(this.gCtrl_DSPN_DataSourceChanged);
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
            // gView_DSPN
            // 
            this.gView_DSPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãphiếunhập,
            this.colMãsách,
            this.colTênsách,
            this.colThểloại,
            this.colTácgiả,
            this.colSốlượngnhập});
            this.gView_DSPN.GridControl = this.gCtrl_DSPN;
            this.gView_DSPN.Name = "gView_DSPN";
            this.gView_DSPN.OptionsBehavior.Editable = false;
            this.gView_DSPN.OptionsBehavior.ReadOnly = true;
            this.gView_DSPN.OptionsFind.AlwaysVisible = true;
            // 
            // colMãphiếunhập
            // 
            this.colMãphiếunhập.FieldName = "Mã phiếu nhập";
            this.colMãphiếunhập.Name = "colMãphiếunhập";
            this.colMãphiếunhập.Visible = true;
            this.colMãphiếunhập.VisibleIndex = 0;
            // 
            // colMãsách
            // 
            this.colMãsách.FieldName = "Mã sách";
            this.colMãsách.Name = "colMãsách";
            this.colMãsách.Visible = true;
            this.colMãsách.VisibleIndex = 1;
            // 
            // colTênsách
            // 
            this.colTênsách.FieldName = "Tên sách";
            this.colTênsách.Name = "colTênsách";
            this.colTênsách.Visible = true;
            this.colTênsách.VisibleIndex = 2;
            // 
            // colThểloại
            // 
            this.colThểloại.FieldName = "Thể loại";
            this.colThểloại.Name = "colThểloại";
            this.colThểloại.Visible = true;
            this.colThểloại.VisibleIndex = 3;
            // 
            // colTácgiả
            // 
            this.colTácgiả.FieldName = "Tác giả";
            this.colTácgiả.Name = "colTácgiả";
            this.colTácgiả.Visible = true;
            this.colTácgiả.VisibleIndex = 4;
            // 
            // colSốlượngnhập
            // 
            this.colSốlượngnhập.FieldName = "Số lượng nhập";
            this.colSốlượngnhập.Name = "colSốlượngnhập";
            this.colSốlượngnhập.Visible = true;
            this.colSốlượngnhập.VisibleIndex = 5;
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnKetthuc.Image = ((System.Drawing.Image)(resources.GetObject("btnKetthuc.Image")));
            this.btnKetthuc.Location = new System.Drawing.Point(762, 506);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(105, 34);
            this.btnKetthuc.TabIndex = 27;
            this.btnKetthuc.Text = "Thoát";
            this.btnKetthuc.Click += new System.EventHandler(this.btnKetthuc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTonTruocNhap);
            this.groupBox1.Controls.Add(this.lblNhaptt);
            this.groupBox1.Controls.Add(this.labelControl11);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Location = new System.Drawing.Point(18, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 74);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lưu ý";
            // 
            // lblTonTruocNhap
            // 
            this.lblTonTruocNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTonTruocNhap.Location = new System.Drawing.Point(306, 47);
            this.lblTonTruocNhap.Name = "lblTonTruocNhap";
            this.lblTonTruocNhap.Size = new System.Drawing.Size(37, 16);
            this.lblTonTruocNhap.TabIndex = 1;
            this.lblTonTruocNhap.Text = "Money";
            // 
            // lblNhaptt
            // 
            this.lblNhaptt.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaptt.Location = new System.Drawing.Point(306, 20);
            this.lblNhaptt.Name = "lblNhaptt";
            this.lblNhaptt.Size = new System.Drawing.Size(37, 16);
            this.lblNhaptt.TabIndex = 1;
            this.lblNhaptt.Text = "Money";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(8, 51);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(269, 16);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Chỉ nhập các đầu sách có lượng tồn ít hơn";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(9, 20);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(154, 16);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Số lượng nhập ít nhất là";
            // 
            // fmLapPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gCtrl_DSPN);
            this.Controls.Add(this.btnKetthuc);
            this.Controls.Add(this.btReloadDSPN);
            this.Controls.Add(this.dati);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPNS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmLapPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LẬP PHIẾU NHẬP";
            this.Load += new System.EventHandler(this.fmLapPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btEditTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEditMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrl_DSPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView_DSPN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPNS;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private DevExpress.XtraEditors.ButtonEdit btEditTen;
        private DevExpress.XtraEditors.ButtonEdit btEditMa;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSLT;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private DevExpress.XtraEditors.TextEdit txtSLN;
        private DevExpress.XtraEditors.TextEdit txtTG;
        private DevExpress.XtraEditors.TextEdit txtTL;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtMaPhieu;
        private System.Windows.Forms.DateTimePicker dati;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btReloadDSPN;
        private DevExpress.XtraGrid.GridControl gCtrl_DSPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gView_DSPN;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãphiếunhập;
        private DevExpress.XtraGrid.Columns.GridColumn colMãsách;
        private DevExpress.XtraGrid.Columns.GridColumn colTênsách;
        private DevExpress.XtraGrid.Columns.GridColumn colThểloại;
        private DevExpress.XtraGrid.Columns.GridColumn colTácgiả;
        private DevExpress.XtraGrid.Columns.GridColumn colSốlượngnhập;
        private DevExpress.XtraEditors.SimpleButton btnKetthuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl lblTonTruocNhap;
        private DevExpress.XtraEditors.LabelControl lblNhaptt;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}