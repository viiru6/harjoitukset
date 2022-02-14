using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "kiuas";
            kiuas kiuas = new kiuas(80, 90);
            for(; ; )
            {
                kiuas.komennot();
                kiuas.tila();
            }
        }
    }
}
