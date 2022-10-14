namespace QuanLy
{
    partial class frmThongKe
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
            this.charDoanhThuThang = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.charDoanhThuThang)).BeginInit();
            this.SuspendLayout();
            // 
            // charDoanhThuThang
            // 
            this.charDoanhThuThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charDoanhThuThang.Location = new System.Drawing.Point(0, 0);
            this.charDoanhThuThang.Name = "charDoanhThuThang";
            this.charDoanhThuThang.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.charDoanhThuThang.Size = new System.Drawing.Size(627, 514);
            this.charDoanhThuThang.TabIndex = 0;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 514);
            this.Controls.Add(this.charDoanhThuThang);
            this.Name = "frmThongKe";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charDoanhThuThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl charDoanhThuThang;
    }
}