﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAssignment
{
    public class FixedProperty
    {
        protected string location;
        protected bool inCity;
        protected decimal estimatedValue;

        public FixedProperty(string location, bool inCity, decimal value)
        {
            this.location = location;
            this.inCity = inCity;
            this.estimatedValue = value;
        }
        public FixedProperty(string location) : this(location, true, 1000000)
        { }

        public string Location { 
            get { return location; } 
        }
    }
}
