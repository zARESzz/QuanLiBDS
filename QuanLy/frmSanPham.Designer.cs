namespace QuanLy
{
    partial class frmSanPham
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
            this.gcBDS = new DevExpress.XtraGrid.GridControl();
            this.lvBDS = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.MaNC = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_MaNC = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.MaBDS = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_MaBDS = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.TenNC = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_TenNC = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.TenBDS = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_TenBDS = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.MaLoai = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_MaLoai = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.TenLoai = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_TenLoai = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.TenTT = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_TenTT = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.MaKH = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_MaKH = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.TenKH = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_TenKH = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.HinhAnh = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_HinhAnh = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.MaTT = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_MaTT = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.DienTich = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_DienTich = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.DinhGia = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_DinhGia = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.DiaChi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_DiaChi = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.GioiThieu = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_GioiThieu = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            ((System.ComponentModel.ISupportInitialize)(this.gcBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_MaNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_MaBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_TenNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_TenBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_MaLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_TenLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_TenTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_MaKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_TenKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_HinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_MaTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_DienTich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_DinhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_DiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_GioiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcBDS
            // 
            this.gcBDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBDS.Location = new System.Drawing.Point(0, 0);
            this.gcBDS.MainView = this.lvBDS;
            this.gcBDS.Name = "gcBDS";
            this.gcBDS.Size = new System.Drawing.Size(977, 636);
            this.gcBDS.TabIndex = 1;
            this.gcBDS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lvBDS});
            // 
            // lvBDS
            // 
            this.lvBDS.CardMinSize = new System.Drawing.Size(229, 608);
            this.lvBDS.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.MaNC,
            this.MaBDS,
            this.TenNC,
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
            this.DiaChi,
            this.GioiThieu});
            this.lvBDS.GridControl = this.gcBDS;
            this.lvBDS.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_MaKH,
            this.layoutViewField_MaLoai,
            this.layoutViewField_MaNC,
            this.layoutViewField_MaTT,
            this.layoutViewField_MaBDS});
            this.lvBDS.Name = "lvBDS";
            this.lvBDS.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.lvBDS.OptionsItemText.AlignMode = DevExpress.XtraGrid.Views.Layout.FieldTextAlignMode.AutoSize;
            this.lvBDS.OptionsItemText.TextToControlDistance = 0;
            this.lvBDS.OptionsView.ShowCardLines = false;
            this.lvBDS.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.lvBDS.TemplateCard = this.layoutViewCard1;
            // 
            // MaNC
            // 
            this.MaNC.Caption = "ID";
            this.MaNC.FieldName = "MaNC";
            this.MaNC.LayoutViewField = this.layoutViewField_MaNC;
            this.MaNC.MinWidth = 25;
            this.MaNC.Name = "MaNC";
            this.MaNC.Width = 94;
            // 
            // layoutViewField_MaNC
            // 
            this.layoutViewField_MaNC.EditorPreferredWidth = 20;
            this.layoutViewField_MaNC.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_MaNC.Name = "layoutViewField_MaNC";
            this.layoutViewField_MaNC.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_MaNC.Size = new System.Drawing.Size(217, 520);
            this.layoutViewField_MaNC.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_MaNC.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_MaNC.TextSize = new System.Drawing.Size(17, 16);
            // 
            // MaBDS
            // 
            this.MaBDS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MaBDS.AppearanceCell.Options.UseFont = true;
            this.MaBDS.Caption = "ID";
            this.MaBDS.FieldName = "MaBDS";
            this.MaBDS.LayoutViewField = this.layoutViewField_MaBDS;
            this.MaBDS.MaxWidth = 50;
            this.MaBDS.MinWidth = 50;
            this.MaBDS.Name = "MaBDS";
            this.MaBDS.Width = 50;
            // 
            // layoutViewField_MaBDS
            // 
            this.layoutViewField_MaBDS.EditorPreferredWidth = 20;
            this.layoutViewField_MaBDS.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_MaBDS.Name = "layoutViewField_MaBDS";
            this.layoutViewField_MaBDS.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_MaBDS.Size = new System.Drawing.Size(217, 520);
            this.layoutViewField_MaBDS.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_MaBDS.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_MaBDS.TextSize = new System.Drawing.Size(17, 16);
            // 
            // TenNC
            // 
            this.TenNC.Caption = "Nhu Cầu";
            this.TenNC.FieldName = "TenNC";
            this.TenNC.LayoutViewField = this.layoutViewField_TenNC;
            this.TenNC.MinWidth = 25;
            this.TenNC.Name = "TenNC";
            this.TenNC.Width = 94;
            // 
            // layoutViewField_TenNC
            // 
            this.layoutViewField_TenNC.EditorPreferredWidth = 203;
            this.layoutViewField_TenNC.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_TenNC.Name = "layoutViewField_TenNC";
            this.layoutViewField_TenNC.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_TenNC.Size = new System.Drawing.Size(219, 52);
            this.layoutViewField_TenNC.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_TenNC.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_TenNC.TextSize = new System.Drawing.Size(53, 16);
            // 
            // TenBDS
            // 
            this.TenBDS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TenBDS.AppearanceCell.Options.UseFont = true;
            this.TenBDS.Caption = "Tên ";
            this.TenBDS.FieldName = "TenBDS";
            this.TenBDS.LayoutViewField = this.layoutViewField_TenBDS;
            this.TenBDS.MaxWidth = 200;
            this.TenBDS.MinWidth = 200;
            this.TenBDS.Name = "TenBDS";
            this.TenBDS.Width = 200;
            // 
            // layoutViewField_TenBDS
            // 
            this.layoutViewField_TenBDS.EditorPreferredWidth = 203;
            this.layoutViewField_TenBDS.Location = new System.Drawing.Point(0, 52);
            this.layoutViewField_TenBDS.Name = "layoutViewField_TenBDS";
            this.layoutViewField_TenBDS.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_TenBDS.Size = new System.Drawing.Size(219, 52);
            this.layoutViewField_TenBDS.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_TenBDS.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_TenBDS.TextSize = new System.Drawing.Size(31, 16);
            // 
            // MaLoai
            // 
            this.MaLoai.Caption = "ID";
            this.MaLoai.FieldName = "MaLoai";
            this.MaLoai.LayoutViewField = this.layoutViewField_MaLoai;
            this.MaLoai.MinWidth = 25;
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.Width = 94;
            // 
            // layoutViewField_MaLoai
            // 
            this.layoutViewField_MaLoai.EditorPreferredWidth = 20;
            this.layoutViewField_MaLoai.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_MaLoai.Name = "layoutViewField_MaLoai";
            this.layoutViewField_MaLoai.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_MaLoai.Size = new System.Drawing.Size(217, 520);
            this.layoutViewField_MaLoai.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_MaLoai.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_MaLoai.TextSize = new System.Drawing.Size(17, 16);
            // 
            // TenLoai
            // 
            this.TenLoai.Caption = "Loại";
            this.TenLoai.FieldName = "TenLoai";
            this.TenLoai.LayoutViewField = this.layoutViewField_TenLoai;
            this.TenLoai.MinWidth = 25;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.Width = 94;
            // 
            // layoutViewField_TenLoai
            // 
            this.layoutViewField_TenLoai.EditorPreferredWidth = 203;
            this.layoutViewField_TenLoai.Location = new System.Drawing.Point(0, 104);
            this.layoutViewField_TenLoai.Name = "layoutViewField_TenLoai";
            this.layoutViewField_TenLoai.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_TenLoai.Size = new System.Drawing.Size(219, 52);
            this.layoutViewField_TenLoai.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_TenLoai.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_TenLoai.TextSize = new System.Drawing.Size(28, 16);
            // 
            // TenTT
            // 
            this.TenTT.Caption = "Tình Trạng";
            this.TenTT.FieldName = "TenTT";
            this.TenTT.LayoutViewField = this.layoutViewField_TenTT;
            this.TenTT.MinWidth = 25;
            this.TenTT.Name = "TenTT";
            this.TenTT.Width = 94;
            // 
            // layoutViewField_TenTT
            // 
            this.layoutViewField_TenTT.EditorPreferredWidth = 203;
            this.layoutViewField_TenTT.Location = new System.Drawing.Point(0, 156);
            this.layoutViewField_TenTT.Name = "layoutViewField_TenTT";
            this.layoutViewField_TenTT.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_TenTT.Size = new System.Drawing.Size(219, 52);
            this.layoutViewField_TenTT.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_TenTT.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_TenTT.TextSize = new System.Drawing.Size(68, 16);
            // 
            // MaKH
            // 
            this.MaKH.Caption = "ID";
            this.MaKH.FieldName = "MaKH";
            this.MaKH.LayoutViewField = this.layoutViewField_MaKH;
            this.MaKH.MinWidth = 25;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 94;
            // 
            // layoutViewField_MaKH
            // 
            this.layoutViewField_MaKH.EditorPreferredWidth = 20;
            this.layoutViewField_MaKH.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_MaKH.Name = "layoutViewField_MaKH";
            this.layoutViewField_MaKH.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_MaKH.Size = new System.Drawing.Size(217, 520);
            this.layoutViewField_MaKH.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_MaKH.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_MaKH.TextSize = new System.Drawing.Size(17, 16);
            // 
            // TenKH
            // 
            this.TenKH.Caption = "Khách Hàng";
            this.TenKH.FieldName = "TenKH";
            this.TenKH.LayoutViewField = this.layoutViewField_TenKH;
            this.TenKH.MinWidth = 25;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 94;
            // 
            // layoutViewField_TenKH
            // 
            this.layoutViewField_TenKH.EditorPreferredWidth = 203;
            this.layoutViewField_TenKH.Location = new System.Drawing.Point(0, 208);
            this.layoutViewField_TenKH.Name = "layoutViewField_TenKH";
            this.layoutViewField_TenKH.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_TenKH.Size = new System.Drawing.Size(219, 52);
            this.layoutViewField_TenKH.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_TenKH.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_TenKH.TextSize = new System.Drawing.Size(72, 16);
            // 
            // HinhAnh
            // 
            this.HinhAnh.Caption = "Hình Ảnh";
            this.HinhAnh.FieldName = "HinhAnh";
            this.HinhAnh.LayoutViewField = this.layoutViewField_HinhAnh;
            this.HinhAnh.MinWidth = 25;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Width = 94;
            // 
            // layoutViewField_HinhAnh
            // 
            this.layoutViewField_HinhAnh.EditorPreferredWidth = 203;
            this.layoutViewField_HinhAnh.Location = new System.Drawing.Point(0, 260);
            this.layoutViewField_HinhAnh.Name = "layoutViewField_HinhAnh";
            this.layoutViewField_HinhAnh.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_HinhAnh.Size = new System.Drawing.Size(219, 52);
            this.layoutViewField_HinhAnh.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_HinhAnh.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_HinhAnh.TextSize = new System.Drawing.Size(56, 16);
            // 
            // MaTT
            // 
            this.MaTT.Caption = "ID";
            this.MaTT.FieldName = "MaTT";
            this.MaTT.LayoutViewField = this.layoutViewField_MaTT;
            this.MaTT.MinWidth = 25;
            this.MaTT.Name = "MaTT";
            this.MaTT.Width = 94;
            // 
            // layoutViewField_MaTT
            // 
            this.layoutViewField_MaTT.EditorPreferredWidth = 20;
            this.layoutViewField_MaTT.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_MaTT.Name = "layoutViewField_MaTT";
            this.layoutViewField_MaTT.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_MaTT.Size = new System.Drawing.Size(217, 520);
            this.layoutViewField_MaTT.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_MaTT.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_MaTT.TextSize = new System.Drawing.Size(17, 16);
            // 
            // DienTich
            // 
            this.DienTich.Caption = "Diện Tích";
            this.DienTich.FieldName = "DienTich";
            this.DienTich.LayoutViewField = this.layoutViewField_DienTich;
            this.DienTich.MinWidth = 25;
            this.DienTich.Name = "DienTich";
            this.DienTich.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.DienTich.Width = 94;
            // 
            // layoutViewField_DienTich
            // 
            this.layoutViewField_DienTich.EditorPreferredWidth = 203;
            this.layoutViewField_DienTich.Location = new System.Drawing.Point(0, 312);
            this.layoutViewField_DienTich.Name = "layoutViewField_DienTich";
            this.layoutViewField_DienTich.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_DienTich.Size = new System.Drawing.Size(219, 52);
            this.layoutViewField_DienTich.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_DienTich.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_DienTich.TextSize = new System.Drawing.Size(58, 16);
            // 
            // DinhGia
            // 
            this.DinhGia.Caption = "Giá";
            this.DinhGia.FieldName = "DinhGia";
            this.DinhGia.LayoutViewField = this.layoutViewField_DinhGia;
            this.DinhGia.MinWidth = 25;
            this.DinhGia.Name = "DinhGia";
            this.DinhGia.Width = 94;
            // 
            // layoutViewField_DinhGia
            // 
            this.layoutViewField_DinhGia.EditorPreferredWidth = 203;
            this.layoutViewField_DinhGia.Location = new System.Drawing.Point(0, 364);
            this.layoutViewField_DinhGia.Name = "layoutViewField_DinhGia";
            this.layoutViewField_DinhGia.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_DinhGia.Size = new System.Drawing.Size(219, 52);
            this.layoutViewField_DinhGia.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_DinhGia.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_DinhGia.TextSize = new System.Drawing.Size(23, 16);
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.LayoutViewField = this.layoutViewField_DiaChi;
            this.DiaChi.MinWidth = 25;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 94;
            // 
            // layoutViewField_DiaChi
            // 
            this.layoutViewField_DiaChi.EditorPreferredWidth = 203;
            this.layoutViewField_DiaChi.Location = new System.Drawing.Point(0, 416);
            this.layoutViewField_DiaChi.Name = "layoutViewField_DiaChi";
            this.layoutViewField_DiaChi.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_DiaChi.Size = new System.Drawing.Size(219, 52);
            this.layoutViewField_DiaChi.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_DiaChi.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_DiaChi.TextSize = new System.Drawing.Size(46, 16);
            // 
            // GioiThieu
            // 
            this.GioiThieu.Caption = "Giới Thiệu";
            this.GioiThieu.FieldName = "GioiThieu";
            this.GioiThieu.LayoutViewField = this.layoutViewField_GioiThieu;
            this.GioiThieu.MinWidth = 25;
            this.GioiThieu.Name = "GioiThieu";
            this.GioiThieu.Width = 94;
            // 
            // layoutViewField_GioiThieu
            // 
            this.layoutViewField_GioiThieu.EditorPreferredWidth = 203;
            this.layoutViewField_GioiThieu.Location = new System.Drawing.Point(0, 468);
            this.layoutViewField_GioiThieu.Name = "layoutViewField_GioiThieu";
            this.layoutViewField_GioiThieu.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_GioiThieu.Size = new System.Drawing.Size(219, 102);
            this.layoutViewField_GioiThieu.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_GioiThieu.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_GioiThieu.TextSize = new System.Drawing.Size(62, 16);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_TenNC,
            this.layoutViewField_TenBDS,
            this.layoutViewField_TenLoai,
            this.layoutViewField_TenTT,
            this.layoutViewField_TenKH,
            this.layoutViewField_HinhAnh,
            this.layoutViewField_DienTich,
            this.layoutViewField_DinhGia,
            this.layoutViewField_DiaChi,
            this.layoutViewField_GioiThieu});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 0;
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 636);
            this.Controls.Add(this.gcBDS);
            this.Name = "frmSanPham";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_MaNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_MaBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_TenNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_TenBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_MaLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_TenLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_TenTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_MaKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_TenKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_HinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_MaTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_DienTich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_DinhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_DiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_GioiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcBDS;
        private DevExpress.XtraGrid.Views.Layout.LayoutView lvBDS;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn MaNC;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn TenNC;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn MaBDS;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn TenBDS;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn MaLoai;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn TenLoai;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn TenTT;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn MaKH;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn TenKH;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn HinhAnh;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn MaTT;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn DienTich;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn DinhGia;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn DiaChi;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn GioiThieu;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_MaNC;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_MaBDS;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_TenNC;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_TenBDS;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_MaLoai;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_TenLoai;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_TenTT;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_MaKH;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_TenKH;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_HinhAnh;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_MaTT;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_DienTich;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_DinhGia;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_DiaChi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_GioiThieu;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}