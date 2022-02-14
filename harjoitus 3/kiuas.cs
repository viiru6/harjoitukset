using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class kiuas
    {
        int lämpötila;
        int kosteus;
        Boolean päällä;

        public kiuas(int _lämpötila, int _kosteus)
        {
            lämpötila = _lämpötila;
            kosteus = _kosteus;
        }

        public void tila()//tulostaa kiukaan tilan ja tiedot
        {
            if (päällä)
            {
                Console.WriteLine("\nkiuas on päällä");
                Console.WriteLine("kiukaan lämpötila on: " + lämpötila);
                Console.WriteLine("kiukaan kosteus: " + kosteus);
                Console.Write("\n");

            }
            if (!päällä)
            {
                Console.WriteLine("\nkiuas on pois päältä");
            }
        }
        public void komennot()//kiukaan komennot
        {
            string t;
            Console.WriteLine("haluatko käynnistää/sammuttaa kiukaan kiukaan vai säätää kiuasta? \nkomennot: <käynnistys> <sammutus> <säätö>");
            t = Console.ReadLine();

            if (t.ToLower() == "käynnistys")
            {
                päällä = true;
                t = "a";

            }
            if (t.ToLower() == "sammutus")
            {
                päällä = false;
                t = "";
            }
            if (t.ToLower() == "säätö")
            {
                if (päällä)
                {
                    try
                    {
                        Console.WriteLine("\nanna haluamasi lämpötila: ");
                        lämpötila = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("anna haluamasi kosteus: ");
                        kosteus = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("anna numero");
                    }
                    t = "";
                    Console.Write("nykyinen lämpötila : " + lämpötila);
                    Console.Write(" ja kosteus: " + kosteus);
                    Console.Write("\n");
                }
            }
        }
    }
}
