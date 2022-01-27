using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_10
{
    interface ICanFly
    {
        public double wingSize { get; set; }
        public void fly();
    }
}