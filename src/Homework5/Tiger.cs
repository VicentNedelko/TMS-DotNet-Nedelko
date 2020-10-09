using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Tiger : AnimalBase, IPredator
    {
        public Tiger()
        {
            Console.WriteLine("New Tiger created.");
        }
        public void Hungry()
        {
            Console.WriteLine("Want to eat");
        }

        public override void Move()
        {
            Console.WriteLine("Run");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }

        public override void Voice()
        {
            Console.WriteLine("Roar");
        }
    }
}
