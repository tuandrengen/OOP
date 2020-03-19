using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Pair<object, object> pair = new Pair<object, object>(true, 42);

            pair.Print();

            Pair<object, object> newPair = pair.Swap();

            newPair.Print();

            Pair<object, object> xpair = new Pair<object, object>(true, "Hello World!");

            xpair.Print();

            Pair<object, object> newxPair = xpair.SetFirst(42);

            newxPair.Print();
        }
    }
}

