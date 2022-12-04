using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        int numberOfHeroes = int.Parse(Console.ReadLine());
        Dictionary<string, Hero> allHeroes = new Dictionary<string, Hero>();

        // input heroes:
        for (int i = 0; i < numberOfHeroes; i++)
        {
            string[] inputHero = Console.ReadLine().Split();
            string name = inputHero[0];
            int hp = int.Parse(inputHero[1]);
            int mp = int.Parse(inputHero[2]);

            Hero currHero = new Hero(hp, mp);
            allHeroes[name] = currHero;
        }

        // play with heroes:
        string input = string.Empty;
        string[] separator = new string[] { " - " };

        while ((input = Console.ReadLine()) != "End")
        {
            string[] command = input.Split(separator, StringSplitOptions.None);
            string action = command[0];
            string name = command[1];

            if (action == "CastSpell")
            {
                int neededMP = int.Parse(command[2]);
                string spellName = command[3];

                if (neededMP <= allHeroes[name].ManaPoints)
                {
                    allHeroes[name].ManaPoints -= neededMP;
                    Console.WriteLine("{0} has successfully cast {1} and now has {2} MP!", name, spellName, allHeroes[name].ManaPoints);
                }
                else
                {
                    Console.WriteLine("{0} does not have enough MP to cast {1}!", name, spellName);
                }
            }
            else if (action == "TakeDamage")
            {
                int damage = int.Parse(command[2]);
                string attackerName = command[3];

                if (damage < allHeroes[name].HitPoints)
                {
                    allHeroes[name].HitPoints -= damage;
                    Console.WriteLine("{0} was hit for {1} HP by {2} and now has {3} HP left!", name, damage, attackerName, allHeroes[name].HitPoints);
                }
                else
                {
                    Console.WriteLine("{0} has been killed by {1}!", name, attackerName);
                    allHeroes.Remove(name);
                }
            }
            else if (action == "Recharge")
            {
                int rechargeAmount = int.Parse(command[2]);
                allHeroes[name].ManaPoints += rechargeAmount;
                int rest = 0;

                if (allHeroes[name].ManaPoints > 200)
                {
                    rest = allHeroes[name].ManaPoints - 200;
                    allHeroes[name].ManaPoints = 200;
                }

                Console.WriteLine("{0} recharged for {1} MP!", name, rechargeAmount - rest);
            }
            else if (action == "Heal")
            {
                int healAmount = int.Parse(command[2]);
                allHeroes[name].HitPoints += healAmount;
                int rest = 0;

                if (allHeroes[name].HitPoints > 100)
                {
                    rest = allHeroes[name].HitPoints - 100;
                    allHeroes[name].HitPoints = 100;
                }

                Console.WriteLine("{0} healed for {1} HP!", name, healAmount - rest);
            }
        }

        // output hereos:
        foreach (var hero in allHeroes)
        {
            Console.WriteLine(hero.Key);
            Console.WriteLine("  HP: {0}", hero.Value.HitPoints);
            Console.WriteLine("  MP: {0}", hero.Value.ManaPoints);
        }
    }
}

class Hero
{
    public Hero(int hp, int mp)
    {
        HitPoints = hp;
        ManaPoints = mp;
    }
    public int HitPoints { get; set; }
    public int ManaPoints { get; set; }
}