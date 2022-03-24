using System;
using System.Linq;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());

            int[] arr = new int[wagons];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
                sum+=item;
            }
            Console.WriteLine();
            Console.WriteLine(sum);

            //Console.WriteLine(String.Join(" ",arr));  
        }
    }
}
