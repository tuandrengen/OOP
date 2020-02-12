using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesObjects
{
    class PersonPrinter
    {
        public static void PrintPerson(Person person)
        {
            Console.WriteLine(person.firstName + " " + person.surName + ", " + person.age); // Print
        }

        public static void PrintTree(List<Person> familyList)
        {
            foreach (Person member in familyList) // For hvert medlem i familyList, gør noget.
            {
                PrintPerson(member);
            }
        }
    }
}
