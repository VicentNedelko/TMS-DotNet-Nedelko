using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    interface ICanFly
    {
        public double MaxSpeed { get; set; }
        public double MaxAltitude { get; set; }
        public void Climbing();
        public void Descending();
    }
}
