using System;

namespace harjoitus_6_eläimet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "harjoitus 6";
            eläin apina1 = new apina();
            
            eläin apina2 = new apina();
            apina1.nimi = "paavo"; 
            apina2.nimi = "pertti";
            eläin poro1 = new poro();
            eläin poro2 = new poro();
            poro1.nimi = "petteri";
            poro2.nimi = "pate";
            Console.WriteLine(apina1.ToString());
            Console.WriteLine(poro2.ToString());
            apina1.puhu();
            eläin.määrä();
            Console.ReadLine();

        }
    }
}
