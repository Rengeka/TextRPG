using System;

namespace StasTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StasTest.Character x = new Character();
            StasTest.UserInterface userInterface = new UserInterface();
           // @interface.PlayerThings[1] = "Sword";
            
            
            userInterface.PrintInterface();
            Console.ReadKey();
        }
    }
}