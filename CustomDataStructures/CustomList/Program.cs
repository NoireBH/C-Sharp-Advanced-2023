using System;

namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList customList = new CustomList();
            customList.Add(1);        
            customList[0] = 234;
            Console.WriteLine(customList[0]);
            customList.AddRange(new int[] {1,2,3});
            customList.Add(0);
            customList.RemoveAt(0);
            customList.RemoveAt(1);
            customList.RemoveAt(2);
            Console.WriteLine(customList.Contains(3));
            Console.WriteLine(customList.Contains(100));
            customList.InsertAt(1, 5);
            customList.Swap(0, 2);
            customList.ForEach(x => Console.Write(x + " "));





        }
    }
}
