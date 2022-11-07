namespace Overloaded_Constructors_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructors =    technique to create multiple constructors,
            //                              with a different set of parameters.
            //                              name + parameters = signature

            //object
            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni");
            Pizza pizza2 = new Pizza("stuffed crust", "red sauce", "mozzarella");
            Pizza pizza3 = new Pizza("stuffed crust", "red sauce");
            Pizza pizza4 = new Pizza("stuffed crust");

            Console.WriteLine(pizza);
            Console.WriteLine(pizza2);
            Console.WriteLine(pizza3);
            Console.WriteLine(pizza4);

            Console.ReadKey();
        }
    }
}