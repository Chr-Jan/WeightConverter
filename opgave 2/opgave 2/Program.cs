using System.Security.Cryptography.X509Certificates;

namespace opgave_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x1;
            
            Console.WriteLine("Enter x1 position: ");

            x1 = float.Parse(Console.ReadLine());

            float y1;

            Console.WriteLine("Enter y1 position: ");

            y1 = float.Parse(Console.ReadLine());

            float x2;

            Console.WriteLine("Enter x2 position: ");

            x2 = float.Parse(Console.ReadLine());

            float y2;

            Console.WriteLine("Enter y2 position: ");

            y2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Your Total are ");

            float bobs = (y2-y1)/(x2-x1);

            Console.WriteLine(bobs);

            Console.ReadLine();
        }
    }
}