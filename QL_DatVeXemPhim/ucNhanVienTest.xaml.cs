using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QL_DatVeXemPhim
{
    /// <summary>
    /// Interaction logic for ucNhanVienTest.xaml
    /// </summary>
    public partial class ucNhanVienTest : UserControl
    {

        Data data = new Data();
        QL_DatVeXemPhim.DataTableAdapters.NhanVienTableAdapter nvAD = new DataTableAdapters.NhanVienTableAdapter();
        List<string> listGioiTinh = new List<string>();
        public ucNhanVienTest()
        {
            InitializeComponent();
            listGioiTinh.Add("1");
            listGioiTinh.Add("2");
            listGioiTinh.Add("3");
            NapDuLieu();
        }

     
      

        private void NapDuLieu()
        {
            nvAD.Fill(data.NhanVien);
            dataGrid.ItemsSource = data.NhanVien;
        }

        private void btnChonHinh_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
           

            if(dlg.ShowDialog() == true)
            {
                imgNhanVien.Source = new ImageSourceConverter().ConvertFromString(dlg.FileName) as ImageSource;


                var dv = dataGrid.SelectedItem as DataRowView;
                var nv =dv.Row as Data.NhanVienRow;


                if (nv != null)
                {
                    nv.Hinh = imageToByteArray(System.Drawing.Image.FromFile(dlg.FileName));
                }
            }
        }


        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var dv = dataGrid.SelectedItem as DataRowView;
            if (dv == null) return;
            var nv = dv.Row as Data.NhanVienRow;
            if (nv.IsHinhNull())
            {
                imgNhanVien.Source = null;
                return;
            }
            var stream = new System.IO.MemoryStream();
            System.Drawing.Image img = byteArrayToImage(nv.Hinh);
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
         
            
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.StreamSource = stream;
            bitmap.EndInit();
            imgNhanVien.Source = bitmap;

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var dt = data.NhanVien.GetChanges() as Data.NhanVienDataTable;
            if (dt == null) return;

            nvAD.Update(dt);
        }
    }
}
