using System.ComponentModel.Design;

namespace Params_Keyword_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //params keyword =   method parameter that takes a variavle number of arguments.
            //                   The parameter type must be a single - dimentiosnal array

            double total = CheckOut(3.99, 5.75, 15);

            Console.WriteLine(total);
            Console.ReadKey();
        }
        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }

        //instead of writing multiple method like below use the params keyword

        //static double CheckOut(double a)
        //{
        //    return a;
        //}
        //static double CheckOut(double a, double b)
        //{
        //    return a + b;
        //}
        //static double CheckOut(double a, double b, double c)
        //{
        //    return a + b + c;
        //}
        //static double CheckOut(double a, double b, double c, double d)
        //{
        //    return a + b + c + d;
        //}
    }
}