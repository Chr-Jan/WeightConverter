using System;
using System.ComponentModel.Design;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string name;
            int age;
            int i;
            i = 100;

            Console.WriteLine("Skriv venligst dit navn: ");
            name = Console.ReadLine();
            Console.WriteLine("Skriv venligst din alder: ");
            age = int.Parse(Console.ReadLine());

            //Console.WriteLine(age - 10 + " minus 10 år.");

            //exercise 4.2

            Console.WriteLine("What are your name: ");
            Console.Write(name);

            Console.WriteLine("What are your age: ");
            Console.Write(age);

            Console.Clear();

            Console.WriteLine(name + " er " + age + " år gammel.");

            for (i = age; i < 12 && i > 0;)
            {
                Console.WriteLine("et barn");
                break;
            }
            for (i = age; i < 19 && i > 13;)
            {
                Console.WriteLine("en teenager");
                break;
            }
            for (i = age; i < 25 && i > 20;)
            {
                Console.WriteLine("wn studerende");
                break;
            }
            for (i = age; i < 67 && i > 26;)
            {
                Console.WriteLine("i arbejde");
                break;
            }
            for (i = age; i > 68;)
            {
                Console.WriteLine("en pensionist");
                break;
            }

            Console.ReadLine();

            Console.Clear();
            */
            //opgave 5.1
            Console.WriteLine("Min fantastiske menu:\n");
            Console.WriteLine("Hvis ’1’, skriv Punkt 1 er valgt: Gør dit");
            Console.WriteLine("Hvis ’2’, skriv Punkt 2 er valgt: Gør dat");
            Console.WriteLine("Hvis ’3’, skriv Punkt 3 er valgt: Gør noget");
            Console.WriteLine("Hvis ’4’, skriv Punkt 4 er valgt: 42");
            //Console.WriteLine("skriv ”Forkert valg”");

            int menu = int.Parse(Console.ReadLine());
            string message = "";

            Console.Clear();

            switch (menu)
            {
                case 1:
                    //Console.WriteLine("Gør dit");
                    message = "Gør dit";
                    //Console.ReadLine();
                    break;

                case 2:
                    //Console.WriteLine("Gør dat");
                    //Console.ReadLine();
                    message = "Gør dat";
                    break;

                case 3:
                    //Console.WriteLine("Gør noget");
                    //Console.ReadLine();
                    message = "Gør noget";
                    break;

                case 4:
                    //Console.WriteLine("42");
                    //Console.ReadLine();
                    message = "42";
                    break;

                default:
                    //Console.WriteLine("Forkert svar");
                    //Console.ReadLine();
                    message = "Forkert svar";
                    break;
            }

            Console.WriteLine("Punkt {0} er valgt: {1}:", menu, message);
            Console.ReadLine();

        }
    }
}
    
