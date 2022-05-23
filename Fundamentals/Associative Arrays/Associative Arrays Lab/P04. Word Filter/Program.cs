using System;
using System.Linq;

namespace P04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Where(x=>x.Length%2==0)
                .ToArray();

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
