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
using WPF.MDI;

namespace QL_DatVeXemPhim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mnUser_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "User Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                Content = new uc_UserRegistration()
            });
        }

        private void mnCompany_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Company Registation",
                Height = 768,
                Width = 1024,
                //Style = null,
                Content = new uc_CompRegistration()
            });
        }

        private void mnHelp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Phần này chưa có làm !");
        }

        private void mnNhanVien_Click(object sender, RoutedEventArgs e)
        {
            frmNhanVien fNV = new frmNhanVien();
            fNV.Show();
        }

        private void mnAnimation_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Thông tin Nhân Viên",
                Height = 768,
                Width = 1024,
                //Style = null,
                Content = new ucNhanVien()
            });
        }

        private void mnSimple_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Test Nhân Viên",
                Height = 768,
                Width = 1024,
                //Style = null,
                Content = new ucNhanVienTest()
            });
        }
    }
}
