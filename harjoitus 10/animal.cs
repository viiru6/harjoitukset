using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_10
{
    class animal
    {
        public string name;
        public static void MakeASound()
        {
            Console.WriteLine(": ääni");
        }
        interface ICanSwim
        {
            static double swimSpeed { get; set; }
            public static void Swim()
            {
                Console.WriteLine("ui...");
            }
        }
        interface ICanFly
        {
            public static double wingSize { get; set; }
            public static void Fly()
            {
                Console.WriteLine("lentää...");
            }
        }
        public class lohi : ICanSwim
        {
            
        }
        public class särki : ICanSwim
        {

        }
        public class kotka : ICanFly
        {
            
        }

    }
}
