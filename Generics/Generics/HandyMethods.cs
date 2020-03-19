using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Generics
{
    public static class HandyMethods
    {
        public static T Max<T>(List<T> list) where T : IComparable<T>
        {
            T max = list[0];
            foreach (T item in list)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T Min<T>(List<T> list) where T : IComparable
        {
            T min = list[0];

            foreach (T item in list)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static void Copy<T>(T[] one, T[] two)
        {
            if (one.Length != two.Length)
            {
                throw new Exception("Unequal length of the arrays");
            }

            for (int i = 0; i < one.Length; i++)
            {
                two[i] = one[i];
            }
        }

        public static void Shuffle<T>(T[] array)
        {
            int j, k;
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                j = rand.Next(array.Length);
                k = rand.Next(array.Length);

                T temp = array[j];
                array[j] = array[k];
                array[k] = temp;
                Console.WriteLine($"Step: {i+1}, indices: {j+1} {k+1}");
                for (int l = 0; l < array.Length; l++)
                {
                    Console.WriteLine($"{l+1}: {array[l]}");
                }
                Console.WriteLine();
            }
        }

    }
}
