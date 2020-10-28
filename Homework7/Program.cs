using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework7
{
    class Program
    {
        public static void Main(string[] args)
        {
            User user;
            Console.WriteLine("Press SPACE to enter start Energy or press ECS to default : ");
            if(Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Console.WriteLine("A");
                user = new User();
            }
            else
            {
                Console.Write("Enter start Energy : ");
                if (double.TryParse(Console.ReadLine(), out double valueEnergy))
                {
                    user = new User(valueEnergy);
                }
                else
                {
                    user = new User();
                    Console.WriteLine("Error! Wrong value entered.");
                }
            }
            Activity activity = new Activity();
            Console.WriteLine();
            ShowUserMenu();
            bool exit = false;
            while (!exit)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.R:
                        if (user.Energy > 0)
                        {
                            Console.WriteLine();
                            activity.curActivity = GetUserInfo;
                            activity.Running();
                            user.Energy -= activity.activEnergy.Aggregate((current, next) => current + next) / 2;
                            PrintUserData();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Let's Relax!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                            break;
                    case ConsoleKey.S:
                        if (user.Energy > 0)
                        {
                            Console.WriteLine();
                            activity.curActivity = GetUserInfo;
                            activity.Swimming();
                            user.Energy -= activity.activEnergy.Aggregate((current, next) => current + next) / 2;
                            PrintUserData();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Let's Relax!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.W:
                        if (user.Energy > 0)
                        {
                            Console.WriteLine();
                            activity.curActivity = GetUserInfo;
                            activity.Walking();
                            user.Energy -= activity.activEnergy.Aggregate((current, next) => current + next) / 2;
                            PrintUserData();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Let's Relax!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.T:
                        if (user.Energy > 0)
                        {
                            Console.WriteLine();
                            activity.curActivity = GetUserInfo;
                            activity.Training();
                            user.Energy -= activity.activEnergy.Aggregate((current, next) => current + next) / 2;
                            PrintUserData();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Let's Relax!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.X:
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            activity.curActivity = GetUserInfo;
                            activity.Relax();
                            user.Energy += activity.activEnergy.Aggregate((current, next) => current + next) / 2;
                            Console.WriteLine($"USER Energy - {user.Energy} KJ");
                            Console.WriteLine($"HeartRate - {(int)activity.activEnergy.Average()} bpm");
                            Console.WriteLine("-------");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.E:
                        exit = true;
                        break;
                }
            }
            void PrintUserData()
            {
                Console.WriteLine($"USER Energy - {user.Energy} KJ");
                Console.WriteLine($"HeartRate - {(int)activity.activEnergy.Average()} bpm");
                Console.WriteLine($"Equivalent steps - {(int)(activity.activEnergy.Average() * 1.2)}");
                Console.WriteLine("-------");
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
            Console.WriteLine("-------");
            Console.Write("Enter : ");
        }
        public static void GetUserInfo(string s, List<int> info)
        {
            Console.WriteLine($"User activity - {s}");
            Console.WriteLine($"Energy - {info.Aggregate((current, next) => current + next) / 2} KJ");
        }
    }
}
