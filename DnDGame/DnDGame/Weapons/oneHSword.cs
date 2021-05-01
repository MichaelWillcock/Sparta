using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGame
{
    public class oneHSword : Weapon
    {
        public oneHSword() { }
        public oneHSword(string name) : base(name)
        {

        }
        public override string ListWeapon()
        {
            return _name;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
