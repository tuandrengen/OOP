using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Opgave 1
            //Pair<object, object> pair = new Pair<object, object>(true, 42);
            //pair.Print();

            //// Opgave 1c
            //Pair<object, object> newPair = pair.Swap();
            //newPair.Print();

            //// Opgave 1d
            //Pair<object, object> xpair = new Pair<object, object>(true, "Hello World!");
            //xpair.Print();

            //Pair<object, object> newxPair = xpair.SetFirst(42);
            //newxPair.Print();

            //// Opgave 2a

            //List<int> numbers = new List<int>();
            //Random rand = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    numbers.Add(rand.Next(100));
            //}

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Higest value: {HandyMethods.Max<int>(numbers)}");
            //Console.WriteLine($"Lowest value: {HandyMethods.Min<int>(numbers)}");
            //Console.WriteLine();

            //// 2b
            //int[] array = new int[10];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rand.Next(100);
            //}
            //Console.WriteLine();

            //int[] copy = new int[10];
            //HandyMethods.Copy<int>(array, copy);

            //Console.WriteLine("Original: \t Copy:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"{array[i]} \t\t {copy[i]}");
            //}

            // 2c
            //string[] array = new string[5]{ "Bus", "Tog", "Bil", "Cykel", "Skateboard"};
            //string[] array = new int[5];
            string[] array = new string[5] { "Bus", "Tog", "Bil", "Cykel", "Skateboard" };


            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                //array[i] = rand.Next(50);
                Console.WriteLine($"{i+1}: {array[i]}");
            }
            Console.WriteLine();

            HandyMethods.Shuffle<object>(array);
        }
    }
}