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
                new Crystal(" Crystal of Alexandrite"),
                new Knives("Set of Dual Knives"),
                new oneHSword("Rapier")
            };
            var classList = new Dictionary<string, Adventurer> { };


            classList.Add("FOS", new Fighter(10, 18, 12, 14, 12, 10, 13, weaponList[0]));
            classList.Add("FTS", new Fighter(10, 18, 12, 14, 12, 10, 13, weaponList[1]));
            classList.Add("FS", new Fighter(10, 18, 12, 14, 12, 10, 13, weaponList[2]));
            classList.Add("FC", new Fighter(10, 18, 12, 14, 12, 10, 13, weaponList[3]));
            classList.Add("FDK", new Fighter(10, 18, 12, 14, 12, 10, 13, weaponList[4]));
            classList.Add("FR", new Fighter(10, 18, 12, 14, 12, 10, 13, weaponList[5]));
            classList.Add("WOS", new Wizard(6, 10, 12, 13, 18, 14, 12, weaponList[0]));
            classList.Add("WTS", new Wizard(6, 10, 12, 13, 18, 14, 12, weaponList[1]));
            classList.Add("WS", new Wizard(6, 10, 12, 13, 18, 14, 12, weaponList[2]));
            classList.Add("WC", new Wizard(6, 10, 12, 13, 18, 14, 12, weaponList[3]));
            classList.Add("WDK", new Wizard(6, 10, 12, 13, 18, 14, 12, weaponList[4]));
            classList.Add("WR", new Wizard(6, 10, 12, 13, 18, 14, 12, weaponList[5]));
            classList.Add("COS", new Cleric(8, 14, 10, 13, 12, 18, 12, weaponList[0]));
            classList.Add("CTS", new Cleric(8, 14, 10, 13, 12, 18, 12, weaponList[1]));
            classList.Add("CS", new Cleric(8, 14, 10, 13, 12, 18, 12, weaponList[2]));
            classList.Add("CC", new Cleric(8, 14, 10, 13, 12, 18, 12, weaponList[3]));
            classList.Add("CDK", new Cleric(8, 14, 10, 13, 12, 18, 12, weaponList[4]));
            classList.Add("CR", new Cleric(8, 14, 10, 13, 12, 18, 12, weaponList[5]));
            classList.Add("TOS", new Thief(8, 12, 18, 10, 14, 12, 13, weaponList[0]));
            classList.Add("TTS", new Thief(8, 12, 18, 10, 14, 12, 13, weaponList[1]));
            classList.Add("TS", new Thief(8, 12, 18, 10, 14, 12, 13, weaponList[2]));
            classList.Add("TC", new Thief(8, 12, 18, 10, 14, 12, 13, weaponList[3]));
            classList.Add("TDK", new Thief(8, 12, 18, 10, 14, 12, 13, weaponList[4]));
            classList.Add("TR", new Thief(8, 12, 18, 10, 14, 12, 13, weaponList[5]));

            string classListIndex = "";
            bool validClass = false;
            do
            {
                Console.WriteLine("What class would you like to play?\nFighter, Wizard, Cleric, Thief");
                string playerClassString = Console.ReadLine().ToLower();
                if (playerClassString.Equals("fighter"))
                {
                    classListIndex = "F";
                    validClass = true;
                }
                else if (playerClassString.Equals("wizard"))
                {
                    classListIndex = "W";
                    validClass = true;
                }
                else if (playerClassString.Equals("cleric"))
                {
                    classListIndex = "C";
                    validClass = true;
                }
                else if (playerClassString.Equals("thief"))
                {
                    classListIndex = "T";
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
                Console.WriteLine("What weapon loadout do you want?\nSword&Shield\nGreatsword\nStaff\nCrystal\nKnives\nRapier");
                string playerWeapons = Console.ReadLine().ToLower();
                if (playerWeapons == "sword&shield" || playerWeapons == "sword and shield")
                {
                    classListIndex += "OS";
                    validWeapon = true;
                }
                else if (playerWeapons == "greatsword" || playerWeapons == "great sword")
                {
                    classListIndex += "TS";
                    validWeapon = true;
                }
                else if (playerWeapons == "staff")
                {
                    classListIndex += "S";
                    validWeapon = true;
                }
                else if (playerWeapons == "crystal")
                {
                    classListIndex += "C";
                    validWeapon = true;
                }
                else if (playerWeapons == "knives" || playerWeapons == "knifes")
                {
                    classListIndex += "DK";
                    validWeapon = true;
                }
                else if (playerWeapons == "rapier")
                {
                    classListIndex += "R";
                    validWeapon = true;
                }
                else
                {
                    Console.WriteLine("Your weapon choice is invalid please try again");
                }
            }
            while (validWeapon == false);

            
            var playerClass = classList[classListIndex];
            playerClass.EquipShield();
            playerClass.HitPoints();
            Console.WriteLine(playerClass);
        }
    }
}
