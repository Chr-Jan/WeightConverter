namespace Interfaces_demo

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // interface =  defines a "contract" that all the clases inheriting from should follow

            //              An inferface declares "what a clss shuld have"
            //              An nheriting class defines "how it should do it"

            //              Benefit = security + multiple inherince + "plug and play"

            //Ex1:
            Console.WriteLine("This is ex1:");
            //object
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Hunt();
            fish.Flee();


            //Ex2:
            Console.WriteLine("\nThis is ex2:");
            Car car = new Car();
            LawnMower mower = new LawnMower();

            car.Start();
            car.Stop();
            mower.Start();
            mower.Stop();

            Console.ReadKey();

        }
    }
}


