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
        protected string _ammoType = "";
        public int _ammo;

        public virtual string Shoot()
        {
            return $"{_brand}";
        }

        public void Fire()
        {
            _ammo--;
        }

        public void Fire(int times)
        {
            if (_ammo > times)
            {
                _ammo -= times;
            }
            else
            {
                _ammo = 0;
            }
        }

        public override string ToString()
        {
            return (_ammo == 0) ? $"{base.ToString()} - {_brand}. Warning - Out of Ammo." : (_ammoType.Length != 0) ? $"{base.ToString()} - {_brand} loaded with {_ammo} {_ammoType}" : $"{base.ToString()} - {_brand}";
        }

        public Weapon(string brand)
        {
            _brand = brand;
        }

        public Weapon(string brand, string ammoType, int ammo)
        {
            _brand = brand;
            _ammoType = ammoType;
            _ammo = ammo;
        }
    }
}
