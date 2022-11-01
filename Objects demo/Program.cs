namespace Objects_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)

            //object here is human1
            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Chris";
            human1.age = 35;

            human2.name = "Better Chris";
            human2.age = 36;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();

        }
    }
    //class Human
    //{
    //    //field
    //    public String name;
    //    public int age;

    //    //methods
    //    public void Eat()
    //    {
    //        Console.WriteLine($"{name} is eating");
    //    }
    //    public void Sleep()
    //    {
    //        Console.WriteLine($"{name} is sleeping");
    //    }
    //}
}