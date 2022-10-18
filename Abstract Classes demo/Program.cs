namespace Abstract_Classes_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method

            Console.Read();
        }
    }
}