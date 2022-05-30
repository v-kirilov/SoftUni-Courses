using System;
using System.Linq;
using System.Collections.Generic;

namespace P07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(name))
                {
                    List<double> newList = new List<double>() { grade };
                    dict.Add(name, newList);
                }
                else
                {
                    dict[name].Add(grade);
                }
            }

            Dictionary<string,double> finalDict= new Dictionary<string,double>();

            foreach (var item in dict)
            {
                if (item.Value.Average()>=4.5)
                {
                    finalDict.Add(item.Key, item.Value.Average());
                }
            }

            foreach (var item in finalDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
