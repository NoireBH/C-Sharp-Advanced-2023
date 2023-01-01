using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        
        private Node head;
        public Node tail;

        public int Count { get; private set; }

        public void AddFirst(int value)
        {   
            var newNode = new Node(value);

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

        public void AddLast(int value)
        {
            var newNode = new Node(value);

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

        public int RemoveFirst()
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

        public int RemoveLast()
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

        public void ForEach()
        {
            var currentNode = head;

            while (currentNode != null)
            {
              int value = currentNode.Value;
                currentNode = currentNode.Next;

                Console.WriteLine(value);
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
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
    }
}
