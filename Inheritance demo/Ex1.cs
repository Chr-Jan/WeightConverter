using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_demo
{
    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }

}
