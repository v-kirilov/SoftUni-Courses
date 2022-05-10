using System;
using System.Text.RegularExpressions;

namespace P03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<days>\d{2})(/|-|\.)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match item in matches)
            {
                string day = item.Groups["days"].Value;
                string month = item.Groups["month"].Value;
                string year = item.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
