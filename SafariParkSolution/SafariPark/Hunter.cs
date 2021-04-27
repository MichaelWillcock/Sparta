using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    class Hunter : Person
    {
        public Hunter() { }
        private string _camera;

        public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
        {
            _camera = camera;
        }

        public string Shoot()
        {
            return $"{GetFullName()} has taken a photo with their {_camera}.";
        }
    }
}
