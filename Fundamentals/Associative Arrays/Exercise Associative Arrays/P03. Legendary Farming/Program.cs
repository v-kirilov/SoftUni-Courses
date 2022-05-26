using System;
using System.Linq;
using System.Collections.Generic;

namespace P03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string topMaterial = string.Empty;
            bool ItemObtained = false;

            while (!ItemObtained)
            {
                string[] materials = Console.ReadLine()
                    .ToLower()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < materials.Length; i += 2)
                {
                    int quantity = int.Parse(materials[i]);
                    string material = materials[i + 1];

                    if (dict.ContainsKey(material))
                    {
                        dict[material] += quantity;
                        if (dict[material] >= 250)
                        {
                            dict[material] -= 250;
                            ItemObtained = true;
                            topMaterial = material;
                            break;
                        }
                    }
                    else
                    {
                        if (quantity>=250)
                        {
                            quantity -= 250;
                            ItemObtained = true;
                            topMaterial = material;
                            dict.Add(material, quantity);
                            break;
                        }else
                        {
                            dict.Add(material, quantity);
                        }
                    }
                }
            }

            if (topMaterial == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (topMaterial == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (topMaterial == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            Dictionary<string, int> finalDict = new Dictionary<string, int>();

            if (dict.ContainsKey("shards"))
            {
                finalDict.Add("shards", dict["shards"]);
            }
            else
            {
                finalDict.Add("shards", 0);
            }

            if (dict.ContainsKey("motes"))
            {
                finalDict.Add("motes", dict["motes"]);
            }
            else
            {
                finalDict.Add("motes", 0);
            }

            if (dict.ContainsKey("fragments"))
            {
                finalDict.Add("fragments", dict["fragments"]);
            }
            else
            {
                finalDict.Add("fragments", 0);
            }

            foreach (var item in dict)
            {
                if (item.Key != "shards" && item.Key != "motes" && item.Key != "fragments")
                {
                    finalDict.Add(item.Key, item.Value);
                }
            }

            foreach (var item in finalDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }

        static bool IsItemFound(Dictionary<string, int> dict)
        {
            if (dict.Any(x => x.Value >= 250))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
