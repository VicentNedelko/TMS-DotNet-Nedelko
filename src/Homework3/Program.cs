using System;

namespace DateTimeLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now;
            var userDate = GetUserDate();
            Console.WriteLine($"Start DATE - {userDate.startDate.ToShortDateString()}"); // check input data
            Console.WriteLine($"Finish DATE - {userDate.finishDate.ToShortDateString()}");
            Console.Write("Day to search - ");
            string dayToSearch = Console.ReadLine();
            PrintDays(userDate.startDate, userDate.finishDate, dayToSearch);

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

        private static void PrintDays (DateTime startDate, DateTime finishDate, string dayToCheck)
        {
            DateTime tempDate = startDate;
            int i = 0;
            while (tempDate.AddDays(i) <= finishDate)
            {
                if (tempDate.AddDays(i).DayOfWeek.ToString().Equals(dayToCheck))
                {
                    Console.WriteLine(tempDate.AddDays(i).ToShortDateString() + " - " + tempDate.AddDays(i).DayOfWeek);
                }
                i++;
            }
        }
    }
}
