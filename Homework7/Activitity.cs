using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework7
{
    internal class Activity
    {
        public List<int> activEnergy = new List<int>();
        public Action<string, List<int>> curActivity;

        public void Swimming()
        {
            activEnergy = Training(120, 170);
            curActivity?.Invoke("Swimming", activEnergy);
        }
        public void Running()
        {
            activEnergy = Training(100, 130);
            curActivity?.Invoke("Running", activEnergy);
        }
        public void Walking()
        {
            activEnergy = Training(80, 110);
            curActivity?.Invoke("Walking", activEnergy);
        }
        public void Training()
        {
            activEnergy = Training(90, 120);
            curActivity?.Invoke("Training", activEnergy);
        }
        public void Relax()
        {
            activEnergy = Training(60, 80);
            curActivity?.Invoke("Relax", activEnergy);
        }
        public List<int> Training(int startHR, int stopHR)
        {
            List<int> energy = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                energy.Add(rand.Next(startHR, stopHR));
            }
            return energy;
        }
    }
}
