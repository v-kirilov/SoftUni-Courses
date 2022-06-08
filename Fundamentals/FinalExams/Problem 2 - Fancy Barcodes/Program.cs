using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Problem_2___Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(@#+)(?<text>[A-Z][a-zA-Z\d]{4,}[A-Z])@#+");

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                if (pattern.IsMatch(input))
                {
                    char[] digits = input.Where(x => char.IsDigit(x)).ToArray();

                    if (digits.Length == 0)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {string.Join("", digits)}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }
}
