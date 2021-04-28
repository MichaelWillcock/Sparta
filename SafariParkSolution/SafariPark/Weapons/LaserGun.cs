using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark;

namespace ClassesApp
{
    class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand)
        {
            
        }
        public LaserGun(string brand, string ammoType = "kJ", int ammo = 500) : base(brand, ammoType, ammo)
        {

        }

        public override string Shoot()
        {
            if (_ammo > 0)
            {
                return $"Zing!! Shooting a {base.ToString()}";
            }
            else
            {
                return $"Click!! Attempting to shoot a {base.ToString()}";
            }
        }
    }
}
