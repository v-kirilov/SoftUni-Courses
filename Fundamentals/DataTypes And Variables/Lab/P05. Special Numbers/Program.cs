using System;

namespace _5._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int newNumber = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i<=9)
                {
                    if (i % 5 == 0 || i % 7 == 0 || i % 11 == 0)
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> False");
                    }
                }else
                {
                    int currentI = i;
                    sum = 0;
                    while (currentI>0)
                    {

                        int remover = currentI % 10;
                        sum += remover;
                        currentI = currentI / 10;
                    }
                    if (sum  == 5 || sum  == 7 || sum  == 11)
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> False");
                    }
                }
              
            }
        }
    }
}
