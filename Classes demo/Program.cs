namespace Classes_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // class =  A bundle of related code.
            //          Can be used as a blueprint to create objects (OOP)

            //this is an exampel of using the Math class
            //Math.Round(3.14);
            //Math.Abs(-3.14);
            //Math.Pow(2, 3);

            //here I am using the class I made myself
            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
        }
    }
}