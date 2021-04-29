using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGame
{
    class DiceRoller
    {
        public int _numSides;

        public int diceRoller(int _numSides)
        {
            var random = new Random();
            int diceRoll = random.Next(0, _numSides);
            return diceRoll;
        }
    }
}
