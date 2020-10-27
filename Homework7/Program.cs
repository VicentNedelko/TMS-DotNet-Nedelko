using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework7
{
    class Program
    {
        public static void Main(string[] args)
        {
            ShowUserMenu();
            Activity activity = new Activity();
            User user = new User();
            bool exit = false;
            while (!exit)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.R:
                        //activity.Running();
                        if (user.Energy > 0)
                        {
                            activity.curActivity = GetUserInfo;
                            user.Energy -= activity.activEnergy.Aggregate((current, next) => current + next) / 2;
                            Console.WriteLine($"Current Energy - {user.Energy}");
                            Console.WriteLine($"HeartRate - {activity.activEnergy.Average()}");
                        }
                        else
                        {
                            Console.WriteLine("Let's Relax!");
                        }
                            break;
                    case ConsoleKey.S:
                        activity.Swimming();
                        if (user.Energy > 0)
                        {
                            activity.curActivity = GetUserInfo;
                            user.Energy -= activity.activEnergy.Aggregate((current, next) => current + next) / 2;
                        }
                        break;
                    case ConsoleKey.W:
                        activity.Walking();
                        if (user.Energy > 0)
                        {
                            activity.curActivity = GetUserInfo;
                            user.Energy -= activity.activEnergy.Aggregate((current, next) => current + next) / 2;
                        }
                        break;
                    case ConsoleKey.T:
                        activity.Training();
                        if (user.Energy > 0)
                        {
                            activity.curActivity = GetUserInfo;
                            user.Energy -= activity.activEnergy.Aggregate((current, next) => current + next) / 2;
                        }
                        break;
                    case ConsoleKey.X:
                        activity.Relax();
                        if (user.Energy > 0)
                        {
                            activity.curActivity = GetUserInfo;
                            user.Energy += activity.activEnergy.Aggregate((current, next) => current + next) / 2;
                        }
                        break;
                    case ConsoleKey.E:
                        exit = true;
                        break;
                }
            }
        }
        public static void ShowUserMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose activity :");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Running - \"R\"");
            Console.WriteLine("Swimming - \"S\"");
            Console.WriteLine("Walking - \"W\"");
            Console.WriteLine("Training - \"T\"");
            Console.WriteLine("Relax - \"X\"");
            Console.WriteLine("Exit - \"E\"");
        }
        public static void GetUserInfo(string s, List<int> info)
        {
            Console.WriteLine($"User activity - {s}");
            Console.WriteLine($"Energy - {info.Aggregate((current, next) => current + next) / 2}");
        }
    }
}
