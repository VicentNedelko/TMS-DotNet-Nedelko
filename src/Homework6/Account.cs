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
        public Account(decimal sum)
        {
            Balance = sum;
        }
        public void AddMoney(decimal sumToAdd)
        {
            Balance += sumToAdd;
        }
        public void GetMoney(decimal sumToWithDraw)
        {
            Balance -= sumToWithDraw;
        }
        public void PrintActualBalance()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Actual Balance = {Balance}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void addInfo(decimal sum)
        {
            Console.WriteLine();
            Console.WriteLine("Your add {0:f2} BYN to your account.", sum);
        }
        public void addInfo(string str, decimal sum)
        {
            Console.WriteLine();
            Console.WriteLine("Your add {0:f2} BYN to your account.", sum);
        }
        public void withdrawInfo(decimal sum)
        {
            Console.WriteLine();
            Console.WriteLine("You withdraw {0:f2} BYN.", sum);
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
                    Console.Clear();
                    result = ("BYN", 1);
                    break;
                case ConsoleKey.U:
                    Console.Clear();
                    result = ("USD", usdToByn);
                    break;
                case ConsoleKey.E:
                    Console.Clear();
                    result =("EURO", euroToByn);
                    break;
                default:
                    Console.Clear();
                    result = ("X", 0);
                    break;
            }
            return result;
        }
    }
}
