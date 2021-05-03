using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGame
{
    public class Adventurer : IHealthable, IWeaponable
    {
        protected int _pBonus = 2;
        protected int _hitdice;
        protected int _strength;
        protected int _dexterity;
        protected int _constitution;
        protected int _intelligence;
        protected int _wisdom;
        protected int _charisma;
        protected int _armourClass;
        protected string _role;
        public IWeaponable Weapon;

        public Adventurer() { }
        public Adventurer(int hitdice, int str, int dex, int con, int intel, int wis, int cha)
        {
            _hitdice = hitdice;
            _strength = str;
            _dexterity = dex;
            _constitution = con;
            _intelligence = intel;
            _wisdom = wis;
            _charisma = cha;
    }
        public Adventurer(string role)
        {
            _role = role;
        }
        public virtual int HitPoints()
        {
            int hitPointmax = 0;
            var Dice = new DiceRoller();
            for (int i = 0; i <= 5; i++)
            {
                int hitPoints = Dice.diceRoller(_hitdice) + ((_constitution / 2) - 5);
                hitPointmax += hitPoints;
            }
            return hitPointmax;
        }
        public virtual string ListWeapon()
        {
            return Weapon.ListWeapon();
        }
    }
}
