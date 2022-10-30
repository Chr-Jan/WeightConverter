namespace Return_Keyword_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // return   = returns data back to the place where a methojd is invoked

            double x;
            double y;
            double result;

            Console.WriteLine("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);
            Console.WriteLine(result);

            Console.ReadKey();
        }
        //the method need to have double after static since the data type that is returned is double
        static double Multiply(double x, double y)
        {
            //double z = x * y;
            //return z;

            // this would work the same:
            return x * y;
        }
    }
}