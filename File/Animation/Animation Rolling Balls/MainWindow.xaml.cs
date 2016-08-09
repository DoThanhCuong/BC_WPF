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
using System.Windows.Media.Animation;

namespace Animation_Rolling_Balls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StartRolling();
        }

        private void StartRolling()
        {
            double nRotation = 360 * 450 / 2 / Math.PI / 25;

            // Constant speed: 
            DoubleAnimation da = new DoubleAnimation(0, 450,
                TimeSpan.FromSeconds(5));
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            ellipse1.BeginAnimation(Canvas.LeftProperty, da);

            da = new DoubleAnimation(0, nRotation,
                TimeSpan.FromSeconds(5));
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            ellipse1Rotate.BeginAnimation(
                RotateTransform.AngleProperty, da);

            // Acceleration: 
            da = new DoubleAnimation(0, 450,
                TimeSpan.FromSeconds(5));
            da.AccelerationRatio = 0.4;
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            ellipse2.BeginAnimation(Canvas.LeftProperty, da);

            da = new DoubleAnimation(0, nRotation,
                TimeSpan.FromSeconds(5));
            da.AccelerationRatio = 0.4;
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            ellipse2Rotate.BeginAnimation(
                RotateTransform.AngleProperty, da);

            // Deceleration: 
            da = new DoubleAnimation(0, 450,
                TimeSpan.FromSeconds(5));
            da.DecelerationRatio = 0.6;
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            ellipse3.BeginAnimation(Canvas.LeftProperty, da);

            da = new DoubleAnimation(0, nRotation,
                TimeSpan.FromSeconds(5));
            da.DecelerationRatio = 0.6;
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            ellipse3Rotate.BeginAnimation(
                RotateTransform.AngleProperty, da);

            // Acceleration + Deceleration: 
            da = new DoubleAnimation(0, 450,
                TimeSpan.FromSeconds(5));
            da.DecelerationRatio = 0.6;
            da.AccelerationRatio = 0.4;
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            ellipse4.BeginAnimation(Canvas.LeftProperty, da);

            da = new DoubleAnimation(0, nRotation,
                TimeSpan.FromSeconds(5));
            da.DecelerationRatio = 0.6;
            da.AccelerationRatio = 0.4;
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            ellipse4Rotate.BeginAnimation(
                RotateTransform.AngleProperty, da);
        }
    }
}
