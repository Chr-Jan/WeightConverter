using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_demo
{
    //Data abstraction is the process of hiding certain details and showing only essential information to the user.
    //Abstraction can be achieved with either abstract classes or interfaces

    //Abstract class: is a restricted class that cannot be used to create objects(to access it, it must be inherited from another class).

    //Abstract method: can only be used in an abstract class, and it does not have a body.The body is provided by the derived class (inherited from).



    //abstract class Animal
    //{
    //    //An abstract class can have both abstract and regular methods:
    //    public abstract void animalSound();
    //    public void sleep()
    //    {
    //        Console.WriteLine("Zzz");
    //    }

    //From the example above, it is not possible to create an object of the Animal class:

    //Animal myObj = new Animal(); // Will generate an error (Cannot create an instance of the abstract class or interface 'Animal')


    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
}
