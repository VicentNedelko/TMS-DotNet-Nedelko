using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Deer : AnimalBase, ITerraine
    {
        public Deer()
        {
            Console.WriteLine("New Deer created.");
        }
        public double MaxSpeed { get ; set ; }
        public bool Edible { get ; set ; }

        public override void Move()
        {
            Console.WriteLine("Run fast.");
        }

        public override void Voice()
        {
            Console.WriteLine("Mu-Mu");
        }
    }
}
