using System;
using System.Linq;

namespace P07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int repeatedNumber = 0;
            int maxCounter = int.MinValue;


            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                int counter = 0;

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (currentNum == arr[j])
                    {
                        counter++;
                    }else
                    {
                        break;
                    }
                   
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    repeatedNumber = currentNum;
                }
            }

            for (int i = 0; i <= maxCounter; i++)
            {
                Console.Write(repeatedNumber+" ");
            }
        }
    }
}
