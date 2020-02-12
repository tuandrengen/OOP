using System;
using System.Collections.Generic;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> family = new List<Person>();

            Person person = new Person();
            person.firstName = "Anh Tuan";
            person.surName = "Truong";
            person.age = 22;
            family.Add(person);

            Person mom = new Person();
            mom.firstName = "Van";
            mom.surName = "Nguyen";
            mom.age = 49;
            family.Add(mom);

            Person dad = new Person();
            dad.firstName = "Hoa";
            dad.surName = "Truong";
            dad.age = 51;
            family.Add(dad);

            Person daddad = new Person();
            daddad.firstName = "Ca";
            daddad.surName = "Truong";
            family.Add(daddad);

            Person dadmom = new Person();
            dadmom.firstName = "Nga";
            dadmom.surName = "Chau";
            family.Add(dadmom);

            Person momdad = new Person();
            momdad.firstName = "Ba";
            momdad.surName = "Uai";
            family.Add(momdad);

            Person mommom = new Person();
            mommom.firstName = "Ma";
            mommom.surName = "Nguyen";
            family.Add(mommom);

            person.father = dad;
            person.mother = mom;


            PersonPrinter.PrintTree(family);
            Console.ReadLine();
        }
    }
}
