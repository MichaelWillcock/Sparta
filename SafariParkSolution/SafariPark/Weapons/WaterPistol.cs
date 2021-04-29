using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark;

namespace ClassesApp
{
    class WaterPistol : Weapon
    {
        public WaterPistol(string brand) : base(brand)
        {
            
        }
        public WaterPistol(string brand, string ammoType = "Water", int ammo = 500) : base(brand, ammoType, ammo)
        {

        }

        public override string Shoot()
        {
            return (_ammo > 0) ? $"Splash!! Shooting a {base.ToString()}" : $"Click!! Attempting to shoot a {base.ToString()}";
        }
    }
}
