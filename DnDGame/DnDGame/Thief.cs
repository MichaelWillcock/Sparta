using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGame
{
    class Thief : Adventurer
    {
        protected int _armourClass;
        private int _hitPointMax;
        public Thief(int hitdice, int str, int dex, int con, int intel, int wis, int cha) : base(hitdice, str, dex, con, intel, wis, cha)
        { }

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
            return $"You are a Thief with {_hitPointMax} hit points";
        }
    }
}
