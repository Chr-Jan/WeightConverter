namespace Constants_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constants =  Are immutable values which are known at compile time
            //              AbandonedMutexException do NotFiniteNumberException change for the life of the program

            //double pi = 3.14159;

            //If we dont want people to change the value of "pi" we use the const keyword to lock the value.
            //and make it constant.

            const double pi = 3.14159;



            Console.ReadKey();
        }
    }
}