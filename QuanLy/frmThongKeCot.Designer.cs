namespace QuanLy
{
    partial class frmThongKeCot
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgayC = new System.Windows.Forms.DateTimePicker();
            this.dtNgayD = new System.Windows.Forms.DateTimePicker();
            this.charDoanhThuThang = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charDoanhThuThang)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayC);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayD);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.charDoanhThuThang);
            this.splitContainer1.Size = new System.Drawing.Size(935, 817);
            this.splitContainer1.SplitterDistance = 117;
            this.splitContainer1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đến ngày :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Từ ngày :";
            // 
            // dtNgayC
            // 
            this.dtNgayC.CustomFormat = "dd/MM/yyyy";
            this.dtNgayC.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayC.Location = new System.Drawing.Point(381, 61);
            this.dtNgayC.Name = "dtNgayC";
            this.dtNgayC.Size = new System.Drawing.Size(200, 28);
            this.dtNgayC.TabIndex = 2;
            // 
            // dtNgayD
            // 
            this.dtNgayD.CustomFormat = "dd/MM/yyyy";
            this.dtNgayD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayD.Location = new System.Drawing.Point(381, 27);
            this.dtNgayD.Name = "dtNgayD";
            this.dtNgayD.Size = new System.Drawing.Size(200, 28);
            this.dtNgayD.TabIndex = 1;
            // 
            // charDoanhThuThang
            // 
            this.charDoanhThuThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charDoanhThuThang.Location = new System.Drawing.Point(0, 0);
            this.charDoanhThuThang.Name = "charDoanhThuThang";
            this.charDoanhThuThang.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.charDoanhThuThang.Size = new System.Drawing.Size(935, 696);
            this.charDoanhThuThang.TabIndex = 1;
            // 
            // frmThongKeCot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 817);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmThongKeCot";
            this.Text = "Doanh Thu Theo Cột";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charDoanhThuThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgayC;
        private System.Windows.Forms.DateTimePicker dtNgayD;
        private DevExpress.XtraCharts.ChartControl charDoanhThuThang;
    }
}