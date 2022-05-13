using System;
using System.Text.RegularExpressions;

namespace P03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)\%[^|\$%\.]*?\<(?<product>\w+)>[^|\$%\.]*?\|(?<quantity>\d+)\|[^|\$%\.]*?(?<price>\d+\.*\d+)\$";

            decimal total = 0m;

            string input = Console.ReadLine();

            while (input!= "end of shift")
            {
                MatchCollection matches = Regex.Matches(input, pattern);
                foreach (Match match in matches)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int qty = int.Parse(match.Groups["quantity"].Value);
                    Console.WriteLine($"{name}: {product} - {price*qty:f2}");
                    total+=price*qty;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
