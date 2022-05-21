using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double,int> dict=new SortedDictionary<double,int>();

            foreach (double item in input)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }else
                {
                    dict.Add(item, 1);
                }
            }

            foreach (KeyValuePair<double,int> item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
