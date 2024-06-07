﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_demo
{
    internal class Vehicle2
    {
        //field
        public int speed = 0;
        //method
        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    //children classes
    class Car2 : Vehicle2
    {
        public int wheels = 4;
    }
    class Bicycle2 : Vehicle2
    {
        public int wheels = 2;
    }
    class Boat2 : Vehicle2
    {
        public int wheels = 0;
    }
}