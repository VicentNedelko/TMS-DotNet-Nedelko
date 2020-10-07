using System;
using System.Collections.Generic;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            var calendar = new List<Event>();
            bool addNewEvent = true;
            while (addNewEvent)
            {
                if (calendar.Count == 0)
                {
                    Console.WriteLine("Calendar is empty. Create new Event.");
                    calendar.Add(AddEvent());
                }
                else
                {
                    Console.WriteLine();
                    calendar.Add(AddEvent());
                }
                addNewEvent = CheckUserChoice();
            }
            PrintCalendar(calendar);
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--------------");
                Console.ForegroundColor = ConsoleColor.White;
                switch (UserMenuChoice())
                {
                    case 1:
                        calendar.Add(AddEvent());
                        break;
                    case 2:
                        EditEvent(calendar);
                        break;
                    case 3:
                        DeleteEvent(calendar);
                        break;
                }
                PrintCalendar(calendar);
            }
        }
        public static Event AddEvent()
        {
            Event eve = new Event();
            Console.Write("Enter discription : ");
            eve.Description = Console.ReadLine();
            Console.Write("Enter START date or press \"N\" for NOW : ");
            if (!DateTime.TryParse(Console.ReadLine(), out eve.startDate))
            {
                eve.startDate = DateTime.Now;
            }
            Console.Write("Enter FINISH date : ");
            eve.finishDate = DateTime.Parse(Console.ReadLine());
            if (eve.startDate > DateTime.Now)
            {
                eve.status = Event.State.ToDo;
            }
            else
            {
                eve.status = Event.State.InProcess;
                eve.startDate = DateTime.Now;
            }
            return eve;
        }
        public static void PrintCalendar(List<Event> calendar)
        {
            Console.Clear();
            foreach (var events in calendar)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"ID - ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(events.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Description - {events.Description}");
                Console.WriteLine($"Dates - {events.startDate.ToShortDateString()} -> { events.finishDate.ToShortDateString()} ");
                Console.WriteLine($"Status - {events.status}");
            }
        }
        public static bool CheckUserChoice()
        {
            Console.Write("Add one more event ? [Y/N]");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int UserMenuChoice()
        {
            Console.WriteLine("Choose operation : ");
            Console.WriteLine("ADD event - press \"A");
            Console.WriteLine("Edit event - press\"E");
            Console.WriteLine("Delete event - press\"D");
            int result = Console.ReadKey().Key switch
            {
                ConsoleKey.A => result = 1,
                ConsoleKey.E => result = 2,
                ConsoleKey.D => result = 3,
                _=> result = 0,
            };
            return result;
        }
        public static void EditEvent(List<Event> calendar)
        {
            bool isFound = false;
            int i = 0;
            Console.Write("Enter event ID : ");
            string id = Console.ReadLine().ToUpper();
            while(!isFound && i < calendar.Count)
            {
                if (id.Equals(calendar[i].Id))
                {
                    isFound = true;
                }
                else
                {
                    i++;
                }
            }
            if (isFound)
            {
                Console.Write("Enter new Description : ");
                calendar[i].Description = Console.ReadLine();
                Console.Write("Enter new START date : ");
                calendar[i].startDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter new FINISH date : ");
                calendar[i].finishDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter new STATUS [ToDo, InProcess, Done, Canceled] : ");
                calendar[i].status = Console.ReadLine().ToUpper() switch
                {
                    "TODO" => Event.State.ToDo,
                    "INPROCESS" => Event.State.InProcess,
                    "DONE" => Event.State.Done,
                    "CANCELED" => Event.State.Canceled,
                    _=> Event.State.Unknown,
                };
            }
        }
        public static void DeleteEvent(List<Event> calendar)
        {
            bool isFound = false;
            int i = 0;
            Console.Write("Enter event ID : ");
            string id = Console.ReadLine().ToUpper();
            while (!isFound && i < calendar.Count)
            {
                if (id.Equals(calendar[i].Id))
                {
                    isFound = true;
                }
                else
                {
                    i++;
                }
            }
            if(isFound)
            {
                calendar.RemoveAt(i);
            }
        }
    }
}
