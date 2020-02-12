using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesObjects
{
    class Person
    {
        private string _firstName;
        private string _surName;
        private int _age;

        public string firstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value == null) // Giv fornavn en værdi, hvis den allerede ikke har nogen.
                {
                    _firstName = "Unknown first name";
                }
                else
                {
                    _firstName = value;
                }
            }
        }

        public string surName
        {
            get
            {
                return _surName;
            }
            set
            {
                if (value == null)
                {
                    _surName = "Unknown surname";
                }
                else
                {
                    _surName = value;
                }
            }
        }

        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Age can not be negative");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public Person father { get; set; }
        public Person mother { get; set; }

        public Person() { }
        public Person(Person person, Person father, Person mother)
        {
            firstName = person.firstName;
            surName = person.surName;
            age = person.age;
            person.father = father;
            person.mother = mother;
        }
    }
}
