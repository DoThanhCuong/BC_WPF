using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBanVeXemPhim.DanhMuc
{
    public partial class FrmNhanVien : FrmBase
    {
        public FrmNhanVien()
        {
            InitializeComponent();

            GioiTinhCbo.Properties.Items.AddEnum(typeof(GioiTinh), true);
            rcboGioiTInh.Items.AddEnum(typeof(GioiTinh), true);
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {

            OnReload();
        }

        protected override void OnReload()
        {
            this.nhanVienTableAdapter.Fill(this.data.NhanVien);
        }
        protected override void OnInsert()
        {
            gridView1.AddNewRow();
        }
        protected override void OnSave()
        {
            dataLayoutControl1.Validate();
            gridView1.UpdateCurrentRow();
            try
            {
                var dt = data.NhanVien.GetChanges() as Data.NhanVienDataTable;
                if (dt == null) return;
                nhanVienTableAdapter.Update(dt);
                data.NhanVien.AcceptChanges();
              
            }
            catch (Exception ex)
            {
                // show err
              

            }
        }

        protected override void OnDelete()
        {
            //var dlg = MsgBox.ShowYesNoDialog("Bạn có chắc muốn xóa (những) dòng này?");
            //if (dlg == System.Windows.Forms.DialogResult.No) return;

            gridView1.DeleteSelectedRows();
            OnSave();
            OnReload();
        }

        private void nhanVienBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView dv = nhanVienBindingSource.Current as DataRowView;
                if (dv == null) return;

                MaNVTextEdit.Enabled 
                    = gridView1.Columns["MaNV"].OptionsColumn.AllowEdit
                    = DataUtils.IsNewDataRow(dv.Row);

            }
            catch { }
        }
    }

}
