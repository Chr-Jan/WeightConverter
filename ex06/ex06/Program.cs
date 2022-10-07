using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Lommeregner
{
    public class Program
    {
        //Exercise 2.0
        static void Main(string[] args)
        {
            string stop;
            do
            {
                Calculator Cal = new Calculator();

                Console.WriteLine("Decide your math method:");
                Console.WriteLine("1: Add:");
                Console.WriteLine("2: Subtract:");
                Console.WriteLine("3: Divide:");
                Console.WriteLine("4: Multiply");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Add:");
                            Console.WriteLine("x + y: ");
                            Console.WriteLine("Enter value for x: ");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter value for y: ");
                            int y = int.Parse(Console.ReadLine());
                            Console.WriteLine("Solution: ");
                            Console.WriteLine(Cal.Add(x, y));
                            Console.WriteLine("Press enter to continue: ");
                            Console.ReadLine();
                            break;
                        }

                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Subtract:");
                            Console.WriteLine("x - y: ");
                            Console.WriteLine("Enter value for x: ");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter value for y: ");
                            int y = int.Parse(Console.ReadLine());
                            Console.WriteLine("Solution: ");
                            Console.WriteLine(Cal.Subtract(x, y));
                            Console.WriteLine("Press enter to continue: ");
                            Console.ReadLine();
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Divide: x/y");
                            Console.WriteLine("Enter value for x: ");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter value for y: ");
                            int y = int.Parse(Console.ReadLine());
                            Console.WriteLine("Solution: ");
                            Console.WriteLine(Cal.Divide(x, y));
                            Console.WriteLine("Press enter to continue: ");
                            Console.ReadLine();
                            break;
                        }
                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Multiply: x * y");
                            Console.WriteLine("Enter value for x: ");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter value for y: ");
                            int y = int.Parse(Console.ReadLine());
                            Console.WriteLine("Solution: ");
                            Console.WriteLine(Cal.Multiply(x, y));
                            Console.WriteLine("Press enter to continue: ");
                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("wrong answer, please try again.");
                            break;
                        }


                }
                Console.Clear();
                Console.Write("Do You Want To Continue? (Y/N) : ");
                stop = Console.ReadLine();
            } while (stop != "N" && stop != "n");

            //Exercise 3.2
            int _person1 = 22;
            int _person2 = 24;
            int _person3 = 25;
            int _person4 = 26;
            int _person5 = 28;
            int _person6 = 35;

            int[] names = new int[] { _person1, _person2, _person3, _person4, _person5, _person6 };
            int total_age = 0;



            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
                total_age += names[i];
            }

            Console.WriteLine($"The total age: {total_age}");

            double average;
            average = (double)total_age / names.Length;

            Console.WriteLine($"The average age: {average}");

            Console.ReadLine();
        }

    }
}