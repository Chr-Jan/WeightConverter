namespace Random_Numbers_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize random object
            Random random = new Random();

            //Will generate a random int number
            //we set the range of random int generated inside the ()
            //first int is the minium, the second is the maxium. here it is 1 to 6, the maxium here 7 is exclusive
            int num = random.Next(1, 7);
            Console.WriteLine(num);
            //you can also add numbers
            int num2 = random.Next(1, 7) + 100;
            Console.WriteLine(num2);
            //Or a random number between 1 and 20
            int num3 = random.Next(1, 20);
            Console.WriteLine(num3);

            //if we want ro roll a decimal number we use the method double
            double num4 = random.NextDouble();
            Console.WriteLine(num4);

            Console.ReadKey();
        }
    }
}