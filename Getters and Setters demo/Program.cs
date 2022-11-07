namespace Getters_and_Setters_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // getters and stters = add security to fields by encapsulation
            //                      They're accessors found whin properties

            //  properties      =   combine aspect of both fields and methods (share name with a field)
            //  get accessor    =   used to return the property value
            //  set accessor    =   used to assiagn a new value
            //  value keyword   =   defines the value being assigned by the set (parameter)

            Car car = new Car(4000);

            car.Speed = 1000000000;

            Console.WriteLine(car.Speed);

            Console.ReadKey();
        }
    }
}