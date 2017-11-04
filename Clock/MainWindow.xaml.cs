using System;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Media;
using Clock;

namespace Clock
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
          
                InitializeComponent();
           
            
            CompositionTarget.Rendering += rotate;

        }

        public void rotate(object sender, object args)
        {
            DateTime dt = DateTime.Now;

            RotateTransform rotateTransform1 = new RotateTransform(DateTime.Now.Hour * 30 + DateTime.Now.Minute / 6 + DateTime.Now.Second / 120, 0.5, 0.5);
            Hours.RenderTransform = rotateTransform1;

            RotateTransform rotateTransform2 = new RotateTransform(DateTime.Now.Minute * 6 + DateTime.Now.Second / 10, 0.5, 0.5);
            Minutes.RenderTransform = rotateTransform2;

            RotateTransform rotateTransform3 = new RotateTransform(DateTime.Now.Second * 6, 0.5, 0.5);
            Seconds.RenderTransform = rotateTransform3;

        }
       


        }
}
