using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Plant_Discovery
{
    internal class Program
    {
        public class Plant
        {
            public Plant(string name, double rarity, List<double> rating)
            {
                this.Name = name;
                this.Rating = rating;
                this.Rarity = rarity;
            }
            public string Name { get; set; }
            public double Rarity { get; set; }
            public List<double> Rating { get; set; }
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                List<Plant> plants = new List<Plant>();
                for (int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split("<->");
                    string name = input[0];
                    double rarity = double.Parse(input[1]);
                    List<double> plantRating = new List<double>();

                    Plant newPlant = new Plant(name, rarity, plantRating);
                    plants.Add(newPlant);
                }

                string cmd = Console.ReadLine();
                while (cmd != "Exhibition")
                {
                    string[] cmdArgs = cmd.Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);
                    string action = cmdArgs[0];
                    string plantName = cmdArgs[1];

                    if (action == "Rate")
                    {
                        double rating = double.Parse(cmdArgs[2]);
                        Plant plant = plants.FirstOrDefault(x => x.Name == plantName);
                        if (plant != null)
                        {
                            plant.Rating.Add(rating);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                    else if (action == "Update")
                    {
                        int newRarity = int.Parse(cmdArgs[2]);
                        Plant plant = plants.FirstOrDefault(x => x.Name == plantName);
                        if (plant != null)
                        {
                            plant.Rarity = newRarity;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                    else if (action == "Reset")
                    {
                        Plant plant = plants.FirstOrDefault(x => x.Name == plantName);
                        if (plant != null)
                        {
                            plant.Rating.Clear();
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }


                    cmd = Console.ReadLine();
                }

                Console.WriteLine("Plants for the exhibition:");
                for (int i = 0; i < plants.Count; i++)
                {
                    if (plants[i].Rating.Count == 0)
                    {
                        plants[i].Rating.Add(0);
                    }
                }
                foreach (var plant in plants)
                {
                    Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {plant.Rating.Average():f2}");
                }
            }
        }
    }
}
