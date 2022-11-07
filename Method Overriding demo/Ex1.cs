using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding_demo
{
    //Parent Class
    internal class Animal
    {
        //method
        public virtual void Speak()
        {
            Console.WriteLine("The animal go *brrr*");
        }
    }
    //child class
    internal class Dog : Animal
    {
        //override method need the same name and the same parameters
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }
    //child class
    internal class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes miav"); ;
        }
    }
}
