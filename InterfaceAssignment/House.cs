using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAssignment
{
    public class House : FixedProperty
    {
        protected double area;

        public House(string location, bool inCity, double area, decimal value) : base(location, inCity, value)
        {
            this.area = area;
        }

        public double Area
        {
            get
            {
                return area;
            }
        }
    }
}
