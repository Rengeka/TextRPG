using System.Linq.Expressions;

namespace StasTest
{
    public class Character
    {
        public int Damage;
        public int Hp;
        public int Armor;
        public int Dexterity; /*Сейчас не нужное поле*/
        
        public int Defence (int Hp, int Armor)  /*Метод определяющий количество здоровья после битвы*/
        {
            if (Damage > Armor)
            {
                int Hp2 = Hp - Damage + Armor;
                return Hp2;
            }
            else
            {
                return Hp;
            }
        }

    }
}