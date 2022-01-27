using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_10
{
    class lohi : eläin, ICanSwim
    {
        public double swimSpeed { get; set; }
        public lohi(string _nimi, double _swinSpeed)
        {
            nimi = _nimi;
            swimSpeed = _swinSpeed;
        }
        public override void MakeASound()
        {
            Console.WriteLine("pläts");
        }

        public void swim()
        {
            Console.WriteLine("{0} ui. nopeus: {1}", nimi, swimSpeed);
        }
    }
}