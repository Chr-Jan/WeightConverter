namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double height;
            double width;

            Console.WriteLine("rectangle calculator");
            Console.WriteLine("Input height: ");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("input weight: ");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("The total area is: ");
            Console.WriteLine(height * width);
            

            //Exercise 3.2

            //formular h = (y2 - y1)/(x2 - x1)
            double h1;
            h1 = (3 - 5) - (3 - 3);
            double h2;
            h2 = (5 - 3) / (5 - 3);
            double h3;
            double y2 = 4;
            double y1 = 3;
            double x2 = 5;
            double x1 = 3;
            h3 = (y2 - y1) / (x2 - x1);

            Console.Write("First test: ");
            Console.WriteLine(h1);
            Console.Write("Second test: ");
            Console.WriteLine(h2);
            Console.Write("Third test: ");
            Console.WriteLine(h3);
            //Exercise 4.1
            Console.WriteLine("\nThis is the lenght of a random sentence: ");
            Console.WriteLine("This is a random sentence".Length);

            //Exercise 4.2

            string message;
            message = "This is a test for using Substring.";

            //first number is starting location, second is the end location
            Console.WriteLine(message.Substring(0, 9));

            //Exercise 4.3
            //finds where a word or letter is used.
            Console.WriteLine(message.IndexOf("test"));

            Console.ReadLine();



        }
    }
}