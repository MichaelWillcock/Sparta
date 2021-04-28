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

        public override string Shoot()
        {
            return $"Bang!! Shooting a {base.ToString()}";
        }
    }
}
