using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InterfaceAssignment
{
    public class Car : IComparable<Car>
    {
        public string make { get; set; }
        public string model { get; set; }
        public double price { get; set; }

        public int CompareTo(Car car)
        {
            return price.CompareTo(car.price);
        }
    }
}
