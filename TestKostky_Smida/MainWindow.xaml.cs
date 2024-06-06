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
        private Kosticka[] kostky;
        private Canvas[] kostkavCanvas;
        private Random random;

        public MainWindow()
        {
            InitializeComponent();

            random = new Random();
            kostky = new Kosticka[6];
            kostkavCanvas = new Canvas[6];

            for (int i = 0; i < 6; i++)
            {
                kostky[i] = new Kosticka();
                kostkavCanvas[i] = new Canvas();
                canva.Children.Add(kostkavCanvas[i]);
                Canvas.SetLeft(kostkavCanvas[i], 50 + i * 100);
                Canvas.SetTop(kostkavCanvas[i], 50);
                kostky[i].Tecky(kostkavCanvas[i], 0, 0);
            }

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += Timer_Tick;
        }

        private void Rolluj_Click(object sender, RoutedEventArgs e)
        {
            foreach (var kostka in kostky)
            {
                kostka.Hod();
            }
            updCanva();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            foreach (var kostka in kostky)
            {
                kostka.Hod();
            }
            updCanva();
        }

        private void updCanva()
        {
            for (int i = 0; i < 6; i++)
            {
                kostky[i].Tecky(kostkavCanvas[i], 0, 0);
            }
        }

    }
}
