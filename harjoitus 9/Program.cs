using System;

namespace harjoitus_9
{
    class Program : radio
    {
        static void Main(string[] args)
        {
            
            for(; ; )
            {
                kanava Kanava1 = new kanava("kanava1", 100D);
                kanava Kanava2 = new kanava("kanava2", 105.75D);
                radio.komennot();
                if (b.ToLower() == "päälle")
                {
                    radio.päällePois();
                }
                if (b.ToLower() == "pois")
                {
                    radio.päällePois();
                }
                if (b.ToLower() == "äänenvoimakkuus")
                {
                    radio.äänenVoimakkuus();
                }
                if (b.ToLower() == "taajuudenvalinta")
                {
                    radio.tajuudenValinta();
                }
                if (radionTaajuus == 100D)
                {
                    Console.WriteLine("tervetuloa! olet nyt kanavalla1\n");
                    radionTaajuus = 0;
                }
                if (radionTaajuus == 105.75D)
                {
                    Console.WriteLine("tervetuloa! olet nyt kanavalla2\n");
                    radionTaajuus = 0;
                }
            }
        }
    }
}
