using System.Globalization;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("Indtast dit navn: ");
            name = Console.ReadLine();
            Console.WriteLine("Indtast din alder: ");
            age = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Indtast navn: " + name);
            Console.Write("Navn: ");
            Console.WriteLine("Jens Hansen");
            Console.WriteLine("Indtast alder: " + age);
            Console.Write("Alder: ");
            Console.WriteLine("25");

            Console.WriteLine(name + " er " + age + " år gammel.");

            Console.ReadLine();
        }
    }
}