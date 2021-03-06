using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark;

namespace ClassesApp
{
    public class Rifle : Weapon
    {
        public Rifle(string brand) : base(brand)
        {
            
        }

        public Rifle(string brand, string ammoType = "round", int ammo = 10) : base(brand, ammoType, ammo)
        {

        }

        public override string Shoot()
        {
            return (_ammo > 0) ? $"Bang!! Shooting a {base.ToString()}" : $"Click!! Attempting to shoot a {base.ToString()}";
        }
    }
}
