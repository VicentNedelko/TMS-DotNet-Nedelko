using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Eagle : AnimalBase, ICanFly
    {
        public Eagle()
        {
            Console.WriteLine("New Eagle created.");
        }
        public double MaxSpeed { get ; set ; }
        public double MaxAltitude { get ; set ; }

        public void Climbing()
        {
            Console.WriteLine("Start climbing.");
        }

        public void Descending()
        {
            Console.WriteLine("Start descending.");
        }

        public override void Move()
        {
            Console.WriteLine("Fly");
        }

        public override void Voice()
        {
            Console.WriteLine("Car-Car");
        }
    }
}
