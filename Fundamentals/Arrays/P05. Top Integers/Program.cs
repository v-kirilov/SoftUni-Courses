using System;
using System.Linq;

namespace P05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < numberArr.Length; i++)
            {
                bool isGreater = true;

                for (int j = i+1; j < numberArr.Length; j++)
                {
                    if (numberArr[i] <= numberArr[j])
                    {
                        isGreater = false;
                    }

                }
                if (isGreater)
                {
                    Console.Write(numberArr[i]+" ");

                }

            }
        }
    }
}
