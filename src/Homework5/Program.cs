using System;
using System.Collections.Generic;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AnimalBase> list = new List<AnimalBase>();
            Shark shark = new Shark()
            {
                Name = "Valya",
                Breed = "White",
                Weight = 100.0,
                MaxSpeed = 25.5,
                MaxDepth = 200.0,
            };
            list.Add(shark);
            Eagle eagle = new Eagle()
            {
                Name = "Vasya",
                Breed = "Rocky",
                Weight = 5.0,
                MaxSpeed = 75.0,
                MaxAltitude = 1500.0,
            };
            list.Add(eagle);
            Tiger tiger = new Tiger()
            {
                Name = "Kolya",
                Breed = "Lazy",
                Weight = 150.0,
            };
            list.Add(tiger);
            Deer deer = new Deer()
            {
                Name = "Valik",
                Breed = "Horned",
                Weight = 200.0,
                MaxSpeed = 5.0,
                Edible = true,
            };
            list.Add(deer);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------SHARK : {0}", shark.Name);
            Console.ForegroundColor = ConsoleColor.White;
            shark.Breathe();
            shark.Move();
            shark.Voice();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------EAGLE : {0}", eagle.Name);
            Console.ForegroundColor = ConsoleColor.White;
            eagle.Move();
            eagle.Climbing();
            eagle.Descending();
            eagle.Voice();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------TIGER : {0}", tiger.Name);
            Console.ForegroundColor = ConsoleColor.White;
            tiger.Move();
            tiger.Hungry();
            tiger.Sleep();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------DEER : {0}", deer.Name);
            Console.ForegroundColor = ConsoleColor.White;
            deer.Move();
            deer.Voice();
        }
        public static void Print(List<AnimalBase> list)
        {
            Console.WriteLine("-----ANIMALS-----");
            foreach (AnimalBase animal in list)
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine(animal.Breed);
            }
        }
    }
}
