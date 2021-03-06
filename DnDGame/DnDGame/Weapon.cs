using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGame
{
    public abstract class Weapon : IWeaponable
    {
        protected string _name;
        protected int damage;

        public Weapon() { }
        public Weapon(string name)
        {
            _name = name;
        }
        public virtual string ListWeapon()
        {
            return _name;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
