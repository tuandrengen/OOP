using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAssignment
{
    public class SortByMakeModelPrice : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x.make == y.make)
            {
                if (x.model == y.model)
                {
                    return x.price.CompareTo(y.price);
                }
                return x.model.CompareTo(y.model);
            }
            return x.make.CompareTo(y.make);
        }
    }
}
