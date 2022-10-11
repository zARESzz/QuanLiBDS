namespace QuanLy
{
    partial class frmLoaiBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiBD));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcLoaiBD = new DevExpress.XtraGrid.GridControl();
            this.gvLoaiBD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManagerTT = new DevExpress.XtraBars.BarManager(this.components);
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
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManagerCV = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl9 = new DevExpress.XtraBars.BarDockControl();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerCV)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtTen);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcLoaiBD);
            this.splitContainer1.Size = new System.Drawing.Size(892, 687);
            this.splitContainer1.SplitterDistance = 122;
            this.splitContainer1.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(140, 36);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(285, 34);
            this.txtTen.TabIndex = 1;
            this.txtTen.EditValueChanged += new System.EventHandler(this.txtTen_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(81, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên :";
            // 
            // gcLoaiBD
            // 
            this.gcLoaiBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLoaiBD.Location = new System.Drawing.Point(0, 0);
            this.gcLoaiBD.MainView = this.gvLoaiBD;
            this.gcLoaiBD.Name = "gcLoaiBD";
            this.gcLoaiBD.Size = new System.Drawing.Size(892, 561);
            this.gcLoaiBD.TabIndex = 0;
            this.gcLoaiBD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoaiBD});
            // 
            // gvLoaiBD
            // 
            this.gvLoaiBD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLoai,
            this.TenLoai});
            this.gvLoaiBD.GridControl = this.gcLoaiBD;
            this.gvLoaiBD.Name = "gvLoaiBD";
            this.gvLoaiBD.OptionsView.ShowGroupPanel = false;
            this.gvLoaiBD.Click += new System.EventHandler(this.gvLoaiBD_Click);
            // 
            // MaLoai
            // 
            this.MaLoai.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MaLoai.AppearanceCell.Options.UseFont = true;
            this.MaLoai.Caption = "ID";
            this.MaLoai.FieldName = "MaLoai";
            this.MaLoai.MaxWidth = 50;
            this.MaLoai.MinWidth = 50;
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.Visible = true;
            this.MaLoai.VisibleIndex = 0;
            this.MaLoai.Width = 50;
            // 
            // TenLoai
            // 
            this.TenLoai.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TenLoai.AppearanceCell.Options.UseFont = true;
            this.TenLoai.Caption = "Tên ";
            this.TenLoai.FieldName = "TenLoai";
            this.TenLoai.MaxWidth = 200;
            this.TenLoai.MinWidth = 200;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.Visible = true;
            this.TenLoai.VisibleIndex = 1;
            this.TenLoai.Width = 200;
            // 
            // barManagerTT
            // 
            this.barManagerTT.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManagerTT.DockControls.Add(this.barDockControlTop);
            this.barManagerTT.DockControls.Add(this.barDockControlBottom);
            this.barManagerTT.DockControls.Add(this.barDockControlLeft);
            this.barManagerTT.DockControls.Add(this.barDockControlRight);
            this.barManagerTT.Form = this;
            this.barManagerTT.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnEdit,
            this.btnDele,
            this.btnSave,
            this.btnHuy,
            this.btnDong});
            this.barManagerTT.MaxItemId = 6;
            this.barManagerTT.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.AutoUpdateMergedBars = DevExpress.Utils.DefaultBoolean.True;
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(615, 153);
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
            this.barDockControlTop.Manager = this.barManagerTT;
            this.barDockControlTop.Size = new System.Drawing.Size(892, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 717);
            this.barDockControlBottom.Manager = this.barManagerTT;
            this.barDockControlBottom.Size = new System.Drawing.Size(892, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManagerTT;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 687);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(892, 30);
            this.barDockControlRight.Manager = this.barManagerTT;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 687);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Lưu";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar2
            // 
            this.bar2.AutoUpdateMergedBars = DevExpress.Utils.DefaultBoolean.True;
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(310, 202);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDele, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.Text = "Tools";
            // 
            // barManagerCV
            // 
            this.barManagerCV.DockControls.Add(this.barDockControl6);
            this.barManagerCV.DockControls.Add(this.barDockControl7);
            this.barManagerCV.DockControls.Add(this.barDockControl8);
            this.barManagerCV.DockControls.Add(this.barDockControl9);
            this.barManagerCV.Form = this;
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl6.Location = new System.Drawing.Point(0, 0);
            this.barDockControl6.Manager = this.barManagerCV;
            this.barDockControl6.Size = new System.Drawing.Size(892, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl7.Location = new System.Drawing.Point(0, 737);
            this.barDockControl7.Manager = this.barManagerCV;
            this.barDockControl7.Size = new System.Drawing.Size(892, 0);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl8.Location = new System.Drawing.Point(0, 0);
            this.barDockControl8.Manager = this.barManagerCV;
            this.barDockControl8.Size = new System.Drawing.Size(0, 737);
            // 
            // barDockControl9
            // 
            this.barDockControl9.CausesValidation = false;
            this.barDockControl9.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl9.Location = new System.Drawing.Point(892, 0);
            this.barDockControl9.Manager = this.barManagerCV;
            this.barDockControl9.Size = new System.Drawing.Size(0, 737);
            // 
            // bar4
            // 
            this.bar4.DockCol = 0;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 30);
            this.barDockControl1.Manager = this.barManagerCV;
            this.barDockControl1.Size = new System.Drawing.Size(892, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 717);
            this.barDockControl2.Manager = this.barManagerCV;
            this.barDockControl2.Size = new System.Drawing.Size(892, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 30);
            this.barDockControl3.Manager = this.barManagerCV;
            this.barDockControl3.Size = new System.Drawing.Size(0, 687);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(892, 30);
            this.barDockControl4.Manager = this.barManagerCV;
            this.barDockControl4.Size = new System.Drawing.Size(0, 687);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.barManagerCV;
            this.barDockControl5.Size = new System.Drawing.Size(0, 0);
            // 
            // frmLoaiBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 737);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl9);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl6);
            this.Name = "frmLoaiBD";
            this.Text = "Loại Bất Động Sản";
            this.Load += new System.EventHandler(this.frmTinhTrang_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcLoaiBD;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoaiBD;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoai;
        private DevExpress.XtraBars.BarManager barManagerTT;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDele;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarManager barManagerCV;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.BarDockControl barDockControl9;
    }
}