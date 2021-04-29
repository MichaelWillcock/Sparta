using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGame
{
    class Cleric : Adventurer
    {
        protected int _armourClass;
        private int _hitPointMax;
        public Cleric(int hitdice, int str, int dex, int con, int intel, int wis, int cha) : base(hitdice, str, dex, con, intel, wis, cha)
        { }

        public override int hitPoints()
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
            return $"You are a Cleric with {_hitPointMax} hit points";
        }
    }
}
