using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_demo
{
    abstract class Vehicle
    {
        //field
        public int speed = 0;
        //method
        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    //children class
    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }
    //children class
    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    //children class
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
}
