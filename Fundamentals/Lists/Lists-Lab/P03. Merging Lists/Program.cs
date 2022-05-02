using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> firstList = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            List<double> secondList = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            List<double> resultList = new List<double>();

            int bigCount = 0;

            if (firstList.Count > secondList.Count)
            {
                bigCount = firstList.Count;
            }
            else
            {
                bigCount = secondList.Count;
            }

            for (int i = 0; i < bigCount; i++)
            {
                if (firstList.Count >= i+1)
                {
                    resultList.Add(firstList[i]);
                }
                if (secondList.Count >= i+1)
                {
                    resultList.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
