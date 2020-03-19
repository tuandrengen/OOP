using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Pair <T1, T2>
    {

        public T1 firstElement { get; set; }
        public T2 secondElement { get; set; }

        public Pair(T1 firstElement, T2 secondElement)
        {
            this.firstElement = firstElement;
            this.secondElement = secondElement;
        }

        public Pair<T1, T2> Swap()
        {
            // Swaps the first and second elements
            object first = secondElement;
            object second = firstElement;
            return new Pair<T1, T2>((T1)first, (T2)second);
        }

        public void Print()
        {
            Console.WriteLine($"{firstElement}, {secondElement}");

        }
        public Pair<T1, T2> SetFirst(object input)
        {
            firstElement = (T1)input;
            return new Pair<T1, T2>(firstElement, secondElement);
        }

        public Pair<T1, T2> SetSecond(object input)
        {
            secondElement = (T2)input;
            return new Pair<T1, T2>(firstElement, secondElement);
        }
    }
}
