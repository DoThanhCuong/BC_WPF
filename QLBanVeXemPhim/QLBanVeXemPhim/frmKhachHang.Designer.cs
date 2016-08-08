namespace QLBanVeXemPhim
{
    partial class frmKhachHang
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
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new QLBanVeXemPhim.Data();
            this.khachHangTableAdapter = new QLBanVeXemPhim.DataTableAdapters.KhachHangTableAdapter();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.MaKhachHangTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForMaKhachHang = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.UserNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.HoTenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForHoTen = new DevExpress.XtraLayout.LayoutControlItem();
            this.NgaySinhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForNgaySinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.DiaChiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForDiaChi = new DevExpress.XtraLayout.LayoutControlItem();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.SoDienThoaiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForSoDienThoai = new DevExpress.XtraLayout.LayoutControlItem();
            this.GioiTinhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForGioiTinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colMaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhachHangTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoTenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoDienThoaiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSoDienThoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GioiTinhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInsert, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.toolbar.OptionsBar.AllowQuickCustomization = false;
            this.toolbar.OptionsBar.DrawDragBorder = false;
            this.toolbar.OptionsBar.UseWholeRow = true;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.data;
            // 
            // data
            // 
            this.data.DataSetName = "Data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.MaKhachHangTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UserNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.HoTenTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NgaySinhDateEdit);
            this.dataLayoutControl1.Controls.Add(this.DiaChiTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SoDienThoaiTextEdit);
            this.dataLayoutControl1.Controls.Add(this.GioiTinhTextEdit);
            this.dataLayoutControl1.DataSource = this.khachHangBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 35);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dataLayoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.dataLayoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.dataLayoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(945, 651);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(945, 651);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // MaKhachHangTextEdit
            // 
            this.MaKhachHangTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "MaKhachHang", true));
            this.MaKhachHangTextEdit.Location = new System.Drawing.Point(116, 46);
            this.MaKhachHangTextEdit.MenuManager = this.barManager;
            this.MaKhachHangTextEdit.Name = "MaKhachHangTextEdit";
            this.MaKhachHangTextEdit.Size = new System.Drawing.Size(354, 22);
            this.MaKhachHangTextEdit.StyleController = this.dataLayoutControl1;
            this.MaKhachHangTextEdit.TabIndex = 4;
            // 
            // ItemForMaKhachHang
            // 
            this.ItemForMaKhachHang.Control = this.MaKhachHangTextEdit;
            this.ItemForMaKhachHang.Location = new System.Drawing.Point(0, 0);
            this.ItemForMaKhachHang.Name = "ItemForMaKhachHang";
            this.ItemForMaKhachHang.Size = new System.Drawing.Size(450, 26);
            this.ItemForMaKhachHang.Text = "Ma Khach Hang";
            this.ItemForMaKhachHang.TextSize = new System.Drawing.Size(88, 16);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(925, 631);
            // 
            // UserNameTextEdit
            // 
            this.UserNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "UserName", true));
            this.UserNameTextEdit.Location = new System.Drawing.Point(116, 72);
            this.UserNameTextEdit.MenuManager = this.barManager;
            this.UserNameTextEdit.Name = "UserNameTextEdit";
            this.UserNameTextEdit.Size = new System.Drawing.Size(805, 22);
            this.UserNameTextEdit.StyleController = this.dataLayoutControl1;
            this.UserNameTextEdit.TabIndex = 5;
            // 
            // ItemForUserName
            // 
            this.ItemForUserName.Control = this.UserNameTextEdit;
            this.ItemForUserName.Location = new System.Drawing.Point(0, 26);
            this.ItemForUserName.Name = "ItemForUserName";
            this.ItemForUserName.Size = new System.Drawing.Size(901, 26);
            this.ItemForUserName.Text = "User Name";
            this.ItemForUserName.TextSize = new System.Drawing.Size(88, 16);
            // 
            // HoTenTextEdit
            // 
            this.HoTenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "HoTen", true));
            this.HoTenTextEdit.Location = new System.Drawing.Point(566, 46);
            this.HoTenTextEdit.MenuManager = this.barManager;
            this.HoTenTextEdit.Name = "HoTenTextEdit";
            this.HoTenTextEdit.Size = new System.Drawing.Size(355, 22);
            this.HoTenTextEdit.StyleController = this.dataLayoutControl1;
            this.HoTenTextEdit.TabIndex = 6;
            // 
            // ItemForHoTen
            // 
            this.ItemForHoTen.Control = this.HoTenTextEdit;
            this.ItemForHoTen.Location = new System.Drawing.Point(450, 0);
            this.ItemForHoTen.Name = "ItemForHoTen";
            this.ItemForHoTen.Size = new System.Drawing.Size(451, 26);
            this.ItemForHoTen.Text = "Ho Ten";
            this.ItemForHoTen.TextSize = new System.Drawing.Size(88, 16);
            // 
            // NgaySinhDateEdit
            // 
            this.NgaySinhDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "NgaySinh", true));
            this.NgaySinhDateEdit.EditValue = null;
            this.NgaySinhDateEdit.Location = new System.Drawing.Point(116, 98);
            this.NgaySinhDateEdit.MenuManager = this.barManager;
            this.NgaySinhDateEdit.Name = "NgaySinhDateEdit";
            this.NgaySinhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgaySinhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgaySinhDateEdit.Size = new System.Drawing.Size(354, 22);
            this.NgaySinhDateEdit.StyleController = this.dataLayoutControl1;
            this.NgaySinhDateEdit.TabIndex = 7;
            // 
            // ItemForNgaySinh
            // 
            this.ItemForNgaySinh.Control = this.NgaySinhDateEdit;
            this.ItemForNgaySinh.Location = new System.Drawing.Point(0, 52);
            this.ItemForNgaySinh.Name = "ItemForNgaySinh";
            this.ItemForNgaySinh.Size = new System.Drawing.Size(450, 26);
            this.ItemForNgaySinh.Text = "Ngay Sinh";
            this.ItemForNgaySinh.TextSize = new System.Drawing.Size(88, 16);
            // 
            // DiaChiTextEdit
            // 
            this.DiaChiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "DiaChi", true));
            this.DiaChiTextEdit.Location = new System.Drawing.Point(116, 124);
            this.DiaChiTextEdit.MenuManager = this.barManager;
            this.DiaChiTextEdit.Name = "DiaChiTextEdit";
            this.DiaChiTextEdit.Size = new System.Drawing.Size(805, 22);
            this.DiaChiTextEdit.StyleController = this.dataLayoutControl1;
            this.DiaChiTextEdit.TabIndex = 8;
            // 
            // ItemForDiaChi
            // 
            this.ItemForDiaChi.Control = this.DiaChiTextEdit;
            this.ItemForDiaChi.Location = new System.Drawing.Point(0, 78);
            this.ItemForDiaChi.Name = "ItemForDiaChi";
            this.ItemForDiaChi.Size = new System.Drawing.Size(901, 26);
            this.ItemForDiaChi.Text = "Dia Chi";
            this.ItemForDiaChi.TextSize = new System.Drawing.Size(88, 16);
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(116, 150);
            this.EmailTextEdit.MenuManager = this.barManager;
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(354, 22);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 9;
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(0, 104);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(450, 26);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(88, 16);
            // 
            // SoDienThoaiTextEdit
            // 
            this.SoDienThoaiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "SoDienThoai", true));
            this.SoDienThoaiTextEdit.Location = new System.Drawing.Point(566, 150);
            this.SoDienThoaiTextEdit.MenuManager = this.barManager;
            this.SoDienThoaiTextEdit.Name = "SoDienThoaiTextEdit";
            this.SoDienThoaiTextEdit.Size = new System.Drawing.Size(355, 22);
            this.SoDienThoaiTextEdit.StyleController = this.dataLayoutControl1;
            this.SoDienThoaiTextEdit.TabIndex = 10;
            // 
            // ItemForSoDienThoai
            // 
            this.ItemForSoDienThoai.Control = this.SoDienThoaiTextEdit;
            this.ItemForSoDienThoai.Location = new System.Drawing.Point(450, 104);
            this.ItemForSoDienThoai.Name = "ItemForSoDienThoai";
            this.ItemForSoDienThoai.Size = new System.Drawing.Size(451, 26);
            this.ItemForSoDienThoai.Text = "So Dien Thoai";
            this.ItemForSoDienThoai.TextSize = new System.Drawing.Size(88, 16);
            // 
            // GioiTinhTextEdit
            // 
            this.GioiTinhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "GioiTinh", true));
            this.GioiTinhTextEdit.Location = new System.Drawing.Point(566, 98);
            this.GioiTinhTextEdit.MenuManager = this.barManager;
            this.GioiTinhTextEdit.Name = "GioiTinhTextEdit";
            this.GioiTinhTextEdit.Size = new System.Drawing.Size(355, 22);
            this.GioiTinhTextEdit.StyleController = this.dataLayoutControl1;
            this.GioiTinhTextEdit.TabIndex = 11;
            // 
            // ItemForGioiTinh
            // 
            this.ItemForGioiTinh.Control = this.GioiTinhTextEdit;
            this.ItemForGioiTinh.Location = new System.Drawing.Point(450, 52);
            this.ItemForGioiTinh.Name = "ItemForGioiTinh";
            this.ItemForGioiTinh.Size = new System.Drawing.Size(451, 26);
            this.ItemForGioiTinh.Text = "Gioi Tinh";
            this.ItemForGioiTinh.TextSize = new System.Drawing.Size(88, 16);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.khachHangBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 188);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(921, 451);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKhachHang,
            this.colUserName,
            this.colHoTen,
            this.colNgaySinh,
            this.colDiaChi,
            this.colEmail,
            this.colSoDienThoai,
            this.colGioiTinh});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 176);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(925, 455);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.FieldName = "MaKhachHang";
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.Visible = true;
            this.colMaKhachHang.VisibleIndex = 0;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            // 
            // colHoTen
            // 
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 2;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 3;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.FieldName = "SoDienThoai";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 6;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 7;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMaKhachHang,
            this.ItemForUserName,
            this.ItemForNgaySinh,
            this.ItemForDiaChi,
            this.ItemForEmail,
            this.ItemForHoTen,
            this.ItemForGioiTinh,
            this.ItemForSoDienThoai});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(925, 176);
            this.layoutControlGroup3.Text = "Thông tin Khách Hàng";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 686);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmKhachHang";
            this.Text = "THÔNG TIN KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.Testform_Load);
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhachHangTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoTenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoDienThoaiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSoDienThoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GioiTinhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Data data;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private DataTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraEditors.TextEdit MaKhachHangTextEdit;
        private DevExpress.XtraEditors.TextEdit UserNameTextEdit;
        private DevExpress.XtraEditors.TextEdit HoTenTextEdit;
        private DevExpress.XtraEditors.DateEdit NgaySinhDateEdit;
        private DevExpress.XtraEditors.TextEdit DiaChiTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit SoDienThoaiTextEdit;
        private DevExpress.XtraEditors.TextEdit GioiTinhTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaKhachHang;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNgaySinh;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDiaChi;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHoTen;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGioiTinh;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSoDienThoai;
    }
}