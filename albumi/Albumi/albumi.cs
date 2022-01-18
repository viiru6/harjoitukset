using System;
using System.Collections.Generic;
using System.Text;

namespace Albumi
{
    class albumi
    {
        public List<string> kappaleet = new List<string>();


        public void tulostadata()
        {
            kappaleet.ForEach(num => Console.WriteLine(num + ", "));

        }

        public void lisääkappale()
        {
            kappaleet.Add("");
            kappaleet.Add("");
            kappaleet.Add("");
            kappaleet.Add("");
            kappaleet.Add("");
        }




    }
}
