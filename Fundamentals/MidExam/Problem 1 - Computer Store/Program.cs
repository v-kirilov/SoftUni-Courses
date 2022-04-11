using System;

namespace Problem_1___Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal sum = 0;

            while (input != "special" && input != "regular")
            {
                decimal price = decimal.Parse(input);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }
                sum += price;

                input = Console.ReadLine();
            }
            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            decimal taxes = .2m * sum;
            decimal specialPrice = .9m * (taxes + sum);

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sum:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");

            if (input == "special")
            {
                Console.WriteLine($"Total price: {specialPrice:f2}$");
            }
            else
            {
                Console.WriteLine($"Total price: {sum+taxes:f2}$");
            }
        }
    }
}
