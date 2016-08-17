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
    /// Interaction logic for uc_A_Point.xaml
    /// </summary>
    public partial class uc_A_Point : UserControl
    {
        double XMin = 0;
        double YMin = 0;
        double XMax = 100;
        double YMax = 50;
        double X0 = 10;
        double Y0 = 10;
        double Vx = 10;
        double Vy = 10;
        double Gravity = 9.81;
        double TimeDelay = 50;
        double time = 0;
        double dt = 0.1;
        DispatcherTimer timer = new DispatcherTimer();
        Polyline pl = new Polyline(); 


        public uc_A_Point()
        {
            InitializeComponent();

            pl.Stroke = Brushes.Blue;
            canvas1.Children.Add(pl);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            double x = X0 + Vx * time;
            double y = Y0 + Vy * time - 0.5 * Gravity * time * time;

            if (y >= Y0)
            {
                Canvas.SetLeft(ellipse, XNormalize(x));
                Canvas.SetTop(ellipse, YNormalize(y));
                pl.Points.Add(new Point(
                    XNormalize(x) + 5, YNormalize(y) + 5));
            }
            else
            {
                timer.Stop();
                return;
            }
            time += dt;
        }


        private double XNormalize(double x)
        {
            double result = (x - XMin) *
                   canvas1.Width / (XMax - XMin);
            return result;
        }

        private double YNormalize(double y)
        {
            double result = canvas1.Height - (y - YMin) *
                canvas1.Height / (YMax - YMin);
            return result;
        }
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            time = 0;
            dt = 0.1;

            if (canvas1.Children.Count > 3)
                canvas1.Children.Remove(pl);

            pl = new Polyline();
            pl.Stroke = Brushes.Blue;
            canvas1.Children.Add(pl);
            timer = new DispatcherTimer();

            X0 = Double.Parse(tbX0.Text);
            Y0 = Double.Parse(tbY0.Text);
            Vx = Double.Parse(tbVx.Text);
            Vy = Double.Parse(tbVy.Text);
            TimeDelay = Double.Parse(tbTimeDelay.Text);
            Gravity = Double.Parse(tbGravity.Text);

            // Get maximum x and y: 
            double xm = 2 * Vx * Vy / Gravity;
            double ym = 0.5 * Vy * Vy / Gravity;
            double x1 = Math.Round(X0 + xm, 0);
            double y1 = Math.Round(Y0 + ym, 0);

            timer.Interval = TimeSpan.FromMilliseconds(
                TimeDelay);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
