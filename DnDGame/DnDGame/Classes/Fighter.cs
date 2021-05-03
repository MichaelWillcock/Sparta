using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGame
{
    public class Fighter : Adventurer, IWeaponable
    {
        private int _armourClass = 18;
        private int _hitPointMax;
        public IWeaponable Weapon { get; set; }
        public Fighter(int hitdice, int str, int dex, int con, int intel, int wis, int cha, IWeaponable weapon) : base(hitdice, str, dex, con, intel, wis, cha)
        {
            Weapon = weapon;
        }

        public override int HitPoints()
        {
            var Dice = new DiceRoller();
            for (int i = 0; i <= 5; i++)
            {
                int hitPoints = Dice.diceRoller(_hitdice) + ((_constitution / 2) - 5);
                _hitPointMax += hitPoints;
            }
            return _hitPointMax;
        }

        public override string ToString()
        {
            return $"You are a Fighter with {_hitPointMax} hit points.\nEquipment: You are clad in full plate armour and are wielding a {Weapon.ListWeapon()}";
        }

        public override string ListWeapon()
        {
            return Weapon.ListWeapon();
        }
    }
}
