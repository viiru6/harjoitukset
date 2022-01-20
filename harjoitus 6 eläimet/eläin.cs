using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_6_eläimet
{
    class eläin
    {
        public string nimi = "";
        public static int instanssit = 0;
        public eläin()
        {
            instanssit++;
        }
        public virtual void puhu()
        {
            Console.WriteLine(nimi + ": terve");
        }
        public static void määrä()
        {
            Console.WriteLine("eläimet luotu: "+ instanssit);
        }
        public override string ToString()
        {
            return nimi + ": moi";
        }
        

        

        

    }
}
