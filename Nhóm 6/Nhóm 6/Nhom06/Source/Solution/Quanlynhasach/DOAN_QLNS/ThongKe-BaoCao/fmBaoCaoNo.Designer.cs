namespace DOAN_QLNS
{
    partial class fmBaoCaoNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmBaoCaoNo));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BCNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataBaoCaoNo = new DOAN_QLNS.DataBaoCaoNo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BCNTableAdapter = new DOAN_QLNS.DataBaoCaoNoTableAdapters.BCNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BCNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCaoNo)).BeginInit();
            this.SuspendLayout();
            // 
            // BCNBindingSource
            // 
            this.BCNBindingSource.DataMember = "BCN";
            this.BCNBindingSource.DataSource = this.DataBaoCaoNo;
            // 
            // DataBaoCaoNo
            // 
            this.DataBaoCaoNo.DataSetName = "DataBaoCaoNo";
            this.DataBaoCaoNo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 100);
            this.panel1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BCNBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOAN_QLNS.rpBaoCaoNo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(718, 347);
            this.reportViewer1.TabIndex = 2;
            // 
            // BCNTableAdapter
            // 
            this.BCNTableAdapter.ClearBeforeFill = true;
            // 
            // fmBaoCaoNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 447);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "fmBaoCaoNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO NỢ";
            this.Load += new System.EventHandler(this.fmBaoCaoNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BCNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCaoNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BCNBindingSource;
        private DataBaoCaoNo DataBaoCaoNo;
        private DataBaoCaoNoTableAdapters.BCNTableAdapter BCNTableAdapter;
    }
}