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

namespace Per_Frame_Animation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TimeSpan lastRender;
        double time = 0;
        double dt = 0;

        public MainWindow()
        {
            InitializeComponent();
            lastRender = TimeSpan.FromTicks(DateTime.Now.Ticks);
            CompositionTarget.Rendering += StartAnimation;
        }

        private void StartAnimation(object sender, EventArgs e)
        {
            RenderingEventArgs renderArgs = (RenderingEventArgs)e;
            dt = (renderArgs.RenderingTime - lastRender).TotalSeconds;
            lastRender = renderArgs.RenderingTime;

            double x = 180 + 150 * Math.Cos(2 * time);
            double y = 180 + 75 * Math.Sin(2 * time);
            ball1.Center = new Point(x, y);
            x = 180 + 75 * Math.Cos(0.5 * time);
            y = 180 + 150 * Math.Sin(0.5 * time);
            ball2.Center = new Point(x, y);
            time += dt;
        }
    }
}
