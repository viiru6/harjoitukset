using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_11
{
    class Opiskelija
    {
        
        public  string Etunimi;
        public  string Sukunimi;
        public  string Ryhmätunnus;
        public  string OpiskelijaID;
        public  string Avain;
        public  Dictionary<string, Opiskelija> sk = new Dictionary<string, Opiskelija>();
        public Opiskelija(string _etunimi, string _sukunimi, string _ryhmätunnus, string _opiskelijaID,string _avain)
        {
            Etunimi = _etunimi;
            Sukunimi = _sukunimi;
            Ryhmätunnus = _ryhmätunnus;
            OpiskelijaID = _opiskelijaID;
            Avain = _avain;
        }
        public static string syöte = "";
        public void K()
        {
            while (syöte.ToLower() != "b")
            {
                Console.WriteLine("anna opiskelijan etunimi: ");
                syöte = Console.ReadLine();
                if(syöte.ToLower() != "b")
                {
                    Etunimi = syöte;
                    Avain = "asdasd";
                    Console.WriteLine("anna opiskelijan sukunimi: ");
                    syöte = Console.ReadLine();
                    if (syöte.ToLower() != "b")
                    {
                        Sukunimi = syöte;
                        Console.WriteLine("anna opiskelijan ryhmätunnus: ");
                        syöte = Console.ReadLine();
                        if (syöte.ToLower() != "b")
                        {
                            Ryhmätunnus = syöte;
                            Console.WriteLine("anna opiskelijan opiskelijaID: ");
                            syöte = Console.ReadLine();
                            if (syöte.ToLower() != "b")
                            {
                                OpiskelijaID = syöte;
                                Opiskelija opiskelija = new Opiskelija(Etunimi, Sukunimi, Ryhmätunnus, OpiskelijaID, Avain);
                                sk.Add(Avain, opiskelija);
                            }
                        }
                    }
                }
            }
        }
        public void TulostaLista()
        {
            foreach (string avain in sk.Keys)
            {
                Console.WriteLine("opiskelijan tiedot:");
                Console.WriteLine("-nimi: " + sk[avain].Etunimi);
                Console.WriteLine("-sukunimi: " + sk[avain].Sukunimi);
                Console.WriteLine("-ryhmä tunnus: " + sk[avain].Ryhmätunnus);
                Console.WriteLine("-opiskelijaID: " + sk[avain].OpiskelijaID);
            }
        }
        
    }
}
