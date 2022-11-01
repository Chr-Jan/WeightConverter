using System.Security.Cryptography;

namespace Constructors_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constructor  =   A special method in a class
            //                  Same name as the class name
            //                  Can be used to assisgn argument to fields when creating an object

            //the constructor is viewable in the class Human.

            //object here is human1
            Human human1 = new Human("Chris", 35);
            Human human2 = new Human("Better Chris", 36);

            //human1.name = "Chris";
            //human1.age = 35;

            //human2.name = "Better Chris";
            //human2.age = 36;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            //car exampel:
            //instantiate object
            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

            car1.Drive();
            car2.Drive();

            Console.ReadKey();

        }
    }

}