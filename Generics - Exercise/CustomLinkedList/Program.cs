using System;

namespace CustomLinkedList
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddLast(1);
            list.AddFirst(2);
            list.AddLast(3);
            Console.WriteLine(list.RemoveLast());
            Console.WriteLine(list.RemoveFirst());
        }
    }
}
