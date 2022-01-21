using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_7_hissi
{
    class hissi : Program
    {
        static int kerros = 1;
        static int b = 2;
        public static int minKerros = 1;
        public static int maxKerros = 6;
        public static void kerroksenKysyminen()
        {
            for(; ;)
            {
                Console.WriteLine("mihin kerrokseen haluat 1-6?");
                
                try
                {
                    kerros = Convert.ToInt32(Console.ReadLine());
                    if(kerros < minKerros)
                    {
                        kerros = minKerros;
                    }
                    if (kerros > maxKerros)
                    {
                        kerros = maxKerros;
                    }
                }
                
                catch
                {
                    Console.WriteLine("virheellinen syöte. ole hyvä ja yritä uudelleen.");
                }
                finally
                {
                    Console.WriteLine("olet nyt kerroksessa: " + kerros);
                    Console.WriteLine();
                }
            }


        }


    }
}
