namespace DOAN_QLNS
{
    partial class fmSachDaMua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSachDaMua));
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.pnlDate = new DevExpress.XtraEditors.PanelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.pnlName = new DevExpress.XtraEditors.PanelControl();
            this.lblNameCus = new DevExpress.XtraEditors.LabelControl();
            this.txtNameCus = new DevExpress.XtraEditors.TextEdit();
            this.pnlPhone = new DevExpress.XtraEditors.PanelControl();
            this.lblPhone = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.pnlID = new DevExpress.XtraEditors.PanelControl();
            this.btnGetInfo = new DevExpress.XtraEditors.SimpleButton();
            this.lblIDCus = new DevExpress.XtraEditors.LabelControl();
            this.txtIDCus = new DevExpress.XtraEditors.TextEdit();
            this.pnlDebt = new DevExpress.XtraEditors.PanelControl();
            this.lblDebt = new DevExpress.XtraEditors.LabelControl();
            this.txtDebt = new DevExpress.XtraEditors.TextEdit();
            this.pnlAddress = new DevExpress.XtraEditors.PanelControl();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.pnlEmail = new DevExpress.XtraEditors.PanelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.gridControl_SachDaMua = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView_SachDaMua = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSĐT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNợ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichú = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDate)).BeginInit();
            this.pnlDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlName)).BeginInit();
            this.pnlName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPhone)).BeginInit();
            this.pnlPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlID)).BeginInit();
            this.pnlID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDCus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDebt)).BeginInit();
            this.pnlDebt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddress)).BeginInit();
            this.pnlAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEmail)).BeginInit();
            this.pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SachDaMua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_SachDaMua)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 100);
            this.panel1.TabIndex = 0;
            // 
            // panelControl9
            // 
            this.panelControl9.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.panelControl9.Appearance.BackColor2 = System.Drawing.Color.Azure;
            this.panelControl9.Appearance.BorderColor = System.Drawing.Color.MintCream;
            this.panelControl9.Appearance.Options.UseBackColor = true;
            this.panelControl9.Appearance.Options.UseBorderColor = true;
            this.panelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl9.Location = new System.Drawing.Point(0, 217);
            this.panelControl9.Name = "panelControl9";
            this.panelControl9.Size = new System.Drawing.Size(368, 40);
            this.panelControl9.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(9, 10);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 19);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // pnlDate
            // 
            this.pnlDate.Appearance.BackColor = System.Drawing.Color.MintCream;
            this.pnlDate.Appearance.BackColor2 = System.Drawing.Color.MintCream;
            this.pnlDate.Appearance.BorderColor = System.Drawing.Color.MintCream;
            this.pnlDate.Appearance.Options.UseBackColor = true;
            this.pnlDate.Appearance.Options.UseBorderColor = true;
            this.pnlDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlDate.Controls.Add(this.lblDate);
            this.pnlDate.Controls.Add(this.txtDate);
            this.pnlDate.Location = new System.Drawing.Point(367, 217);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(363, 40);
            this.pnlDate.TabIndex = 16;
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(9, 10);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 19);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Ngày";
            // 
            // txtDate
            // 
            this.txtDate.EditValue = null;
            this.txtDate.Location = new System.Drawing.Point(69, 5);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Properties.Appearance.Options.UseBackColor = true;
            this.txtDate.Properties.Appearance.Options.UseFont = true;
            this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.txtDate.Properties.DisplayFormat.FormatString = "";
            this.txtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDate.Properties.EditFormat.FormatString = "";
            this.txtDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.txtDate.Size = new System.Drawing.Size(289, 26);
            this.txtDate.TabIndex = 6;
            // 
            // pnlName
            // 
            this.pnlName.Appearance.BackColor = System.Drawing.Color.MintCream;
            this.pnlName.Appearance.BackColor2 = System.Drawing.Color.MintCream;
            this.pnlName.Appearance.BorderColor = System.Drawing.Color.MintCream;
            this.pnlName.Appearance.Options.UseBackColor = true;
            this.pnlName.Appearance.Options.UseBorderColor = true;
            this.pnlName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlName.Controls.Add(this.lblNameCus);
            this.pnlName.Controls.Add(this.txtNameCus);
            this.pnlName.Location = new System.Drawing.Point(367, 100);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(363, 40);
            this.pnlName.TabIndex = 13;
            // 
            // lblNameCus
            // 
            this.lblNameCus.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCus.Location = new System.Drawing.Point(9, 10);
            this.lblNameCus.Margin = new System.Windows.Forms.Padding(4);
            this.lblNameCus.Name = "lblNameCus";
            this.lblNameCus.Size = new System.Drawing.Size(54, 19);
            this.lblNameCus.TabIndex = 0;
            this.lblNameCus.Text = "Họ tên";
            // 
            // txtNameCus
            // 
            this.txtNameCus.Enabled = false;
            this.txtNameCus.Location = new System.Drawing.Point(69, 6);
            this.txtNameCus.Name = "txtNameCus";
            this.txtNameCus.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtNameCus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCus.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtNameCus.Properties.Appearance.Options.UseBackColor = true;
            this.txtNameCus.Properties.Appearance.Options.UseFont = true;
            this.txtNameCus.Properties.Appearance.Options.UseForeColor = true;
            this.txtNameCus.Size = new System.Drawing.Size(289, 26);
            this.txtNameCus.TabIndex = 1;
            // 
            // pnlPhone
            // 
            this.pnlPhone.Appearance.BackColor = System.Drawing.Color.MintCream;
            this.pnlPhone.Appearance.BackColor2 = System.Drawing.Color.MintCream;
            this.pnlPhone.Appearance.BorderColor = System.Drawing.Color.MintCream;
            this.pnlPhone.Appearance.Options.UseBackColor = true;
            this.pnlPhone.Appearance.Options.UseBorderColor = true;
            this.pnlPhone.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlPhone.Controls.Add(this.lblPhone);
            this.pnlPhone.Controls.Add(this.txtPhone);
            this.pnlPhone.Location = new System.Drawing.Point(367, 139);
            this.pnlPhone.Name = "pnlPhone";
            this.pnlPhone.Size = new System.Drawing.Size(363, 40);
            this.pnlPhone.TabIndex = 14;
            // 
            // lblPhone
            // 
            this.lblPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(9, 10);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(33, 19);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "SĐT";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(69, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Properties.Appearance.Options.UseBackColor = true;
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Properties.Appearance.Options.UseForeColor = true;
            this.txtPhone.Size = new System.Drawing.Size(289, 26);
            this.txtPhone.TabIndex = 3;
            // 
            // pnlID
            // 
            this.pnlID.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlID.Appearance.BackColor2 = System.Drawing.Color.Azure;
            this.pnlID.Appearance.BorderColor = System.Drawing.Color.MintCream;
            this.pnlID.Appearance.Options.UseBackColor = true;
            this.pnlID.Appearance.Options.UseBorderColor = true;
            this.pnlID.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlID.Controls.Add(this.btnGetInfo);
            this.pnlID.Controls.Add(this.lblIDCus);
            this.pnlID.Controls.Add(this.txtIDCus);
            this.pnlID.Location = new System.Drawing.Point(0, 100);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(368, 40);
            this.pnlID.TabIndex = 9;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetInfo.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnGetInfo.Appearance.Options.UseFont = true;
            this.btnGetInfo.Appearance.Options.UseForeColor = true;
            this.btnGetInfo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnGetInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnGetInfo.Image")));
            this.btnGetInfo.Location = new System.Drawing.Point(230, 3);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(122, 30);
            this.btnGetInfo.TabIndex = 7;
            this.btnGetInfo.Text = "Thực hiện";
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // lblIDCus
            // 
            this.lblIDCus.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCus.Location = new System.Drawing.Point(9, 10);
            this.lblIDCus.Margin = new System.Windows.Forms.Padding(4);
            this.lblIDCus.Name = "lblIDCus";
            this.lblIDCus.Size = new System.Drawing.Size(52, 19);
            this.lblIDCus.TabIndex = 0;
            this.lblIDCus.Text = "Mã KH";
            // 
            // txtIDCus
            // 
            this.txtIDCus.Location = new System.Drawing.Point(124, 3);
            this.txtIDCus.Name = "txtIDCus";
            this.txtIDCus.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtIDCus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCus.Properties.Appearance.Options.UseBackColor = true;
            this.txtIDCus.Properties.Appearance.Options.UseFont = true;
            this.txtIDCus.Size = new System.Drawing.Size(94, 26);
            this.txtIDCus.TabIndex = 0;
            // 
            // pnlDebt
            // 
            this.pnlDebt.Appearance.BackColor = System.Drawing.Color.MintCream;
            this.pnlDebt.Appearance.BackColor2 = System.Drawing.Color.MintCream;
            this.pnlDebt.Appearance.BorderColor = System.Drawing.Color.MintCream;
            this.pnlDebt.Appearance.Options.UseBackColor = true;
            this.pnlDebt.Appearance.Options.UseBorderColor = true;
            this.pnlDebt.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlDebt.Controls.Add(this.lblDebt);
            this.pnlDebt.Controls.Add(this.txtDebt);
            this.pnlDebt.Location = new System.Drawing.Point(367, 178);
            this.pnlDebt.Name = "pnlDebt";
            this.pnlDebt.Size = new System.Drawing.Size(363, 40);
            this.pnlDebt.TabIndex = 15;
            // 
            // lblDebt
            // 
            this.lblDebt.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebt.Location = new System.Drawing.Point(9, 10);
            this.lblDebt.Margin = new System.Windows.Forms.Padding(4);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(22, 19);
            this.lblDebt.TabIndex = 0;
            this.lblDebt.Text = "Nợ";
            // 
            // txtDebt
            // 
            this.txtDebt.Enabled = false;
            this.txtDebt.Location = new System.Drawing.Point(69, 5);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtDebt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebt.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDebt.Properties.Appearance.Options.UseBackColor = true;
            this.txtDebt.Properties.Appearance.Options.UseFont = true;
            this.txtDebt.Properties.Appearance.Options.UseForeColor = true;
            this.txtDebt.Size = new System.Drawing.Size(289, 26);
            this.txtDebt.TabIndex = 5;
            // 
            // pnlAddress
            // 
            this.pnlAddress.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlAddress.Appearance.BackColor2 = System.Drawing.Color.Azure;
            this.pnlAddress.Appearance.BorderColor = System.Drawing.Color.MintCream;
            this.pnlAddress.Appearance.Options.UseBackColor = true;
            this.pnlAddress.Appearance.Options.UseBorderColor = true;
            this.pnlAddress.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlAddress.Controls.Add(this.lblAddress);
            this.pnlAddress.Controls.Add(this.txtAddress);
            this.pnlAddress.Location = new System.Drawing.Point(0, 139);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(368, 40);
            this.pnlAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(9, 10);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 19);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(124, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Properties.Appearance.Options.UseBackColor = true;
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Properties.Appearance.Options.UseForeColor = true;
            this.txtAddress.Size = new System.Drawing.Size(228, 26);
            this.txtAddress.TabIndex = 2;
            // 
            // pnlEmail
            // 
            this.pnlEmail.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlEmail.Appearance.BackColor2 = System.Drawing.Color.Azure;
            this.pnlEmail.Appearance.BorderColor = System.Drawing.Color.MintCream;
            this.pnlEmail.Appearance.Options.UseBackColor = true;
            this.pnlEmail.Appearance.Options.UseBorderColor = true;
            this.pnlEmail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Location = new System.Drawing.Point(0, 178);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(368, 40);
            this.pnlEmail.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(124, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.Appearance.Options.UseForeColor = true;
            this.txtEmail.Size = new System.Drawing.Size(228, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // gridControl_SachDaMua
            // 
            this.gridControl_SachDaMua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_SachDaMua.DataMember = "Query";
            this.gridControl_SachDaMua.DataSource = this.sqlDataSource1;
            this.gridControl_SachDaMua.Location = new System.Drawing.Point(0, 258);
            this.gridControl_SachDaMua.MainView = this.gridView_SachDaMua;
            this.gridControl_SachDaMua.Name = "gridControl_SachDaMua";
            this.gridControl_SachDaMua.Size = new System.Drawing.Size(730, 212);
            this.gridControl_SachDaMua.TabIndex = 17;
            this.gridControl_SachDaMua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_SachDaMua});
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
            // gridView_SachDaMua
            // 
            this.gridView_SachDaMua.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãKH,
            this.colTênKH,
            this.colSĐT,
            this.colEmail,
            this.colNợ,
            this.colGhichú});
            this.gridView_SachDaMua.GridControl = this.gridControl_SachDaMua;
            this.gridView_SachDaMua.Name = "gridView_SachDaMua";
            this.gridView_SachDaMua.OptionsBehavior.Editable = false;
            this.gridView_SachDaMua.OptionsBehavior.ReadOnly = true;
            this.gridView_SachDaMua.OptionsFind.AlwaysVisible = true;
            // 
            // colMãKH
            // 
            this.colMãKH.FieldName = "Mã KH";
            this.colMãKH.Name = "colMãKH";
            this.colMãKH.Visible = true;
            this.colMãKH.VisibleIndex = 0;
            // 
            // colTênKH
            // 
            this.colTênKH.FieldName = "Tên KH";
            this.colTênKH.Name = "colTênKH";
            this.colTênKH.Visible = true;
            this.colTênKH.VisibleIndex = 1;
            // 
            // colSĐT
            // 
            this.colSĐT.FieldName = "SĐT";
            this.colSĐT.Name = "colSĐT";
            this.colSĐT.Visible = true;
            this.colSĐT.VisibleIndex = 2;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // colNợ
            // 
            this.colNợ.FieldName = "Nợ";
            this.colNợ.Name = "colNợ";
            this.colNợ.Visible = true;
            this.colNợ.VisibleIndex = 4;
            // 
            // colGhichú
            // 
            this.colGhichú.FieldName = "Ghi chú";
            this.colGhichú.Name = "colGhichú";
            this.colGhichú.Visible = true;
            this.colGhichú.VisibleIndex = 5;
            // 
            // fmSachDaMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 470);
            this.Controls.Add(this.gridControl_SachDaMua);
            this.Controls.Add(this.panelControl9);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.pnlPhone);
            this.Controls.Add(this.pnlID);
            this.Controls.Add(this.pnlDebt);
            this.Controls.Add(this.pnlAddress);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmSachDaMua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SÁCH ĐÃ MUA";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDate)).EndInit();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlName)).EndInit();
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPhone)).EndInit();
            this.pnlPhone.ResumeLayout(false);
            this.pnlPhone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlID)).EndInit();
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDCus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDebt)).EndInit();
            this.pnlDebt.ResumeLayout(false);
            this.pnlDebt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddress)).EndInit();
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEmail)).EndInit();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SachDaMua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_SachDaMua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.PanelControl pnlDate;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private DevExpress.XtraEditors.PanelControl pnlName;
        private DevExpress.XtraEditors.LabelControl lblNameCus;
        private DevExpress.XtraEditors.TextEdit txtNameCus;
        private DevExpress.XtraEditors.PanelControl pnlPhone;
        private DevExpress.XtraEditors.LabelControl lblPhone;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.PanelControl pnlID;
        private DevExpress.XtraEditors.SimpleButton btnGetInfo;
        private DevExpress.XtraEditors.LabelControl lblIDCus;
        private DevExpress.XtraEditors.TextEdit txtIDCus;
        private DevExpress.XtraEditors.PanelControl pnlDebt;
        private DevExpress.XtraEditors.LabelControl lblDebt;
        private DevExpress.XtraEditors.TextEdit txtDebt;
        private DevExpress.XtraEditors.PanelControl pnlAddress;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.PanelControl pnlEmail;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraGrid.GridControl gridControl_SachDaMua;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_SachDaMua;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTênKH;
        private DevExpress.XtraGrid.Columns.GridColumn colSĐT;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colNợ;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichú;
    }
}