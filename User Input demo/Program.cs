namespace User_Input_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?:");
            //make variable called "name"
            String name = Console.ReadLine();

            Console.WriteLine("What is your age?:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"hello {name}, your are {age} years old.");

            Console.ReadKey();
        }
    }
}