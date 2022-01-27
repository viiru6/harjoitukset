using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_10
{
    interface ICanSwim
    {
        public double swimSpeed { get; set; }
        public void swim();
    }
}