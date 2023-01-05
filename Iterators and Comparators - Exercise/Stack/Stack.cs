using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private T[] items;
        private const int startingCapacity = 4;
       

        public Stack()
        {   
            items = new T[startingCapacity];
        }

        public int Count { get; private set; }
        public void Push(T element)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            items[Count] = element;
            Count++;
        }

        public T Pop()
        {   
            if (Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T elementToRemove = items[Count - 1];
            Count--;
            return elementToRemove;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void Resize()
        {
            T[] copy = new T[items.Length * 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }
    }
}
