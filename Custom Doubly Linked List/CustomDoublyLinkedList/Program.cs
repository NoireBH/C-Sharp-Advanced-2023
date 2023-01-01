using System;

namespace CustomDoublyLinkedList
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.AddFirst(5);
            doublyLinkedList.AddFirst(6);
            doublyLinkedList.AddLast(7);
            doublyLinkedList.ForEach();
        }
    }
}
