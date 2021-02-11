using System;
using System.Linq.Expressions;

namespace StasTest
{
    public class Character
    {
        Stats Stats;

        public Character(Stats stats)
        {
            Stats = stats;
        }

        public int Atack(int MaxDamage) //Метод атаки
        {
            Random Rnd = new Random();
            int Damage = Rnd.Next(1, MaxDamage);
            return Damage;
        }
        
        // Надо связать эти 2 метода
        
        public int GetDamage (int Hp, int Armor, int Damage)  /*Метод определяющий количество здоровья после битвы*/
        {
            if (Damage > Armor)  
            {
                Hp = Hp - Damage + Armor;
                return Hp;                         //Получаем количество здоровья после удара
            }
            else
            {
                return Hp;   // Количество здоровья остаётся тем-же
            }
        }

    }
}