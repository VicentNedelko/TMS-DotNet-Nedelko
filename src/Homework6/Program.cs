using System;
using System.Threading;
namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<decimal> Operation;
            //Action<decimal> ShowInformation;
            Action<string, decimal> ShowInformation;
            bool goFuther = true;
            Console.Write("Enter start sum [BYN] : ");
            Account account = new Account(Decimal.Parse(Console.ReadLine()));
            while(goFuther)
            {
                PrintUserMenu();
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Operation = account.AddMoney;
                        ShowInformation = account.addInfo;
                        Console.Write("Enter sum to add [BYN] : ");
                        decimal sum = Decimal.Parse(Console.ReadLine());
                        Operation.Invoke(sum);
                        ShowInformation.Invoke("BYN",sum);
                        break;
                    case ConsoleKey.W:
                        Console.Clear();
                        Operation = account.GetMoney;
                        ShowInformation = account.withdrawInfo;
                        var userChoice = account.ChooseCurrency();
                        Console.Write($"Enter sum to withdraw : [{userChoice.Item1}]");
                        sum = Decimal.Parse(Console.ReadLine()) * userChoice.Item2;
                        if (sum <= account.Balance)
                        {
                            Operation.Invoke(sum);
                            ShowInformation(userChoice.Item1, sum);
                        }
                        else
                        {
                            Console.WriteLine("Error! Your sum is exceeding the balance.");
                        }
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        account.PrintActualBalance();
                        break;
                    case ConsoleKey.E:
                        goFuther = false;
                        break;
                }

            }
        }
        public static void PrintUserMenu()
        {
            Console.WriteLine("------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose operation : ");
            Console.WriteLine("Top up an Account - [A]");
            Console.WriteLine("Withdrawal of funds - [W]");
            Console.WriteLine("Display actual balance - [D]");
            Console.WriteLine("Exit - [E]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------");
        }
    }
}
