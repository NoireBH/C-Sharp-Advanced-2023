using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public class ListNode
        {
            public T Value { get; set; }
            public ListNode Next { get; set; }
            public ListNode Previous { get; set; }

            public ListNode(T value)
            {
                Value = value;
            }
        }

        private ListNode head;
        public ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(T value)
        {   
            var newNode = new ListNode(value);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }

            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            var newNode = new ListNode(value);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }

            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
                tail = newNode;
            }

            Count++;
        }

        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            var firstElement = head.Value;
            head = head.Next;

            if (head == null)
            {
                tail = null;
            }

            else
            {
                head.Previous = null;
            }

            Count--;
            return firstElement;
        }

        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            var lastElement = tail.Value;
            tail = tail.Previous;

            if (tail == null)
            {
                head = null;
            }

            else
            {
                tail.Next = null;
            }

            Count--;
            return lastElement;
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];
            int counter = 0;
            var currentNode = head;

            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                currentNode = currentNode.Next;
                counter++;
            }
            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = head;

            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode=currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
