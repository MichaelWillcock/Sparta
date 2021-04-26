using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHomework
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed;
        //public int Position { get; private set; }
        public int Position
        {
            get { return _speed; }
            private set { }
        }
        public int NumPassengers
        {
            get { return _numPassengers; }
            set { if (value >= 0 && value < _capacity) _numPassengers = value; }
        }

        public string Move()
        {
            return "Moving along";
        }

        public Vehicle() {}

        public string Move(int times) 
        {
            return $"Moving along {times} times";
        }
        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
        }
    }
}
