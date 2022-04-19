using System;

namespace P02.__Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string first = string.Empty;
            string second = string.Empty;

            if (input[0].Length >= input[1].Length)
            {
                 first = input[0];
                 second = input[1];
            }
            else
            {
                 first = input[1];
                 second = input[0];
            }
            int sum = FindSumOfStrings(first, second);
            Console.WriteLine(sum);
        }

        static int FindSumOfStrings(string first, string second)
        {
            int sum = 0;
            for (int i = 0; i < second.Length; i++)
            {
                sum += (int)first[i]*(int)second[i];
            }
            if (first.Length>second.Length)
            {
                for (int i = second.Length; i < first.Length; i++)
                {
                    sum += (int)first[i];
                }
            }
            return sum;
        }
    }
}
