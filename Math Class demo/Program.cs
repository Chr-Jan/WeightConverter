namespace Math_Class_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x = 3;

            //Pow method will rise a value to a certain power.
            //the first value is my base "x", we rise x to the second value.
            double a = Math.Pow(x, 2);
            Console.WriteLine(a);

            //Square Root meathod 
            double b = Math.Sqrt(x);
            Console.WriteLine(b);

            //The absolut value, that is how much something is from zero.
            double c = Math.Abs(x);
            Console.WriteLine(c);

            double y = 3.14;

            //Rounding a number
            double d = Math.Round(y);
            Console.WriteLine(d);

            //Rounding up
            double e = Math.Ceiling(y);
            Console.WriteLine(e);

            //Rounding down
            double f = Math.Floor(y);
            Console.WriteLine(f);

            //Maxium value between of two values
            double g = Math.Max(x, y);
            Console.WriteLine(g);

            //Minium value between of two values
            double h = Math.Max(x, y);
            Console.WriteLine(h);

            Console.ReadKey();
        }
    }
}