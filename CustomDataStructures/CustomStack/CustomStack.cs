using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class CustomStack
    {
        int[] items;
        const int startingCapacity = 4;

        public int Count { get; private set; }

        public CustomStack()
        {
            items = new int[startingCapacity];
        }

        private void CheckIfIndexIsValid(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int this[int index]
        {
            get
            {
                CheckIfIndexIsValid(index);
                return items[index];
            }
            set
            {
                CheckIfIndexIsValid(index);
                items[index] = value;
            }
        }

        public void Push(int element)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            items[Count] = element;
            Count++;
        }

        public int Pop()
        {
            CheckIfEmpty();
            int itemToRemove = items[Count - 1];
            items[Count - 1] = default(int);
            Count--;

            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return itemToRemove;
           
        }

        public int Peek()
        {
            CheckIfEmpty();
            return items[Count - 1];
        }

        public void ForEach(Action<int> action)
        {
           
            for (int i = Count - 1; i >= 0; i--)
            {
                int currentIndex = items[i];
                action(currentIndex);
            }
        }

        public void Clear()
        {
            items = new int[startingCapacity];
            Count = 0;
        }

        private void Resize()
        {
            int[] copy = new int[items.Length * 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        private void Shrink()
        {
            int[] copy = new int[items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }

        private void CheckIfEmpty()
        {
            if (items.Length == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
        }

    }
}
