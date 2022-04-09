using System;

namespace _5.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double endPrice = ProductOrder(product, count);
            Console.WriteLine($"{endPrice:f2}");
        }

        static double ProductOrder(string product, int count)
        {
            double sum = 0;
            switch (product)
            {
                case "coffee":
                    sum = count * 1.5;
                    break;
                case "water":
                    sum = count * 1;
                    break;
                case "coke":
                    sum = count * 1.4;
                    break;
                case "snacks":
                    sum = count * 2;
                    break;
            }

            return sum;
        }
    }
}
