using System;
using System.Collections.Generic;
using System.Text;

namespace Albumi
{
    class albumi
    {
        public List<string> kappaleet = new List<string>();//luo kappaleet listan
        public List<string> tiedot = new List<string>();//luo tiedot listan
        public void tulostatiedot()//tulostaa tiedot listan
        {
            Console.WriteLine("albumin tiedot:");
            tiedot.ForEach(h=>Console.WriteLine(h + ""));
        }
        public void tulostabiisit()//tulostaa kappaleet listan
        {
            Console.WriteLine("biisit:");
            kappaleet.ForEach(g => Console.WriteLine(g + ""));
        }
        public void albumintiedot()//lisää tiedot kappale listaan
        {

            kappaleet.Add(" next to me");
            kappaleet.Add(" i dont know why");
            kappaleet.Add(" eliever");
            kappaleet.Add(" thunder");
        }
        public void lisääkappaleet()// lisää tiedot listan tiedot
        {

            tiedot.Add("  artisti: imagine dragons");
            tiedot.Add("  nimi: evolve");
            tiedot.Add("  genre: pop rock");
            tiedot.Add("  hinta 10e");
        }
        
        




    }
}
