using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2___The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            List<int> wagons = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < wagons.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (wagons[i]==4)
                    {
                        break;
                    }
                    if (people > 0)
                    {
                        wagons[i]++;
                        people--;
                    }else
                    {
                        break;
                    }
                }
                if (people == 0)
                {
                    break;
                }
            }
            if (people==0)
            {
                if (wagons[wagons.Count-1]==4)
                {
                    Console.WriteLine(string.Join(" ",wagons));
                }else
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(string.Join(" ", wagons));
                }
            }else
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}
