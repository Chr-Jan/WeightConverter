using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_demo
{
    internal class Human
    {
        //field
        public String name;
        public int age;

        //constructor
        public Human(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //methods
        public void Eat()
        {
            Console.WriteLine($"{name} is eating");
        }
        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping");
        }
    }
}
