namespace QLBanVeXemPhim.DanhMuc
{
    partial class FrmNhanVien
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new QLBanVeXemPhim.Data();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rcboGioiTInh = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.MaNVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.HoTenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NgaySinhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SoDienThoaiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.HinhPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.DiaChiTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.GioiTinhCbo = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMaNV = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHoTen = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNgaySinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSoDienThoai = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDiaChi = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGioiTinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.nhanVienTableAdapter = new QLBanVeXemPhim.DataTableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcboGioiTInh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaNVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoTenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoDienThoaiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HinhPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GioiTinhCbo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSoDienThoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGioiTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInsert, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.toolbar.OptionsBar.AllowQuickCustomization = false;
            this.toolbar.OptionsBar.DrawDragBorder = false;
            this.toolbar.OptionsBar.UseWholeRow = true;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.MaNVTextEdit);
            this.dataLayoutControl1.Controls.Add(this.HoTenTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NgaySinhDateEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SoDienThoaiTextEdit);
            this.dataLayoutControl1.Controls.Add(this.HinhPictureEdit);
            this.dataLayoutControl1.Controls.Add(this.DiaChiTextEdit);
            this.dataLayoutControl1.Controls.Add(this.GioiTinhCbo);
            this.dataLayoutControl1.DataSource = this.nhanVienBindingSource;
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
            this.dataLayoutControl1.Size = new System.Drawing.Size(891, 520);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.nhanVienBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rcboGioiTInh});
            this.gridControl1.Size = new System.Drawing.Size(867, 364);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.data;
            this.nhanVienBindingSource.CurrentChanged += new System.EventHandler(this.nhanVienBindingSource_CurrentChanged);
            // 
            // data
            // 
            this.data.DataSetName = "Data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colNgaySinh,
            this.colDiaChi,
            this.colEmail,
            this.colSoDienThoai,
            this.colGioiTinh});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            // 
            // colHoTen
            // 
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 3;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.FieldName = "SoDienThoai";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 5;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.ColumnEdit = this.rcboGioiTInh;
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 6;
            // 
            // rcboGioiTInh
            // 
            this.rcboGioiTInh.AutoHeight = false;
            this.rcboGioiTInh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rcboGioiTInh.Name = "rcboGioiTInh";
            // 
            // MaNVTextEdit
            // 
            this.MaNVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "MaNV", true));
            this.MaNVTextEdit.Location = new System.Drawing.Point(197, 12);
            this.MaNVTextEdit.MenuManager = this.barManager;
            this.MaNVTextEdit.Name = "MaNVTextEdit";
            this.MaNVTextEdit.Size = new System.Drawing.Size(281, 22);
            this.MaNVTextEdit.StyleController = this.dataLayoutControl1;
            this.MaNVTextEdit.TabIndex = 4;
            // 
            // HoTenTextEdit
            // 
            this.HoTenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "HoTen", true));
            this.HoTenTextEdit.Location = new System.Drawing.Point(565, 12);
            this.HoTenTextEdit.MenuManager = this.barManager;
            this.HoTenTextEdit.Name = "HoTenTextEdit";
            this.HoTenTextEdit.Size = new System.Drawing.Size(314, 22);
            this.HoTenTextEdit.StyleController = this.dataLayoutControl1;
            this.HoTenTextEdit.TabIndex = 5;
            // 
            // NgaySinhDateEdit
            // 
            this.NgaySinhDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "NgaySinh", true));
            this.NgaySinhDateEdit.EditValue = null;
            this.NgaySinhDateEdit.Location = new System.Drawing.Point(197, 38);
            this.NgaySinhDateEdit.MenuManager = this.barManager;
            this.NgaySinhDateEdit.Name = "NgaySinhDateEdit";
            this.NgaySinhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgaySinhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgaySinhDateEdit.Size = new System.Drawing.Size(280, 22);
            this.NgaySinhDateEdit.StyleController = this.dataLayoutControl1;
            this.NgaySinhDateEdit.TabIndex = 6;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(197, 64);
            this.EmailTextEdit.MenuManager = this.barManager;
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(280, 22);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 8;
            // 
            // SoDienThoaiTextEdit
            // 
            this.SoDienThoaiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "SoDienThoai", true));
            this.SoDienThoaiTextEdit.Location = new System.Drawing.Point(564, 64);
            this.SoDienThoaiTextEdit.MenuManager = this.barManager;
            this.SoDienThoaiTextEdit.Name = "SoDienThoaiTextEdit";
            this.SoDienThoaiTextEdit.Size = new System.Drawing.Size(315, 22);
            this.SoDienThoaiTextEdit.StyleController = this.dataLayoutControl1;
            this.SoDienThoaiTextEdit.TabIndex = 9;
            // 
            // HinhPictureEdit
            // 
            this.HinhPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "Hinh", true));
            this.HinhPictureEdit.Location = new System.Drawing.Point(12, 12);
            this.HinhPictureEdit.MenuManager = this.barManager;
            this.HinhPictureEdit.Name = "HinhPictureEdit";
            this.HinhPictureEdit.Size = new System.Drawing.Size(98, 128);
            this.HinhPictureEdit.StyleController = this.dataLayoutControl1;
            this.HinhPictureEdit.TabIndex = 10;
            // 
            // DiaChiTextEdit
            // 
            this.DiaChiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "DiaChi", true));
            this.DiaChiTextEdit.Location = new System.Drawing.Point(197, 90);
            this.DiaChiTextEdit.MenuManager = this.barManager;
            this.DiaChiTextEdit.Name = "DiaChiTextEdit";
            this.DiaChiTextEdit.Size = new System.Drawing.Size(682, 50);
            this.DiaChiTextEdit.StyleController = this.dataLayoutControl1;
            this.DiaChiTextEdit.TabIndex = 7;
            // 
            // GioiTinhCbo
            // 
            this.GioiTinhCbo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "GioiTinh", true));
            this.GioiTinhCbo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.GioiTinhCbo.Location = new System.Drawing.Point(564, 38);
            this.GioiTinhCbo.MenuManager = this.barManager;
            this.GioiTinhCbo.Name = "GioiTinhCbo";
            this.GioiTinhCbo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GioiTinhCbo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.GioiTinhCbo.Size = new System.Drawing.Size(315, 22);
            this.GioiTinhCbo.StyleController = this.dataLayoutControl1;
            this.GioiTinhCbo.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(891, 520);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMaNV,
            this.ItemForHoTen,
            this.ItemForNgaySinh,
            this.ItemForEmail,
            this.layoutControlItem1,
            this.ItemForHinh,
            this.ItemForSoDienThoai,
            this.ItemForDiaChi,
            this.ItemForGioiTinh});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(871, 500);
            // 
            // ItemForMaNV
            // 
            this.ItemForMaNV.Control = this.MaNVTextEdit;
            this.ItemForMaNV.Location = new System.Drawing.Point(102, 0);
            this.ItemForMaNV.Name = "ItemForMaNV";
            this.ItemForMaNV.Size = new System.Drawing.Size(368, 26);
            this.ItemForMaNV.Text = "Mã";
            this.ItemForMaNV.TextSize = new System.Drawing.Size(80, 16);
            // 
            // ItemForHoTen
            // 
            this.ItemForHoTen.Control = this.HoTenTextEdit;
            this.ItemForHoTen.Location = new System.Drawing.Point(470, 0);
            this.ItemForHoTen.Name = "ItemForHoTen";
            this.ItemForHoTen.Size = new System.Drawing.Size(401, 26);
            this.ItemForHoTen.Text = "Họ tên";
            this.ItemForHoTen.TextSize = new System.Drawing.Size(80, 17);
            // 
            // ItemForNgaySinh
            // 
            this.ItemForNgaySinh.Control = this.NgaySinhDateEdit;
            this.ItemForNgaySinh.Location = new System.Drawing.Point(102, 26);
            this.ItemForNgaySinh.Name = "ItemForNgaySinh";
            this.ItemForNgaySinh.Size = new System.Drawing.Size(367, 26);
            this.ItemForNgaySinh.Text = "Ngay Sinh";
            this.ItemForNgaySinh.TextSize = new System.Drawing.Size(80, 16);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(102, 52);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(367, 26);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(80, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 132);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(871, 368);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ItemForHinh
            // 
            this.ItemForHinh.Control = this.HinhPictureEdit;
            this.ItemForHinh.Location = new System.Drawing.Point(0, 0);
            this.ItemForHinh.MaxSize = new System.Drawing.Size(102, 132);
            this.ItemForHinh.MinSize = new System.Drawing.Size(102, 132);
            this.ItemForHinh.Name = "ItemForHinh";
            this.ItemForHinh.Size = new System.Drawing.Size(102, 132);
            this.ItemForHinh.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForHinh.StartNewLine = true;
            this.ItemForHinh.Text = "Hinh";
            this.ItemForHinh.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForHinh.TextVisible = false;
            // 
            // ItemForSoDienThoai
            // 
            this.ItemForSoDienThoai.Control = this.SoDienThoaiTextEdit;
            this.ItemForSoDienThoai.Location = new System.Drawing.Point(469, 52);
            this.ItemForSoDienThoai.Name = "ItemForSoDienThoai";
            this.ItemForSoDienThoai.Size = new System.Drawing.Size(402, 26);
            this.ItemForSoDienThoai.Text = "So Dien Thoai";
            this.ItemForSoDienThoai.TextSize = new System.Drawing.Size(80, 16);
            // 
            // ItemForDiaChi
            // 
            this.ItemForDiaChi.Control = this.DiaChiTextEdit;
            this.ItemForDiaChi.Location = new System.Drawing.Point(102, 78);
            this.ItemForDiaChi.Name = "ItemForDiaChi";
            this.ItemForDiaChi.Size = new System.Drawing.Size(769, 54);
            this.ItemForDiaChi.Text = "Dia Chi";
            this.ItemForDiaChi.TextSize = new System.Drawing.Size(80, 16);
            // 
            // ItemForGioiTinh
            // 
            this.ItemForGioiTinh.Control = this.GioiTinhCbo;
            this.ItemForGioiTinh.Location = new System.Drawing.Point(469, 26);
            this.ItemForGioiTinh.Name = "ItemForGioiTinh";
            this.ItemForGioiTinh.Size = new System.Drawing.Size(402, 26);
            this.ItemForGioiTinh.Text = "Gioi Tinh";
            this.ItemForGioiTinh.TextSize = new System.Drawing.Size(80, 16);
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 555);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcboGioiTInh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaNVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoTenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoDienThoaiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HinhPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GioiTinhCbo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSoDienThoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGioiTinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private Data data;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DataTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DevExpress.XtraEditors.TextEdit MaNVTextEdit;
        private DevExpress.XtraEditors.TextEdit HoTenTextEdit;
        private DevExpress.XtraEditors.DateEdit NgaySinhDateEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit SoDienThoaiTextEdit;
        private DevExpress.XtraEditors.PictureEdit HinhPictureEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaNV;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHoTen;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNgaySinh;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDiaChi;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSoDienThoai;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHinh;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGioiTinh;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraEditors.MemoEdit DiaChiTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox rcboGioiTInh;
        private DevExpress.XtraEditors.ImageComboBoxEdit GioiTinhCbo;
    }
}