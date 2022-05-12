using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[>]{2}(?<product>[A-Za-z]+)(?:<<)(?<price>\d+\.*\d+)!(?<quantity>\d{1,})";

            List<string> furniture = new List<string>();
            decimal price = 0m;
            int qty = 0;
            decimal totalSpend = 0;

            string input = Console.ReadLine();
            while (input!= "Purchase")
            {
                Match order = Regex.Match(input, pattern);

                if (order.Success)
                {
                    furniture.Add(order.Groups["product"].Value);
                    price = decimal.Parse(order.Groups["price"].Value);
                    qty = int.Parse(order.Groups["quantity"].Value);
                    totalSpend += price * qty;

                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalSpend:f2}");

           
        }
    }
}
