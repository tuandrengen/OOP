using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public abstract class PdaItem
    {
        public virtual string Name { get; set; }
        public PdaItem(string name)
        {
            Name = name;
        }
    }
}
