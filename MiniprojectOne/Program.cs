using System;
using System.Collections.Generic;

namespace MiniprojectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("Japanese Pop-Culture");
            menu.AddMenuItem(new MenuItem("Tokyo Tower"));
            menu.AddMenuItem(new MenuItem("Ichiran Ramen"));
            MenuItem bulletTrain = new MenuItem("Bullet Train",
                "Tokyo to Kyoto");
            menu.AddMenuItem(bulletTrain);

            Menu shinkaiMakoto = new Menu("Makoto Shinkai Films");
            shinkaiMakoto.AddMenuItem(
                new MenuItem("Your Name."),
                new MenuItem("Weathering with you"),
                new MenuItem("A Garden of Words")
                );
            menu.AddMenuItem(shinkaiMakoto);

            menu.AddMenuItem(new InfiniteMenu("Din mor!"));

            menu.Start();
        }
    }
}
