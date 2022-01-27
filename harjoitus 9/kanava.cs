using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_9
{
    class kanava : radio
    {
        public static string nimi { get; set; }
        public static double kanavanTaajuus { get; set; }
        public kanava(string _nimi, double _kanavantaajuus)
        {
            nimi = _nimi;
            kanavanTaajuus = _kanavantaajuus;
        }

       
    }
}
