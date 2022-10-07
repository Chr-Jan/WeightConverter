using System;
namespace CsharpString
{
    class Test
    {
        public static void Main(string[] args)
        {

            string a = "Jeg har en kat";

            int result = a.IndexOf("kat");

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}