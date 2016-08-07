using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Configuration;

namespace QLBanVeXemPhim
{
    public partial class frmEmployee : frmBase
    {
        public frmEmployee()
        {
            InitializeComponent();
            cmbGioiTinh.Properties.Items.AddEnum(typeof(Gender),true);
            reComboBox_GioiTinh.Items.AddEnum(typeof(Gender), true);
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.data.NhanVien);

        }

        protected override void OnSave()
        {
            var dtChange = this.data.NhanVien.GetChanges() as Data.NhanVienDataTable;
            if (dtChange == null) return;

            try
            {
                nhanVienTableAdapter.Update(dtChange);
                XtraMessageBox.Show("Đã lưu thành công");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        protected override void OnInsert()
        {
            grvEmployee.AddNewRow();
        }

        protected override void OnDelete()
        {
            if (XtraMessageBox.Show("Bạn muốn xóa dòng đã chọn", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.Yes)
            {
                grvEmployee.DeleteSelectedRows();

                try
                {
                    var dtChange = this.data.NhanVien.GetChanges() as Data.NhanVienDataTable;
                    if (dtChange == null) return;
                    nhanVienTableAdapter.Update(dtChange);
                    XtraMessageBox.Show("Đã xóa thành công");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }
    }
}
