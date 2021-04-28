using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark;

namespace ClassesApp
{
    public class Airplane : Vehicle
    {
        private string _airline;
        private int _altitude;
        private int _maxAltitude = 27000;

        public Airplane(int capacity) : base(capacity) { }

        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline;
        }

        public void Ascend(int distance)
        {
            if (distance > _maxAltitude)
            {
                _altitude = _maxAltitude;
            }
            else if (distance < 0)
            {
                distance = 0;
            }
            else
            {
                _altitude += distance;
            }
        }

        public void Descend(int distance)
        {
            if (_altitude < distance)
            {
                distance = _altitude;
            }
                _altitude -= distance;
        }

        public override string Move()
        {
            return $"{base.Move()} at an altitude of {_altitude} metres.";
        }

        public override string Move(int times)
        {
            return $"{base.Move(times)} at an altitude of {_altitude} metres.";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} altitude: {_altitude}.";
        }
    }
}
