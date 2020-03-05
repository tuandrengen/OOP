using System;
using System.Collections.Generic;
using System.Text;

namespace MiniprojectOne
{
    abstract class MenuItemSuperBaseBase
    {
        public virtual string title { get; }
        public MenuItemSuperBaseBase(string title)
        {
            this.title = title;
        }

        public abstract void Select();
    }
}
