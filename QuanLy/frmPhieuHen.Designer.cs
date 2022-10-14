namespace QuanLy
{
    partial class frmPhieuHen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuHen));
            this.barManagerCV = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDele = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbxNV = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbxKHTN = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayGio = new System.Windows.Forms.DateTimePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaDiem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcPhieuHen = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuHen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTenTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIADIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYGIO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaDiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuHen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuHen)).BeginInit();
            this.SuspendLayout();
            // 
            // barManagerCV
            // 
            this.barManagerCV.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManagerCV.DockControls.Add(this.barDockControlTop);
            this.barManagerCV.DockControls.Add(this.barDockControlBottom);
            this.barManagerCV.DockControls.Add(this.barDockControlLeft);
            this.barManagerCV.DockControls.Add(this.barDockControlRight);
            this.barManagerCV.Form = this;
            this.barManagerCV.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnEdit,
            this.btnDele,
            this.btnSave,
            this.btnHuy,
            this.btnDong});
            this.barManagerCV.MaxItemId = 6;
            this.barManagerCV.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.AutoUpdateMergedBars = DevExpress.Utils.DefaultBoolean.True;
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(310, 202);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDele, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 1;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDele
            // 
            this.btnDele.Caption = "Xóa";
            this.btnDele.Id = 2;
            this.btnDele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDele.ImageOptions.SvgImage")));
            this.btnDele.Name = "btnDele";
            this.btnDele.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDele_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 3;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerCV;
            this.barDockControlTop.Size = new System.Drawing.Size(892, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 717);
            this.barDockControlBottom.Manager = this.barManagerCV;
            this.barDockControlBottom.Size = new System.Drawing.Size(892, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManagerCV;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 687);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(892, 30);
            this.barDockControlRight.Manager = this.barManagerCV;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 687);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbxNV);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.cbxKHTN);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayGio);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.txtDiaDiem);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcPhieuHen);
            this.splitContainer1.Size = new System.Drawing.Size(892, 687);
            this.splitContainer1.SplitterDistance = 127;
            this.splitContainer1.TabIndex = 4;
            // 
            // cbxNV
            // 
            this.cbxNV.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxNV.FormattingEnabled = true;
            this.cbxNV.Location = new System.Drawing.Point(190, 77);
            this.cbxNV.Name = "cbxNV";
            this.cbxNV.Size = new System.Drawing.Size(231, 32);
            this.cbxNV.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(112, 28);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Nhân Viên:";
            // 
            // cbxKHTN
            // 
            this.cbxKHTN.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxKHTN.FormattingEnabled = true;
            this.cbxKHTN.Location = new System.Drawing.Point(190, 20);
            this.cbxKHTN.Name = "cbxKHTN";
            this.cbxKHTN.Size = new System.Drawing.Size(231, 32);
            this.cbxKHTN.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(45, 20);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(139, 28);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Khách Hàng :";
            // 
            // dtNgayGio
            // 
            this.dtNgayGio.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtNgayGio.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtNgayGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayGio.Location = new System.Drawing.Point(571, 77);
            this.dtNgayGio.Name = "dtNgayGio";
            this.dtNgayGio.Size = new System.Drawing.Size(285, 32);
            this.dtNgayGio.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(456, 81);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(106, 28);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Ngày Giờ :";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(571, 13);
            this.txtDiaDiem.MenuManager = this.barManagerCV;
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiem.Properties.Appearance.Options.UseFont = true;
            this.txtDiaDiem.Size = new System.Drawing.Size(285, 34);
            this.txtDiaDiem.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(456, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Địa điểm :";
            // 
            // gcPhieuHen
            // 
            this.gcPhieuHen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhieuHen.Location = new System.Drawing.Point(0, 0);
            this.gcPhieuHen.MainView = this.gvPhieuHen;
            this.gcPhieuHen.MenuManager = this.barManagerCV;
            this.gcPhieuHen.Name = "gcPhieuHen";
            this.gcPhieuHen.Size = new System.Drawing.Size(892, 556);
            this.gcPhieuHen.TabIndex = 0;
            this.gcPhieuHen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuHen});
            // 
            // gvPhieuHen
            // 
            this.gvPhieuHen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaPH,
            this.MaTN,
            this.HoTenTN,
            this.MaTK,
            this.HoTenNV,
            this.DIADIEM,
            this.NGAYGIO});
            this.gvPhieuHen.GridControl = this.gcPhieuHen;
            this.gvPhieuHen.Name = "gvPhieuHen";
            this.gvPhieuHen.OptionsView.ShowGroupPanel = false;
            this.gvPhieuHen.Click += new System.EventHandler(this.gvPhieuHen_Click);
            // 
            // MaPH
            // 
            this.MaPH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MaPH.AppearanceCell.Options.UseFont = true;
            this.MaPH.Caption = "ID";
            this.MaPH.FieldName = "MaPH";
            this.MaPH.MaxWidth = 50;
            this.MaPH.MinWidth = 50;
            this.MaPH.Name = "MaPH";
            this.MaPH.Visible = true;
            this.MaPH.VisibleIndex = 0;
            this.MaPH.Width = 50;
            // 
            // MaTN
            // 
            this.MaTN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MaTN.AppearanceCell.Options.UseFont = true;
            this.MaTN.Caption = "ID";
            this.MaTN.FieldName = "MaTN";
            this.MaTN.MaxWidth = 200;
            this.MaTN.MinWidth = 200;
            this.MaTN.Name = "MaTN";
            this.MaTN.Width = 200;
            // 
            // HoTenTN
            // 
            this.HoTenTN.Caption = "Khách Hàng";
            this.HoTenTN.FieldName = "HoTenTN";
            this.HoTenTN.MinWidth = 25;
            this.HoTenTN.Name = "HoTenTN";
            this.HoTenTN.Visible = true;
            this.HoTenTN.VisibleIndex = 1;
            this.HoTenTN.Width = 94;
            // 
            // MaTK
            // 
            this.MaTK.Caption = "ID";
            this.MaTK.FieldName = "MaTK";
            this.MaTK.MinWidth = 25;
            this.MaTK.Name = "MaTK";
            this.MaTK.Width = 94;
            // 
            // HoTenNV
            // 
            this.HoTenNV.Caption = "Nhân Viên";
            this.HoTenNV.FieldName = "HoTenNV";
            this.HoTenNV.MinWidth = 25;
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.Visible = true;
            this.HoTenNV.VisibleIndex = 2;
            this.HoTenNV.Width = 94;
            // 
            // DIADIEM
            // 
            this.DIADIEM.Caption = "Địa Điểm";
            this.DIADIEM.FieldName = "DIADIEM";
            this.DIADIEM.MinWidth = 25;
            this.DIADIEM.Name = "DIADIEM";
            this.DIADIEM.Visible = true;
            this.DIADIEM.VisibleIndex = 3;
            this.DIADIEM.Width = 94;
            // 
            // NGAYGIO
            // 
            this.NGAYGIO.Caption = "Ngày giờ";
            this.NGAYGIO.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.NGAYGIO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NGAYGIO.FieldName = "NGAYGIO";
            this.NGAYGIO.MinWidth = 25;
            this.NGAYGIO.Name = "NGAYGIO";
            this.NGAYGIO.Visible = true;
            this.NGAYGIO.VisibleIndex = 4;
            this.NGAYGIO.Width = 94;
            // 
            // frmPhieuHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 737);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuHen";
            this.Text = "Phiếu Hẹn";
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerCV)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaDiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuHen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuHen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDele;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TextEdit txtDiaDiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManagerCV;
        private DevExpress.XtraGrid.GridControl gcPhieuHen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuHen;
        private DevExpress.XtraGrid.Columns.GridColumn MaPH;
        private DevExpress.XtraGrid.Columns.GridColumn MaTN;
        private System.Windows.Forms.DateTimePicker dtNgayGio;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox cbxNV;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cbxKHTN;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn HoTenTN;
        private DevExpress.XtraGrid.Columns.GridColumn MaTK;
        private DevExpress.XtraGrid.Columns.GridColumn HoTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn DIADIEM;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYGIO;
    }
}