using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Vehicle : IMoveable
    {
        protected int _capacity;
        private int _numPassengers;
        protected int _speed = 10;
        public int Position { get; private set; }
        public int NumPassengers
        {
            get { return _numPassengers; }
            set
            {
                if (value < 0)
                {
                    _numPassengers = 0;
                }
                else if (value > _capacity)
                {
                    _numPassengers = _capacity;
                }
                else
                {
                    _numPassengers = value;
                }
            }
        }

        public virtual string Move()
        {
            Position += _speed;
            return "Moving along";
        }

        public Vehicle() { }

        public virtual string Move(int times)
        {
            Position += _speed * times;
            return $"Moving along {times} times";
        }
        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
        }

        public override string ToString()
        {
            return $"{base.ToString()} capacity: {_capacity} passengers: {NumPassengers} speed: {_speed} position: {Position}";
        }
    }
}
