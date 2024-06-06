using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
