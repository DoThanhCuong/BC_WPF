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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPF_Demo.Animation
{
    /// <summary>
    /// Interaction logic for uc_A_Download.xaml
    /// </summary>
    public partial class uc_A_Download : UserControl
    {
        private int i;
        private double startPos;
        private DispatcherTimer timer;
        public uc_A_Download()
        {
            InitializeComponent();

             i = 0;

            // Store start position of sliding canvas
            startPos = Canvas.GetLeft(SlidingCanvas);

            // Create animation timer
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            i++;

            if (i < 16)
            {
                // Move SlidingCanvas containg the three colored dots 14 units to the right
                Canvas.SetLeft(SlidingCanvas, Canvas.GetLeft(SlidingCanvas) + 14);
            }
            else
            {
                // Move SlidingCanvas back to its starting position and reset counter
                i = 0;
                Canvas.SetLeft(SlidingCanvas, startPos);
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }
    }
}
