using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            List<int> finalProduct = new List<int>();

            for (int i = input.Length-1; i >= 0; i--)
            {
                List<int> temp = input[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                for (int j = 0; j < temp.Count; j++)
                {
                    int newNumber = temp[j];
                    finalProduct.Add(newNumber);
                }
            }

            Console.WriteLine(String.Join(" ", finalProduct));
        }
    }
}
