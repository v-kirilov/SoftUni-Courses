﻿using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isEven = false;
            while (!isEven)
            {
                if (num%2!=0)
                {
                    Console.WriteLine("Please write an even number.");
                    num = int.Parse(Console.ReadLine());

                }
                else if (num%2==0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    isEven = true;
                }


            }
        }
    }
}
