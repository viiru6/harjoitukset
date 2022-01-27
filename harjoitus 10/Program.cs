using System;

namespace harjoitus_10
{
    class Program
    {
        static void Main(string[] args)
        {
            kotka Kotka = new kotka("pertti", 5.5D);
            Kotka.MakeASound();
            Kotka.fly();
            lohi Lohi = new lohi("pate", 10.6D);
            Lohi.MakeASound();
            Lohi.swim();
        }
    }
}