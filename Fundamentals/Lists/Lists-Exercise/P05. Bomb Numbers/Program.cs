using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] inputArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int bomb = inputArr[0];
            int power = inputArr[1];

            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] == bomb)
                {
                    numList[i] = 0;
                    for (int j = 1; j <= power; j++)
                    {
                        if (i+j>numList.Count)
                        {
                            continue;
                        }
                        else
                        {
                            numList[i + j] = 0;
                        }

                        if (i-j<0)
                        {
                            continue;
                        }
                        else
                        {
                            numList[i - j] = 0;
                        }
                    }
                }
            }

            Console.WriteLine(numList.Sum());
            //end
        }
    }
}
