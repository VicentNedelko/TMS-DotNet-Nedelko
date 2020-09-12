using System;

namespace DateTimeLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now;
            var userDate = GetUserDate();
            Console.WriteLine($"Start DATE - {userDate.startDate}");
            Console.WriteLine($"Finish DATE - {userDate.finishDate}");

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
    }
}
