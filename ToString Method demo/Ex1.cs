using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString_Method_demo
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
        //override method:
        public override string ToString()
        {
            //String message = "This is a " + make + " " + model;
            //return base.ToString();

            //or easier way

            return "This is a " + make + " " + model;
        }
    }
}
