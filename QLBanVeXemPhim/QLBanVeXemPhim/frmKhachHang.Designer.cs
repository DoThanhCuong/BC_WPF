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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new QLBanVeXemPhim.Data();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khachHangTableAdapter = new QLBanVeXemPhim.DataTableAdapters.KhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.khachHangBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 196);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1056, 478);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 686);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmKhachHang";
            this.Text = "THÔNG TIN KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.Testform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Data data;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private DataTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
    }
}