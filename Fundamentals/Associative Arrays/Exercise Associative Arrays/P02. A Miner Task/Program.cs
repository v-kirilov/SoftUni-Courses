using System;
using System.Linq;
using System.Collections.Generic;

namespace P02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string,int> dict = new Dictionary<string,int>();

            while (resource!="stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                
                    if (dict.ContainsKey(resource) ==false)
                    {
                        dict.Add(resource,quantity);
                    }else
                    {
                        dict[resource] += quantity;
                    }
               
                resource = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
