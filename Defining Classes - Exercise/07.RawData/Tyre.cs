using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Tyre
    {
        public Tyre(int age, double pressure)
        {
            Age = age;
            Pressure = pressure;
        }

        public int Age { get; set; }
        public double Pressure { get; set; }
    }
    
}
