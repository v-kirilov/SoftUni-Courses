using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encrypter = @"[STARstar]";
            int counter = int.Parse(Console.ReadLine());
            string planetdecrypter = @"@(?<name>[A-Z]*[a-z]*)[^@\-!:>]*?:(?<population>\d+)[^@\-!:>]*?!(?<attacktype>[A-Z])![^@\-!:>]*?->(?<soldiers>\d+)";

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < counter; i++)
            {
                string input = Console.ReadLine();
                MatchCollection decryptCollection = Regex.Matches(input, encrypter);
                int decryptCounter = decryptCollection.Count();

                string output = string.Empty;

                foreach (var currentCh in input)
                {
                    char newChar = (char)(currentCh - decryptCounter);
                    output += newChar.ToString();
                }




                MatchCollection planetMatch = Regex.Matches(output, planetdecrypter);
                foreach (Match match in planetMatch)
                {
                    string planet = match.Groups["name"].Value;
                    string attackType = match.Groups["attacktype"].Value;

                    if (attackType=="A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }
            attackedPlanets = attackedPlanets.OrderBy(x => x).ToList();
            destroyedPlanets= destroyedPlanets.OrderBy(y => y).ToList();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count>0)
            {
                foreach (var planet in attackedPlanets)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count>0)
            {
                foreach (var planet in destroyedPlanets)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

        }
    }
}
