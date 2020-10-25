using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework7_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
                { new Person("Mike", 35), new Person("Nike", 25), new Person("Alex", 65), new Person("Nataly", 45)};
            LinqSamples sample= new LinqSamples();
            sample.Run();
            var youngPersons = people.Where(p => p.Age <= 35);
            Console.WriteLine();
            Console.WriteLine("New peoples : ");
            foreach(Person p in youngPersons)
            {
                Console.WriteLine(p);
            }
        }
    }
}
