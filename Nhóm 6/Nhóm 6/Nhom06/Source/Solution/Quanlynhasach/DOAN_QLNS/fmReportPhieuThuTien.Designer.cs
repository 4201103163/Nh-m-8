namespace DOAN_QLNS
{
    partial class fmReportPhieuThuTien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataBaoCaoNo = new DOAN_QLNS.DataBaoCaoNo();
            this.PTTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PTTTableAdapter = new DOAN_QLNS.DataBaoCaoNoTableAdapters.PTTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCaoNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PTTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PTTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOAN_QLNS.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataBaoCaoNo
            // 
            this.DataBaoCaoNo.DataSetName = "DataBaoCaoNo";
            this.DataBaoCaoNo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PTTBindingSource
            // 
            this.PTTBindingSource.DataMember = "PTT";
            this.PTTBindingSource.DataSource = this.DataBaoCaoNo;
            // 
            // PTTTableAdapter
            // 
            this.PTTTableAdapter.ClearBeforeFill = true;
            // 
            // fmReportPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fmReportPhieuThuTien";
            this.Text = "fmReportPhieuThuTien";
            this.Load += new System.EventHandler(this.fmReportPhieuThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCaoNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PTTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PTTBindingSource;
        private DataBaoCaoNo DataBaoCaoNo;
        private DataBaoCaoNoTableAdapters.PTTTableAdapter PTTTableAdapter;
    }
}