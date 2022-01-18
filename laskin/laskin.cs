using System;
using System.Collections.Generic;
using System.Text;

namespace laskin
{
    class laskin
    {
        public static int a;
        public static int b;
        public static void numerot()
        {
            
            Console.WriteLine("anna numero jota haluat käsitellä:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("anna numero jolla haluat käsitellä:");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public static void Summa()
        {
            numerot();
            Console.Write("numeroiden ");
            Console.Write(a + " ");
            Console.Write("ja " + b);
            Console.Write(" summa on: ");
            Console.WriteLine(a + b + "\n");
        }
        public static void Erotus()
        {
            numerot();
            Console.Write("numeroiden ");
            Console.Write(a + " ");
            Console.Write("ja " + b);
            Console.Write(" erotus on: ");
            Console.WriteLine(a - b + "\n");
        }
        public static void Kertolasku()
        {
            numerot();
            Console.Write("numero ");
            Console.Write(a + " kerrottuna numerolla ");
            Console.Write(b);
            Console.Write(" on: ");
            Console.WriteLine(a * b + "\n");
        }
        public static void Jako()
        {
            numerot();
            Console.Write("numero ");
            Console.Write(a + " jaettuna numerolla ");
            Console.Write(b);
            Console.Write(" on: ");
            Console.WriteLine(a / b + "\n");
        }

    }
}
