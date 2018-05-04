namespace DOAN_QLNS
{
    partial class fmBaoCaoTon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmBaoCaoTon));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataBaoCaoTon = new DOAN_QLNS.DataBaoCaoTon();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BCTTableAdapter = new DOAN_QLNS.DataBaoCaoTonTableAdapters.BCTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCaoTon)).BeginInit();
            this.SuspendLayout();
            // 
            // BCTBindingSource
            // 
            this.BCTBindingSource.DataMember = "BCT";
            this.BCTBindingSource.DataSource = this.DataBaoCaoTon;
            // 
            // DataBaoCaoTon
            // 
            this.DataBaoCaoTon.DataSetName = "DataBaoCaoTon";
            this.DataBaoCaoTon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 100);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataBCT";
            reportDataSource1.Value = this.BCTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOAN_QLNS.rpBaoCaoTon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(718, 347);
            this.reportViewer1.TabIndex = 1;
            // 
            // BCTTableAdapter
            // 
            this.BCTTableAdapter.ClearBeforeFill = true;
            // 
            // fmBaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 447);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmBaoCaoTon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO TỒN";
            this.Load += new System.EventHandler(this.fmBaoCaoTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCaoTon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BCTBindingSource;
        private DataBaoCaoTon DataBaoCaoTon;
        private DataBaoCaoTonTableAdapters.BCTTableAdapter BCTTableAdapter;
    }
}