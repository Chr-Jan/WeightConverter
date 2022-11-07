namespace ToString_Method_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ToString() = convert an object to its string representation so that it is suitable for display.

            //ex1
            Console.WriteLine("Ex1: ");

            //object
            //Car(make, model, year, color) from ex1. 
            Car car = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car.ToString());
            //or easier, behind the scene call the ToString() method
            Console.WriteLine(car);

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}