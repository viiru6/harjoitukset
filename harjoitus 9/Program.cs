using System;

namespace harjoitus_9
{
    class Program : radio
    {
        static void Main(string[] args)
        {
            
            for(; ; )
            {
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
                kanava Kanava1 = new kanava("kanava1", 100D);


            }

        }
    }
}
