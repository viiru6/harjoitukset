using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus3
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
        public void tila()
        {
            string b;
            Console.WriteLine("Toiminnot: <käynnistä> <sammuta> <säädä>");
            b = Console.ReadLine();
            if (b.ToLower() == "käynnistä")
            {
                Console.WriteLine("\nkiuas on päällä");
                Console.WriteLine("lämpötila: " + lämpötila);
                Console.WriteLine("kosteus: " + kosteus);
                Console.WriteLine("\n");
                päällä = true;
                b = "";
                   
            }
            if (b.ToLower() == "sammuta")
            {
                Console.WriteLine("kiuas on nyt pois päältä\n");
                päällä = false;
                b = "a";
            }
                if (b.ToLower() == "säädä")
                {
                    Console.WriteLine("anna haluttu lämpötila: ");
                    lämpötila = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("anna haluttu kosteus: ");
                    kosteus = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                if (päällä)
                {
                    Console.WriteLine("kiuas on päällä");
                    Console.WriteLine("lämpötila: " + lämpötila);
                    Console.WriteLine("kosteus: " + kosteus);
                }
                    b = "a";
                }
        
           
        }
    }
}
