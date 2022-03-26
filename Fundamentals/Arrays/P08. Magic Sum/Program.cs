using System;
using System.Linq;

namespace P08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                int currentSum = 0;

                for (int j = i+1; j < arr.Length; j++)
                {
                    currentSum = currentNum + arr[j];

                    if (currentSum == magicSum)
                    {
                        Console.Write(currentNum + " " + arr[j]);
                        Console.WriteLine();
                    }
                }

            }
        }
    }
}
