using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace TestKostky_Smida
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DispatcherTimer timer;
        private int cislo = 6;

        public double X { get; private set; }
        public double Y { get; private set; }
        private int value = 5;
        public MainWindow()
        {
            InitializeComponent();
            kostka(50, 50);
            kostka(150, 50);
            kostka(250, 50);
            kostka(350, 50);
            kostka(450, 50);
            kostka(550, 50);
            Bod(5, 10, 10);
            for (int i = 0; i < 10; i++)
            {
                Bod(5, 20, 20);
            }
            Bod(5, 30, 30);
            Bod(5, 10, 40);
            Bod(5, 10, 30);
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += timertick;
        }

        private void timertick(object? sender, EventArgs e)
        {

        }
        

        public void kostka(double x, double y)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Height = 80;
            rectangle.Width = 80;
            rectangle.Fill = Brushes.White;
            rectangle.Stroke = Brushes.Black;

            for (int i = 0; i < cislo; i++)
            {
                Canvas.SetLeft(rectangle, x + 10);
                Canvas.SetTop(rectangle, y + 10);
            }
            canva.Children.Add(rectangle);

        }

        public void Bod(int value, double x, double y)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 15;
            ellipse.Height = 15;
            ellipse.Stroke = Brushes.Black;
            ellipse.Fill = Brushes.Black;
            Canvas.SetLeft(ellipse, x + 30);
            Canvas.SetTop(ellipse, y + 30);
            canva.Children.Add(ellipse);
        }

    }
}
