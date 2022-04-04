using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            double sum = 0;

            while (start != "Start")
            {
                double coin = double.Parse(start);
                if (coin == 0.1 || coin == .2 || coin == .5 || coin == 1 || coin == 2)
                {
                    sum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                start = Console.ReadLine();
            }
            string product = Console.ReadLine();

            while (product != "End")
            {
                if (product == "Nuts")
                {
                    if (sum - 2 < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased nuts");
                        sum -= 2;
                    }
                }
                else if (product == "Water")
                {
                    if (sum - 0.7 < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased water");
                        sum -= 0.7;
                    }
                }
                else if (product == "Crisps")
                {
                    if (sum - 1.5 < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased crisps");
                        sum -= 1.5;
                    }
                }
                else if (product == "Soda")
                {
                    if (sum - 0.8 < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased soda");
                        sum -= 0.8;
                    }
                }
                else if (product == "Coke")
                {
                    if (sum - 1 < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased coke");
                        sum -= 1;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");

        }
    }
}
