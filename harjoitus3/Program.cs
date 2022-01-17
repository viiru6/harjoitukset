using System;

namespace harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            kiuas kiuas = new kiuas(0,0);
            Console.Title = "kiuas";
            for(; ; )
            {
                kiuas.tila();
            }
        }
    }
}
