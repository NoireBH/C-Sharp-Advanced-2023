using System;
using System.Collections.Generic;
using System.Text;

namespace CustomQueue
{
    public class CustomQueue
    {
        int[] items;
        const int startingCapacity = 4;

        public int Count { get; private set; }

        public CustomQueue()
        {
            items = new int[startingCapacity];
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
        public void Enqueue(int element)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            items[Count] = element;
            Count++;
        }
        public int Dequeue()
        {
            CheckIfEmpty();
            int itemToRemove = items[0];
            items[0] = default(int);
            ShiftToTheLeft(0);
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
            return items[0];
        }

        public void Clear()
        {
            items = new int[startingCapacity];
            Count = 0;
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                int currentIndex = items[i];
                action(currentIndex);


            }
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
        private void CheckIfIndexIsValid(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void ShiftToTheLeft(int index)
        {
            for (int i = index; i < Count; i++)
            {
                items[i] = items[i + 1];
            }
        }




    }
}
