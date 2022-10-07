using System.Security.Cryptography.X509Certificates;

namespace Lommeregner
{
    internal class Program
    {
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
           
        }
        
    }
}