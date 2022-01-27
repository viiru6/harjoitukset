using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_9
{
    class radio
    {
        private static int ääni;
        private static int minÄäni = 0;
        private static int maxÄäni = 9;
        public static double radionTaajuus;
        private static double minRadionTaajuus = 88.0f;
        private static double maxRadionTaajuus = 107.9f;
        public static Boolean päällä;
        public static string b;
        private static int q;
        private static double w;
        public static void komennot()
        {
            Console.WriteLine("radion toiminnot: <päälle>/<pois> <äänenVoimakkuus> <taajuudenValinta>");
            b = Console.ReadLine();
        }
        public static void päällePois()
        {
            if (b.ToLower() == "päälle")
            {
                Console.WriteLine("radio on nyt päällä");
                Console.Write("äänen voimakkuus: " + ääni);
                Console.WriteLine(" taajuus: " + radionTaajuus);
                Console.WriteLine();
                päällä = true;
            }
            if (b.ToLower() == "pois")
            {
                Console.WriteLine("radio on nyt pois päältä");
                päällä = false;
            }
        }
        public static void äänenVoimakkuus()
        {
            if (päällä)
            {
                Console.WriteLine("valitse äänen voimakkuus 0-9: ");
                try
                {
                    q = Convert.ToInt32(Console.ReadLine());//käyttäjä syöttää numeron
                }
                catch
                {
                    Console.WriteLine("virheellinen syöte");//jos syöte ei ole numero
                }
                finally
                {
                    if (q < 9 & q > 0) // jos syötetty numero on oikein
                    {
                        ääni = q;
                        Console.WriteLine("äänen voimakkuus on nyt: " + ääni);
                        Console.WriteLine();
                    }
                    if (q > 9)// jos syötetty numero on liian korkea
                    {
                        ääni = maxÄäni;
                    }
                    if (q < 0)// jos syötetty numero on liian matala
                    {
                        ääni = minÄäni;
                    }
                }
            }
            if (!päällä)
            {
                Console.WriteLine("radio on pois päältä");
            }
        }
        public static void tajuudenValinta()
        {
            if (päällä)
            {
                Console.WriteLine("kanavien tajuudet: kanava1: 100 ja kanava2: 105.75");
                Console.WriteLine("valitse tajuus 88,0 - 107,9: ");
                try
                {
                    w = Convert.ToDouble(Console.ReadLine());//käyttäjä syöttää numeron
                }
                catch
                {
                    Console.WriteLine("virheellinen syöte");//jos syöte ei ole numero
                }
                finally
                {
                    if (w < 107.9D & w > 88.0D) // jos syötetty numero on oikein
                    {
                        radionTaajuus = w;
                        Console.WriteLine("taajuus on nyt: " + radionTaajuus);
                        Console.WriteLine();
                    }
                    if (w > 107.9D)// jos syötetty numero on liian korkea
                    {
                        radionTaajuus = maxRadionTaajuus;
                    }
                    if (w < 88.0D)// jos syötetty numero on liian matala
                    {
                        radionTaajuus = minRadionTaajuus;
                    }
                }
            }
            if (!päällä)
            {
                Console.WriteLine("radio on pois päältä");
            }

        }
    }
}