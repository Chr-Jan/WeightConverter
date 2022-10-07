using System;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast fornavn: ");

            string firstName;
            firstName = Console.ReadLine();

            Console.WriteLine("Det indstatede fornavn er: " + firstName);

            Console.Write("Indtast efternavnnavn: ");

            string lastName;
            lastName = Console.ReadLine();

            Console.WriteLine("Det indstatede efternavnnavn er: " + lastName);

            Console.WriteLine("Det fulde navn er: " + firstName + " " + lastName);

            Console.ReadLine();
        }
    }
} 