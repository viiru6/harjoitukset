using System;
using System.Collections.Generic;
using System.Text;

namespace Albumi
{
    class albumi
    {
        public List<string> kappaleet = new List<string>();
        public List<string> tiedot = new List<string>();
        public void tulostatiedot()
        {
            Console.WriteLine("albumin tiedot:");
            kappaleet.ForEach(tiedot=>Console.WriteLine(tiedot + ""));
            

        }
        public void tulostabiisit()
        {
            Console.WriteLine("biisit:");
            kappaleet.ForEach(kappaleet => Console.WriteLine(kappaleet + ""));
        }
        public void albumintiedot()
        {

            kappaleet.Add(" next to me");
            kappaleet.Add(" i dont know why");
            kappaleet.Add(" eliever");
            kappaleet.Add(" thunder");
        }
        public void lisääkappaleet()
        {

            tiedot.Add("  artisti: imagine dragons");
            tiedot.Add("  nimi: evolve");
            tiedot.Add("  genre: pop rock");
            tiedot.Add("  hinta 10€");
        }
        
        




    }
}
