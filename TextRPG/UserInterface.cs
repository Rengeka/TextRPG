using System;

namespace StasTest
{
    public class UserInterface
    {
        private PlayerStats PlayerStats;
        
            /// <summary>
            /// Конструктор, который получает экземпляр класса PlayerStats
            /// </summary>
            /// <param name="playerStats"> Экземпляр класса PlayerStats </param>
            
        public UserInterface(PlayerStats playerStats) 
        {
            PlayerStats = playerStats;
        }

        public void PrintPlayerStats() /*Метод, выводящий интерфейс на экран*/
        {
            // Console.Clear();
            Console.WriteLine($"Player Health - {PlayerStats.Hp}");
            Console.WriteLine($"Player Experience - {PlayerStats.Exp}");
            Console.WriteLine($"Player Armor - {PlayerStats.Armor}");
            Console.WriteLine($"Player Dexterity - {PlayerStats.Dexterity}");
            Console.WriteLine($"Player MaxDamage - {PlayerStats.MaxDamage}");
        }

        public void PrintLine()
        {
            Console.WriteLine(
                "_______________________________________________________________________________________________" +
                "_____________________________________________________________________________________");
        }

        // Console.Clear(); не забыть этот метод
    }
}