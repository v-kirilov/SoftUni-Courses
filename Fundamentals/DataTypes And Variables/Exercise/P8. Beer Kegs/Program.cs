using System;

namespace P8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double volume = double.MinValue;
            double currentKeg = 0;
            string bestModel = string.Empty;

            for (int i = 0; i < num; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                currentKeg = Math.PI*radius*radius*height;
                if (currentKeg>volume)
                {
                    volume = currentKeg;
                    bestModel=model;
                }
            }

            Console.WriteLine(bestModel);
        }
    }
}
