using System;
using System.Collections.Generic;

namespace Homework7
{
    class Program
    {
        public static void Main(string[] args)
        {
            ShowUserMenu();
            Activity activity = new Activity();
            bool exit = false;
            while (!exit)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.R:
                        activity.curActivity += ShowUserMenu;
                        activity.Running();
                        break;
                    case ConsoleKey.S:
                        activity.Swimming();
                        break;
                    case ConsoleKey.W:
                        activity.Walking();
                        break;
                    case ConsoleKey.T:
                        activity.Training();
                        break;
                    case ConsoleKey.X:
                        activity.Relax();
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


    }
}
