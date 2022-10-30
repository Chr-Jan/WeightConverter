namespace Foreach_Loop_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // foreach loop     = a simpler way to iterate over an array, but it's less flexible

            //this is an exampel for a for loop:
            String[] cars = { "BMW", "Mustang", "Corvette" };
            
            Console.WriteLine("for loop:");

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine("\nforeach loop:");

            //this forfull the same function
            foreach(String car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}