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

namespace WPF_Demo
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
                Content = new UserRegistration()
            });
        }

        private void mnCompany_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Company Registation",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                Content = new CompRegistration()
            });
        }

        private void mnRevisited_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Animation Revisited",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                Content = new uc_A_Revisited()
            });
        }

        private void mnOverview_Click_1(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Animation Overview",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                Content = new uc_A_Overview()
            });
        }

        private void mnRollingBalls_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Animation Overview",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                Content = new uc_A_RollingBalls()
            });
        }

        private void mnSolidColor_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Tô màu đồng nhất",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                Content = new uc_B_SolidColor()
            });
        }

        private void mnShape_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Các đối tượng hình học cơ bản-Shape",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                Content = new uc_B_Shape()
            });
        }

        private void mnRadGran_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Đổ màu theo bán kinh hình tròn",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                Content = new uc_B_Radial_Gradient()
            });
        }

        private void mnOpacity_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Thiết lập độ mờ của chổi tô – Opacity",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                Content = new uc_B_OpacityBrush()
            });
        }

        private void mnLGColor_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Tô theo hướng tuyến tính",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                Content = new uc_B_LinearGradientColor()
            });
        }

        private void mnImgBitmap_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Tô màu bằng Bitmap",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                Content = new uc_B_ImageBitmap()
            });
        }
    }
}
