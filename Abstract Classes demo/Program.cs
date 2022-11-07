namespace Abstract_Classes_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract classes =    modifier that indicates missing components or incomplete implementation

            //Ex1
            Console.WriteLine("Ex1:");
            //object
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat bat = new Boat();
            //Vehicle vehicle = new Vehicle();
            //how to prevent people from using the vehicle object, since it is incomplete implementation.
            //use the abstract keyword to achieve that, now you can not make a object from that class.

            //Ex2
            Console.WriteLine("\nEx2:");
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method

            Console.Read();
        }
    }
}