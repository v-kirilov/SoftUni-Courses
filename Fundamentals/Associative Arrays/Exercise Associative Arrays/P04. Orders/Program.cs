using System;
using System.Linq;
using System.Collections.Generic;

namespace P04._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<double,int>> dict = new Dictionary<string,Dictionary<double,int>>();

            string order = Console.ReadLine();
            while (order!="buy")
            {
                string[] cmdArgs = order.Split(' ');
                string product = cmdArgs[0];
                double price = Convert.ToDouble(cmdArgs[1]);
                int quantity = Convert.ToInt32(cmdArgs[2]);

                if (!dict.ContainsKey(product))
                {
                    Dictionary<double,int> prodcutQuant = new Dictionary<double,int>();
                    prodcutQuant.Add(price, quantity);
                    dict[product] = prodcutQuant;
                }else
                {
                    foreach (var item in dict[product])
                    {
                        quantity += item.Value;
                    }
                    Dictionary<double,int> newPrice  = new Dictionary<double, int>();
                    newPrice[price] = quantity;
                    dict[product] = newPrice;
                }

                order = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                double total = item.Value.Keys.Sum()*item.Value.Values.Sum();
                Console.WriteLine($"{item.Key} -> {total:f2}");
            }
        }
    }
}
