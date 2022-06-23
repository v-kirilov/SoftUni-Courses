using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Exam_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(@|#)+(?<color>[a-z]{3,})(@|#)+([^a-zA-Z\d]*)(\/)+(?<amount>\d+)(\/)+");
            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);

            foreach (Match match in matches)
            {
                decimal amount = decimal.Parse(match.Groups["amount"].Value);
                
              
                Console.WriteLine($"You found {amount} {match.Groups["color"].Value} eggs!");
                
            }
        }
    }
}
