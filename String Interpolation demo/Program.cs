namespace String_Interpolation_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string interpolation =   allow us to insert variables into a string literal
            //                          precede a string literal with $
            //                          {} are placeholders

            String firstName = "Chirs";
            String lastName = "Jans";
            int age = 35;
            //this is an exampel without string interpolation:
            //Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            //Console.WriteLine("You are " + age + " years old.");

            //this is an exampel of string interpolation:
            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age} years old.");

            Console.WriteLine("");

            // you can also add numbers to add space:
            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age,10} years old.");
            Console.WriteLine($"You are {age,-10} years old.");

            Console.ReadKey();
        }
    }
}