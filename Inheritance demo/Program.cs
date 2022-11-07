namespace Inheritance_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance =    1 or more child classes receiveing fields, methids, etc. from a common parents

            //Ex1:
            Console.WriteLine("Ex1:");
            //object
            Car2 car2 = new Car2();
            Bicycle2 bicycle2 = new Bicycle2();
            Boat2 boat2 = new Boat2();

            Console.WriteLine(car2.speed);
            Console.WriteLine(car2.wheels);
            //method
            car2.go();

            Console.WriteLine(bicycle2.speed);
            Console.WriteLine(bicycle2.wheels);
            //method
            bicycle2.go();

            Console.WriteLine(boat2.speed);
            Console.WriteLine(boat2.wheels);
            //method
            boat2.go();


            //Ex2:
            Console.WriteLine("\nEx2:");
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            Console.ReadLine();
        }
    }
}