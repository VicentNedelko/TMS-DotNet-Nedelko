using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    public class Account
    {
        /// <summary>
        /// Currency exchange.
        /// </summary>
        const decimal usdToByn = 2.57M;
        const decimal euroToByn = 3.02M;
        public decimal Balance { get; set; }
        public event Action<decimal, string> Notify;

        public Account(decimal sum)
        {
            Balance = sum;
        }
        public void AddMoney(decimal sumToAdd)
        {
            Balance += sumToAdd;
            Notify?.Invoke(sumToAdd, " Add.");
        }
        public void GetMoney(decimal sumToWithDraw)
        {
            Balance -= sumToWithDraw;
            Notify?.Invoke(sumToWithDraw, " Withdraw.");
        }
        public void PrintActualBalance()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Actual Balance = {Balance} BYN.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public (string, decimal) ChooseCurrency()
        {
            (string, decimal) result;
            Console.WriteLine("Choose currency : ");
            Console.WriteLine("-------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("BYN - [B]");
            Console.WriteLine("USD - [U]");
            Console.WriteLine("EURO - [E]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.B:
                    result = ("BYN", 1);
                    break;
                case ConsoleKey.U:
                    result = ("USD", usdToByn);
                    break;
                case ConsoleKey.E:
                    result =("EURO", euroToByn);
                    break;
                default:
                    result = ("X", 0);
                    break;
            }
            return result;
        }
        public void DisplayOperationInfo(decimal sum, string operation)
        {
            Console.WriteLine($"Operation - {operation} Amount - {sum} BYN.");
        }
    }
}
