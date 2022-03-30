﻿using System;

namespace P2._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sum = 0;

            while (input > 0)
            {
                sum += input % 10;
                input = input / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
