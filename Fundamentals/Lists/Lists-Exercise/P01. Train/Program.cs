using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> vagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArray = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);


                if (inputArray[0] == "Add")
                {
                    int newWagon = int.Parse(inputArray[1]);
                    vagons.Add(newWagon);
                }
                else
                {
                    int extraPassengers = int.Parse(inputArray[0]);
                    for (int i = 0; i < vagons.Count; i++)
                    {
                        int currentVagon = vagons[i];
                        if (extraPassengers+currentVagon>maxCapacity)
                        {
                            continue;
                        }else
                        {
                            vagons[i]+=extraPassengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ",vagons));
        }
    }
}
