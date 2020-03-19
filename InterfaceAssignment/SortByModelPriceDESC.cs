using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InterfaceAssignment
{
    public class SortByModelPriceDESC : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if(y.model == x.model)
            {
                return y.price.CompareTo(x.price);
            }
            return y.model.CompareTo(x.model);
        }
    }
}
