using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Collections;


namespace QL_DatVeXemPhim
{
    /// <summary>
    /// Interaction logic for frmNhanVien.xaml
    /// </summary>
    public partial class frmNhanVien : Window
    {
        string kn = "Data Source=HAILUA\\SQL2008r2;Initial Catalog=DatVeXemPhim; User = sa; Password = barcode;Integrated Security=True;TrustServerCertificate=False";
        public ArrayList tr = new ArrayList();
        
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
             
        }

        
        //private void dualenlistviewsv()
        //{
        //    lvNhanVien.Items.Clear();
        //    if (tr != null)
        //    {
        //        for (int i = 0; i < tr.Count; i = i + 8)
        //        {
        //            ListViewItem it = new ListViewItem(tr[i].ToString());
        //            //ListViewItem it = new ListViewItem(tr[i].ToString());
        //            //it.SubItems.Add(tr[i + 1].ToString());
        //            //it.SubItems.Add(tr[i + 2].ToString());
        //            //it.SubItems.Add(tr[i + 3].ToString());
        //            //it.SubItems.Add(tr[i + 4].ToString());
        //            //it.SubItems.Add(tr[i + 5].ToString());
        //            //it.SubItems.Add(tr[i + 6].ToString());
        //            //it.SubItems.Add(tr[i + 7].ToString());
        //            //lvNhanVien.Items.Add(it);
        //        }
        //    }
        //    else
        //        MessageBox.Show("Chưa có nhân viên");
        //}


        //


        //private void lvwsv_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (lvwsv.SelectedItems.Count > 0)
        //    {
        //        ListViewItem item = lvwsv.SelectedItems[0];
        //        txtmasosv.Text = item.Text;
        //        txthoten.Text = item.SubItems[1].Text;
        //        cbphai.Text = item.SubItems[2].Text;
        //        dateTimepnamsinh.Text = item.SubItems[3].Text;
        //        txtdiachi.Text = item.SubItems[4].Text;
        //        cbchuyenmalop.Text = item.SubItems[5].Text;
        //        tbhocphi.Text = item.SubItems[6].Text;
        //        tbhocbong.Text = item.SubItems[7].Text;
        //        //Biến Để Kiểm Tra
        //        masososanh = txtmasosv.Text.Trim().ToUpper();
        //        tensvcs = txthoten.Text.Trim();
        //        phaisvcs = cbphai.Text;
        //        namsinhcs = dateTimepnamsinh.Text;
        //        diachics = txtdiachi.Text.Trim();
        //        malopcs = cbchuyenmalop.Text;
        //        hocphics = tbhocphi.Text.Trim();
        //        hocbongcs = tbhocbong.Text.Trim();
        //        txtmasosv.Focus();
        //        txtmasosv.SelectAll();
        //    }
        //}
    }
}
