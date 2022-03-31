using System;

namespace P10._Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int originalValue = pokePower;
            int distance = int.Parse(Console.ReadLine());
            int exhaustFactor = int.Parse(Console.ReadLine());
            int count = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                count++;
                if (exhaustFactor == 0)
                {
                    continue;
                }
                else if (pokePower == .5 * originalValue)
                {
                    pokePower /= exhaustFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(count);

        }
    }
}
