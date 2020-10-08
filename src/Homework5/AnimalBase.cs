using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    public abstract class AnimalBase
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }
        public enum Color
        {
            Black,
            White,
            Red,
            Different,
        }
        public abstract void Move();
        public abstract void Voice();
    }
}
