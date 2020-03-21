using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        public delegate string StringJoin(string a, string b);
        public delegate T Join<T>(T a, T b);
        static void Main(string[] args)
        {
            List<string> strings = new List<string> { "a", "b", "c", "d" };
            List<int> numbers = new List<int> { 1, 2, 3, 4 };

            StringJoin stringJoin = (a, b) => a + b;
            StringJoin stringJoinWithDot = (a, b) => a + "." + b;
            StringJoin stringJoinOnlyLast = (a, b) => b;

            Console.WriteLine(stringJoin("Hello ", "Delegates"));

            Console.WriteLine(JoinThree("a", "b", "c", stringJoin));
            Console.WriteLine(JoinThree("a", "b", "c", stringJoinWithDot));
            Console.WriteLine(JoinThree("a", "b", "c", stringJoinOnlyLast));

            Console.WriteLine();

            Console.WriteLine(JoinAllStrings(strings, stringJoin));
            Console.WriteLine(JoinAllStrings(strings, stringJoinWithDot));
            Console.WriteLine(JoinAllStrings(strings, stringJoinOnlyLast));

            Console.WriteLine();

            Join<int> numberJoin = (a, b) => a + b;
            Join<int> numberJoinMultiply = (a, b) => a * b;
            Join<string> stringJoins = (a, b) => a + "." + b;

            Console.WriteLine(JoinList<int>(numbers, numberJoin));
            Console.WriteLine(JoinList<int>(numbers, numberJoinMultiply));
            Console.WriteLine(JoinList<string>(strings, stringJoins));


        }
        // Ex2
        static string JoinThree(string a, string b, string c, StringJoin x)
        {
            string newString = x(a, b);
            newString = x(newString, c);
            return newString;
        }

        // Ex3
        static string JoinAllStrings(List<string> strings, StringJoin x)
        {
            bool isFirst = true;
            string newString = "";
            foreach (string item in strings)
            {
                if (isFirst)
                {
                    newString = item;
                }
                else
                {
                    newString = x(newString, item);
                }
                isFirst = false;
            }
            return newString;
        }
        // Ex4
        static T JoinList<T>(List<T> list, Join<T> join)
        {
            T result = default(T);
            bool isFirst = true;

            foreach (T item in list)
            {
                if (isFirst)
                {
                    result = item;
                }
                else
                {
                    result = join(result, item);
                }
                isFirst = false;
            }
            return result;
        }

        // Ex5

        // Ex6
    }
}
