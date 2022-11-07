using System.ComponentModel.DataAnnotations;

namespace Polymorphism_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // polymorphism =   Greek word that means to "have many forms"
            //                  Objevts can be identified by more than one type
            //                  Example, A dog is also: Canine, Animal, Organism

            //ex1
            Console.WriteLine("This is Ex1: ");

            //creating objects
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            //array
            //datatype is Vehicle
            Vehicle[] vechiles = { car, bicycle, boat };
            
            foreach(Vehicle vechicle in vechiles)
            {
                //each vechile will use their Go() method
                vechicle.Go();
            }

            Console.ReadKey();
        }
    }
}