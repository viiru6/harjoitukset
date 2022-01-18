using System;

namespace Albumi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "albumi tehtävä";
            albumi albumi = new albumi();
            albumi.albumintiedot();
            albumi.lisääkappaleet();
            albumi.tulostatiedot();
            albumi.tulostabiisit();
            kappale kappale = new kappale();
            kappale.biisi();

        }
    }
}
