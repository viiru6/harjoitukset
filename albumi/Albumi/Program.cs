using System;

namespace Albumi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "albumi tehtävä";//vaihtaa konsoli ikkunan nimen
            albumi albumi = new albumi();//luo albumi olion ja käyttään sen metodit
            albumi.albumintiedot();
            albumi.lisääkappaleet();
            albumi.tulostatiedot();
            albumi.tulostabiisit();
            kappale kappale = new kappale();//luo kappale olion ja tulostaa biisin
            kappale.biisi();
            Console.ReadLine();
        }
    }
}
