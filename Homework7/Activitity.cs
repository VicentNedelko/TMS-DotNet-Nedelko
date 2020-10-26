using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework7
{
    internal class Activity
    {
        public List<int> activEnergy = new List<int>();
        public delegate void userActivity();
        public event userActivity curActivity;
        public User user { get; set; }
        public Activity()
        {
            user = new User();
        }

        public void Swimming()
        {
            activEnergy = Training(120, 170);
            user.Energy -= activEnergy.Aggregate((current, next) => current + next) / 2;
            curActivity?.Invoke();
        }
        public void Running()
        {
            activEnergy = Training(100, 130);
            user.Energy -= activEnergy.Aggregate((current, next) => current + next) / 2;
            curActivity?.Invoke();
        }
        public void Walking()
        {
            activEnergy = Training(80, 110);
            user.Energy -= activEnergy.Aggregate((current, next) => current + next) / 2;
            curActivity?.Invoke();
        }
        public void Training()
        {
            activEnergy = Training(90, 120);
            user.Energy -= activEnergy.Aggregate((current, next) => current + next) / 2;
            curActivity?.Invoke();
        }
        public void Relax()
        {
            activEnergy = Training(60, 80);
            user.Energy += activEnergy.Aggregate((current, next) => current + next) / 2;
            curActivity?.Invoke();
        }
        public List<int> Training(int startHR, int stopHR)
        {
            List<int> energy = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                energy.Add(rand.Next(startHR, stopHR));
            }
            user.Energy -= activEnergy.Aggregate((current, next) => current + next) / 2;
            return energy;
        }
    }
}
