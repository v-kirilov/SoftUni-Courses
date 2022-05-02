using System;
using System.Collections.Generic;

namespace P04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> product = new List<string>(number);

            for (int i = 0; i < number; i++)
            {
                product.Add(Console.ReadLine());
            }

            product.Sort();

            for (int i = 0; i < product.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{product[i]}");
            }
            //int counter = 1;
            //foreach (string item in product)
            //{

            //    Console.WriteLine($"{counter}.{item}");
            //    counter++;
            //}
        }
    }
}
