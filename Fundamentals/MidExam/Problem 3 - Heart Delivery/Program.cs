using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int cupidPlace = 0;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] words = input
                    .Split(' ')
                    .ToArray();

                int index = int.Parse(words[1]);
                cupidPlace += index;
                if (cupidPlace > neighborhood.Count - 1)
                {
                    cupidPlace = 0;
                }
                if (neighborhood[cupidPlace] == 0)
                {
                    Console.WriteLine($"Place {cupidPlace} already had Valentine's day.");
                    continue;
                }
                else
                {
                    neighborhood[cupidPlace] -= 2;
                    if (neighborhood[cupidPlace] == 0)
                    {
                        Console.WriteLine($"Place {cupidPlace} has Valentine's day.");
                    }
                }
            }

            Console.WriteLine($"Cupid's last position was {cupidPlace}.");
            if (neighborhood.Sum() == 0)
            {
                Console.WriteLine($"Mission was successful.");
            }else
            {
                int houseCount = 0;
                for (int i = 0; i < neighborhood.Count; i++)
                {
                    if (neighborhood[i]!=0)
                    {
                        houseCount++;
                    }
                }
                Console.WriteLine($"Cupid has failed {houseCount} places.");
            }
        }
    }
}
