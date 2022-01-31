using System;
using System.IO;
namespace harjoitus_14
{
    class Program
    {
            static void Main(string[] args)
        {
            string path = @"c:\harjoitus14.txt";
            try
            {
                if (!File.Exists(path))//luodaan uusi tiedosto
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("uusi tiedosto");
                        sw.WriteLine("luotu" + DateTime.Now.ToString());
                        sw.WriteLine();
                    }
                }
                using (StreamWriter sw = File.AppendText(path))//kirjoitetaan tiedostoon
                {
                    sw.WriteLine("tämä kirjoitettiin tiedostoon:");
                    sw.WriteLine("asdadasdasdw");
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("virhe");
                Console.ReadLine();
            }
        }
    }
}

