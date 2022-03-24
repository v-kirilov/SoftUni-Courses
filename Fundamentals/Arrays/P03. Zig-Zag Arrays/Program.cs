using System;
using System.Linq;

namespace P03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrOdd = new int[n];
            int[] arrEven = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 != 0)
                {
                    arrOdd[i - 1] = input[0];
                    arrEven[i - 1] = input[1];
                }
                else
                {
                    arrEven[i - 1] = input[0];
                    arrOdd[i - 1] = input[1];
                }
            }

            Console.Write(String.Join(" ", arrOdd));
            Console.WriteLine();
            Console.Write(String.Join(" ", arrEven));

        }
    }
}
