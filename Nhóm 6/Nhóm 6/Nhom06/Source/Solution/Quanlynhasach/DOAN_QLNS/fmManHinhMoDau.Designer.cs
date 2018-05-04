namespace DOAN_QLNS
{
    partial class fmManHinhMoDau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmManHinhMoDau));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTacGia = new DevExpress.XtraEditors.SimpleButton();
            this.btnTuSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnGioiThieu = new DevExpress.XtraEditors.SimpleButton();
            this.txtND = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 281);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnTacGia
            // 
            this.btnTacGia.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacGia.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTacGia.Appearance.Options.UseFont = true;
            this.btnTacGia.Appearance.Options.UseForeColor = true;
            this.btnTacGia.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTacGia.Location = new System.Drawing.Point(177, 287);
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Size = new System.Drawing.Size(77, 27);
            this.btnTacGia.TabIndex = 8;
            this.btnTacGia.Text = "TÁC GIẢ";
            this.btnTacGia.Click += new System.EventHandler(this.btnTacGia_Click);
            // 
            // btnTuSach
            // 
            this.btnTuSach.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuSach.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTuSach.Appearance.Options.UseFont = true;
            this.btnTuSach.Appearance.Options.UseForeColor = true;
            this.btnTuSach.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTuSach.Location = new System.Drawing.Point(94, 287);
            this.btnTuSach.Name = "btnTuSach";
            this.btnTuSach.Size = new System.Drawing.Size(77, 27);
            this.btnTuSach.TabIndex = 9;
            this.btnTuSach.Text = "TỦ SÁCH";
            this.btnTuSach.Click += new System.EventHandler(this.btnTuSach_Click);
            // 
            // btnGioiThieu
            // 
            this.btnGioiThieu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioiThieu.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGioiThieu.Appearance.Options.UseFont = true;
            this.btnGioiThieu.Appearance.Options.UseForeColor = true;
            this.btnGioiThieu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnGioiThieu.Location = new System.Drawing.Point(11, 287);
            this.btnGioiThieu.Name = "btnGioiThieu";
            this.btnGioiThieu.Size = new System.Drawing.Size(77, 27);
            this.btnGioiThieu.TabIndex = 10;
            this.btnGioiThieu.Text = "GIỚI THIỆU";
            this.btnGioiThieu.Click += new System.EventHandler(this.btnGioiThieu_Click);
            // 
            // txtND
            // 
            this.txtND.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtND.Enabled = false;
            this.txtND.Location = new System.Drawing.Point(0, 320);
            this.txtND.Multiline = true;
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(825, 212);
            this.txtND.TabIndex = 11;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Appearance.Options.UseForeColor = true;
            this.btnDangNhap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDangNhap.Location = new System.Drawing.Point(260, 287);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(93, 27);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // fmManHinhMoDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(825, 532);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnTacGia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTuSach);
            this.Controls.Add(this.btnGioiThieu);
            this.Controls.Add(this.txtND);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmManHinhMoDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÀN HÌNH MỞ ĐẦU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnTacGia;
        private DevExpress.XtraEditors.SimpleButton btnTuSach;
        private DevExpress.XtraEditors.SimpleButton btnGioiThieu;
        private System.Windows.Forms.TextBox txtND;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
    }
}