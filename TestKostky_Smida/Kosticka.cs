using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            random.Next(1, 7);
        }

        public Kosticka()
        {
            Hod();
        }



        public void Tecky(int value, Rectangle rectangle)
        {
            
            for (int i = 0; i < value; i++)
            {
                Ellipse ellipse = new Ellipse()
                {
                    Height = 15,
                    Width = 15,
                    Fill = Brushes.Black
                };
            }
        }


    }
}
