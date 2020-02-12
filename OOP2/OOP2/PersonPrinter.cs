using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class PersonPrinter
    {
        public static void PrintPerson(Person person)
        {
            Console.WriteLine(person.firstName + " " + person.surName + ", " + person.age);
        }

        public static void PrintTree(List<Person> familiy)
        {
            foreach (Person i in familiy)
            {
                Console.WriteLine(i.firstName + " " + i.surName + ", " + i.age);
            }
        }
    }
}
