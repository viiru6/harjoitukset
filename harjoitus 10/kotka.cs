using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_10
{
    class kotka : eläin, ICanFly
    {
        public double wingSize { get; set; }
        public kotka(string _nimi, double _wingSize)
        {
            nimi = _nimi;
            wingSize = _wingSize;
        }
        public void fly()
        {
            Console.WriteLine("{0} lentää. siipi väli: {1}", nimi, wingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("kakaa");

        }
    }
}