using System;
using System.Collections.Generic;
using System.Text;

namespace MiniprojectOne
{
    class MenuItem : MenuItemSuperBaseBase
    {
        public MenuItem(string title) : this(title, "") { }

        public MenuItem(string title, string content): base(title)
        {
            this.content = content;
        }

        public string content { get; }

        public override void Select()
        {
            string oldTitle = Console.Title;
            Console.Title = title;
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine(content);
            Console.ReadKey();
            Console.Title = oldTitle;
        }
    }
}
