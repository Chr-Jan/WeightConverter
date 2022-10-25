namespace Instance_Methods_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I am making a instance of a class here.
            Instance newInstance = new Instance();
            Console.WriteLine("This value of the return value is: " + newInstance.instanceMethod());

            Console.Read();
        }
    }
}