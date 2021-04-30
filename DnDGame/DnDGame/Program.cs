using System;
using System.Collections;
using System.Collections.Generic;

namespace DnDGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var classList = new List<Adventurer>
            {
                new Fighter(10, 18, 12, 14, 12, 10, 13),
                new Wizard(6, 10, 12, 13, 18, 14, 12),
                new Cleric(8, 14, 10, 13, 12, 18, 12),
                new Thief(8, 12, 18, 10, 14, 12, 13)
            };

            int classListIndex = 0;
            bool validClass = false;
            do
            {
                Console.WriteLine("What class would you like to play?\nFighter, Wizard, Cleric, Thief");
                string playerClassString = Console.ReadLine();
                if (playerClassString.Equals("Fighter"))
                {
                    classListIndex = 0;
                    validClass = true;
                }
                else if (playerClassString.Equals("Wizard"))
                {
                    classListIndex = 1;
                    validClass = true;
                }
                else if (playerClassString.Equals("Cleric"))
                {
                    classListIndex = 2;
                    validClass = true;
                }
                else if (playerClassString.Equals("Thief"))
                {
                    classListIndex = 3;
                    validClass = true;
                }
                else
                {
                    Console.WriteLine("You have entered an invalid class, please try again.");
                }
            }
            while (validClass == false);

            var playerClass = classList[classListIndex];

            playerClass.HitPoints();
            Console.WriteLine(playerClass);
        }
    }
}
