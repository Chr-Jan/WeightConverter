using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_demo
{
    internal class Vehicle
    {
        public virtual void Go()
        {

        }
    }
    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("the car is moving");
        }
    }
    class Bicycle : Vehicle
    {
        //method
        public override void Go()
        {
            Console.WriteLine("the bicycle is moving");
        }
    }
    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("the boat is moving");
        }
    }
}
