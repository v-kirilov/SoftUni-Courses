using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_2___Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(=|\/)(?<places>[A-Z][a-zA-z]{2,})(\1)");

            string places = Console.ReadLine();

            MatchCollection matches = pattern.Matches(places);

            int travelPoints = 0;
            List<string> placesList = new List<string>();

            foreach (Match match in matches)
            {
                travelPoints += match.Groups["places"].Value.Length;
                placesList.Add(match.Groups["places"].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ",placesList)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }


}

