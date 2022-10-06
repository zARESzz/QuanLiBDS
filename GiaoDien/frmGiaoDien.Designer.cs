namespace GiaoDien
{
    partial class frmGiaoDien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnBanDat = new System.Windows.Forms.Button();
            this.btnLienHe = new System.Windows.Forms.Button();
            this.btnDangTin = new System.Windows.Forms.Button();
            this.btnBanBietThu = new System.Windows.Forms.Button();
            this.btnBanChungCu = new System.Windows.Forms.Button();
            this.btnBanNha = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 581);
            this.panel1.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnBanDat);
            this.panelMenu.Controls.Add(this.btnLienHe);
            this.panelMenu.Controls.Add(this.btnDangTin);
            this.panelMenu.Controls.Add(this.btnBanBietThu);
            this.panelMenu.Controls.Add(this.btnBanChungCu);
            this.panelMenu.Controls.Add(this.btnBanNha);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 581);
            this.panelMenu.TabIndex = 0;
            // 
            // btnBanDat
            // 
            this.btnBanDat.FlatAppearance.BorderSize = 0;
            this.btnBanDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanDat.Image = global::GiaoDien.Properties.Resources.icons8_land_50;
            this.btnBanDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanDat.Location = new System.Drawing.Point(3, 126);
            this.btnBanDat.Name = "btnBanDat";
            this.btnBanDat.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBanDat.Size = new System.Drawing.Size(214, 77);
            this.btnBanDat.TabIndex = 5;
            this.btnBanDat.Text = "   Bán đất";
            this.btnBanDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanDat.UseVisualStyleBackColor = true;
            this.btnBanDat.Click += new System.EventHandler(this.btnBanDat_Click);
            // 
            // btnLienHe
            // 
            this.btnLienHe.FlatAppearance.BorderSize = 0;
            this.btnLienHe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLienHe.Image = global::GiaoDien.Properties.Resources.icons8_call_male_50;
            this.btnLienHe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLienHe.Location = new System.Drawing.Point(0, 504);
            this.btnLienHe.Name = "btnLienHe";
            this.btnLienHe.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLienHe.Size = new System.Drawing.Size(214, 77);
            this.btnLienHe.TabIndex = 1;
            this.btnLienHe.Text = "   Liên hệ";
            this.btnLienHe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLienHe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLienHe.UseVisualStyleBackColor = true;
            this.btnLienHe.Click += new System.EventHandler(this.btnLienHe_Click);
            // 
            // btnDangTin
            // 
            this.btnDangTin.FlatAppearance.BorderSize = 0;
            this.btnDangTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangTin.Image = global::GiaoDien.Properties.Resources.icons8_post_50;
            this.btnDangTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangTin.Location = new System.Drawing.Point(0, 435);
            this.btnDangTin.Name = "btnDangTin";
            this.btnDangTin.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDangTin.Size = new System.Drawing.Size(214, 77);
            this.btnDangTin.TabIndex = 4;
            this.btnDangTin.Text = "   Đăng tin";
            this.btnDangTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangTin.UseVisualStyleBackColor = true;
            this.btnDangTin.Click += new System.EventHandler(this.btnDangTin_Click);
            // 
            // btnBanBietThu
            // 
            this.btnBanBietThu.FlatAppearance.BorderSize = 0;
            this.btnBanBietThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanBietThu.Image = global::GiaoDien.Properties.Resources.icons8_villa_50;
            this.btnBanBietThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanBietThu.Location = new System.Drawing.Point(0, 364);
            this.btnBanBietThu.Name = "btnBanBietThu";
            this.btnBanBietThu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBanBietThu.Size = new System.Drawing.Size(214, 77);
            this.btnBanBietThu.TabIndex = 3;
            this.btnBanBietThu.Text = "   Bán biệt thự";
            this.btnBanBietThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanBietThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanBietThu.UseVisualStyleBackColor = true;
            this.btnBanBietThu.Click += new System.EventHandler(this.btnBanBietThu_Click);
            // 
            // btnBanChungCu
            // 
            this.btnBanChungCu.FlatAppearance.BorderSize = 0;
            this.btnBanChungCu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanChungCu.Image = global::GiaoDien.Properties.Resources.icons8_building_with_rooftop_terrace_50;
            this.btnBanChungCu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanChungCu.Location = new System.Drawing.Point(0, 292);
            this.btnBanChungCu.Name = "btnBanChungCu";
            this.btnBanChungCu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBanChungCu.Size = new System.Drawing.Size(214, 77);
            this.btnBanChungCu.TabIndex = 2;
            this.btnBanChungCu.Text = "   Bán chung cư";
            this.btnBanChungCu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanChungCu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanChungCu.UseVisualStyleBackColor = true;
            this.btnBanChungCu.Click += new System.EventHandler(this.btnBanChungCu_Click);
            // 
            // btnBanNha
            // 
            this.btnBanNha.FlatAppearance.BorderSize = 0;
            this.btnBanNha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanNha.Image = global::GiaoDien.Properties.Resources.icons8_home_50;
            this.btnBanNha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanNha.Location = new System.Drawing.Point(0, 209);
            this.btnBanNha.Name = "btnBanNha";
            this.btnBanNha.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBanNha.Size = new System.Drawing.Size(214, 77);
            this.btnBanNha.TabIndex = 1;
            this.btnBanNha.Text = "   Bán nhà";
            this.btnBanNha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanNha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanNha.UseVisualStyleBackColor = true;
            this.btnBanNha.Click += new System.EventHandler(this.btnBanNha_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 125);
            this.panel3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 580);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panelMenu;
        private Button btnBanDat;
        private Button btnLienHe;
        private Button btnDangTin;
        private Button btnBanBietThu;
        private Button btnBanChungCu;
        private Button btnBanNha;
        private Panel panel3;
    }
}