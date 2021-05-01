using System;
using System.Collections;
using System.Collections.Generic;

namespace DnDGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var weaponList = new List<Weapon>
            {
                new oneHSword("Longsword and Shield"),
                new twoHSword("Greatsword"),
                new Staff("Mage's Staff"),
                new Crystal("Alexandrite"),
                new Knives("Dual Knives"),
                new oneHSword("Rapier")
            };
            var classList = new Dictionary<string, Adventurer> { };


            classList.Add("FOS", new Fighter(10, 18, 12, 14, 12, 10, 13, weaponList[0]));
            classList.Add("FTS", new Fighter(10, 18, 12, 14, 12, 10, 13, weaponList[1]));
            classList.Add("FS", new Fighter(10, 18, 12, 14, 12, 10, 13, weaponList[2]));
            classList.Add("FC", new Fighter(10, 18, 12, 14, 12, 10, 13, weaponList[3]));
            classList.Add("FDK", new Fighter(10, 18, 12, 14, 12, 10, 13, weaponList[4]));
            classList.Add("FR", new Fighter(10, 18, 12, 14, 12, 10, 13, weaponList[5]));
            classList.Add("WOS", new Wizard(6, 10, 12, 13, 18, 14, 12));
            classList.Add("COS", new Cleric(8, 14, 10, 13, 12, 18, 12));
            classList.Add("TOS", new Thief(8, 12, 18, 10, 14, 12, 13));

            int classListIndex = 0;
            bool validClass = false;
            do
            {
                Console.WriteLine("What class would you like to play?\nFighter, Wizard, Cleric, Thief");
                string playerClassString = Console.ReadLine().ToLower();
                if (playerClassString.Equals("fighter"))
                {
                    classListIndex = 0;
                    validClass = true;
                }
                else if (playerClassString.Equals("wizard"))
                {
                    classListIndex = 1;
                    validClass = true;
                }
                else if (playerClassString.Equals("cleric"))
                {
                    classListIndex = 2;
                    validClass = true;
                }
                else if (playerClassString.Equals("thief"))
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

            bool validWeapon = false;
            do
            {
                Console.WriteLine("What weapon loadout do you want?\nSword&Shield\nGreataxe\nStaff\nCrystal\nKnives\nRapier");
                string playerWeapons = Console.ReadLine().ToLower();
                if (playerWeapons == "sword&shield")
                {
                    
                }
            }
            while (validWeapon == false);

            var playerClass = classList[classListIndex];
            playerClass.HitPoints();
            Console.WriteLine(playerClass);
        }
    }
}
