using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDouble
{
    public class Box<T> where T : IComparable<T>
    {   

        public Box()
        {
            Items = new List<T>();
        }
        public List<T> Items { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString();
        }

        public int Count(List<T> list , T element)
        {      int count = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                    
                }           
            }
            return count;
        }
    }

    
}
