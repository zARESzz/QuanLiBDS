namespace QuanLy
{
    partial class frmPhanQuyen
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnThayDoi = new Main.Custom.CtButton();
            this.cbxChucVu = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gcNHANVIEN = new DevExpress.XtraGrid.GridControl();
            this.gvNHANVIEN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNHANVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNHANVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnThayDoi);
            this.splitContainer1.Panel1.Controls.Add(this.cbxChucVu);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcNHANVIEN);
            this.splitContainer1.Size = new System.Drawing.Size(919, 825);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnThayDoi.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnThayDoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThayDoi.BorderRadius = 20;
            this.btnThayDoi.BorderSize = 0;
            this.btnThayDoi.FlatAppearance.BorderSize = 0;
            this.btnThayDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThayDoi.ForeColor = System.Drawing.Color.White;
            this.btnThayDoi.Location = new System.Drawing.Point(407, 26);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(150, 40);
            this.btnThayDoi.TabIndex = 2;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.TextColor = System.Drawing.Color.White;
            this.btnThayDoi.UseVisualStyleBackColor = false;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // cbxChucVu
            // 
            this.cbxChucVu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxChucVu.FormattingEnabled = true;
            this.cbxChucVu.Location = new System.Drawing.Point(147, 34);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Size = new System.Drawing.Size(231, 32);
            this.cbxChucVu.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(40, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 28);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Chức Vụ:";
            // 
            // gcNHANVIEN
            // 
            this.gcNHANVIEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNHANVIEN.Location = new System.Drawing.Point(0, 0);
            this.gcNHANVIEN.MainView = this.gvNHANVIEN;
            this.gcNHANVIEN.Name = "gcNHANVIEN";
            this.gcNHANVIEN.Size = new System.Drawing.Size(919, 721);
            this.gcNHANVIEN.TabIndex = 1;
            this.gcNHANVIEN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNHANVIEN});
            // 
            // gvNHANVIEN
            // 
            this.gvNHANVIEN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTK,
            this.MK,
            this.HoTenNV,
            this.MaCV,
            this.TenCV,
            this.GioiTinh,
            this.NgaySinh,
            this.SDT,
            this.Email,
            this.DiaChi});
            this.gvNHANVIEN.GridControl = this.gcNHANVIEN;
            this.gvNHANVIEN.Name = "gvNHANVIEN";
            this.gvNHANVIEN.OptionsView.ShowGroupPanel = false;
            this.gvNHANVIEN.Click += new System.EventHandler(this.gvNHANVIEN_Click);
            // 
            // MaTK
            // 
            this.MaTK.Caption = "Tài Khoản";
            this.MaTK.FieldName = "MaTK";
            this.MaTK.MinWidth = 25;
            this.MaTK.Name = "MaTK";
            this.MaTK.Visible = true;
            this.MaTK.VisibleIndex = 0;
            this.MaTK.Width = 100;
            // 
            // MK
            // 
            this.MK.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MK.AppearanceCell.Options.UseFont = true;
            this.MK.Caption = "Mật Khẩu";
            this.MK.FieldName = "MK";
            this.MK.MaxWidth = 200;
            this.MK.MinWidth = 50;
            this.MK.Name = "MK";
            this.MK.Width = 100;
            // 
            // HoTenNV
            // 
            this.HoTenNV.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HoTenNV.AppearanceCell.Options.UseFont = true;
            this.HoTenNV.Caption = "Họ Tên ";
            this.HoTenNV.FieldName = "HoTenNV";
            this.HoTenNV.MaxWidth = 200;
            this.HoTenNV.MinWidth = 200;
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.Visible = true;
            this.HoTenNV.VisibleIndex = 1;
            this.HoTenNV.Width = 200;
            // 
            // MaCV
            // 
            this.MaCV.Caption = "IDCV";
            this.MaCV.FieldName = "MaCV";
            this.MaCV.MinWidth = 25;
            this.MaCV.Name = "MaCV";
            this.MaCV.Width = 104;
            // 
            // TenCV
            // 
            this.TenCV.Caption = "Chức Vụ";
            this.TenCV.FieldName = "TenCV";
            this.TenCV.MinWidth = 25;
            this.TenCV.Name = "TenCV";
            this.TenCV.Visible = true;
            this.TenCV.VisibleIndex = 3;
            this.TenCV.Width = 94;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới Tính";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.MinWidth = 25;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 104;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày Sinh";
            this.NgaySinh.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgaySinh.FieldName = "NgaySinh";
            this.NgaySinh.MinWidth = 25;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 104;
            // 
            // SDT
            // 
            this.SDT.Caption = "Số điện thoại";
            this.SDT.FieldName = "SDT";
            this.SDT.MinWidth = 25;
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 2;
            this.SDT.Width = 94;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.MinWidth = 25;
            this.Email.Name = "Email";
            this.Email.Width = 104;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MinWidth = 25;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 140;
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 825);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmPhanQuyen";
            this.Text = "Phân quyền";
            this.Load += new System.EventHandler(this.frmNHANVIEN_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNHANVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNHANVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gcNHANVIEN;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn MK;
        private DevExpress.XtraGrid.Columns.GridColumn HoTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private System.Windows.Forms.ComboBox cbxChucVu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn MaTK;
        private DevExpress.XtraGrid.Columns.GridColumn MaCV;
        private DevExpress.XtraGrid.Columns.GridColumn TenCV;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private Main.Custom.CtButton btnThayDoi;
    }
}