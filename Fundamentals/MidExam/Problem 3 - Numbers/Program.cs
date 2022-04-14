using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> outputList = new List<int>();
            double average = 0;
            average = inputList.Average();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] > average)
                {
                    outputList.Add(inputList[i]);
                }
            }
            outputList.Sort();
            outputList.Reverse();
            if (outputList.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }
            if (outputList.Count > 5)
            {
                int removeCount = outputList.Count - 5;
                outputList.RemoveRange(5, removeCount);
            }
            Console.WriteLine(String.Join(" ", outputList));
        }
    }
}
