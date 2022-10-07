using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {

            {
                string Continue;

                do
                {
                    add Cal = new add();

                    Console.WriteLine("Decide your math method:");
                    Console.WriteLine("1: Add:");
                    Console.WriteLine("2: Subtract:");
                    Console.WriteLine("3: Divide:");
                    Console.WriteLine("4: Multiply");

                    switch (Console.ReadLine())

                    {
                        case "1":
                            {
                                Console.WriteLine("Add:");
                                int x = int.Parse(Console.ReadLine());
                                int y = int.Parse(Console.ReadLine());
                                Console.WriteLine(Cal.Add(x, y));
                                break;
                            }

                        case "2":
                            {
                                Console.WriteLine("Subtract:");
                                int x = int.Parse(Console.ReadLine());
                                int y = int.Parse(Console.ReadLine());
                                Console.WriteLine(Cal.Subtract(x, y));
                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine("Divide:");
                                int x = int.Parse(Console.ReadLine());
                                int y = int.Parse(Console.ReadLine());
                                Console.WriteLine(Cal.Divide(x, y));
                                break;
                            }
                        case "4":
                            {
                                Console.WriteLine("Multiply:");
                                int x = int.Parse(Console.ReadLine());
                                int y = int.Parse(Console.ReadLine());
                                Console.WriteLine(Cal.Multiply(x, y));
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("wrong answer, please try again.");
                                break;
                            }


                    }
                    Console.Write("Do You Want To Continue? (Y/N) : ");
                    Continue = Console.ReadLine();
                } while (Continue != "N" && Continue != "n");
            }

        }

    }

}