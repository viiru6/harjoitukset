using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_20
{
    class Opiskeliija :MainWindow
    {
        public static string ENimi;
        public static string SNimi;
        public static string OpiskelijaID;
        public static string SPosti;
        public static int Puh;
        public Opiskeliija(string enimi, string snimi, string opiskelijaID, string sposti, int puh)
        {
            ENimi = en;
            SNimi = sn;
            OpiskelijaID = oID;
            SPosti = sp;
            Puh = p;
        }
        public static Opiskeliija opiskeliija = new Opiskeliija
            (ENimi = en,
            SNimi = sn,
            OpiskelijaID = oID,
            SPosti = sp,
            Puh = p);
    }
}
