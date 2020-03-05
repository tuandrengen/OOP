using System;
using System.Collections.Generic;
using System.Text;

namespace MiniprojectOne
{
    class Menu : MenuItemSuperBaseBase
    {
        List<MenuItemSuperBaseBase> _menuItems = new List<MenuItemSuperBaseBase>();

        public Menu(string title, params MenuItemSuperBaseBase[] menuItems) : base(title)
        {
            foreach (MenuItemSuperBaseBase item in menuItems)
            {
                _menuItems.Add(item);
            }
        }

        // Adds menuitems to a list.
        public void AddMenuItem(params MenuItemSuperBaseBase[] items)
        {
            foreach (MenuItemSuperBaseBase menuItem in items)
            {
                _menuItems.Add(menuItem);
            }
        }

        private int _index = 0;

        private void DrawMenu()
        {
            Console.Clear();
            Console.Title = title;
            for (int i = 0; i < _menuItems.Count; i++)
            {
                // Is this statement true ? Yes : No
                ConsoleColor color = _index == i ? ConsoleColor.DarkMagenta : ConsoleColor.Black; // Alterative to an if-statement.
                ConsoleColor oldColor = Console.BackgroundColor;
                Console.BackgroundColor = color;
                Console.WriteLine(_menuItems[i].title);
                Console.BackgroundColor = oldColor;
            }
        }

        private bool _isRunning;

        public void Start()
        {
            _isRunning = true;
            do
            {
                DrawMenu();
                HandleInput();
            } while (_isRunning);
        }

        // Handles the key presses with a switch.
        void HandleInput()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.Backspace:
                case ConsoleKey.Escape:
                    _isRunning = false;
                    break;
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
                case ConsoleKey.Enter:
                    //CurrentMenuItem.Select(); // This is valid if I use the lambda expression below.
                    _menuItems[_index].Select();
                    break;
                default:
                    break;
            }
        }

        // This lambda expression is the same as the method below.
        //public MenuItemSuperBaseBase CurrentMenuItem => _menuItems[_index];

        // Returns the selected menu item
        public MenuItemSuperBaseBase CurrentMenuItem()
        {
            return _menuItems[_index];
        }

        void MoveDown()
        {
            _index = (_index + 1) % _menuItems.Count;
        }

        void MoveUp()
        {
            _index = (_index - 1 + _menuItems.Count) % _menuItems.Count;
        }

        // Selects the current menu item to print its content
        public override void Select()
        {
            Start();
        }
    }
}
