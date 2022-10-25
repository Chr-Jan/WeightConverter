namespace Integral_Types_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Signed integral types:");

            //sbyte range -128 to 127
            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            //short range -32,768 to 32,767
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            //int range -2,147,483,648 to 2,147,483,647
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            //long range -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
           
            //float = 6-9 digits
            Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue}");
            //double 15-17 digits
            Console.WriteLine($"double   : {double.MinValue} to {double.MaxValue}");
            //decimal 28-29 digits
            Console.WriteLine($"decimal   : {decimal.MinValue} to {decimal.MaxValue}");

            Console.Read();

        }
    }
}