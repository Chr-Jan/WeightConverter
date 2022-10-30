namespace Methods_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method   = performs a section of a code, whenever it's called "invoked".
            //            benefits = Let's us reuse code without writing it multiple times

            //an exampel how messy this would look fast, if needed to sing 3 times:
            //Console.WriteLine("Happy birthday to you!");
            //Console.WriteLine("Happy birthday to you!");
            //Console.WriteLine("Happy birthday dear you!");
            //Console.WriteLine("Happy birthday to you!");

            //Console.WriteLine("Happy birthday to you!");
            //Console.WriteLine("Happy birthday to you!");
            //Console.WriteLine("Happy birthday dear you!");
            //Console.WriteLine("Happy birthday to you!");

            //Console.WriteLine("Happy birthday to you!");
            //Console.WriteLine("Happy birthday to you!");
            //Console.WriteLine("Happy birthday dear you!");
            //Console.WriteLine("Happy birthday to you!");

            String name = "Chris";
            int age = 35;

            singHappyBirthday(name, age);

            Console.ReadKey();
        }

        //outisde main method we make a new method
        //this is a method below

        static void singHappyBirthday(String birthdayBoy, int yearsOld)
        {
            //We need to pass an argument to this method to casses the String called name
            //Arguments = what is sent to methods

            //birthdayBoy do not have to be named "name" as in the main method.
            //but important that the data type match String name = String birthdayBoy

            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + birthdayBoy);
            Console.WriteLine("You are " + yearsOld + " years old");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("");
        }
    }
}