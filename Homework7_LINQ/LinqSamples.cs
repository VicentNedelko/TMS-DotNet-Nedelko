using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace Homework7_LINQ
{
    public class LinqSamples
    {
        List<string> str = new List<string> { "apple", "mango", "orange", "passionfruit", "grape", "blueberry", "strawberry" };
        List<int> ints = new List<int> { 78, 92, 100, 37, 81 };
        ArrayList arrayList = new ArrayList() { };

        public void Run()
        {
            ///<summary>
            /// Aggregate.
            /// </summary>
            Console.WriteLine($"Total numbers of character - {(str.Aggregate((current, next) => current + next)).Length}");
            List<int> strToInt = new List<int>();
            ///<summary>
            /// Average.
            /// </summary>
            foreach(string s in str)
            {
                strToInt.Add(s.Length);
            }
            Console.WriteLine($"Average word length {strToInt.Average()} character");
            Console.WriteLine($"Max - {strToInt.Max()}");
            Console.WriteLine($"Min - {strToInt.Min()}");
            Console.WriteLine($"Sum - {strToInt.Sum()}");

            arrayList.Add("fox");
            arrayList.Add("wolf");
            arrayList.Add("tiger");

            var resultCast = arrayList.Cast<string>().Concat(str).OrderByDescending(item => item).SkipWhile(item => item.Length <= 3);
            Console.WriteLine("-------");
            Console.WriteLine("Cast & Concat result : ");
            foreach (string item in resultCast)
            {
                Console.Write(item + "; ");
            }
            Console.WriteLine();
            Console.WriteLine("-------");
        }
    }
}
