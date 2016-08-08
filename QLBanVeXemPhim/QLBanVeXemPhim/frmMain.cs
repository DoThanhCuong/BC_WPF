using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLBanVeXemPhim
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        // Viết lại hàm trả về tên form con khi form đã mở.

        protected Form GetChildFormByName(string frmName)
        {
            //Form frm = null;
            //foreach (Form f in this.MdiChildren)
            //{
            //    if(f.Name == frmName)
            //    {
            //        frm = f;
            //        break;
            //    }
            //}
            //return frm;

            // Dùng Linq

            return this.MdiChildren.FirstOrDefault(f=>f.Name==frmName);
        }

        // btn Nhân Viên

        private void btnEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            string fName = "frmEmployee";
            Form frmEmp = GetChildFormByName(fName);

            if (frmEmp == null)
            {
                frmEmp = new frmEmployee();
                frmEmp.Name = fName;
                frmEmp.MdiParent = this;
                frmEmp.Show();
            }

        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            string fName = "frmKhachHang";
            Form frmEmp = GetChildFormByName(fName);

            if (frmEmp == null)
            {
                frmEmp = new frmKhachHang();
                frmEmp.Name = fName;
                frmEmp.MdiParent = this;
                frmEmp.Show();
            }
        }

        // 
    }
}