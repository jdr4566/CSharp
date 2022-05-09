/*  Programmer : John-David Rodriguez
    Course: ITSE-1430
    Date: 5/7/2022
    IDE: Microsoft Visual Studio
    Description:   Complete and submit the Warrior Wars project  https://www.udemy.com/course/basics-of-object-oriented-programming-with-csharp/
*/

using System;
using WarriorWars.Enums;
using WarriorWars.Equipment;

namespace WarriorWars
{
    public class Warrior
    {
        private const int GOOD_GUY_START_HEALTH = 20;
        private const int BAD_GUY_START_HEALTH = 20;

        private readonly Faction faction;

        private string name;
        private int health;
        private bool isAlive;
        
        private Weapon weapon;
        private Armor armor;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            this.faction = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_START_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_START_HEALTH;
                    break;
                default:
                    break;
            }
            
        }

        public void Attack(Warrior enemyWarrior)
        {
            int damage = weapon.Damage / enemyWarrior.armor.ArmorPoints;

            enemyWarrior.health = enemyWarrior.health - damage;

            AttackResult(enemyWarrior, damage);

        }

        private void AttackResult(Warrior enemyWarrior, int damage)
        {
            if (enemyWarrior.health <= 0)
            {
                enemyWarrior.isAlive = false;

                Misc.ColorWriteLine($"{enemyWarrior.name} is dead!", ConsoleColor.Red);
                Misc.ColorWriteLine($"{name} is victorious!", ConsoleColor.Green);
            }
            else
            {
                Console.WriteLine($"{name} attacked {enemyWarrior.name} for {damage}.\n" +
                    $"{name} current health: {health}\n" +
                    $"{ enemyWarrior.name} current health: { enemyWarrior.health}\n" +
                    new string('-', 40) + "\n");
            }
        }
    }
}
