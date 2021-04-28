using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public abstract class Weapon : IShootable
    {
        protected string _brand = "";

        public virtual string Shoot()
        {
            return $"{_brand}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {_brand}";
        }

        public Weapon(string brand)
        {
            _brand = brand;
        }
    }
}
