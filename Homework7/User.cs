using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7
{
    public class User
    {
        public int HeartRate { get; set; }
        public double EqSteps { get; private set; }
        public string Id { get; private set; }
        public double Energy { get; set; }
        public User()
        {
            Id = Guid.NewGuid().ToString().Substring(0, 5);
            Energy = 5000.0;
            Console.WriteLine($"User Energy - {Energy} KJ");
            Console.WriteLine($"User ID - {Id}");
        }
        public User(double Energy)
        {
            Id = Guid.NewGuid().ToString().Substring(0, 5);
            this.Energy = Energy;
            Console.WriteLine($"User Energy - {this.Energy} KJ");
            Console.WriteLine($"User ID - {Id}");
        }
    }
}
