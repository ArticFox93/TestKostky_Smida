using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TestKostky_Smida
{
    public class Kosticka
    {
        private static Random random = new Random();
        public int value { get; set; }


        public void Hod()
        {
            value = random.Next(1, 7);
        }

        public Kosticka()
        {
            Hod();
        }


        // cele znovu
        //public void Tecky(int value, Rectangle rectangle)
        //{

        //    for (int i = 0; i < value; i++)
        //    {
        //        Ellipse ellipse = new Ellipse()
        //        {
        //            Height = 15,
        //            Width = 15,
        //            Fill = Brushes.Black
        //        };
        //    }
        //}

        public void Tecky(Canvas canvas, double x, double y)
        {
            
            canvas.Children.Clear();

            
            Rectangle rectangle = new Rectangle
            {
                Width = 80,
                Height = 80,
                Fill = Brushes.White,
                Stroke = Brushes.Black
            };
            Canvas.SetLeft(rectangle, x);
            Canvas.SetTop(rectangle, y);
            canvas.Children.Add(rectangle);

            
            double[][] teckaPositions = {
                new double[] { 40, 40 },
                new double[] { 20, 20 }, new double[] { 60, 60 },
                new double[] { 60, 20 }, new double[] { 20, 60 },
                new double[] { 20, 40 }, new double[] { 60, 40 }
            };

            int[][] tecky = {
                new int[] { 0 },
                new int[] { 1, 2 },
                new int[] { 0, 1, 2 },
                new int[] { 1, 2, 3, 4 },
                new int[] { 0, 1, 2, 3, 4 },
                new int[] { 1, 2, 3, 4, 5, 6 }
            };

            foreach (var index in tecky[value - 1])
            {
                Ellipse ellipse = new Ellipse
                {
                    Width = 15,
                    Height = 15,
                    Fill = Brushes.Black
                };
                Canvas.SetLeft(ellipse, x + teckaPositions[index][0] - 7.5);
                Canvas.SetTop(ellipse, y + teckaPositions[index][1] - 7.5);
                canvas.Children.Add(ellipse);
            }
        }


    }
}
