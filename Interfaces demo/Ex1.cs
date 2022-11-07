using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_demo
{
    //interface
    interface IPray
    {
        void Flee();
    }
    interface IPredator
    {
        void Hunt();
    }

    internal class Rabbit : IPray
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }
    }
    internal class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is seaching for food!");
}
    }
    //two interfaces
    internal class Fish : IPray, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish is looking for smaller fish!");
        }
    }
}
