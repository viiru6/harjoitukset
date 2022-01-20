using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_7_hissi
{
    class hissi
    {
        static int kerros = 0;
        private readonly int minKerros = 0;
        private readonly int maxKerros = 6;
        public static void kerroksenKysyminen()
        {
            Console.WriteLine("mihin kerrokseen haluat 1-6?");
            try
            {
                kerros = Convert.ToInt32(Console.ReadLine());
            }
             catch{
                Console.WriteLine("virheellinen syöte");
            }


        }


    }
}
