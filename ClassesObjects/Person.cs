using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesObjects
{
    class Person
    {
        private string _firstName; // Field
        private string _surName;
        private int _age;

        // Properties are used to encapsulate a field-member
        // Properties are also used to let you control how setting/getting the variable is done.
        // Fields can be made 'read-only' by only using the get method,
        // or 'write-only' by only using the set method.
        public string firstName // Property. Example #1
        {
            get
            {
                return _firstName;
            }
            set
            {
                // By using the if-control structure we ensure that the first name
                // is NEVER null. If said name IS null, we change it to "Unknown first name".
                if (value == null)
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

        public int age // Property. Example #2
        {
            get
            {
                return _age;
            }
            set
            {
                // Again, we use an if-control structure to ensure that the property 'age'
                // is never negative. So if the value IS, for some reason negative we set it to 0.
                // This way we guarantee that the minimum set calue of age is 0.
                if (value < 0)
                {
                    _age = 0;
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
