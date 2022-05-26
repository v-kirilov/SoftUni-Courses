using System;
using System.Linq;
using System.Collections.Generic;

namespace P03._Legendary_Farming_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendary = new Dictionary<string, int>()
            {
                { "shards",0},
                { "motes",0},
                { "fragments",0}
            };
            const int maxMaterialNeeded = 250;
            string maxedMaterial = string.Empty;

            Dictionary<string, int> junk = new Dictionary<string, int>();

            bool isFound = false;

            while (!isFound)
            {
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];
                    if (legendary.ContainsKey(material))
                    {
                        legendary[material] += quantity;
                        if (legendary[material] >= maxMaterialNeeded)
                        {
                            maxedMaterial = material;
                            legendary[material] -= maxMaterialNeeded;
                            isFound = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk[material] = 0;
                        }
                        junk[material] += quantity;
                    }
                }
            }

            if (maxedMaterial=="shards")
            {
                Console.WriteLine($"Shadowmourne obtained!");
            }
            else if (maxedMaterial == "fragments")
            {
                Console.WriteLine($"Valanyr obtained!");
            }
            else if (maxedMaterial == "motes")
            {
                Console.WriteLine($"Dragonwrath obtained!");
            }

            foreach (var item in legendary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
