using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Shark : AnimalBase, ICanSwim
    {
        public Shark()
        {
            Console.WriteLine("New Shark created.");
        }
        public double MaxDepth { get; set; }
        public double MaxSpeed { get; set; }

        public void Breathe()
        {
            Console.WriteLine("Can't breathe."); ;
        }

        public override void Move()
        {
            Console.WriteLine("Swim"); ;
        }

        public override void Voice()
        {
            Console.WriteLine("Has NO voice."); ;
        }
    }
}
