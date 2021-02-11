using System;

namespace StasTest
{
    public class UserInterface
    {
        public int PlayerHp;
        public int PlayerExp;
        public int PlayerArmor;
            
        public string[] PlayerThings;
        
        public void PrintInterface() /*Метод, выводящий интерфейс на экран*/
        {
            Console.Clear();
            Console.WriteLine("_______________________________________________________________________________________________" +
                              "_____________________________________________________________________________________");
            Console.WriteLine($"Player Health - {PlayerHp}" );
            Console.WriteLine($"Player Experience - {PlayerExp}" );
            Console.WriteLine($"Player Armor - {PlayerArmor}" );
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("_______________________________________________________________________________________________" +
                              "_____________________________________________________________________________________");
            Console.WriteLine($"Предметы :");
           /* for (int i = 0; i < PlayerThings.Length; i++)
            {
                Console.Write($"{PlayerThings[i]}");
            } */
        } 
    }
}