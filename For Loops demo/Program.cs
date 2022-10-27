namespace For_Loops_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for loop = repeats some code a finite amount of times

            //the first we put the index of the for loop i or index
            //second statement is the condition we want to stop
            //third how much we want to increment "++" or decrement "--"
            
            Console.WriteLine("increment by 1");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nincrement by 2");
            for (int i = 1; i <= 10; i+= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nincrement by 3");
            for (int i = 1; i <= 10; i += 3)
            {
                Console.WriteLine(i);
            }
            //making a new year countdown
            Console.WriteLine("\ndecrement by 1");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("HAPPY NEW YEAR!");

            Console.ReadKey();
        }
    }
}