using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBanVeXemPhim
{
    public partial class frmKhachHang : frmBase
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void Testform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.data.KhachHang);

        }
    }
}
