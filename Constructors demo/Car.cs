using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_demo
{
    internal class Car
    {
        //field
        String make;
        String model;
        int year;
        String color;

        //constructor
        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        //method
        public void Drive()
        {
            Console.WriteLine($"You drive the {make} {model}");
            Console.WriteLine($"It was made in {year} and are painted {color}");
        }
    }
}
