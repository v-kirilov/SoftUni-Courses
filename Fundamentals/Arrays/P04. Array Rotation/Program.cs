using System;
using System.Linq;

namespace P04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation; i++)
            {
                int tempNumber = numArr[0];
                for (int j = 0; j < numArr.Length-1; j++)
                {
                    numArr[j] = numArr[j + 1];
                }

                numArr[numArr.Length - 1] = tempNumber;
            }

            Console.WriteLine(String.Join(" ",numArr));
        }
    }
}
