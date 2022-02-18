using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_25
{
    [Serializable]
    class Pelaaja :MainWindow
    {
        public static double Ikä;
        public static string ENimi;
        public static string SNimi;
        public static int PelaajaNumero;
        public static string Joukkue;
        public Pelaaja(string enimi, string snimi, double ikä, string joukkue, int pelaajanumero)
        {
            ENimi = enimi;
            SNimi = snimi;
            Ikä = ikä;
            Joukkue = joukkue;
            PelaajaNumero = pelaajanumero;
        }
        public static Pelaaja opiskeliija = new Pelaaja
            (ENimi = en,
            SNimi = sn,
            Ikä = i,
            Joukkue = j,
            PelaajaNumero = p);


    }
}
