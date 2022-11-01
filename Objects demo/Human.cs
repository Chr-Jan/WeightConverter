using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_demo
{
    public class Human
    {

            //field
            public String name;
            public int age;

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
