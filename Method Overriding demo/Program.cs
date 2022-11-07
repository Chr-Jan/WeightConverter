namespace Method_Overriding_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method overriding =   provides a new version of a method inheried from a parent class
            //                      inherited method must be: abstract, virtual, or already overriden
            //                      Used with ToString(), polymorphism

            //Ex1
            Console.WriteLine("Ex1: ");

            //object
            Dog dog = new Dog();
            Cat cat = new Cat();

            //method
            dog.Speak();
            cat.Speak();

            Console.ReadKey();
        }
    }
}