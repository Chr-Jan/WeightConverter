namespace Opgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bred;

            Console.WriteLine("Enter your weight: ");

            bred = int.Parse(Console.ReadLine());

            int hoj;

            Console.WriteLine("Enter your height: ");

            hoj = int.Parse(Console.ReadLine());

            int areal = bred * hoj;

            Console.WriteLine(areal);

            Console.ReadLine();
        }
    }
}