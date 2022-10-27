namespace If_Statements_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if statement = a baisc form of decision making

            //first exampel we use int for the if statement

            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 100)
            {
                Console.WriteLine("You are too old to sign up!");
            }
            else if(age < 0)
            {
                Console.WriteLine("You haven't been born yet!");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are now sign up!");
            }
            else
            {
                Console.WriteLine("You most be 18+ to sign up!");
            }

            //now we will make an exampel using string
            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            //if you only use = c# think we are trying to assign a string, we use == to compar
            //using "" mean we are comparing name to a empy string
            if (name == "")
            {
                Console.WriteLine("You did not enter your name!");
            }
            else
            {
                Console.WriteLine($"Hello {name}");
            }

            //or we can use != to see if something is not equal
            String name2 = Console.ReadLine();
            if (name2 != "")
            {
                Console.WriteLine("You did not enter your name!");
            }
            else
            {
                Console.WriteLine($"Hello {name2}");
            }

            Console.ReadKey();
        }
    }
}