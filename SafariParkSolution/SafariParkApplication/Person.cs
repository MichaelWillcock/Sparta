using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApplication
{
    public class Person
    {
        private string _firstName;
        private string _lastName;

        public int Age { get; set; }

        public Person() { }

        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }
        public Person(string fName, string lName, int age)
        {
            _firstName = fName;
            _lastName = lName;
            Age = age;
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
