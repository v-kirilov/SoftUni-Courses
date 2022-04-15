using System;

namespace RealExam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterForOnePerson = double.Parse(Console.ReadLine());
            double foodForOnePerson = double.Parse(Console.ReadLine());

            double totalWater = 1.0 * days * players * waterForOnePerson;
            double totalFood = 1.0 * days * players * foodForOnePerson;

            double energyLoss = 0;
            for (int i = 1; i <= days; i++)
            {
                energyLoss = double.Parse(Console.ReadLine());
                energy -= energyLoss;
                if (energy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
                    break;
                }
                if (i % 2 == 0)
                {
                    totalWater *= .7;
                    energy *= 1.05;
                }
                if (i % 3 == 0)
                {
                    totalFood = totalFood - totalFood / players;
                    energy *= 1.1;
                }

            }
            if (energy>0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
        }
    }
}
