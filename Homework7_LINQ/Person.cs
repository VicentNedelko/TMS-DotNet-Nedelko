using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7_LINQ
{
    public class Person
    {
        public string Id { private set; get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person()
        {
            Id = Guid.NewGuid().ToString().Substring(0, 5);
            Name = "user";
            Age = 25;
        }
        public Person(string Name, int Age)
        {
            Id = Guid.NewGuid().ToString().Substring(0, 5);
            this.Name = Name;
            this.Age = Age;
        }
        public override string ToString()
        {
            return Name + " --> " + Age + " : " + Id;
        }
    }
}
