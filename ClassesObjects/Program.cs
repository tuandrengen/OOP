using System;
using System.Collections.Generic;

namespace ClassesObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> familyList = new List<Person>(); // Instans af 'familyList'

            Person person = new Person(); // Mig
            person.firstName = "Anh Tuan"; // Tildeling af fornavn.
            person.surName = "Truong";
            person.age = 22;
            familyList.Add(person); // Tilføjer 'person' objektet til 'familyList' listen.

            Person mom = new Person(); // Mor
            mom.firstName = "Van";
            mom.surName = "Nguyen";
            mom.age = 49;
            familyList.Add(mom);

            Person dad = new Person(); // Far
            dad.firstName = "Hoa";
            dad.surName = "Truong";
            dad.age = 51;
            familyList.Add(dad);

            Person daddad = new Person();
            daddad.firstName = "Ca";
            daddad.surName = "Truong";
            familyList.Add(daddad);

            Person dadmom = new Person();
            dadmom.firstName = "Nga";
            dadmom.surName = "Chau";
            familyList.Add(dadmom);

            Person momdad = new Person();
            momdad.firstName = "Ba";
            momdad.surName = "Uai";
            familyList.Add(momdad);

            Person mommom = new Person();
            mommom.firstName = "Ma";
            mommom.surName = "Nguyen";
            familyList.Add(mommom);

            person.father = dad; // Dette er ækvivalent med det nedenstående kode
            person.mother = mom;

            Person me = new Person(person, dad, mom); // Dette er mulig på grund af en contructor i Person.cs med tre inputs.


            PersonPrinter.PrintTree(familyList); // Kald af den statiske metode i PersonPrinter.cs
            Console.ReadLine();
        }
    }
}
