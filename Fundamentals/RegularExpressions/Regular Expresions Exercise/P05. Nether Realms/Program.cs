using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P05._Nether_Realms
{
    public class Demon
    {
        public Demon(string name, double health, double damage)
        {
            this.Name = name;
            this.Health = health;
            this.damage = damage;
        }
        public string Name { get; set; }
        public double Health { get; set; }
        public double damage { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"{this.Name} - {this.Health} health, {this.damage:f2} damage");
            return str.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //char[] separator = { ',', ' ' };
            //string[] sepString = { ",", " ", ",0", ", " };
            List<string> input = Console.ReadLine()
                .Split(new char[] {' ',','}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<Demon> demons = new List<Demon>();

            string damageRegex = @"[-+]*\d\.*\d*";

            foreach (var item in input)
            {
                double damage = 0;

                MatchCollection demonDamage = Regex.Matches(item, damageRegex);

                foreach (Match match in demonDamage)
                {
                    damage += double.Parse(match.Value);
                }

                double health = 0;
                foreach (var curCh in item)
                {
                    if (char.IsLetter(curCh))
                    {
                        health += curCh;
                    }
                    if (curCh == '/')
                    {
                        damage /= 2;
                    }
                    else if (curCh == '*')
                    {
                        damage *= 2;
                    }
                }
             
                Demon newDemon = new Demon(item, health, damage);
                demons.Add(newDemon);
            }

            demons = demons.OrderBy(x => x.Name).ToList();

            foreach (var demon in demons)
            {
                Console.WriteLine(demon);
            }
        }
    }
}
