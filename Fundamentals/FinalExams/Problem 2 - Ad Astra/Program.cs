using System;
using System.Text.RegularExpressions;

namespace Problem_2___Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(#|\|)(?<name>[A-Za-z ]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1");
            string input = Console.ReadLine();
            MatchCollection matches = pattern.Matches(input);

            const int neededCalories = 2000;
            int totalCalories = 0;


            foreach (Match match in matches)
            {
                totalCalories += int.Parse(match.Groups["calories"].Value);
            }

            Console.WriteLine($"You have food to last you for: {totalCalories / neededCalories} days!");
            foreach (Match item in matches)
            {
                Console.WriteLine($"Item: {item.Groups["name"].Value}, Best before: {item.Groups["date"].Value}, Nutrition: {item.Groups["calories"].Value}");
            }
        }
    }
}
