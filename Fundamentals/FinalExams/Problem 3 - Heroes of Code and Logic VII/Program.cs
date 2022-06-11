using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Heroes_of_Code_and_Logic_VII
{
    public class Hero
    {
        public Hero(string name, int hp, int mp)
        {
            this.Name = name;
            this.MP = mp;
            this.HP = hp;
        }
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Hero> heroes = new List<Hero>();

            for (int i = 0; i < number; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = cmdArgs[0];
                int hp = int.Parse(cmdArgs[1]);
                int mp = int.Parse(cmdArgs[2]);
                heroes.Add(new Hero(name, hp, mp));
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmdArgs = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                if (action == "CastSpell")
                {
                    string name = cmdArgs[1];
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];

                    Hero caster = heroes.FirstOrDefault(x => x.Name == name);
                    if (caster.MP >= mpNeeded)
                    {
                        Console.WriteLine($"{caster.Name} has successfully cast {spellName} and now has {caster.MP - mpNeeded} MP!");
                        caster.MP -= mpNeeded;
                    }
                    else
                    {
                        Console.WriteLine($"{caster.Name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    string name = cmdArgs[1];
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];
                    Hero hero = heroes.FirstOrDefault(x => x.Name == name);
                    if (hero.HP - damage > 0)
                    {
                        hero.HP -= damage;
                        Console.WriteLine($"{hero.Name} was hit for {damage} HP by {attacker} and now has {hero.HP} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero.Name} has been killed by {attacker}!");
                        heroes.Remove(hero);
                    }
                }
                else if (action == "Recharge")
                {
                    string name = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);
                    Hero hero = heroes.FirstOrDefault(x => x.Name == name);
                    if (hero.MP + amount > 200)
                    {
                        amount = 200 - hero.MP;
                        hero.MP = 200;
                        Console.WriteLine($"{hero.Name} recharged for {amount} MP!");
                    }
                    else
                    {
                        hero.MP += amount;
                        Console.WriteLine($"{hero.Name} recharged for {amount} MP!");
                    }
                }
                else if (action == "Heal")
                {
                    string name = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);
                    Hero hero = heroes.FirstOrDefault(x => x.Name == name);
                    if (hero.HP + amount > 100)
                    {
                        amount = 100 - hero.HP;
                        hero.HP = 100;
                        Console.WriteLine($"{hero.Name} healed for {amount} HP!");
                    }
                    else
                    {
                        hero.HP += amount;
                        Console.WriteLine($"{hero.Name} healed for {amount} HP!");
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Name}");
                Console.WriteLine($"HP: {hero.HP}");
                Console.WriteLine($"MP: {hero.MP}");
            }
        }
    }
}
