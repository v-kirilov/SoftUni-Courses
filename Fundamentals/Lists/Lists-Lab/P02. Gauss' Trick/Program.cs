using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            List<double> resultList = new List<double>();


            for (int i = 0; i < numbers.Count / 2; i++)
            {
                double sum = numbers[i] + numbers[numbers.Count - i - 1];
                resultList.Add(sum);


            }

            if (numbers.Count % 2 != 0)
            {
                resultList.Add(numbers[numbers.Count /2]);
            }


            Console.WriteLine(String.Join(" ", resultList));
        }
    }
}
