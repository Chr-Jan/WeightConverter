namespace Exception_Handling_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Code to try goes here.

                Console.WriteLine("Enter a number: ");

                var num = int.Parse(Console.ReadLine());

                Console.WriteLine($"Squre of {num} is {num * num}");


            }
            catch
            {
                // Code to handle the exception goes here.
                // Only catch exceptions that you know how to handle.
                // Never catch base class System.Exception without
                // rethrowing it at the end of the catch block.

                Console.Write("Error occurred.");

            }
            finally
            {
                // Code to execute after the try block goes here.

                Console.Write("Re-try with a different number.");
            }


        }
    }
}