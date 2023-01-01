using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class CustomList
    {
        private const int startingCapacity = 2;
        private int[] items;

        public CustomList()
        {
            items = new int[startingCapacity];
        }

        public int Count { get; private set; }

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
        public void Add(int element)
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[Count] = element;
            Count++;
        }

        public void AddRange(int[] array)
        {
            foreach (var item in array)
            {
                Add(item);
            }
        }

        public int RemoveAt(int index)
        {
            CheckIfIndexIsValid(index);
            int indexToRemove = items[index];
            items[index] = default(int);
            ShiftToTheLeft(index);
            Count--;

            if (Count <=  items.Length / 4)
            {
                Shrink();
            }
            return indexToRemove;
        }

        public void InsertAt(int index,int value)
        {
            CheckIfIndexIsValid(index);

            if (Count == items.Length)
            {
                Resize();
            }

            ShiftToTheRight(index);
            items[index] = value;
            Count++;



        }

        public bool Contains(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == element)
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            CheckIfIndexIsValid(firstIndex);
            CheckIfIndexIsValid(secondIndex);

            int temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }

        private void Resize()
        {
            int[] copy = new int[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                int currentIndex = items[i];
                action(currentIndex);


            }
            
            
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

        private void ShiftToTheLeft(int index)
        {
            for (int i = index; i < Count; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void ShiftToTheRight(int index)
        {
            for (int i = Count - 1; i >= index; i--)
            {
                items[i + 1] = items[i];
            }
        }

        private void CheckIfIndexIsValid(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
