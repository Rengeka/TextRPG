using System;

namespace StasTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerStats playerStats = new PlayerStats(); //Уточнить у Артёма. Я создал экземпляр класса PlayerStats и передал его в экземпляр userInterface
            Player player = new Player(playerStats);
            
            StasTest.UserInterface userInterface = new UserInterface(playerStats);

            userInterface.PrintLine();
            userInterface.PrintPlayerStats();
            userInterface.PrintLine();
            
            Console.ReadKey();
        }
    }
}