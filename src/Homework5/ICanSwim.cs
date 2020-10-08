using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    interface ICanSwim
    {
        public double MaxDepth { get; set; }
        public double MaxSpeed { get; set; }
        public void Breathe();
    }
}
