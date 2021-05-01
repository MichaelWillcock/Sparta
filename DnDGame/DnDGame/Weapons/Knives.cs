using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGame
{
    public class Knives : Weapon
    {
        public Knives() { }
        public Knives(string name) : base(name)
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
