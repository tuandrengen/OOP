using System;
using System.Collections.Generic;

namespace InterfaceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car(){make="Ford", model="Fiesta", price = 50000},
                new Car(){make="Skoda", model="Fabia", price = 50300},
                new Car(){make="Skoda", model="Fabia", price = 50300},
                new Car(){make="Nissan", model="Skyline GT-R", price = 110000},
                new Car(){make="Skoda", model="Fabia", price = 50000},
                new Car(){make="Nissan", model="GT-R Egoist", price = 120000},
                new Car(){make="Skoda", model="Octavia", price = 60000},
                new Car(){make="Ford", model="Fiesta Eco-Boost", price = 55000},
                new Car(){make="Nissan", model="Skyline GT-R", price = 100000},
                new Car(){make="Ford", model="Mustang", price = 150000}
            };

            Console.WriteLine("Before sort");
            foreach (Car item in cars)
            {
                Console.WriteLine(item.make + " - " + item.model + " - " + item.price);
            }

            Console.WriteLine();

            cars.Sort();

            Console.WriteLine("Sort by price: ASC");
            foreach (Car item in cars)
            {
                Console.WriteLine(item.make + " - " + item.model + " - " + item.price);
            }

            cars.Sort(new SortByMakeModelPrice());

            Console.WriteLine("Sort by Make, then Model, then price, and then in ascending order");
            foreach (Car item in cars)
            {
                Console.WriteLine(item.make + " - " + item.model + " - " + item.price);
            }

            Console.WriteLine();

            cars.Sort(new SortByModelPriceDESC());

            Console.WriteLine("DESC");
            foreach (Car item in cars)
            {
                Console.WriteLine(item.make + " - " + item.model + " - " + item.price);
            }
        }
    }
}
