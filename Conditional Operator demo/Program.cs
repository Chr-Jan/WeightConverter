namespace Conditional_Operator_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // conditional operator    =   used in conditional assisgnment if a conddition is true/false

            // (condition) ? x : y

            //making a temperatur reading problem

            //first making if-else program and than a conditional operator to compare'

            double temperature = 20;
            String message;
            String message2;


            if (temperature >= 15)
            {
                message = "It's warm outside!";
            }
            else
            {
                message = "It's cold outside!";
            }
            Console.WriteLine(message);

            //conditional operator

            message2 = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

            Console.WriteLine(message2);

            //or we can make it shorter

            Console.WriteLine((temperature >= 15) ? "It's warm outside!" : "It's cold outside!");

            Console.ReadKey();
        }
    }
}