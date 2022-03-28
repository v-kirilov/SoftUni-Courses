using System;

namespace _4._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte century = byte.Parse(Console.ReadLine());
            //decimal years = decimal.Multiply(century, 1000);
            //decimal days = decimal.Multiply(years, (decimal)365.2422);
            //decimal hours = decimal.Multiply(days, (decimal)24);
            //decimal minutes = decimal.Multiply(hours, (decimal)60);
            int years = century * 100;
            int days = (int)(years * 365.2422);
            int hours = (days * 24);
            long minutes = (hours * 60);

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
