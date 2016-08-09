using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLBanVeXemPhim.DanhMuc;

namespace QLBanVeXemPhim
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
      


        void OpenFomr<T>()
        {
            var f = MdiChildren.FirstOrDefault(i => i is T);
            if (f == null)
            {
                f = Activator.CreateInstance<T>() as Form;
                f.MdiParent = this;
                f.Show();
            }
            else f.Activate();
        }

       

        private void btnEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFomr<FrmNhanVien>();

        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

      
    }
}