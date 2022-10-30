namespace Arrays_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  array = a variable that can store multiple values. fixed size



            //  this is an array, namde cars
            String[] cars = {"BMW", "Mustang", "Corvette"};

            //How to declare an array
            //3 is the size of the aray
            String[] cars2 = new string[3];

            //  if I needd to change inside the array
            cars[0] = "Tesla"; 

            //  Computers start with 0, the first element.
            //  cars[index]
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);

            Console.WriteLine("");

            cars2[0] = "Tesla";
            cars2[1] = "Mustang";
            cars2[2] = "Corvette";

            Console.WriteLine("\n");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine("\n");
            for (int i = 0; i < cars2.Length; i++)
            {
                Console.WriteLine(cars2[i]);
            }

            Console.ReadKey();
        }
    }
}