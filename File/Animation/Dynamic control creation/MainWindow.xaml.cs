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

namespace Dynamic_control_creation
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
        // Create StoryBoards
        Storyboard myWidthAnimatedButtonStoryboard = new Storyboard();
        Storyboard myColorAnimatedButtonStoryboard = new Storyboard();
        Storyboard myFadingAnimatedStoryboard = new Storyboard();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Width = 320;
            this.Title = "Dynamic controls creation";

            // Create a button for Scaling Animation.
            Button myWidthAnimatedButton = new Button();

            // Register the name with the page to which the button belongs.
            myWidthAnimatedButton.Name = "myWidthAnimationButton";
            this.RegisterName(myWidthAnimatedButton.Name, myWidthAnimatedButton);
            myWidthAnimatedButton.Height = 30;
            myWidthAnimatedButton.Width = 200;
            myWidthAnimatedButton.HorizontalAlignment = HorizontalAlignment.Left;
            myWidthAnimatedButton.Margin = new Thickness(0, -200, 0, 0);
            myWidthAnimatedButton.Content = "Click me to see Width Animation";

            // Create a DoubleAnimation to animate the width of the button.
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = 200;
            myDoubleAnimation.To = 300;
            myDoubleAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(3000));
            myDoubleAnimation.AutoReverse = true;

            // Add animation to storyboard
            myWidthAnimatedButtonStoryboard.Children.Add(myDoubleAnimation);

            // Configure the animation to target the button's Width property.
            Storyboard.SetTargetName(myDoubleAnimation, myWidthAnimatedButton.Name);
            Storyboard.SetTargetProperty(myDoubleAnimation, new PropertyPath(Button.WidthProperty));

            // Animate the button width when it's clicked.
            myWidthAnimatedButton.Click += new RoutedEventHandler(WidthAnimatedButton);

            // Add button to MasterGrid
            MasterGrid.Children.Add(myWidthAnimatedButton);

            //
            // Create and animate the second button.
            //

            // Create a SolidColorBrush to paint the button's background.
            SolidColorBrush myBackgroundBrush = new SolidColorBrush();
            myBackgroundBrush.Color = Colors.Red;

            // Create a second button.
            Button myColorAnimatedButton = new Button();

            // Because a Brush isn't a FrameworkElement, it doesn't
            // have a Name property to set. Instead, you just
            // register a name for the SolidColorBrush with
            // the page where it's used.
            this.RegisterName("myAnimatedBrush", myBackgroundBrush);
            myColorAnimatedButton.Height = 30;
            myColorAnimatedButton.Width = 200;
            myColorAnimatedButton.Margin = new Thickness(0, -100, 0, 0);
            myColorAnimatedButton.HorizontalAlignment = HorizontalAlignment.Left;
            myColorAnimatedButton.Content = "Click me to see Color Animation";

            // Use the brush to paint the background of the button.
            myColorAnimatedButton.Background = myBackgroundBrush;

            // Create a ColorAnimation to animate the button's background.
            ColorAnimation myColorAnimation = new ColorAnimation();
            myColorAnimation.From = Colors.Red;
            myColorAnimation.To = Colors.Yellow;
            myColorAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(7000));
            myColorAnimation.AutoReverse = true;

            // Add animation to storyboard.
            myColorAnimatedButtonStoryboard.Children.Add(myColorAnimation);

            // Configure the animation to target the brush's Color property.
            Storyboard.SetTargetName(myColorAnimation, "myAnimatedBrush");
            Storyboard.SetTargetProperty(myColorAnimation, new PropertyPath(SolidColorBrush.ColorProperty));

            // Animate the button background color when it's clicked.
            myColorAnimatedButton.Click += new RoutedEventHandler(ColorAnimatedButton);

            // Add button to MasterGrid
            MasterGrid.Children.Add(myColorAnimatedButton);

            //
            // Create Third button
            //
            Button myFadingAnimatedButton = new Button();
            myFadingAnimatedButton.Name = "myFadingAnimatedButton";
            this.RegisterName(myFadingAnimatedButton.Name, myFadingAnimatedButton);
            myFadingAnimatedButton.Width = 200;
            myFadingAnimatedButton.Height = 30;
            myFadingAnimatedButton.Margin = new Thickness(0, 0, 0, 0);
            myFadingAnimatedButton.HorizontalAlignment = HorizontalAlignment.Left;
            myFadingAnimatedButton.Content = "Click me to see Opacity Animation";

            DoubleAnimation myDoubleAnimation1 = new DoubleAnimation();
            myDoubleAnimation1.From = 1.0;
            myDoubleAnimation1.To = 0.0;
            myDoubleAnimation1.Duration = new Duration(TimeSpan.FromSeconds(2));
            myDoubleAnimation1.AutoReverse = true;

            myFadingAnimatedStoryboard.Children.Add(myDoubleAnimation1);
            Storyboard.SetTargetName(myDoubleAnimation1, myFadingAnimatedButton.Name);
            Storyboard.SetTargetProperty(myDoubleAnimation1, new PropertyPath(Button.OpacityProperty));

            myFadingAnimatedButton.Click += new RoutedEventHandler(FadingAnimatedButton);

            MasterGrid.Children.Add(myFadingAnimatedButton);
        }

        void WidthAnimatedButton(object sender, RoutedEventArgs args)
        {
            myWidthAnimatedButtonStoryboard.Begin(this);
        }

        void ColorAnimatedButton(object sender, RoutedEventArgs args)
        {
            myColorAnimatedButtonStoryboard.Begin(this);
        }

        void FadingAnimatedButton(object sender, RoutedEventArgs args)
        {
            myFadingAnimatedStoryboard.Begin(this);
        }
    }
}
