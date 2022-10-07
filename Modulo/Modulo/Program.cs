namespace Modulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A variable that are used in the for loop
            string message;

            for (int i = 1; i <= 100; i++)
            {
                //i is an int and mesage is a string so we use .ToString
                message = i.ToString();

                //When i can be divided with 3 AND 5 and equal 0 the if will tricker
                if (i % 3 == 0 && i % 5 == 0)
                {
                    //the message that is i also become i AND - FizzBuzz 
                    message = message + " - FizzBuzz";
                    //Console.WriteLine("FizzBuzz");
                }
                //Trickers when i can be divided with 3 and be euqal to 0 this else if will tricker
                else if (i % 3 == 0)
                {
                    message = message + " - Fizz";
                    //Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    message = message + " - Buzz";
                    //Console.WriteLine("Buzz");
                }
                //The message that have been made in one loop will be written here.
                Console.WriteLine(message);

                /*Or this is also an option

                for (int i = 1; i < 101; i++)
                {
                    if ((i % 3 == 0) && (i % 5 == 0))
                        Console.WriteLine($"{i} - FizzBuzz");
                    else if (i % 3 == 0)
                        Console.WriteLine($"{i} - Fizz");
                    else if (i % 5 == 0)
                        Console.WriteLine($"{i} - Buzz");
                    else
                        Console.WriteLine($"{i}");
                }*/


            }
            Console.ReadLine();

        }
    }
}