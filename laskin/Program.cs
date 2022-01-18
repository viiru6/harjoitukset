using System;

namespace laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string b = "";
                Console.WriteLine("Toiminnot: <summa> <erotus> <kertolasku> <jakolasku>");
                b = Console.ReadLine();

                if (b.ToLower() == "summa")
                {
                    laskin.Summa();
                }
                if (b.ToLower() == "erotus")
                {
                    laskin.Erotus();
                }
                if (b.ToLower() == "kertolasku")
                {
                    laskin.Kertolasku();
                }
                if (b.ToLower() == "jakolasku")
                {
                    laskin.Jako();
                }
            }

        }
    }
}
