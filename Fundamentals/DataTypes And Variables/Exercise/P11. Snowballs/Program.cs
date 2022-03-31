using System;
using System.Numerics;

namespace P11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowBalls = int.Parse(Console.ReadLine());
            int snow = 0;
            int time = 0;
            int quality = 0;

            int bestSnow = 0;
            int bestTime = 0;
            int bestQty = 0;

            BigInteger value = BigInteger.Zero;
            BigInteger bestValue = BigInteger.Zero;

            for (int i = 0; i < snowBalls; i++)
            {
                snow = int.Parse(Console.ReadLine());
                time = int.Parse(Console.ReadLine());
                quality = int.Parse(Console.ReadLine());
                value = BigInteger.Pow((snow / time), quality);

                if (value>bestValue)
                {
                    bestValue = value;
                    bestSnow = snow;
                    bestQty = quality;
                    bestTime = time;
                }
            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQty})");
        }
    }
}
