using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter date : ");
            var userDate = Console.ReadLine();
            DateTime dateToPrint;

            while (!(DateTime.TryParse(userDate, out dateToPrint)))
            {
                Console.WriteLine("Error: Uncorrect date!");
                Console.Write("Enter date : ");
                userDate = Console.ReadLine();
            }
            Console.WriteLine($"Day is - {dateToPrint.DayOfWeek}");
        }
    }
}
