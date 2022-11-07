namespace Array_Of_Objects_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //datatype in a array
            //3 is the size of the array
            Car[] garage = new Car[3];

            //object
            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;

            //other option
            //array
            Car[] garage2 = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };
            Console.WriteLine("Garage1:");
            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);
            Console.WriteLine("\nGarage2:");
            Console.WriteLine(garage2[0].model);
            Console.WriteLine(garage2[1].model);
            Console.WriteLine(garage2[2].model);

            //other option to display
            Console.WriteLine("\nGarage1:");
            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }
            Console.WriteLine("\nGarage2:");
            foreach (Car car in garage2)
            {
                Console.WriteLine(car.model);
            }

            Console.ReadKey();
        }
    }
}