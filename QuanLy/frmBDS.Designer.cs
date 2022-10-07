namespace QuanLy
{
    partial class frmBDS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBDS));
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
            this.btnHinhAnh = new DevExpress.XtraEditors.SimpleButton();
            this.txtGioiThieu = new System.Windows.Forms.TextBox();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.cbxKhachHang = new System.Windows.Forms.ComboBox();
            this.cbxTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbxNhuCau = new System.Windows.Forms.ComboBox();
            this.cbxLoai = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDienTich = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDieuKien = new DevExpress.XtraEditors.TextEdit();
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcBDS = new DevExpress.XtraGrid.GridControl();
            this.gvBDS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaBDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenBDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HinhAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienTich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DinhGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DieuKien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienTich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDieuKien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBDS)).BeginInit();
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
            this.bar1.FloatLocation = new System.Drawing.Point(526, 162);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1144, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 717);
            this.barDockControlBottom.Manager = this.barManagerCV;
            this.barDockControlBottom.Size = new System.Drawing.Size(1144, 20);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1144, 30);
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
            this.splitContainer1.Panel1.Controls.Add(this.btnHinhAnh);
            this.splitContainer1.Panel1.Controls.Add(this.txtGioiThieu);
            this.splitContainer1.Panel1.Controls.Add(this.picHinhAnh);
            this.splitContainer1.Panel1.Controls.Add(this.cbxKhachHang);
            this.splitContainer1.Panel1.Controls.Add(this.cbxTinhTrang);
            this.splitContainer1.Panel1.Controls.Add(this.cbxNhuCau);
            this.splitContainer1.Panel1.Controls.Add(this.cbxLoai);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.txtDiaChi);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.txtDienTich);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.txtDieuKien);
            this.splitContainer1.Panel1.Controls.Add(this.txtGia);
            this.splitContainer1.Panel1.Controls.Add(this.txtTen);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl10);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcBDS);
            this.splitContainer1.Size = new System.Drawing.Size(1144, 687);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnHinhAnh
            // 
            this.btnHinhAnh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHinhAnh.ImageOptions.SvgImage")));
            this.btnHinhAnh.Location = new System.Drawing.Point(49, 270);
            this.btnHinhAnh.Name = "btnHinhAnh";
            this.btnHinhAnh.Size = new System.Drawing.Size(135, 39);
            this.btnHinhAnh.TabIndex = 5;
            this.btnHinhAnh.Text = "Chọn Hình";
            this.btnHinhAnh.Click += new System.EventHandler(this.btnHinhAnh_Click);
            // 
            // txtGioiThieu
            // 
            this.txtGioiThieu.Location = new System.Drawing.Point(703, 152);
            this.txtGioiThieu.Multiline = true;
            this.txtGioiThieu.Name = "txtGioiThieu";
            this.txtGioiThieu.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGioiThieu.Size = new System.Drawing.Size(410, 177);
            this.txtGioiThieu.TabIndex = 4;
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Image = global::QuanLy.Properties.Resources.th;
            this.picHinhAnh.Location = new System.Drawing.Point(11, 20);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(221, 225);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinhAnh.TabIndex = 3;
            this.picHinhAnh.TabStop = false;
            // 
            // cbxKhachHang
            // 
            this.cbxKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhachHang.FormattingEnabled = true;
            this.cbxKhachHang.Location = new System.Drawing.Point(416, 199);
            this.cbxKhachHang.Name = "cbxKhachHang";
            this.cbxKhachHang.Size = new System.Drawing.Size(250, 32);
            this.cbxKhachHang.TabIndex = 2;
            // 
            // cbxTinhTrang
            // 
            this.cbxTinhTrang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTinhTrang.FormattingEnabled = true;
            this.cbxTinhTrang.Location = new System.Drawing.Point(416, 152);
            this.cbxTinhTrang.Name = "cbxTinhTrang";
            this.cbxTinhTrang.Size = new System.Drawing.Size(250, 32);
            this.cbxTinhTrang.TabIndex = 2;
            // 
            // cbxNhuCau
            // 
            this.cbxNhuCau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNhuCau.FormattingEnabled = true;
            this.cbxNhuCau.Location = new System.Drawing.Point(416, 6);
            this.cbxNhuCau.Name = "cbxNhuCau";
            this.cbxNhuCau.Size = new System.Drawing.Size(250, 32);
            this.cbxNhuCau.TabIndex = 2;
            // 
            // cbxLoai
            // 
            this.cbxLoai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoai.FormattingEnabled = true;
            this.cbxLoai.Location = new System.Drawing.Point(416, 101);
            this.cbxLoai.Name = "cbxLoai";
            this.cbxLoai.Size = new System.Drawing.Size(250, 32);
            this.cbxLoai.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(691, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(116, 28);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Giới Thiệu :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(851, 6);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(250, 34);
            this.txtDiaChi.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(691, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 28);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Địa Chỉ :";
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(416, 247);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienTich.Properties.Appearance.Options.UseFont = true;
            this.txtDienTich.Size = new System.Drawing.Size(250, 34);
            this.txtDienTich.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(257, 250);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 28);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Diện Tích :";
            // 
            // txtDieuKien
            // 
            this.txtDieuKien.Location = new System.Drawing.Point(851, 50);
            this.txtDieuKien.Name = "txtDieuKien";
            this.txtDieuKien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDieuKien.Properties.Appearance.Options.UseFont = true;
            this.txtDieuKien.Size = new System.Drawing.Size(250, 34);
            this.txtDieuKien.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(416, 295);
            this.txtGia.Name = "txtGia";
            this.txtGia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Properties.Appearance.Options.UseFont = true;
            this.txtGia.Size = new System.Drawing.Size(250, 34);
            this.txtGia.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(416, 50);
            this.txtTen.MenuManager = this.barManagerCV;
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(250, 34);
            this.txtTen.TabIndex = 1;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(256, 152);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(125, 28);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Tình Trạng :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(256, 10);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(102, 28);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Nhu Cầu :";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(691, 53);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(112, 28);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Điều Kiện :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(256, 203);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(139, 28);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Khách Hàng :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(256, 301);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 28);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Giá :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(256, 105);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 28);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Loại :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(256, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên :";
            // 
            // gcBDS
            // 
            this.gcBDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBDS.Location = new System.Drawing.Point(0, 0);
            this.gcBDS.MainView = this.gvBDS;
            this.gcBDS.MenuManager = this.barManagerCV;
            this.gcBDS.Name = "gcBDS";
            this.gcBDS.Size = new System.Drawing.Size(1144, 341);
            this.gcBDS.TabIndex = 0;
            this.gcBDS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBDS});
            // 
            // gvBDS
            // 
            this.gvBDS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNC,
            this.TenNC,
            this.MaBDS,
            this.TenBDS,
            this.MaLoai,
            this.TenLoai,
            this.TenTT,
            this.MaKH,
            this.TenKH,
            this.HinhAnh,
            this.MaTT,
            this.DienTich,
            this.DinhGia,
            this.DieuKien,
            this.DiaChi,
            this.GioiThieu});
            this.gvBDS.GridControl = this.gcBDS;
            this.gvBDS.Name = "gvBDS";
            this.gvBDS.OptionsView.ShowGroupPanel = false;
            this.gvBDS.Click += new System.EventHandler(this.gvBDS_Click);
            // 
            // MaNC
            // 
            this.MaNC.Caption = "ID";
            this.MaNC.FieldName = "MaNC";
            this.MaNC.MinWidth = 25;
            this.MaNC.Name = "MaNC";
            this.MaNC.Width = 94;
            // 
            // TenNC
            // 
            this.TenNC.Caption = "Nhu Cầu";
            this.TenNC.FieldName = "TenNC";
            this.TenNC.MinWidth = 25;
            this.TenNC.Name = "TenNC";
            this.TenNC.Visible = true;
            this.TenNC.VisibleIndex = 0;
            this.TenNC.Width = 94;
            // 
            // MaBDS
            // 
            this.MaBDS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MaBDS.AppearanceCell.Options.UseFont = true;
            this.MaBDS.Caption = "ID";
            this.MaBDS.FieldName = "MaBDS";
            this.MaBDS.MaxWidth = 50;
            this.MaBDS.MinWidth = 50;
            this.MaBDS.Name = "MaBDS";
            this.MaBDS.Width = 50;
            // 
            // TenBDS
            // 
            this.TenBDS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TenBDS.AppearanceCell.Options.UseFont = true;
            this.TenBDS.Caption = "Tên ";
            this.TenBDS.FieldName = "TenBDS";
            this.TenBDS.MaxWidth = 200;
            this.TenBDS.MinWidth = 200;
            this.TenBDS.Name = "TenBDS";
            this.TenBDS.Visible = true;
            this.TenBDS.VisibleIndex = 1;
            this.TenBDS.Width = 200;
            // 
            // MaLoai
            // 
            this.MaLoai.Caption = "ID";
            this.MaLoai.FieldName = "MaLoai";
            this.MaLoai.MinWidth = 25;
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.Width = 94;
            // 
            // TenLoai
            // 
            this.TenLoai.Caption = "Loại";
            this.TenLoai.FieldName = "TenLoai";
            this.TenLoai.MinWidth = 25;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.Visible = true;
            this.TenLoai.VisibleIndex = 2;
            this.TenLoai.Width = 94;
            // 
            // TenTT
            // 
            this.TenTT.Caption = "Tình Trạng";
            this.TenTT.FieldName = "TenTT";
            this.TenTT.MinWidth = 25;
            this.TenTT.Name = "TenTT";
            this.TenTT.Visible = true;
            this.TenTT.VisibleIndex = 3;
            this.TenTT.Width = 94;
            // 
            // MaKH
            // 
            this.MaKH.Caption = "ID";
            this.MaKH.FieldName = "MaKH";
            this.MaKH.MinWidth = 25;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 94;
            // 
            // TenKH
            // 
            this.TenKH.Caption = "Khách Hàng";
            this.TenKH.FieldName = "TenKH";
            this.TenKH.MinWidth = 25;
            this.TenKH.Name = "TenKH";
            this.TenKH.Visible = true;
            this.TenKH.VisibleIndex = 4;
            this.TenKH.Width = 94;
            // 
            // HinhAnh
            // 
            this.HinhAnh.Caption = "Hình Ảnh";
            this.HinhAnh.FieldName = "HinhAnh";
            this.HinhAnh.MinWidth = 25;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Visible = true;
            this.HinhAnh.VisibleIndex = 5;
            this.HinhAnh.Width = 94;
            // 
            // MaTT
            // 
            this.MaTT.Caption = "ID";
            this.MaTT.FieldName = "MaTT";
            this.MaTT.MinWidth = 25;
            this.MaTT.Name = "MaTT";
            this.MaTT.Width = 94;
            // 
            // DienTich
            // 
            this.DienTich.Caption = "Diện Tích";
            this.DienTich.FieldName = "DienTich";
            this.DienTich.MinWidth = 25;
            this.DienTich.Name = "DienTich";
            this.DienTich.Visible = true;
            this.DienTich.VisibleIndex = 6;
            this.DienTich.Width = 94;
            // 
            // DinhGia
            // 
            this.DinhGia.Caption = "Giá";
            this.DinhGia.FieldName = "DinhGia";
            this.DinhGia.MinWidth = 25;
            this.DinhGia.Name = "DinhGia";
            this.DinhGia.Visible = true;
            this.DinhGia.VisibleIndex = 7;
            this.DinhGia.Width = 94;
            // 
            // DieuKien
            // 
            this.DieuKien.Caption = "Điều Kiện";
            this.DieuKien.FieldName = "DieuKien";
            this.DieuKien.MinWidth = 25;
            this.DieuKien.Name = "DieuKien";
            this.DieuKien.Visible = true;
            this.DieuKien.VisibleIndex = 8;
            this.DieuKien.Width = 94;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MinWidth = 25;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 9;
            this.DiaChi.Width = 94;
            // 
            // GioiThieu
            // 
            this.GioiThieu.Caption = "Giới Thiệu";
            this.GioiThieu.FieldName = "GioiThieu";
            this.GioiThieu.MinWidth = 25;
            this.GioiThieu.Name = "GioiThieu";
            this.GioiThieu.Visible = true;
            this.GioiThieu.VisibleIndex = 10;
            this.GioiThieu.Width = 94;
            // 
            // frmBDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 737);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBDS";
            this.Text = "Chức Vụ";
            this.Load += new System.EventHandler(this.frmBDS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerCV)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienTich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDieuKien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBDS)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManagerCV;
        private DevExpress.XtraGrid.GridControl gcBDS;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBDS;
        private DevExpress.XtraGrid.Columns.GridColumn MaBDS;
        private DevExpress.XtraGrid.Columns.GridColumn TenBDS;
        private DevExpress.XtraEditors.TextEdit txtDienTich;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.ComboBox cbxKhachHang;
        private System.Windows.Forms.ComboBox cbxLoai;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtGioiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoai;
        private DevExpress.XtraGrid.Columns.GridColumn MaKH;
        private DevExpress.XtraGrid.Columns.GridColumn TenKH;
        private DevExpress.XtraGrid.Columns.GridColumn DienTich;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn GioiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn HinhAnh;
        private DevExpress.XtraEditors.SimpleButton btnHinhAnh;
        private System.Windows.Forms.ComboBox cbxTinhTrang;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn MaTT;
        private DevExpress.XtraGrid.Columns.GridColumn TenTT;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbxNhuCau;
        private DevExpress.XtraEditors.TextEdit txtDieuKien;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.Columns.GridColumn MaNC;
        private DevExpress.XtraGrid.Columns.GridColumn TenNC;
        private DevExpress.XtraGrid.Columns.GridColumn DieuKien;
        private DevExpress.XtraGrid.Columns.GridColumn DinhGia;
    }
}