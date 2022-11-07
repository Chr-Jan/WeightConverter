namespace Objects_As_Arguments_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method
            Car car1 = new Car("Mustang", "red");

            Car car2 = Copy(car1);

            ChangeColor(car1, "silvier");

            Console.WriteLine(car1.color + " " + car1.model);
            Console.WriteLine(car2.color + " " + car2.model);

            Console.ReadKey();
        }
        //method
        //to change the color of a car:
        public static void ChangeColor(Car car, String color)
        {
            car.color = color;
        }
        //method
        //change the car object, the datatype is Car, since we are returning Car, the argument is car
        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }

    }
}