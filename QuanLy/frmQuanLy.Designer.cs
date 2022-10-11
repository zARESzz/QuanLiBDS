namespace QuanLy
{
    partial class frmQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy));
            this.rbQuanLy = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnTinhTrang = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoai = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhuCau = new DevExpress.XtraBars.BarButtonItem();
            this.btnBatDongSan = new DevExpress.XtraBars.BarButtonItem();
            this.btnHopDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnThanhToan = new DevExpress.XtraBars.BarButtonItem();
            this.rbQLNS = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQLKH = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQLBDS = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBDS = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.rbQuanLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbQuanLy
            // 
            this.rbQuanLy.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.rbQuanLy.ExpandCollapseItem.Id = 0;
            this.rbQuanLy.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbQuanLy.ExpandCollapseItem,
            this.rbQuanLy.SearchEditItem,
            this.btnChucVu,
            this.btnNhanVien,
            this.btnKhachHang,
            this.btnTinhTrang,
            this.btnLoai,
            this.btnNhuCau,
            this.btnBatDongSan,
            this.btnHopDong,
            this.btnThanhToan});
            this.rbQuanLy.Location = new System.Drawing.Point(0, 0);
            this.rbQuanLy.Margin = new System.Windows.Forms.Padding(4);
            this.rbQuanLy.MaxItemId = 16;
            this.rbQuanLy.Name = "rbQuanLy";
            this.rbQuanLy.OptionsMenuMinWidth = 385;
            this.rbQuanLy.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbQLNS,
            this.rbQLKH,
            this.rbQLBDS,
            this.rbBDS});
            this.rbQuanLy.Size = new System.Drawing.Size(1141, 193);
            // 
            // btnChucVu
            // 
            this.btnChucVu.Caption = "Chức Vụ";
            this.btnChucVu.Id = 1;
            this.btnChucVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChucVu.ImageOptions.Image")));
            this.btnChucVu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChucVu.ImageOptions.LargeImage")));
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnChucVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChucVu_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân Viên";
            this.btnNhanVien.Id = 2;
            this.btnNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.Image")));
            this.btnNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.LargeImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách Hàng";
            this.btnKhachHang.Id = 7;
            this.btnKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.Image")));
            this.btnKhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.LargeImage")));
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // btnTinhTrang
            // 
            this.btnTinhTrang.Caption = "Tình Trạng";
            this.btnTinhTrang.Id = 8;
            this.btnTinhTrang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTinhTrang.ImageOptions.SvgImage")));
            this.btnTinhTrang.Name = "btnTinhTrang";
            this.btnTinhTrang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTinhTrang_ItemClick);
            // 
            // btnLoai
            // 
            this.btnLoai.Caption = "Loại ";
            this.btnLoai.Id = 9;
            this.btnLoai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoai.ImageOptions.SvgImage")));
            this.btnLoai.Name = "btnLoai";
            this.btnLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoai_ItemClick);
            // 
            // btnNhuCau
            // 
            this.btnNhuCau.Caption = "Nhu Cầu";
            this.btnNhuCau.Id = 10;
            this.btnNhuCau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhuCau.ImageOptions.SvgImage")));
            this.btnNhuCau.Name = "btnNhuCau";
            this.btnNhuCau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhuCau_ItemClick);
            // 
            // btnBatDongSan
            // 
            this.btnBatDongSan.Caption = "Bất Động Sản";
            this.btnBatDongSan.Id = 11;
            this.btnBatDongSan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBatDongSan.ImageOptions.SvgImage")));
            this.btnBatDongSan.Name = "btnBatDongSan";
            this.btnBatDongSan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBatDongSan_ItemClick);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Caption = "Hợp Đồng";
            this.btnHopDong.Id = 13;
            this.btnHopDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHopDong.ImageOptions.SvgImage")));
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHopDong_ItemClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Caption = "Thanh Toán";
            this.btnThanhToan.Id = 15;
            this.btnThanhToan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThanhToan.ImageOptions.SvgImage")));
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThanhToan_ItemClick);
            // 
            // rbQLNS
            // 
            this.rbQLNS.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbQLNS.Name = "rbQLNS";
            this.rbQLNS.Text = "Quản Lý Nhân Sự";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChucVu, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhanVien, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Danh mục nhân sự";
            // 
            // rbQLKH
            // 
            this.rbQLKH.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.rbQLKH.Name = "rbQLKH";
            this.rbQLKH.Text = "Quản Lý Khách Hàng";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.btnKhachHang, true);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Danh mục khách hàng";
            // 
            // rbQLBDS
            // 
            this.rbQLBDS.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.rbQLBDS.Name = "rbQLBDS";
            this.rbQLBDS.Text = "Quản Lý Bất Động Sản";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTinhTrang, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLoai, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhuCau, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh mục bất động sản";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.btnBatDongSan);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Quản Lý";
            // 
            // rbBDS
            // 
            this.rbBDS.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.rbBDS.Name = "rbBDS";
            this.rbBDS.Text = "Quản Lý Hợp Đồng";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.ItemLinks.Add(this.btnHopDong);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnThanhToan);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Danh mục hợp đồng";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.rbQuanLy;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnChucVu, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNhanVien, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Danh mục dùng chung";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnChucVu, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnNhanVien, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Danh mục dùng chung";
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 748);
            this.Controls.Add(this.rbQuanLy);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLy";
            this.Ribbon = this.rbQuanLy;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.rbQuanLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage rbQLNS;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnChucVu;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbQLBDS;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbQLKH;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnTinhTrang;
        private DevExpress.XtraBars.BarButtonItem btnLoai;
        private DevExpress.XtraBars.BarButtonItem btnNhuCau;
        private DevExpress.XtraBars.BarButtonItem btnBatDongSan;
        private DevExpress.XtraBars.BarButtonItem btnHopDong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbBDS;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnThanhToan;
        private DevExpress.XtraBars.Ribbon.RibbonControl rbQuanLy;
    }
}

