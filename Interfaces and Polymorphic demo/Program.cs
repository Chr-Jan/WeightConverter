using Interfaces_demo;

namespace Interfaces_and_Polymorphic_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var mower = new LawnMower();
            var air = new Airplane();
            Start(car);
            Start(mower);
            Start(air);

            Console.Read();
        }

        static void Start(IMachine machine)
        {
            //Logging
            machine.Start();
        }
    }
}
