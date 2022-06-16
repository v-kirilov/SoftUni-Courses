using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3__P_rates
{
    internal class Program
    {
        public class Cities
        {
            public Cities(string name, int population, int gold)
            {
                this.Name = name;
                this.Population = population;
                this.Gold = gold;
            }
            public string Name { get; set; }
            public int Population { get; set; }
            public int Gold { get; set; }
        }
        static void Main(string[] args)
        {
            List<Cities> cities = new List<Cities>();

            string input = Console.ReadLine();
            while (input != "Sail")
            {
                string[] cmdArgs = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string newCityName = cmdArgs[0];
                int population = int.Parse(cmdArgs[1]);
                int gold = int.Parse(cmdArgs[2]);
                bool isCityFound = false;
                foreach (var city in cities)
                {
                    if (city.Name == newCityName)
                    {
                        city.Population += population;
                        city.Gold += gold;
                        isCityFound = true;
                    }
                }
                if (isCityFound == false)
                {
                    Cities newCity = new Cities(newCityName, population, gold);
                    cities.Add(newCity);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArgs = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                if (action == "Plunder")
                {
                    string name = cmdArgs[1];
                    int population = int.Parse(cmdArgs[2]);
                    int gold = int.Parse(cmdArgs[3]);
                    bool isCityWiped = false;
                    foreach (var city in cities)
                    {
                        if (city.Name == name)
                        {
                            city.Population -= population;
                            city.Gold -= gold;
                            Console.WriteLine($"{name} plundered! {gold} gold stolen, {population} citizens killed.");
                        }
                        if (city.Gold <= 0 || city.Population <= 0)
                        {
                            Console.WriteLine($"{name} has been wiped off the map!");
                            isCityWiped = true;
                        }
                    }
                    if (isCityWiped == true)
                    {
                        RemoveCity(cities, name);
                    }
                }
                else if (action == "Prosper")
                {
                    string name = cmdArgs[1];
                    int gold = int.Parse(cmdArgs[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        input = Console.ReadLine();
                        continue;
                    }
                    foreach (var city in cities)
                    {
                        if (city.Name == name)
                        {
                            city.Gold+=gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {name} now has {city.Gold} gold.");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            if (cities.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }

        }
        static void RemoveCity(List<Cities> cities, string name)
        {
            Cities item = cities.SingleOrDefault(x => x.Name == name);
            cities.Remove(item);
        }

    }

}
