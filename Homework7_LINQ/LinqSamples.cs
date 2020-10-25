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
        List<int> ints2 = new List<int> { 23, 54, 89, 11, 98 };
        ArrayList arrayList = new ArrayList() { };
        List<int> randList1 = new List<int>();
        List<int> randList2 = new List<int>();

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
            Console.WriteLine($"Average word length {strToInt.Average()} characters");
            Console.WriteLine($"Max - {strToInt.Max()}");
            Console.WriteLine($"Min - {strToInt.Min()}");
            Console.WriteLine($"Sum - {strToInt.Sum()}");

            arrayList.Add("fox");
            arrayList.Add("wolf");
            arrayList.Add("tiger");

            var resultCast = arrayList.Cast<string>().Concat(str).OrderByDescending(item => item).SkipWhile(item => item.Length <= 5).Take(4);
            Console.WriteLine("-------");
            Console.WriteLine("Cast & Concat result : ");
            foreach (string item in resultCast)
            {
                Console.Write(item + "; ");
            }
            Console.WriteLine();
            Console.WriteLine("-------");

            ///<summary>
            /// Select.
            /// </summary>
            Console.WriteLine();
            Console.WriteLine("Berries : ");
            var berries = str.Select((item) =>
            {
                if (item.Contains("berry"))
                    return item;
                else return string.Empty;
            });
            foreach(string s in berries)
            {
                if (!string.IsNullOrEmpty(s))
                Console.Write($"{s}; ");
            }
            var moreThanFour = str.Select((item) =>
            {
                if (item.Contains("berry"))
                {
                    return item.Substring(0, item.Length - item.IndexOf("berry", 0));
                }
                else
                {
                    return item;
                }
            });
            Console.WriteLine();
            Console.WriteLine("-------");
            Console.WriteLine("Without BERRY : ");
            foreach(string s in moreThanFour)
            {
                Console.Write($"{s}; ");
            }
            Console.WriteLine();
            Console.WriteLine("Sorted and Trimmed : ");
            var sortedAndTrimmed = moreThanFour.OrderBy(s => s.Length).TakeWhile(s => s.Length < 7);
            foreach(string s in sortedAndTrimmed)
            {
                Console.Write($"{s}; ");
            };
            Console.WriteLine();
            var groupedValues = str.GroupBy(s => s.Length);
            Console.WriteLine();
            Console.WriteLine("-------");
            foreach(var group in groupedValues)
            {
                Console.WriteLine("Group - ");
                foreach (string s in group)
                {
                    Console.Write($"{s}; ");
                }
                Console.WriteLine();
            };
            Console.WriteLine();
            Console.WriteLine("-------");
            Console.WriteLine("Check if Empty : ");
            var checkIfEmpty = str.DefaultIfEmpty();
            if(checkIfEmpty != null)
            {
                foreach(string s in checkIfEmpty)
                {
                    Console.Write(s);
                }
            }
            Console.WriteLine();
            Console.WriteLine("//////////////////////");
            Console.WriteLine("Generate new Enumerable...");
            var rangeInt = Enumerable.Range(0, 25);
            foreach(int i in rangeInt)
            {
                Console.Write($"{i}; ");
            }
            Console.WriteLine();
            Console.WriteLine();
            if (str.Contains("mango"))
            {
                var newMango = Enumerable.Repeat("mango", 10);
                var superStr = str.Concat(newMango);
                Console.WriteLine();
                Console.WriteLine("New Mango cancatenated : ");
                foreach (string s in superStr)
                {
                    Console.Write($"{s}; ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("/////////////////////");
            Console.WriteLine("Zipped Enum");
            var zippedEnum = ints.Zip(ints2, (input1, input2) =>
            {
                return input1 + input2;
            });
            foreach(int i in zippedEnum)
            {
                Console.Write($"{i}; ");
            }
            Console.WriteLine();
            Console.WriteLine();
            FillWithRandomValues(randList1);
            FillWithRandomValues(randList2);
            Console.WriteLine("LIST 1");
            foreach(int i in randList1)
            {
                Console.Write(i + "; ");
            }
            Console.WriteLine();
            Console.WriteLine("LIST 2");
            foreach(int i in randList2)
            {
                Console.Write(i + "; ");
            }
            Console.WriteLine();
            var finalList = randList1.Concat(randList2).Distinct().OrderBy(i => i);
            var finalList2 = randList1.Except(randList2).Distinct().OrderBy(i => i);
            Console.WriteLine("Distinct : ");
            foreach(int i in finalList)
            {
                Console.Write(i + "; ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Except : ");
            foreach (int i in finalList2)
            {
                Console.Write(i + "; ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        private void FillWithRandomValues(List<int> listToFill)
        {
            Random rand = new Random();
            for(int i = 0; i < 10; i++)
            {
                listToFill.Add(rand.Next(100));
            }
        }
    }
}
