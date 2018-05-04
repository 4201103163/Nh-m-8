namespace DOAN_QLNS
{
    partial class frm_Report_HDBS
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
            this.HDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HDTableAdapter = new DOAN_QLNS.DataBaoCaoNoTableAdapters.HDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCaoNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetHD";
            reportDataSource1.Value = this.HDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOAN_QLNS.Report2.rdlc";
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
            // HDBindingSource
            // 
            this.HDBindingSource.DataMember = "HD";
            this.HDBindingSource.DataSource = this.DataBaoCaoNo;
            // 
            // HDTableAdapter
            // 
            this.HDTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Report_HDBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Report_HDBS";
            this.Text = "frm_Report_HDBS";
            this.Load += new System.EventHandler(this.frm_Report_HDBS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCaoNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HDBindingSource;
        private DataBaoCaoNo DataBaoCaoNo;
        private DataBaoCaoNoTableAdapters.HDTableAdapter HDTableAdapter;
    }
}