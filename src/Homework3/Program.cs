using System;
using System.Collections.Generic;

namespace DateTimeLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var userDate = GetUserDate();
            List<DateTime> daysAsList = new List<DateTime>();
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Start DATE - {userDate.startDate.ToShortDateString()}"); // check input data
            Console.WriteLine($"Finish DATE - {userDate.finishDate.ToShortDateString()}");
            Console.WriteLine("----------------------------------");
            DayOfWeek dayToSearch = InputDayEnum();
            Console.WriteLine("----------------------------------");
            PrintDays(userDate.startDate, userDate.finishDate, dayToSearch, out daysAsList);
            PrintList(daysAsList, dayToSearch);

        }

        private static void PrintList(List<DateTime> daysAsList, DayOfWeek dayToPrint)
        {
            foreach(DateTime day in daysAsList)
            {
                Console.WriteLine(day.ToShortDateString() + " - " + dayToPrint);
            }
        }

        private static DayOfWeek InputDayEnum()
        {
            Console.Write("Enter DAY to search - ");
            string dayToSearch = Console.ReadLine();
            DayOfWeek dayEnum;
            while (!Enum.TryParse<DayOfWeek>(dayToSearch, out dayEnum))
            {
                Console.WriteLine("Error! Wrong DAY entered.");
                Console.Write("Enter DAY to search - ");
                dayToSearch = Console.ReadLine();
            }
            Console.WriteLine("DAY entered - " + dayEnum);
            return dayEnum;
        }

        private static (DateTime startDate, DateTime finishDate) GetUserDate()
        {
            DateTime startDate, finishDate;
            Console.Write("Enter start Date : ");
            string strDate = Console.ReadLine();
            while (!DateTime.TryParse(strDate, out startDate))
            {
                Console.WriteLine("Error! Wrong Date entered.");
                Console.Write("Enter start Date : ");
                strDate = Console.ReadLine();
            }
            Console.Write("Enter finish date : ");
            strDate = Console.ReadLine();
            while (!DateTime.TryParse(strDate, out finishDate))
            {
                Console.WriteLine("Error! Wrong Date entered.");
                Console.Write("Enter finish date : ");
                strDate = Console.ReadLine();
            }
            var result = (startDate, finishDate);
            return result;
        }

        private static void PrintDays (DateTime startDate, DateTime finishDate, DayOfWeek dayToCheck, out List<DateTime> daysArray)
        {
            DateTime tempDate = startDate;
            int i = 0;
            List<DateTime> daysList = new List<DateTime>();
            while (tempDate.AddDays(i) <= finishDate)
            {
                if (tempDate.AddDays(i).DayOfWeek == dayToCheck)
                {
                    //Console.WriteLine(tempDate.AddDays(i).ToShortDateString() + " - " + tempDate.AddDays(i).DayOfWeek);
                    daysList.Add(tempDate.AddDays(i));
                }
                i++;
            }
            daysArray = daysList;
        }
    }
}
