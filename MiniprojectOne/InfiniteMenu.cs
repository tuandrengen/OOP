using System;
using System.Collections.Generic;
using System.Text;

namespace MiniprojectOne
{
    class InfiniteMenu : Menu
    {
        static Random random = new Random();

        public InfiniteMenu(string title) : base(title) { }

        private bool _firstTime = true;
        int count = 0;

        public override void Select()
        {
            if (_firstTime)
            {
                count = random.Next(6) + 4;
                for (int i = 0; i < count; i++)
                {
                    this.AddMenuItem(new InfiniteMenu(title + " - " + i));
                }
                _firstTime = false;
            }
            base.Select();
        }
    }
}
