using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo([AllowNull] Person other)
        {
            if (Name != other.Name)
            {
                return Name.CompareTo(other.Name);
            }
            return Age.CompareTo(other.Age);
        }
        public override bool Equals(object obj)
        {
            var item = obj as Person;

            if (item == null)
            {
                return false;
            }
            return this.Name == item.Name && this.Age == item.Age;
        }

        public override int GetHashCode()
        {   
            int hashCode = Name.GetHashCode() + Age.GetHashCode();

            return hashCode;
        }
    }
}
