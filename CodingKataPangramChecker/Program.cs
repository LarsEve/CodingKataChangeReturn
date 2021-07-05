using System;
using System.Linq;

namespace CodingKataPangramChecker
{
    /// <summary>
    /// Pangram Checker Class
    /// </summary>
    class Program
    {
        static char[] alphabet = new[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        /// <summary>
        /// Check input string for pangram
        /// </summary>
        /// <param name="args">Empty</param>
        static void Main(string[] args)
        {
            int count = 0;
            System.Console.WriteLine("Input");
            string ip = System.Console.ReadLine();

            foreach (char c in alphabet)
            {
                foreach (char l in ip.ToLower())
                {
                    if (c == l)
                    {
                        count++;
                        break;
                    }
                }
            }

            if (count == 26 && !IsDoubleValue(ip))
                System.Console.WriteLine(ip + "contains all alphabet letters exactly once");
            else if (count == 26 && IsDoubleValue(ip))
                System.Console.WriteLine(ip + " contains all alphabet letters more than once");
            else
                System.Console.WriteLine(ip + " does not contain all alphabet letters at least once");

            System.Console.ReadLine();
        }
        /// <summary>
        /// Checks input string 4 double char
        /// </summary>
        /// <param name="input">input string</param>
        /// <returns> boolean has double value</returns>
        public static bool IsDoubleValue(string input)
        {
            var t = input.GroupBy(n => n).Select(n => new
            {
                MetricName = n.Key,
                MetricCount = n.Count()
            }).ToList();

            if (t.Where(x => x.MetricCount > 1).Count() > 0)
            {
                return true;
            }
            return false;

        }
    }
}
