using System;
using System.IO;
namespace harjoitus_144
{
    class Program
    {
        static string path = @"c:\New folder\harjoitus14.txt";
        static void Main(string[] args)
        {
            if (!File.Exists(path))//luodaan uusi tiedosto
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("uusi tiedosto");
                    sw.WriteLine("luotu: " + DateTime.Now.ToString());
                    sw.WriteLine();
                }
            }
            void tyhjennä()
            {
                File.WriteAllText(path, String.Empty);
            }
            void kirjoita()
            {
                try
                {

                    using (StreamWriter sw = File.AppendText(path))//kirjoitetaan tiedostoon
                    {
                        Console.Write("\nlisää tiedostoon: ");
                        sw.WriteLine(Console.ReadLine());
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
            void tulosta()
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine("tiedoston sisältö:\n");
                        Console.WriteLine(s);
                    }
                }
            }
            for(; ; )
            {
                Console.WriteLine("komennot: <kirjoita> <tyhjennä> <tulosta>");
                string b;
                b = Console.ReadLine();
                if (b.ToLower() == "kirjoita")
                {
                    kirjoita();
                }
                if (b.ToLower() == "tyhjennä")
                {
                    tyhjennä();
                }
                if (b.ToLower() == "tulosta")
                {
                    tulosta();
                }
            }

        }
    }
}
