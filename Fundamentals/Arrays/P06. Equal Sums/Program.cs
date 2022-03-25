using System;
using System.Linq;

namespace P06._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //int currentNumber = 0;
            bool foundNumber = false;

            for (int i = 0; i < numArr.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                int currentNumber = numArr[i];

                for (int j = i + 1; j < numArr.Length; j++)
                {
                    sumRight += numArr[j];
                }

                for (int k = i - 1; k >= 0; k--)
                {
                    sumLeft += numArr[k];
                }
                if (sumLeft  == sumRight)
                {
                    Console.WriteLine(i);
                    foundNumber = true;
                }
            }

            if (!foundNumber)
            {
                Console.WriteLine("no");
            }

        }
    }
}
